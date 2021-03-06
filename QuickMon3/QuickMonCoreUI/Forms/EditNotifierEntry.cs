﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using QuickMon.Forms;

namespace QuickMon.Management
{
    public partial class EditNotifierEntry : Form
    {
        public EditNotifierEntry()
        {
            InitializeComponent();
        }

        private MonitorPack monitorPack;
        private NotifierEntry editingNotifierEntry;

        public NotifierEntry SelectedEntry { get; set; }
        public bool LaunchAddEntry { get; set; }
        public bool ShowRawEditOnStart { get; set; }
        public bool ShowSelectPresetOnStart { get; set; }

        public DialogResult ShowDialog(MonitorPack monitorPack)
        {
            if (SelectedEntry == null)
            {
                return System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {
                this.monitorPack = monitorPack;
                editingNotifierEntry = NotifierEntry.FromConfig(SelectedEntry.ToConfig());

                try
                {
                    //Create Notifier instance but do not apply Config Variables!
                    editingNotifierEntry.CreateAndConfigureEntry(editingNotifierEntry.NotifierRegistrationName, "", false);
                    return ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return System.Windows.Forms.DialogResult.Cancel;
                }               
            }
        }

        #region Form events
        private void EditNotifierEntry_Load(object sender, EventArgs e)
        {
            if (LaunchAddEntry)
            {
                cmdConfigure_Click(null, null);
            }
            else if (ShowRawEditOnStart && editingNotifierEntry != null && editingNotifierEntry.InitialConfiguration != null)
            {
                llblRawEdit_LinkClicked(null, null);
            }
        }
        private void EditNotifierEntry_Shown(object sender, EventArgs e)
        {
            ApplyConfigToControls();
        }        
        #endregion

        #region Button and link events
        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedEntry == null)
                    SelectedEntry = new NotifierEntry();
                SelectedEntry.Name = txtName.Text;
                SelectedEntry.Enabled = chkEnabled.Checked;
                SelectedEntry.AlertLevel = (AlertLevel)cboAlertLevel.SelectedIndex;
                SelectedEntry.DetailLevel = (DetailLevel)cboDetailLevel.SelectedIndex;
                SelectedEntry.NotifierRegistrationName = editingNotifierEntry.NotifierRegistrationName;
                SelectedEntry.InitialConfiguration = editingNotifierEntry.InitialConfiguration;
                SelectedEntry.AlertForCollectors.Clear();
                if (editingNotifierEntry.AlertForCollectors != null && editingNotifierEntry.AlertForCollectors.Count > 0)
                    SelectedEntry.AlertForCollectors.AddRange(editingNotifierEntry.AlertForCollectors.ToArray());
                SelectedEntry.AttendedOptionOverride = (AttendedOption)cboAttendedOptionOverride.SelectedIndex;
                SelectedEntry.ServiceWindows.CreateFromConfig(editingNotifierEntry.ServiceWindows.ToConfig());
                SelectedEntry.ConfigVariables = new List<ConfigVariable>();
                SelectedEntry.ConfigVariables.AddRange((from ConfigVariable cv in editingNotifierEntry.ConfigVariables
                                                        select cv.Clone()).ToArray());
                SelectedEntry.CreateAndConfigureEntry(SelectedEntry.NotifierRegistrationName);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void alertForCollectorslinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectNotifierCollectors selectNotifierCollectors = new SelectNotifierCollectors();
            selectNotifierCollectors.SelectedCollectors = new List<string>();
            selectNotifierCollectors.SelectedCollectors.AddRange(editingNotifierEntry.AlertForCollectors.ToArray());
            if (selectNotifierCollectors.ShowNotifierCollectors(monitorPack) == System.Windows.Forms.DialogResult.OK)
            {
                editingNotifierEntry.AlertForCollectors.Clear();
                editingNotifierEntry.AlertForCollectors.AddRange(selectNotifierCollectors.SelectedCollectors.ToArray());
                SetAlertForCollectors();
                if (!backgroundWorkerCheckOk.IsBusy)
                    backgroundWorkerCheckOk.RunWorkerAsync();
            }
        }
        private void cmdConfigure_Click(object sender, EventArgs e)
        {
            if (editingNotifierEntry != null && editingNotifierEntry.Notifier != null)
            {
                try
                {
                    INotifier tmpnotifier = editingNotifierEntry.Notifier;
                    if (tmpnotifier != null)
                    {
                        if (txtName.Text.Length == 0)
                            txtName.Text = "No Name";
                        if (tmpnotifier.ShowEditConfiguration("Edit '" + txtName.Text + "' Config"))
                        {
                            editingNotifierEntry.Notifier = tmpnotifier;
                            editingNotifierEntry.InitialConfiguration = tmpnotifier.AgentConfig.ToConfig();
                            if (editingNotifierEntry.Notifier != null && editingNotifierEntry.Notifier.AgentConfig != null)
                            {
                                INotifierConfig config = (INotifierConfig)editingNotifierEntry.Notifier.AgentConfig;
                                lblConfigSummary.Text = config.ConfigSummary;
                            }
                        }
                        CheckOkEnable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void llblNotifierType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change the Notifier type?\r\n\r\nIf you continue this will reset any existing configuration.", "Notifier type", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                List<ConfigVariable> configVars = new List<ConfigVariable>();
                foreach (ConfigVariable cv in editingNotifierEntry.ConfigVariables)
                    configVars.Add(cv.Clone());
                NotifierEntry newNotifierEntry = AgentHelper.CreateNewNotifier();
                if (newNotifierEntry != null)
                {
                    editingNotifierEntry = null;
                    editingNotifierEntry = newNotifierEntry;
                    editingNotifierEntry.ConfigVariables = configVars;
                    ApplyConfigToControls();
                    if (AgentHelper.LastShowRawEditOnStartOption)
                        llblRawEdit_LinkClicked(sender, e);
                }
            }
        }
        private void llblRawEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (editingNotifierEntry.InitialConfiguration != null)
                {
                    EditRAWMarkup editRaw = new EditRAWMarkup();
                    editRaw.SelectedMarkup = XmlFormattingUtils.NormalizeXML(editingNotifierEntry.InitialConfiguration);
                    editRaw.AgentType = editingNotifierEntry.NotifierRegistrationName;
                    editRaw.UseNotifierType = true;
                    editRaw.CurrentMonitorPack = monitorPack;
                    if (editRaw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        editingNotifierEntry.CreateAndConfigureEntry(editingNotifierEntry.NotifierRegistrationName, editRaw.SelectedMarkup, true, false);
                        if (editingNotifierEntry.Notifier != null && editingNotifierEntry.Notifier.AgentConfig != null)
                        {
                            INotifierConfig config = (INotifierConfig)editingNotifierEntry.Notifier.AgentConfig;
                            lblConfigSummary.Text = config.ConfigSummary;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error setting configuration\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void llblExportConfigAsTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (editingNotifierEntry != null && editingNotifierEntry.Notifier != null && txtName.Text.Trim().Length > 0)
            {
                if (MessageBox.Show("Are you sure you want to export the current config as a template?\r\nThe notifier entry name will be used as name for the template.", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        AgentPresetConfig newPreset = new AgentPresetConfig();
                        newPreset.AgentClassName = editingNotifierEntry.NotifierRegistrationName;
                        newPreset.Description = txtName.Text;
                        newPreset.Config = editingNotifierEntry.InitialConfiguration;
                        List<AgentPresetConfig> allExistingPresets = AgentPresetConfig.GetAllPresets();

                        if ((from p in allExistingPresets
                                 where p.AgentClassName == newPreset.AgentClassName && p.Description == newPreset.Description
                             select p).Count() > 0)
                        {
                            if (MessageBox.Show("A template with the name '" + newPreset.Description + "' already exist!\r\nDo you want to replace it?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
                                AgentPresetConfig existingEntry = (from p in allExistingPresets
                                                                   where p.AgentClassName == newPreset.AgentClassName && p.Description == newPreset.Description
                                                                   select p).FirstOrDefault();
                                existingEntry.Config = newPreset.Config;
                            }
                        }
                        else
                            allExistingPresets.Add(newPreset);
                        AgentPresetConfig.SaveAllPresetsToFile(allExistingPresets);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void llblEditConfigVars_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (editingNotifierEntry != null)
                {
                    EditConfigVariables editConfigVariables = new EditConfigVariables();
                    editConfigVariables.SelectedConfigVariables = editingNotifierEntry.ConfigVariables;
                    if (editConfigVariables.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        editingNotifierEntry.ConfigVariables = editConfigVariables.SelectedConfigVariables;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Change checking
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!backgroundWorkerCheckOk.IsBusy)
                backgroundWorkerCheckOk.RunWorkerAsync();
        }
        private void cboNotifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!backgroundWorkerCheckOk.IsBusy)
                backgroundWorkerCheckOk.RunWorkerAsync();
        }
        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!backgroundWorkerCheckOk.IsBusy)
                backgroundWorkerCheckOk.RunWorkerAsync();
        }
        private void backgroundWorkerCheckOk_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                CheckOkEnable();
            });
        }
        private void cboAlertLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!backgroundWorkerCheckOk.IsBusy)
                backgroundWorkerCheckOk.RunWorkerAsync();
        }
        private void cboDetailLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!backgroundWorkerCheckOk.IsBusy)
                backgroundWorkerCheckOk.RunWorkerAsync();
        }
        #endregion

        #region Private methods
        private void CheckOkEnable()
        {
            bool isEnable = true;
            if (txtName.Text.Length == 0 || editingNotifierEntry == null || editingNotifierEntry.InitialConfiguration == null || editingNotifierEntry.InitialConfiguration.Length == 0)
                isEnable = false;

            cmdOK.Enabled = isEnable;
            cmdConfigure.Enabled = editingNotifierEntry!= null && editingNotifierEntry.NotifierRegistrationName != null && editingNotifierEntry.NotifierRegistrationName.Length > 0;
            //lblAgentDescription.Text = "";
            //if (cboNotifier.SelectedIndex > -1)
            //{
            //    try
            //    {
            //        RegisteredAgent ar = (RegisteredAgent)cboNotifier.SelectedItem;
            //        lblAgentDescription.Text = "Description: " + ar.ClassName;
            //        System.Reflection.Assembly a = System.Reflection.Assembly.LoadFrom(ar.AssemblyPath);
            //        lblAgentDescription.Text += ", Version: " + a.GetName().Version.ToString();
            //        lblAgentDescription.Text += ", Assembly: " + System.IO.Path.GetFileName(a.Location);

            //    }
            //    catch { }
            //}
        }
        private void SetAlertForCollectors()
        {
            if (editingNotifierEntry.AlertForCollectors == null || editingNotifierEntry.AlertForCollectors.Count == 0)
                alertForCollectorslinkLabel.Text = "All Collectors";
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < editingNotifierEntry.AlertForCollectors.Count && i < 100; i++)
                {
                    sb.Append(editingNotifierEntry.AlertForCollectors[i] + ", ");
                }
                alertForCollectorslinkLabel.Text = sb.ToString().TrimEnd(' ', ',');
                if (editingNotifierEntry.AlertForCollectors.Count > 100)
                    alertForCollectorslinkLabel.Text += "...";
            }
        }
        private void ApplyConfigToControls()
        {
            cmdConfigure.Enabled = editingNotifierEntry == null;
            cboAttendedOptionOverride.SelectedIndex = 0;
            if (editingNotifierEntry != null)
            {
                txtName.Text = editingNotifierEntry.Name;
                chkEnabled.Checked = editingNotifierEntry.Enabled;
                RegisteredAgent ar = RegisteredAgentCache.GetRegisteredAgentByClassName(editingNotifierEntry.NotifierRegistrationName, false);
                if (ar != null)
                {
                    llblNotifierType.Text = ar.DisplayName;
                }
                cboAlertLevel.SelectedIndex = (int)editingNotifierEntry.AlertLevel;
                cboDetailLevel.SelectedIndex = (int)editingNotifierEntry.DetailLevel;
                if (editingNotifierEntry.Notifier != null && editingNotifierEntry.Notifier.AgentConfig != null)
                {
                    INotifierConfig config = (INotifierConfig)editingNotifierEntry.Notifier.AgentConfig;
                    lblConfigSummary.Text = config.ConfigSummary;
                    if (editingNotifierEntry.Notifier.AttendedRunOption != AttendedOption.AttendedAndUnAttended)
                    {
                        editingNotifierEntry.AttendedOptionOverride = editingNotifierEntry.Notifier.AttendedRunOption;
                        cboAttendedOptionOverride.Enabled = false;
                    }
                    else
                        cboAttendedOptionOverride.Enabled = true;
                }
                cboAttendedOptionOverride.SelectedIndex = (int)editingNotifierEntry.AttendedOptionOverride;
                SetAlertForCollectors();
                linkLabelServiceWindows.Text = editingNotifierEntry.ServiceWindows.ToString();
                CheckOkEnable();
            }
        }
        #endregion

        private void linkLabelServiceWindows_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditServiceWindows editServiceWindows = new EditServiceWindows();
            editServiceWindows.SelectedServiceWindows = editingNotifierEntry.ServiceWindows;
            if (editServiceWindows.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                editingNotifierEntry.ServiceWindows = editServiceWindows.SelectedServiceWindows;
                linkLabelServiceWindows.Text = editServiceWindows.SelectedServiceWindows.ToString();
                toolTip1.SetToolTip(linkLabelServiceWindows, "Only operate within specified times. Return 'disabled' status otherwise\r\n" + editingNotifierEntry.ServiceWindows.ToString());
                CheckOkEnable();
            }
        }

        #region Manual config edit context menu events
        //private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    txtConfig.Copy();
        //}
        //private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    txtConfig.Paste();
        //}
        //private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    txtConfig.SelectAll();
        //}
        #endregion
       
    }
}
