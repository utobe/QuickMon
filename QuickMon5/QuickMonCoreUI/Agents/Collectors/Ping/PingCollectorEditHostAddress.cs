﻿using QuickMon.Collectors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMon.UI
{
    public partial class PingCollectorEditHostAddress : Form, ICollectorConfigEntryEditWindow
    {
        public PingCollectorEditHostAddress()
        {
            InitializeComponent();
        }

        #region IEditConfigEntryWindow Members
        public ICollectorConfigEntry SelectedEntry { get; set; }
        public QuickMonDialogResult ShowEditEntry()
        {
            if (SelectedEntry == null)
                SelectedEntry = new PingCollectorHostEntry();
            HostEntry = (PingCollectorHostEntry)SelectedEntry;
            switch (HostEntry.PingType)
            {
                case PingCollectorType.HTTP:
                    cboPingType.SelectedIndex = 1;
                    break;
                case PingCollectorType.Socket:
                    cboPingType.SelectedIndex = 2;
                    break;
                default:
                    cboPingType.SelectedIndex = 0;
                    break;
            }
            txtAddress.Text = HostEntry.Address;
            txtDescription.Text = HostEntry.DescriptionLocal;
            nudExpextedTime.Value = HostEntry.MaxTimeMS;
            nudTimeOut.Value = HostEntry.TimeOutMS;
            txtHTTPHeaderUsername.Text = HostEntry.HttpHeaderUserName;
            txtHTTPHeaderPassword.Text = HostEntry.HttpHeaderPassword;
            txtHttpProxy.Text = HostEntry.HttpProxyServer;
            txtProxyUsername.Text = HostEntry.HttpProxyUserName;
            txtProxyPassword.Text = HostEntry.HttpProxyPassword;
            txtHTMLContent.Text = HostEntry.HTMLContentContain;
            nudPortNumber.Value = HostEntry.SocketPort;
            nudReceiveTimeout.Value = HostEntry.ReceiveTimeOutMS;
            nudSendTimeout.Value = HostEntry.SendTimeOutMS;
            chkUseTelNetLogin.Checked = HostEntry.UseTelnetLogin;
            txtUserName.Text = HostEntry.TelnetUserName;
            txtPassword.Text = HostEntry.TelnetPassword;
            return (QuickMonDialogResult)ShowDialog();
        }
        #endregion

        private PingCollectorHostEntry HostEntry { get; set; }

        public DialogResult ShowHostAddress()
        {
            switch (HostEntry.PingType)
            {
                case PingCollectorType.HTTP:
                    cboPingType.SelectedIndex = 1;
                    break;
                case PingCollectorType.Socket:
                    cboPingType.SelectedIndex = 2;
                    break;
                default:
                    cboPingType.SelectedIndex = 0;
                    break;
            }
            txtAddress.Text = HostEntry.Address;
            txtDescription.Text = HostEntry.DescriptionLocal;
            nudExpextedTime.Value = HostEntry.MaxTimeMS;
            nudTimeOut.Value = HostEntry.TimeOutMS;
            txtHTTPHeaderUsername.Text = HostEntry.HttpHeaderUserName;
            txtHTTPHeaderPassword.Text = HostEntry.HttpHeaderPassword;
            txtHttpProxy.Text = HostEntry.HttpProxyServer;
            txtProxyUsername.Text = HostEntry.HttpProxyUserName;
            txtProxyPassword.Text = HostEntry.HttpProxyPassword;
            txtHTMLContent.Text = HostEntry.HTMLContentContain;
            chkIgnoreInvalidHTTPSCerts.Checked = HostEntry.IgnoreInvalidHTTPSCerts;
            nudPortNumber.Value = HostEntry.SocketPort;
            nudReceiveTimeout.Value = HostEntry.ReceiveTimeOutMS;
            nudSendTimeout.Value = HostEntry.SendTimeOutMS;
            chkUseTelNetLogin.Checked = HostEntry.UseTelnetLogin;
            txtUserName.Text = HostEntry.TelnetUserName;
            txtPassword.Text = HostEntry.TelnetPassword;
            txtSocketPingMsgBody.Text = HostEntry.SocketPingMsgBody;
            CheckOkEnabled();
            return ShowDialog();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0)
            {
                txtAddress.Focus();
            }
            else if (RunPingTestWithPrompt().State == CollectorState.Good)
            {
                if (cboPingType.SelectedIndex == 1)
                    HostEntry.PingType = PingCollectorType.HTTP;
                else if (cboPingType.SelectedIndex == 2)
                    HostEntry.PingType = PingCollectorType.Socket;
                else
                    HostEntry.PingType = PingCollectorType.Ping;

                HostEntry.Address = txtAddress.Text;
                HostEntry.DescriptionLocal = txtDescription.Text;
                HostEntry.MaxTimeMS = Convert.ToInt32(nudExpextedTime.Value);
                HostEntry.TimeOutMS = Convert.ToInt32(nudTimeOut.Value);
                HostEntry.HttpHeaderUserName = txtHTTPHeaderUsername.Text;
                HostEntry.HttpHeaderPassword = txtHTTPHeaderPassword.Text;
                HostEntry.HttpProxyServer = txtHttpProxy.Text;
                HostEntry.HttpProxyUserName = txtProxyUsername.Text;
                HostEntry.HttpProxyPassword = txtProxyPassword.Text;
                HostEntry.HTMLContentContain = txtHTMLContent.Text;
                HostEntry.IgnoreInvalidHTTPSCerts = chkIgnoreInvalidHTTPSCerts.Checked;
                HostEntry.SocketPort = (int)nudPortNumber.Value;
                HostEntry.ReceiveTimeOutMS = (int)nudReceiveTimeout.Value;
                HostEntry.SendTimeOutMS = (int)nudSendTimeout.Value;
                HostEntry.UseTelnetLogin = chkUseTelNetLogin.Checked;
                HostEntry.TelnetUserName = txtUserName.Text;
                HostEntry.TelnetPassword = txtPassword.Text;
                HostEntry.SocketPingMsgBody = txtSocketPingMsgBody.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private MonitorState RunPingTest()
        {
            MonitorState result;

            PingCollectorHostEntry tmpPingCollectorHostEntry = new PingCollectorHostEntry();
            if (cboPingType.SelectedIndex == 1)
            {
                tmpPingCollectorHostEntry.PingType = PingCollectorType.HTTP;
                if (!txtAddress.Text.ToUpper().StartsWith("HTTP"))
                    txtAddress.Text = "http://" + txtAddress.Text;
            }
            else if (cboPingType.SelectedIndex == 2)
                tmpPingCollectorHostEntry.PingType = PingCollectorType.Socket;
            else
                tmpPingCollectorHostEntry.PingType = PingCollectorType.Ping;

            tmpPingCollectorHostEntry.Address = txtAddress.Text;
            tmpPingCollectorHostEntry.DescriptionLocal = txtDescription.Text;
            tmpPingCollectorHostEntry.MaxTimeMS = Convert.ToInt32(nudExpextedTime.Value);
            tmpPingCollectorHostEntry.TimeOutMS = Convert.ToInt32(nudTimeOut.Value);
            tmpPingCollectorHostEntry.HttpHeaderUserName = txtHTTPHeaderUsername.Text;
            tmpPingCollectorHostEntry.HttpHeaderPassword = txtHTTPHeaderPassword.Text;
            tmpPingCollectorHostEntry.HttpProxyServer = txtHttpProxy.Text;
            tmpPingCollectorHostEntry.HttpProxyUserName = txtProxyUsername.Text;
            tmpPingCollectorHostEntry.HttpProxyPassword = txtProxyPassword.Text;
            tmpPingCollectorHostEntry.HTMLContentContain = txtHTMLContent.Text;
            tmpPingCollectorHostEntry.IgnoreInvalidHTTPSCerts = chkIgnoreInvalidHTTPSCerts.Checked;
            tmpPingCollectorHostEntry.SocketPort = (int)nudPortNumber.Value;
            tmpPingCollectorHostEntry.ReceiveTimeOutMS = (int)nudReceiveTimeout.Value;
            tmpPingCollectorHostEntry.SendTimeOutMS = (int)nudSendTimeout.Value;
            tmpPingCollectorHostEntry.UseTelnetLogin = chkUseTelNetLogin.Checked;
            tmpPingCollectorHostEntry.TelnetUserName = txtUserName.Text;
            tmpPingCollectorHostEntry.TelnetPassword = txtPassword.Text;
            tmpPingCollectorHostEntry.SocketPingMsgBody = txtSocketPingMsgBody.Text;

            result = tmpPingCollectorHostEntry.GetCurrentState();            
            return result;
        }

        private MonitorState RunPingTestWithPrompt()
        {
            MonitorState result = new MonitorState();
            try
            {
                result = RunPingTest();
                if (result.State != CollectorState.Good)
                {
                    throw new Exception(result.ReadAllRawDetails());
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(string.Format("Test failed!\r\nResult: {0}\r\nAccept anyway?", ex.Message), "Ping test", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    result.State = CollectorState.Good;
                }
            }
            return result;
        }

        private void cmdTestAddress_Click(object sender, EventArgs e)
        {
            try
            {
                MonitorState result = RunPingTest();
                if (result.State == CollectorState.Good)
                {
                    if (cboPingType.SelectedIndex == 1)
                    {
                        try
                        {
                            string tempFileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt");
                            System.IO.File.WriteAllText(tempFileName, result.ReadAllRawDetails());
                            System.Diagnostics.Process p = new System.Diagnostics.Process();
                            p.StartInfo = new System.Diagnostics.ProcessStartInfo("notepad.exe", tempFileName);
                            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                            p.Start();
                            System.Threading.Thread.Sleep(1000);
                            System.IO.File.Delete(tempFileName);
                        }
                        catch { }

                    }
                    MessageBox.Show(string.Format("Test was successful\r\n{0}", result.ReadAllRawDetails()), "Ping test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Test failed!\r\nResult: " + result.ReadAllRawDetails(), "Ping test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test failed!\r\nResult: " + ex.Message, "Ping test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            httpGroupBox.Enabled = cboPingType.SelectedIndex == 1;
            socketPingGroupBox.Enabled = cboPingType.SelectedIndex == 2;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            CheckOkEnabled();
        }

        private void CheckOkEnabled()
        {
            cmdOK.Enabled = txtAddress.Text.Length > 0 && (!chkUseTelNetLogin.Checked || txtUserName.Text.Length > 0);
            cmdTestAddress.Enabled = txtAddress.Text.Length > 0 && (!chkUseTelNetLogin.Checked || txtUserName.Text.Length > 0);
        }

        private void chkUseTelNetLogin_CheckedChanged(object sender, EventArgs e)
        {
            CheckOkEnabled();
            txtUserName.Enabled = chkUseTelNetLogin.Checked;
            txtPassword.Enabled = chkUseTelNetLogin.Checked;
        }

        private void PingCollectorEditHostAddress_Load(object sender, EventArgs e)
        {

        }


    }
}
