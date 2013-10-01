﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Management;

namespace QuickMon
{
	public class WMIQuery : CollectorBase
	{
		internal WMIConfig WmiIConfig = new WMIConfig();

		public override MonitorStates GetState()
		{
			MonitorStates returnState = MonitorStates.Good;
			StringBuilder plainTextDetails = new StringBuilder();
			StringBuilder htmlTextTextDetails = new StringBuilder();
			LastDetailMsg.PlainText = "Running WMI query";
			LastDetailMsg.HtmlText = "";
			int errors = 0;
			int warnings = 0;
			int success = 0;
			double totalValue = 0;
			try
			{
				plainTextDetails.AppendLine(string.Format("Running the WMI query: '{0}'", WmiIConfig.StateQuery));
				htmlTextTextDetails.AppendLine(string.Format("<i>Running the WMI query: '{0}'</i>", WmiIConfig.StateQuery));
				htmlTextTextDetails.AppendLine("<ul>");
				foreach (string machineName in WmiIConfig.Machines)
				{
					object value = null;
					LastDetailMsg.PlainText = string.Format("Running WMI query for '{0}' - '{1}'", machineName, WmiIConfig.StateQuery);

                    value = WmiIConfig.RunQuery(machineName);
                    MonitorStates currentState = WmiIConfig.GetState(value);

                    if (value != null && value.IsNumber())
                        totalValue += double.Parse(value.ToString());

                    if (currentState == MonitorStates.Error)
					{
						errors++;
						plainTextDetails.AppendLine(string.Format("Machine '{0}' - value '{1}' - Error (trigger {2})", machineName, FormatUtils.N(value, "[null]"), WmiIConfig.ErrorValue));
						htmlTextTextDetails.AppendLine(string.Format("<li>Machine '{0}' - Value '{1}' - <b>Error</b> (trigger {2})</li>", machineName, FormatUtils.N(value, "[null]"), WmiIConfig.ErrorValue));
					}
					else if (currentState == MonitorStates.Warning)
					{
						warnings++;
						plainTextDetails.AppendLine(string.Format("Machine '{0}' - value '{1}' - Warning (trigger {2})", machineName, FormatUtils.N(value, "[null]"), WmiIConfig.WarningValue));
						htmlTextTextDetails.AppendLine(string.Format("<li>Machine '{0}' - Value '{1}' - <b>Warning</b> (trigger {2})</li>", machineName, FormatUtils.N(value, "[null]"), WmiIConfig.WarningValue));
					}
					else
					{
						success++;
						plainTextDetails.AppendLine(string.Format("Machine '{0}' - value '{1}'", machineName, value));
						htmlTextTextDetails.AppendLine(string.Format("<li>Machine '{0}' - Value '{1}'</li>", machineName, value));
					}
				}
				htmlTextTextDetails.AppendLine("</ul>");
				if (errors > 0 && warnings == 0)
					returnState = MonitorStates.Error;
				else if (warnings > 0)
					returnState = MonitorStates.Warning;
				LastDetailMsg.PlainText = plainTextDetails.ToString().TrimEnd('\r', '\n');
				LastDetailMsg.HtmlText = htmlTextTextDetails.ToString();
                LastDetailMsg.LastValue = totalValue;
			}
			catch (Exception ex)
			{
				LastError = 1;
				LastErrorMsg = ex.Message;
				LastDetailMsg.PlainText = string.Format("Last step: '{0}\r\n{1}", LastDetailMsg.PlainText, ex.Message);
				LastDetailMsg.HtmlText = string.Format("<blockquote>Last step: '{0}<br />{1}</blockquote>", LastDetailMsg.PlainText, ex.Message);
				returnState = MonitorStates.Error;
			}
			return returnState;
		}

		public override void ShowStatusDetails(string collectorName)
		{
			ShowDetails showDetails = new ShowDetails();
			showDetails.WmiIConfig = WmiIConfig;
			showDetails.Text = "Show details - " + collectorName;
			showDetails.Show();
		}

		public override string ConfigureAgent(string config)
		{
			XmlDocument configDoc = new XmlDocument();
			if (config.Length > 0)
				configDoc.LoadXml(config);
			else
				configDoc.LoadXml(GetDefaultOrEmptyConfigString());
			ReadConfiguration(configDoc);

			EditConfig editConfig = new EditConfig();
			editConfig.WmiIConfig = WmiIConfig;
			if (editConfig.ShowConfig() == System.Windows.Forms.DialogResult.OK)
			{
				config = editConfig.WmiIConfig.ToConfig();
			}
			return config;
		}

		public override string GetDefaultOrEmptyConfigString()
		{
			return Properties.Resources.WMIQueryEmptyConfig;
		}

		public override void ReadConfiguration(XmlDocument configDoc)
		{
			WmiIConfig.ReadConfig(configDoc);
		}

        public override ICollectorDetailView GetCollectorDetailView()
        {
            return (ICollectorDetailView)(new ShowDetails());
        }
    }
}
