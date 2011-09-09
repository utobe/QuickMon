﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace QuickMon
{
	public class DiskSpace : CollectorBase
	{
		private List<DriveSpaceEntry> drives = new List<DriveSpaceEntry>();

		public override MonitorStates GetState()
		{
			MonitorStates returnState = MonitorStates.Good;
			string lastDetails = "";
			LastDetailMsg.PlainText = "Getting drive infos";
			LastError = 0;
			LastErrorMsg = "";
			try
			{
				foreach (DriveSpaceEntry dse in drives)
				{
					LastDetailMsg.PlainText = "Getting drive info for " + dse.DriveLetter;
					DriveInfo di = new DriveInfo(dse.DriveLetter);
					if (di.IsReady)
					{
						if (di.TotalFreeSpace < dse.ErrorSizeLeftMB * 1048576)
						{
							LastDetailMsg.PlainText = string.Format("Drive {0} has reached error level {1} MB left.", dse.DriveLetter, (di.TotalFreeSpace / 1048576));
							LastErrorMsg = LastDetailMsg.PlainText;
							return MonitorStates.Error;

						}
						else if (di.TotalFreeSpace < dse.WarningSizeLeftMB * 1048576)
						{
							lastDetails += string.Format("Drive {0} has {1} MB available space - Warning", dse.DriveLetter, (di.TotalFreeSpace / 1048576));
							returnState = MonitorStates.Warning;
						}
						else
						{
							lastDetails += string.Format("Drive {0} has {1} MB available space", dse.DriveLetter, (di.TotalFreeSpace / 1048576));
						}
					}
					else
					{
						if (dse.WarnOnNotReady && returnState == MonitorStates.Good)
						{
							lastDetails += string.Format("Drive {0} is not available!", dse.DriveLetter);
							returnState = MonitorStates.Warning;
						}
						else
						{
							lastDetails += string.Format("Drive {0} is not available.", dse.DriveLetter);
						}
					}
				}
			}
			catch (Exception ex)
			{
				LastError = 1;
				LastErrorMsg = ex.Message;
				lastDetails = ex.Message;
				returnState = MonitorStates.Error;
			}
			LastDetailMsg.PlainText = lastDetails.TrimEnd('\r', '\n');
			return returnState;
		}

		public override void ShowStatusDetails()
		{
			ShowDetails showDetails = new ShowDetails();
			//XmlDocument configXml = new XmlDocument();
			//configXml.LoadXml(config);
			//ReadConfiguration(configXml);
			showDetails.Drives = drives;
			showDetails.Show();
		}

		public override string ConfigureAgent(string config)
		{
			EditConfig editConfig = new EditConfig();
			editConfig.CustomConfig = config;
			if (editConfig.ShowConfig() == System.Windows.Forms.DialogResult.OK)
			{
				config = editConfig.CustomConfig;
			}
			return config;
		}

		public override string GetDefaultOrEmptyConfigString()
		{
			return Properties.Resources.DiskSpaceEmptyConfig_xml;
		}

		public override void ReadConfiguration(XmlDocument config)
		{
			drives = new List<DriveSpaceEntry>();
			XmlElement root = config.DocumentElement;
			foreach (XmlElement drive in root.SelectNodes("drives/drive"))
			{
				DriveSpaceEntry driveSpaceEntry = new DriveSpaceEntry();
				driveSpaceEntry.DriveLetter = drive.ReadXmlElementAttr("name", "c");
				driveSpaceEntry.WarningSizeLeftMB = long.Parse(drive.ReadXmlElementAttr("warningSizeLeftMB", "500"));
				driveSpaceEntry.ErrorSizeLeftMB = long.Parse(drive.ReadXmlElementAttr("errorSizeLeftMB", "100"));
				driveSpaceEntry.WarnOnNotReady = bool.Parse(drive.ReadXmlElementAttr("warnOnNotReady", "False"));
				drives.Add(driveSpaceEntry);
			}
		}
	}
}

// WMI option
// strComputer = "bizint2" 
// Set objWMIService = GetObject("winmgmts:\\" & strComputer & "\root\CIMV2") 
// Set colItems = objWMIService.ExecQuery( _
// "SELECT * FROM Win32_LogicalDisk",,48) 
// For Each objItem in colItems 
//     Wscript.Echo "-----------------------------------"
//     Wscript.Echo "Win32_LogicalDisk instance"
//     Wscript.Echo "-----------------------------------"
//     Wscript.Echo "Caption: " & objItem.Caption
//     Wscript.Echo "FreeSpace: " & objItem.FreeSpace
// Next