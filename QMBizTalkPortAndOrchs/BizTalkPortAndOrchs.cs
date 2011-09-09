﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuickMon
{
    public class BizTalkPortAndOrchs : CollectorBase
    {
        private BizTalkGroup bizTalkGroup = new BizTalkGroup();

        public override MonitorStates GetState()
        {
            MonitorStates returnState = MonitorStates.Good;
            CollectorMessage details = new CollectorMessage();            

            LastDetailMsg.HtmlText = "";
            LastDetailMsg.PlainText = "Getting Ports and Orchestration states and counts";
			LastError = 0;
			LastErrorMsg = "";		
			try
			{
                LastDetailMsg.PlainText = "Getting Receive Location count";
                int receiveLocationCount = bizTalkGroup.AllReceiveLocations ? bizTalkGroup.GetTotalReceiveLocationCount() : bizTalkGroup.ReceiveLocations.Count;
                LastDetailMsg.PlainText = "Getting Disabled Receive Location count";
                int receiveLocationsDisabled = bizTalkGroup.AllReceiveLocations ? bizTalkGroup.GetDisabledReceiveLocationCount(new List<string>()) : bizTalkGroup.GetDisabledReceiveLocationCount(bizTalkGroup.ReceiveLocations);
                //Now check send ports
                LastDetailMsg.PlainText = "Getting Send Port count";
                int sendPortCount = bizTalkGroup.AllSendPorts ? bizTalkGroup.GetTotalSendPortCount() : bizTalkGroup.SendPorts.Count;
                LastDetailMsg.PlainText = "Getting Stopped Send Port count";
                int sendPortStoppedCount = bizTalkGroup.AllSendPorts ? bizTalkGroup.GetStoppedSendPortCount(new List<string>()) : bizTalkGroup.GetStoppedSendPortCount(bizTalkGroup.SendPorts);
                //Now check orchestrations
                LastDetailMsg.PlainText = "Getting Orchestration count";
                int orchestrationCount = bizTalkGroup.AllOrchestrations ? bizTalkGroup.GetTotalOrchestrationCount() : bizTalkGroup.Orchestrations.Count;
                LastDetailMsg.PlainText = "Getting Stopped Orchestration count";
                int orchestrationStoppedCount = bizTalkGroup.AllOrchestrations ? bizTalkGroup.GetStoppedOrchestrationCount(new List<string>()) : bizTalkGroup.GetStoppedOrchestrationCount(bizTalkGroup.Orchestrations);

                if (receiveLocationsDisabled == -1 || sendPortStoppedCount == -1 || orchestrationStoppedCount == -1)
                {
                    returnState = MonitorStates.Error;
                    details.PlainText = "An error occured trying to query the BizTalk Management database!";
                    details.HtmlText = "<blockquote>An error occured trying to query the BizTalk Management database!</blockquote>";
                }
                else
                {
                    if (receiveLocationsDisabled >= receiveLocationCount || sendPortStoppedCount >= sendPortCount || orchestrationStoppedCount >= orchestrationCount)
                    {
                        returnState = MonitorStates.Error;

                    }
                    else if (receiveLocationsDisabled > 0 || sendPortStoppedCount > 0 || orchestrationStoppedCount > 0)
                    {
                        returnState = MonitorStates.Warning;
                    }
                    details.PlainText = "Getting summary of current states";
                    details = GetSummaryOfDisabledOrStopped();
                }
                LastDetailMsg = details;
            }
            catch (Exception ex)
            {
                LastError = 1;
                LastErrorMsg = ex.Message;
                LastDetailMsg.PlainText = string.Format("Last step: {0}\r\n{1}", LastDetailMsg.PlainText, ex.Message);
                LastDetailMsg.HtmlText = string.Format("<blockquote>Last step: {0}<br />{1}</blockquote>", LastDetailMsg.PlainText, ex.Message);

                returnState = MonitorStates.Error;
            }
            return returnState;
        }

        private CollectorMessage GetSummaryOfDisabledOrStopped()
        {
            StringBuilder plainTextDetails = new StringBuilder();
            StringBuilder htmlTextTextDetails = new StringBuilder();
            int count = 0;
            plainTextDetails.AppendLine("Disabled Receive Locations");
            htmlTextTextDetails.AppendLine("<b>Disabled Receive Locations</b>\r\n<ul>");
            foreach (string rl in bizTalkGroup.GetDisabledReceiveLocationNames())
            {
                plainTextDetails.AppendLine(string.Format("\t{0}", rl));
                htmlTextTextDetails.AppendLine(string.Format("<li>{0}</li>", rl));
                count++;
            }
            if (count == 0)
            {
                plainTextDetails.AppendLine("\tNone");
                htmlTextTextDetails.AppendLine("<li>None</li>");
            }
            htmlTextTextDetails.AppendLine("</ul>");

            count = 0;
            plainTextDetails.AppendLine("Stopped Send Ports");
            htmlTextTextDetails.AppendLine("<b>Stopped Send Ports</b>\r\n<ul>");
            foreach (string s in bizTalkGroup.GetStoppedSendPortNames())
            {
                plainTextDetails.AppendLine(string.Format("\t{0}", s));
                htmlTextTextDetails.AppendLine(string.Format("<li>{0}</li>", s));
                count++;
            }
            if (count == 0)
            {
                plainTextDetails.AppendLine("\tNone");
                htmlTextTextDetails.AppendLine("<li>None</li>");
            }
            htmlTextTextDetails.AppendLine("</ul>");

            count = 0;
            plainTextDetails.AppendLine("Stopped Orchestrations");
            htmlTextTextDetails.AppendLine("<b>Stopped Orchestrations</b>\r\n<ul>");
            foreach (string s in bizTalkGroup.GetStoppedOrchestrationNames())
            {
                plainTextDetails.AppendLine(string.Format("\t{0}", s));
                htmlTextTextDetails.AppendLine(string.Format("<li>{0}</li>", s));
                count++;
            }
            if (count == 0)
            {
                plainTextDetails.AppendLine("\tNone");
                htmlTextTextDetails.AppendLine("<li>None</li>");
            }
            htmlTextTextDetails.AppendLine("</ul>");

            return new CollectorMessage() { PlainText = plainTextDetails.ToString(), HtmlText = htmlTextTextDetails.ToString() };
        }

        public override void ShowStatusDetails()
        {
            //XmlDocument configXml = new XmlDocument();
            //if (config.Length > 0)
            //    configXml.LoadXml(config);
            //else
            //    configXml.LoadXml(GetDefaultOrEmptyConfigString());
            //ReadConfiguration(configXml);

            ShowDetails showDetails = new ShowDetails();
            showDetails.BizTalkGroup = bizTalkGroup;
            showDetails.Show();
        }

        public override string ConfigureAgent(string config)
        {
            XmlDocument configXml = new XmlDocument();
            if (config.Length > 0)
                configXml.LoadXml(config);
            else
                configXml.LoadXml(GetDefaultOrEmptyConfigString());
            ReadConfiguration(configXml);
            EditConfig editConfig = new EditConfig();
            editConfig.BizTalkGroup = bizTalkGroup;
            if (editConfig.ShowConfig() == System.Windows.Forms.DialogResult.OK)
            {
                XmlNode root = configXml.DocumentElement.SelectSingleNode("bizTalkGroup");
                root.SetAttributeValue("sqlServer", editConfig.BizTalkGroup.SqlServer);
                root.SetAttributeValue("mgmtDb", editConfig.BizTalkGroup.MgmtDBName);
                root.SetAttributeValue("allReceiveLocations", editConfig.BizTalkGroup.AllReceiveLocations.ToString());
                root.SetAttributeValue("allSendPorts", editConfig.BizTalkGroup.AllSendPorts.ToString());
                root.SetAttributeValue("allOrchestrations", editConfig.BizTalkGroup.AllOrchestrations.ToString());

                //Receive locations
                XmlNode receiveLocationsNode = root.SelectSingleNode("receiveLocations");
                receiveLocationsNode.InnerXml = "";
                foreach (string rl in editConfig.BizTalkGroup.ReceiveLocations)
                {
                    XmlElement receiveLocationNode = configXml.CreateElement("receiveLocation");
                    receiveLocationNode.SetAttributeValue("name", rl);
                    receiveLocationsNode.AppendChild(receiveLocationNode);
                }

                //Send ports
                XmlNode sendPortsNode = root.SelectSingleNode("sendPorts");
                sendPortsNode.InnerXml = "";
                foreach (string s in editConfig.BizTalkGroup.SendPorts)
                {
                    XmlElement sendPortNode = configXml.CreateElement("sendPort");
                    sendPortNode.SetAttributeValue("name", s);
                    sendPortsNode.AppendChild(sendPortNode);
                }

                //Orchestrations
                XmlNode orchestrationsNode = root.SelectSingleNode("orchestrations");
                orchestrationsNode.InnerXml = "";
                foreach (string s in editConfig.BizTalkGroup.Orchestrations)
                {
                    XmlElement orchestrationNode = configXml.CreateElement("orchestration");
                    orchestrationNode.SetAttributeValue("name", s);
                    orchestrationsNode.AppendChild(orchestrationNode);
                }

                config = configXml.OuterXml;
            }
            return config;
        }

        public override string GetDefaultOrEmptyConfigString()
        {
            return Properties.Resources.BizTalkPortAndOrchEmptyConfig_xml;
        }

        public override void ReadConfiguration(XmlDocument config)
        {
            XmlNode root = config.DocumentElement.SelectSingleNode("bizTalkGroup");
            bizTalkGroup.SqlServer = root.ReadXmlElementAttr("sqlServer", ".");
            bizTalkGroup.MgmtDBName = root.ReadXmlElementAttr("mgmtDb", "BizTalkMgmtDb");
            bizTalkGroup.AllReceiveLocations = bool.Parse(root.ReadXmlElementAttr("allReceiveLocations", "True"));
            bizTalkGroup.AllSendPorts = bool.Parse(root.ReadXmlElementAttr("allSendPorts", "True"));
            bizTalkGroup.AllOrchestrations = bool.Parse(root.ReadXmlElementAttr("allOrchestrations", "True"));
            bizTalkGroup.ReceiveLocations = new List<string>();
            foreach (XmlElement receiveLocationNode in root.SelectNodes("receiveLocations/receiveLocation"))
            {
                string receiveLocationName = receiveLocationNode.ReadXmlElementAttr("name");
                if (receiveLocationName.Length > 0)
                    bizTalkGroup.ReceiveLocations.Add(receiveLocationName);
            }
            bizTalkGroup.SendPorts = new List<string>();
            foreach (XmlElement sendPortNode in root.SelectNodes("sendPorts/sendPort"))
            {
                string sendPortName = sendPortNode.ReadXmlElementAttr("name");
                if (sendPortName.Length > 0)
                    bizTalkGroup.SendPorts.Add(sendPortName);
            }
            bizTalkGroup.Orchestrations = new List<string>();
            foreach (XmlElement orchestrationNode in root.SelectNodes("orchestrations/orchestration"))
            {
                string orchestrationName = orchestrationNode.ReadXmlElementAttr("name");
                if (orchestrationName.Length > 0)
                    bizTalkGroup.Orchestrations.Add(orchestrationName);
            }
        }
    }
}
