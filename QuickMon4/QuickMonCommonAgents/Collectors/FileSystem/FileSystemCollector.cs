﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace QuickMon.Collectors
{
    [Description("File System Collector"), Category("General")]
    public class FileSystemCollector : CollectorAgentBase
    {
        public FileSystemCollector()
        {
            AgentConfig = new FileSystemCollectorConfig();
        }

        public override MonitorState RefreshState()
        {
            MonitorState returnState = new MonitorState();
            int errorCount = 0;
            int warningCount = 0;
            int okCount = 0;
            int totalFileCount = 0;
            int totalEntryCount = 0;
            try
            {
                FileSystemCollectorConfig currentConfig = (FileSystemCollectorConfig)AgentConfig;
                foreach (FileSystemDirectoryFilterEntry directoryFilter in currentConfig.Entries)
                {
                    DirectoryFileInfo directoryFileInfo = directoryFilter.GetFileListByFilters();
                    CollectorState currentState = directoryFilter.GetState(directoryFileInfo);
                    totalEntryCount++;

                    if (directoryFilter.DirectoryExistOnly && currentState != CollectorState.Good)
                    {
                        errorCount++;
                        returnState.ChildStates.Add(
                           new MonitorState()
                           {
                               ForAgent = directoryFilter.DirectoryPath,
                               State = CollectorState.Error,
                               CurrentValue = directoryFilter.LastErrorMsg
                           });
                    }
                    else if (directoryFilter.DirectoryExistOnly)
                    {
                        okCount++;
                        returnState.ChildStates.Add(
                           new MonitorState()
                           {
                               ForAgent = directoryFilter.DirectoryPath,
                               State = currentState,
                               CurrentValue = directoryFilter.LastErrorMsg
                           });                        
                    }
                    else 
                    {
                        if (directoryFileInfo.FileCount == -1)
                        {
                            errorCount++;
                            returnState.ChildStates.Add(
                           new MonitorState()
                           {
                               ForAgent = directoryFilter.DirectoryPath,
                               State = CollectorState.Error,
                               CurrentValue = directoryFilter.LastErrorMsg
                           });
                        }
                        else
                        {
                            totalFileCount += directoryFileInfo.FileCount;
                            if (directoryFileInfo.FileCount > 0)
                            {
                                if (directoryFilter.LastErrorMsg.Length > 0)
                                {
                                    returnState.ChildStates.Add(
                                           new MonitorState()
                                           {
                                               ForAgent = directoryFilter.DirectoryPath,
                                               State = currentState,
                                               CurrentValue = string.Format("{0} file(s), {1}", directoryFileInfo.FileCount, FormatUtils.FormatFileSize(directoryFileInfo.TotalFileSize))
                                           });
                                }
                                else
                                {
                                    returnState.ChildStates.Add(
                                          new MonitorState()
                                          {
                                              ForAgent = directoryFilter.DirectoryPath,
                                              State = currentState,
                                              CurrentValue = string.Format("{0} file(s) found", directoryFileInfo.FileInfos.Count)
                                          });

                                    if (directoryFilter.ShowFilenamesInDetails)
                                    {
                                        int topCount = 10;
                                        for (int i = 0; i < topCount && i < directoryFileInfo.FileInfos.Count; i++)
                                        {
                                            FileInfo fi = directoryFileInfo.FileInfos[i];
                                            returnState.ChildStates.Add(
                                               new MonitorState()
                                               {
                                                   ForAgent = fi.Name,
                                                   State = currentState,
                                                   CurrentValue = string.Format("{0}", FormatUtils.FormatFileSize(fi.Length))                                                   
                                               });
                                        }
                                    }
                                }
                            }
                            else
                            {
                                returnState.ChildStates.Add(
                                          new MonitorState()
                                          {
                                              ForAgent = directoryFilter.DirectoryPath,
                                              State = currentState,
                                              CurrentValue = "No files found"
                                          });
                            }
                            if (currentState == CollectorState.Warning)
                            {
                                warningCount++;
                            }
                            else if (currentState == CollectorState.Error)
                            {
                                errorCount++;
                            }
                            else
                            {
                                okCount++;
                            }
                        }
                    }
                }
                if (errorCount > 0 && totalEntryCount == errorCount) // any errors
                    returnState.State = CollectorState.Error;
                else if (okCount != totalEntryCount) //any warnings
                    returnState.State = CollectorState.Warning;
                else
                    returnState.State = CollectorState.Good;

                returnState.CurrentValue = totalFileCount;
            }
            catch (Exception ex)
            {
                returnState.RawDetails = ex.Message;
                returnState.HtmlDetails = ex.Message;
                returnState.State = CollectorState.Error;
            }

            return returnState;
        }
        private string GetTop10FileInfos(List<FileInfo> fileInfos)
        {
            StringBuilder sb = new StringBuilder();
            int topCount = 10;
            for (int i = 0; i < topCount && i < fileInfos.Count; i++)
            {
                FileInfo fi = fileInfos[i];
                sb.AppendLine(string.Format("\t{0} - {1}", fi.Name, FormatUtils.FormatFileSize(fi.Length)));
            }
            if (fileInfos.Count > 10)
                sb.AppendLine("...");
            return sb.ToString();
        }

        public override List<System.Data.DataTable> GetDetailDataTables()
        {
            List<System.Data.DataTable> tables = new List<System.Data.DataTable>();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {                
                dt.Columns.Add(new System.Data.DataColumn("Path", typeof(string)));
                dt.Columns.Add(new System.Data.DataColumn("Details", typeof(string)));

                FileSystemCollectorConfig currentConfig = (FileSystemCollectorConfig)AgentConfig;
                foreach (FileSystemDirectoryFilterEntry directoryFilter in currentConfig.Entries)
                {
                    DirectoryFileInfo directoryFileInfo = directoryFilter.GetFileListByFilters();
                    string details = "";
                    try
                    {
                        if (!directoryFileInfo.DirectoryExists)
                            details = "Directory does not exists";
                        else if (directoryFilter.DirectoryExistOnly)
                            details = "Directory exists";
                        else
                        {
                            details = directoryFileInfo.DirectoryExists ? directoryFileInfo.FileCount.ToString() + " file(s), " + FormatUtils.FormatFileSize(directoryFileInfo.TotalFileSize) : "Directory does not exists";
                        }
                    }
                    catch (Exception ex)
                    {
                        details = ex.Message;
                    }
                    dt.Rows.Add(directoryFilter.Description, details);
                }                
            }
            catch (Exception ex)
            {
                dt = new System.Data.DataTable("Exception");
                dt.Columns.Add(new System.Data.DataColumn("Text", typeof(string)));
                dt.Rows.Add(ex.ToString());
            }
            tables.Add(dt);
            return tables;
        }
    }
}
