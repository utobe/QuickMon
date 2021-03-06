﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickMon.Collectors
{
    public class SoapWebServicePingConfigEntry : ICollectorConfigEntry
    {
        #region ICollectorConfigEntry Members
        public string Description
        {
            get { return string.Format("{0}\\{1}:{2}", serviceBaseURL, ServiceName, methodName); }
        }
        public string TriggerSummary
        {
            get { return string.Format("Type:{0},{1} Val:{2},{3}", CheckType, ResultType, CustomValue1, CustomValue2); }
        }
        public List<ICollectorConfigSubEntry> SubItems { get; set; }
        #endregion

        #region Properties
        private string serviceBaseURL = "";
        public string ServiceBaseURL
        {
            get { return serviceBaseURL; }
            set { serviceBaseURL = value; soapWebServiceRunner = null; }
        }
        public string ServiceName { get; set; }
        private string methodName = "";
        public string MethodName
        {
            get { return methodName; }
            set { methodName = value; soapWebServiceRunner = null; }
        }
        public List<string> Parameters { get; set; }

        public SoapWebServicePingCheckType CheckType { get; set; }
        public SoapWebServicePingResult ResultType { get; set; }
        public string CustomValue1 { get; set; }
        public string CustomValue2 { get; set; }
        public string LastError
        {
            get
            {
                if (soapWebServiceRunner != null)
                    return soapWebServiceRunner.LastError;
                else
                    return "";
            }
        } 
        #endregion

        private SoapWebServiceRunner soapWebServiceRunner = null;

        public string ToStringFromParameters()
        {
            string parameters = "";
            if (Parameters != null)
            {
                foreach (string par in Parameters)
                {
                    parameters += par + ",";
                }
                parameters = parameters.TrimEnd(',');
            }
            return parameters;
        }

        internal object ExecuteMethod()
        {
            object obj = null;
            if (soapWebServiceRunner == null)
            {
                soapWebServiceRunner = new SoapWebServiceRunner();
                if (!soapWebServiceRunner.SetWebServiceInstance(ServiceBaseURL, ServiceName))
                {
                    string lastErr = soapWebServiceRunner.LastError;
                    soapWebServiceRunner = null;
                    throw new Exception(lastErr);
                }
            }
            try
            {
                obj = soapWebServiceRunner.RunWSMethod(MethodName, Parameters.ToArray());
            }
            catch
            {
                soapWebServiceRunner = null; //set null so it can be retried from scratch
                throw;
            }
            return obj;
        }

        public bool CheckResultMatch(object val, SoapWebServicePingResult resultType,
            string fromVal, string toVal, out string formattedVal)
        {
            bool result = false;
            formattedVal = "";
            if (resultType == SoapWebServicePingResult.CheckAvailabilityOnly)
            {
                result = true;
                formattedVal = "[Success]";
            }
            else if (resultType == SoapWebServicePingResult.NoValueOnly)
            {
                result = (val == null) || (val.ToString() == "");
                formattedVal = val.ToString();
            }
            else if (resultType == SoapWebServicePingResult.SpecifiedValue)
            {
                if (val == null)
                {
                    result = fromVal == "";
                    formattedVal = "Null";
                }
                else if (val is System.Data.DataSet)
                    throw new Exception("Returned value is a DataSet!");
                else if (val is string[])
                    throw new Exception("Returned value is an array!");
                else
                {
                    result = val.ToString().ToLower() == fromVal.ToLower();
                    formattedVal = val.ToString();
                }
            }
            else if (resultType == SoapWebServicePingResult.InValueRange)
            {
                if (fromVal.IsNumber() && toVal.IsNumber() && (val != null) && val.IsNumber())
                {
                    result = (double.Parse(fromVal) <= double.Parse(val.ToString()))
                            && (double.Parse(val.ToString()) <= double.Parse(toVal));
                    formattedVal = val.ToString();
                }
                else //test as strings
                {
                    throw new Exception(string.Format("Returned value must be a number! ({0})", val));
                }
            }
            else if (resultType == SoapWebServicePingResult.DataSet)
            {
                if (!(val is System.Data.DataSet))
                    throw new Exception("Returned value is not a DataSet!");
                else
                {
                    System.Data.DataSet ds = (System.Data.DataSet)val;
                    if (ds.Tables.Count == 0)
                        throw new Exception("DataSet contains no tables!");
                    else
                    {
                        System.Data.DataTable tab = ds.Tables[0];
                        if ((tab.Rows.Count == 0 && fromVal != "[Count]") || tab.Columns.Count == 0)
                            throw new Exception("DataSet contains no rows or columns!");
                        else
                        {
                            if (fromVal == "[Count]")
                            {
                                if (toVal.IsNumber())
                                {
                                    result = CheckResultMatchMacro(tab.Rows.Count, toVal);
                                    formattedVal = tab.Rows.Count.ToString() + " row(s)";
                                }
                                else
                                    throw new Exception("Second custom value must be a number!");
                            }
                            else if (fromVal == "[FirstValue]")
                            {
                                result = CheckResultMatchMacro(tab.Rows[0][0].ToString().ToLower(), toVal.ToLower());
                                formattedVal = tab.Rows[0][0].ToString();
                            }
                            else if (fromVal == "[LastValue]")
                            {
                                result = CheckResultMatchMacro(tab.Rows[tab.Rows.Count - 1][tab.Columns.Count - 1].ToString().ToLower(), toVal.ToLower());
                                formattedVal = tab.Rows[tab.Rows.Count - 1][tab.Columns.Count - 1].ToString();
                            }
                            else if (fromVal.StartsWith("[") && fromVal.EndsWith("]") && fromVal.Contains("]["))
                            {
                                string[] tabArr = fromVal.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);
                                if (!tabArr[0].IsInteger() || !tabArr[1].IsInteger())
                                    throw new Exception("First custom value cotains invalid macro format!");
                                else
                                {
                                    object celVal = tab.Rows[int.Parse(tabArr[0])][int.Parse(tabArr[1])];
                                    result = CheckResultMatchMacro(celVal, toVal);
                                    formattedVal = celVal.ToString();
                                }
                            }
                            else
                            {
                                result = CheckResultMatchMacro(tab.Rows[0][0].ToString().ToLower(), toVal.ToLower());
                                formattedVal = tab.Rows[0][0].ToString();
                            }
                        }
                    }
                }
            }
            else// if (resultType == SoapWebServicePingResultEnum.StringArray)
            {
                if (!(val is string[]))
                    throw new Exception("Returned value is not a string array!");
                else
                {
                    string[] sa = (string[])val;
                    if (sa.Length == 0 && fromVal != "[Count]")
                        throw new Exception("String array is empty!");
                    else if (fromVal == "[Count]")
                    {
                        //if (toVal.IsNumber())
                        {
                            result = CheckResultMatchMacro(sa.Length, toVal);
                            formattedVal = sa.Length.ToString() + " row(s)";
                        }
                        //else
                        //                            throw new Exception("Second custom value must be a number!");
                    }
                    else if (fromVal == "[LastValue]")
                    {
                        result = CheckResultMatchMacro(sa[sa.Length - 1].ToLower(), toVal.ToLower());
                        formattedVal = sa[sa.Length - 1];
                    }
                    else if (fromVal == "[FirstValue]")
                    {
                        result = CheckResultMatchMacro(sa[0].ToLower(), toVal.ToLower());
                        formattedVal = sa[0];
                    }
                    else
                    {
                        result = CheckResultMatchMacro(sa[0].ToLower(), fromVal.ToLower());
                        formattedVal = sa[0];
                    }
                }
            }
            return (result == (CheckType == SoapWebServicePingCheckType.Success));
        }

        private bool CheckResultMatchMacro(object val, string macro)
        {
            bool result = false;

            if (macro.StartsWith("[Between]") && macro.Contains("[and]"))
            {
                string[] queryItems = macro.Split(' ');
                if (val.IsNumber() && queryItems.Length == 4 && queryItems[1].IsNumber() && queryItems[3].IsNumber())
                    result = (double.Parse(queryItems[1]) < double.Parse(val.ToString()))
                        && (double.Parse(val.ToString()) < double.Parse(queryItems[3]));
                else
                    throw new Exception("Invalid value returned or second custom value cotains invalid macro!");
            }
            else if (macro.StartsWith("[LargerThan]"))
            {
                string macroValue = macro.Replace("[LargerThan]", "").Trim();
                if (val.IsNumber() && macroValue.IsNumber())
                    result = (double.Parse(macroValue) < double.Parse(val.ToString()));
                else
                    throw new Exception("Invalid value returned or second custom value cotains invalid macro!");
            }
            else if (macro.StartsWith("[SmallerThan]"))
            {
                string macroValue = macro.Replace("[SmallerThan]", "").Trim();
                if (val.IsNumber() && macroValue.IsNumber())
                    result = (double.Parse(macroValue) > double.Parse(val.ToString()));
                else
                    throw new Exception("Invalid value returned or second custom value cotains invalid macro!");
            }
            else
            {
                result = val.ToString() == macro;
            }
            return result;
        }
    }
}
