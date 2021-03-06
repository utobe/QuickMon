﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading;
using System.Net.Mail;

namespace QuickMon
{
    public class SMTPNotifier : NotifierBase
    {
        private MailSettings mailSettings = new MailSettings();
        private Mutex smtpWriteMutex = new Mutex();

        public override void RecordMessage(AlertLevel alertLevel, string collectorType, string category, MonitorStates oldState, MonitorStates newState, CollectorMessage collectorMessage)
        {
            string lastStep = "";
            try
            {
                smtpWriteMutex.WaitOne();
                if (mailSettings.HostServer.Length == 0)
                {
                    throw new Exception("SMTP host server not specified!");
                }
                lastStep = "Setting up SMTP client details";
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    smtpClient.Host = mailSettings.HostServer;
                    smtpClient.UseDefaultCredentials = mailSettings.UseDefaultCredentials;
                    smtpClient.Port = mailSettings.Port;

                    if (!mailSettings.UseDefaultCredentials)
                    {
                        lastStep = "Setting up non default credentials";
                        System.Net.NetworkCredential cr = new System.Net.NetworkCredential();
                        cr.Domain = mailSettings.Domain;
                        cr.UserName = mailSettings.UserName;
                        cr.Password = mailSettings.Password; 
                        smtpClient.Credentials = cr;
                    }
                    if (mailSettings.UseTLS)
                    {                        
                        smtpClient.EnableSsl = true;
                    }
                    MailMessage mailMessage = new MailMessage(mailSettings.FromAddress, mailSettings.ToAddress);

                    lastStep = "Setting up mail body";
                    string body = mailSettings.Body
                        .Replace("%Details%", mailSettings.IsBodyHtml ? collectorMessage.HtmlText : collectorMessage.PlainText)
                    .Replace("%DateTime%", DateTime.Now.ToString("F"))
                    .Replace("%AlertLevel%", alertLevel.ToString())
                    .Replace("%PreviousState%", oldState.ToString())
                    .Replace("%CurrentState%", newState.ToString())
                    .Replace("%CollectorName%", category)
                    .Replace("%CollectorType%", collectorType);

                    string subject = mailSettings.Subject
                       .Replace("%DateTime%", DateTime.Now.ToString("F"))
                       .Replace("%AlertLevel%", alertLevel.ToString())
                       .Replace("%PreviousState%", oldState.ToString())
                       .Replace("%CurrentState%", newState.ToString())
                       .Replace("%CollectorName%", category)
                       .Replace("%CollectorType%", collectorType);

                    mailMessage.Priority = (MailPriority)mailSettings.MailPriority;
                    if (mailSettings.SenderAddress.Length > 0)
                        mailMessage.Sender = new MailAddress(mailSettings.SenderAddress);
                    if (mailSettings.ReplyToAddress.Length > 0)
                    {
                        mailMessage.ReplyToList.Add(mailSettings.ReplyToAddress);
                    }

                    mailMessage.Body = body;
                    mailMessage.IsBodyHtml = mailSettings.IsBodyHtml;

                    mailMessage.Subject = subject;
                    lastStep = "Sending SMTP mail";
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error recording message in SMTP notifier\r\nLast step: " + lastStep, ex);
            }
            finally
            {
                smtpWriteMutex.ReleaseMutex();
            }
        }
        public override void OpenViewer(string notifierName)
        {
            throw new NotImplementedException();
        }
        public override bool HasViewer
        {
            get { return false; }
        }
        public override string ConfigureAgent(string config)
        {
            XmlDocument configXml = new XmlDocument();
            EditConfig editConfig = new EditConfig();
            if (config.Length > 0)
            {
                try
                {
                    configXml.LoadXml(config);
                }
                catch
                {
                    configXml.LoadXml(Properties.Resources.SMTPNotifierEmptyConfig_xml);
                }
            }
            else
            {
                configXml.LoadXml(Properties.Resources.SMTPNotifierEmptyConfig_xml);
            }

            ReadConfiguration(configXml);
            editConfig.MailSettings = mailSettings;

            if (editConfig.ShowConfig() == System.Windows.Forms.DialogResult.OK)
            {
                mailSettings = editConfig.MailSettings;
                XmlElement root = configXml.DocumentElement;
                XmlNode connectionNode = root.SelectSingleNode("smtp");
                connectionNode.SetAttributeValue("hostServer", mailSettings.HostServer);
                connectionNode.SetAttributeValue("useDefaultCredentials", mailSettings.UseDefaultCredentials.ToString());
                connectionNode.SetAttributeValue("domain", mailSettings.Domain);                
                connectionNode.SetAttributeValue("userName", mailSettings.UserName);
                connectionNode.SetAttributeValue("password", mailSettings.Password);
                connectionNode.SetAttributeValue("fromAddress", mailSettings.FromAddress);
                connectionNode.SetAttributeValue("toAddress", mailSettings.ToAddress);
                connectionNode.SetAttributeValue("senderAddress", mailSettings.SenderAddress);
                connectionNode.SetAttributeValue("replyToAddress", mailSettings.ReplyToAddress);
                connectionNode.SetAttributeValue("mailPriority", mailSettings.MailPriority);                
                connectionNode.SetAttributeValue("isBodyHtml", mailSettings.IsBodyHtml.ToString());
                connectionNode.SetAttributeValue("subject", mailSettings.Subject);
                connectionNode.SetAttributeValue("body", mailSettings.Body);
                connectionNode.SetAttributeValue("useTLS", mailSettings.UseTLS.ToString());
                connectionNode.SetAttributeValue("port", mailSettings.Port.ToString());
                config = configXml.OuterXml;
            }
            return config;
        }
        public override string GetDefaultOrEmptyConfigString()
        {
            return Properties.Resources.SMTPNotifierEmptyConfig_xml;
        }
        public override void ReadConfiguration(XmlDocument config)
        {            
            XmlElement root = config.DocumentElement;
            XmlNode connectionNode = root.SelectSingleNode("smtp");
            mailSettings.HostServer = connectionNode.ReadXmlElementAttr("hostServer", "");
            mailSettings.UseDefaultCredentials = bool.Parse(connectionNode.ReadXmlElementAttr("useDefaultCredentials", "True"));
            mailSettings.UseTLS = bool.Parse(connectionNode.ReadXmlElementAttr("useTLS", "False"));
            mailSettings.Port = int.Parse(connectionNode.ReadXmlElementAttr("port", "25"));
            mailSettings.Domain = connectionNode.ReadXmlElementAttr("domain", "");
            mailSettings.UserName = connectionNode.ReadXmlElementAttr("userName", "");
            mailSettings.Password = connectionNode.ReadXmlElementAttr("password", "");
            mailSettings.FromAddress = connectionNode.ReadXmlElementAttr("fromAddress", "");
            mailSettings.SenderAddress = connectionNode.ReadXmlElementAttr("senderAddress", "");
            mailSettings.ReplyToAddress = connectionNode.ReadXmlElementAttr("replyToAddress", "");
            mailSettings.MailPriority = int.Parse(connectionNode.ReadXmlElementAttr("mailPriority", "1"));
            mailSettings.ToAddress = connectionNode.ReadXmlElementAttr("toAddress", "");
            mailSettings.IsBodyHtml = bool.Parse(connectionNode.ReadXmlElementAttr("isBodyHtml", "True"));
            mailSettings.Subject = connectionNode.ReadXmlElementAttr("subject", "");
            mailSettings.Body = connectionNode.ReadXmlElementAttr("body", "");
        }
    }
}
