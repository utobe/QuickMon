﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenIT.RTF;

namespace QuickMon
{
    public partial class CollectorStats : Form
    {
        public CollectorStats()
        {
            InitializeComponent();
        }

        public CollectorEntry SelectedEntry { get; set; }

        private void CollectorStats_Load(object sender, EventArgs e)
        {
            RefreshCollectorStats();
            lvwProperties.AutoResizeColumnEnabled = true;
            lvwProperties.AutoResizeColumnIndex = 1;
            splitContainer1.Panel2Collapsed = true;
        }

        private void CollectorStats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshCollectorStats();
            }
        }

        private void RefreshCollectorStats()
        {
            try
            {
                lvwProperties.Items.Clear();
                lvwProperties.Groups.Clear();
                lvwProperties.BeginUpdate();
                if (SelectedEntry != null)
                {
                    this.Text = "Collector statistics - " + SelectedEntry.Name;
                    ListViewGroup lvgGeneral = new ListViewGroup("General");
                    lvwProperties.Groups.Add(lvgGeneral);

                    ListViewItem lvi = new ListViewItem("Collector Name");
                    lvi.SubItems.Add(SelectedEntry.Name);
                    lvi.Group = lvgGeneral;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Enabled");
                    lvi.SubItems.Add(SelectedEntry.Enabled ? "Yes" : "No");
                    lvi.Group = lvgGeneral;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Agent type");
                    lvi.SubItems.Add(SelectedEntry.CollectorRegistrationDisplayName);
                    lvi.Group = lvgGeneral;
                    lvwProperties.Items.Add(lvi);

                    ListViewGroup lvgCurrent = new ListViewGroup("Current state");
                    lvwProperties.Groups.Add(lvgCurrent);
                    ListViewGroup lvgPrevious = new ListViewGroup("Previous state");
                    lvwProperties.Groups.Add(lvgPrevious);

                    lvi = new ListViewItem("Current state");
                    lvi.SubItems.Add(SelectedEntry.CurrentState.State.ToString());
                    lvi.Group = lvgCurrent;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Current state details");
                    lvi.SubItems.Add(SelectedEntry.CurrentState.RawDetails);
                    lvi.Group = lvgCurrent;
                    lvwProperties.Items.Add(lvi);                    

                    lvi = new ListViewItem("Last state update");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastStateUpdate));
                    lvi.Group = lvgCurrent;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last state check duration (ms)");
                    lvi.SubItems.Add(SelectedEntry.LastStateCheckDurationMS.ToString());
                    lvi.Group = lvgCurrent;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Previous state");
                    lvi.SubItems.Add(SelectedEntry.LastMonitorState.State.ToString());
                    lvi.Group = lvgPrevious;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Previous state details");
                    lvi.SubItems.Add(SelectedEntry.LastMonitorState.RawDetails);
                    lvi.Group = lvgPrevious;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Previous state time");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastMonitorState.LastStateChangeTime));
                    lvi.Group = lvgPrevious;
                    lvwProperties.Items.Add(lvi);

                    ListViewGroup lvgPolling = new ListViewGroup("Polling details");
                    lvwProperties.Groups.Add(lvgPolling);

                    lvi = new ListViewItem("# of times polled");
                    lvi.SubItems.Add(SelectedEntry.PollCount.ToString());
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("First polled time");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.FirstStateUpdate));
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("# of times good states");
                    lvi.SubItems.Add(SelectedEntry.GoodStateCount.ToString());
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("# of times warning states");
                    lvi.SubItems.Add(SelectedEntry.WarningStateCount.ToString());
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("# of times error states");
                    lvi.SubItems.Add(SelectedEntry.ErrorStateCount.ToString());
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last attempted polling time");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastStateCheckAttemptBegin));
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    ListViewGroup lvgAlerts = new ListViewGroup("Alerts");
                    lvwProperties.Groups.Add(lvgAlerts);

                    lvi = new ListViewItem("Last alert time");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastAlertTime));
                    lvi.Group = lvgAlerts;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last warning alert time");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastWarningAlertTime));
                    lvi.Group = lvgAlerts;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last error alert time");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastErrorAlertTime));
                    lvi.Group = lvgAlerts;
                    lvwProperties.Items.Add(lvi);                    

                    lvi = new ListViewItem("Last good state time:");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastGoodStateTime));
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last good state details");
                    if (SelectedEntry.LastGoodState != null && SelectedEntry.LastGoodState.RawDetails != null)
                        lvi.SubItems.Add(SelectedEntry.LastGoodState.RawDetails);
                    else
                        lvi.SubItems.Add("N/A");
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last warning state");
                    lvi.SubItems.Add(FormatDate(SelectedEntry.LastWarningStateTime));
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last warning state details");
                    if (SelectedEntry.LastWarningState != null && SelectedEntry.LastWarningState.RawDetails != null)
                        lvi.SubItems.Add(SelectedEntry.LastWarningState.RawDetails);
                    else
                        lvi.SubItems.Add("N/A");
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last error state");
                    lvi.SubItems.Add(FormatDate( SelectedEntry.LastErrorStateTime));
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);

                    lvi = new ListViewItem("Last error state details");
                    if (SelectedEntry.LastErrorState != null && SelectedEntry.LastErrorState.RawDetails != null)
                        lvi.SubItems.Add(SelectedEntry.LastErrorState.RawDetails);
                    else
                        lvi.SubItems.Add("N/A");
                    lvi.Group = lvgPolling;
                    lvwProperties.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lvwProperties.EndUpdate();
            }
        }

        private void lvwProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RTFBuilder rtfBuilder = new RTFBuilder();
                if (lvwProperties.SelectedItems.Count > 0)
                {
                    int maxlen = 35;
                    foreach (ListViewItem lvi in lvwProperties.Items)
                    {
                        if (lvi.Text.Length + 2 > maxlen)
                            maxlen = lvi.Text.Length + 2;
                    }


                    foreach (ListViewItem lvi in lvwProperties.SelectedItems)
                    {
                        rtfBuilder.FontStyle(FontStyle.Bold).Append((lvi.Text + ":").PadRight(maxlen));
                        if (lvi.SubItems[1].Text.Contains("\r"))
                        {
                            rtfBuilder.AppendLine("");
                        }
                        else
                            rtfBuilder.Append("\t");
                        rtfBuilder.AppendLine(lvi.SubItems[1].Text);
                    }
                }
                rtxDetails.Rtf = rtfBuilder.ToString();
                rtxDetails.SelectionStart = 0;
                rtxDetails.SelectionLength = 0;
                rtxDetails.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdViewDetails_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
            cmdViewDetails.Text = splitContainer1.Panel2Collapsed ? "ttt" : "uuu";
            splitContainer1.SplitterWidth = 8;
        }

        private string FormatDate(DateTime date)
        {
            if (date == null || date <= (new DateTime(2000, 1, 1)))
                return "N/A";
            else
               return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshCollectorStats();
        }
    }
}