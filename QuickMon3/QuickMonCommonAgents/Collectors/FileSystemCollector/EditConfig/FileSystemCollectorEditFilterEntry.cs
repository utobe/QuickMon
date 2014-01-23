﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickMon.Collectors
{
    public partial class FileSystemCollectorEditFilterEntry : Form, IEditConfigEntryWindow
    {
        public FileSystemCollectorEditFilterEntry()
        {
            InitializeComponent();
            SelectedFilterEntry = new FileSystemDirectoryFilterEntry();
            SelectedFilterEntry.FileFilter = "*.*";
        }

        #region IEditConfigEntryWindow Members
        public ICollectorConfigEntry SelectedEntry { get; set; }
        public DialogResult ShowEditEntry()
        {
            return ShowDialog();
        }
        #endregion

        public FileSystemDirectoryFilterEntry SelectedFilterEntry { get; set; }

        private void FileSystemCollectorEditFilterEntry_Load(object sender, EventArgs e)
        {
            FileSystemDirectoryFilterEntry selectedEntry;
            if (SelectedEntry != null)
                selectedEntry = (FileSystemDirectoryFilterEntry)SelectedEntry;
            else
                selectedEntry = (FileSystemDirectoryFilterEntry)SelectedFilterEntry;

            txtDirectory.Text = selectedEntry.DirectoryPath;
            txtFilter.Text = selectedEntry.FileFilter;
            chkDirectoryExistOnly.Checked = selectedEntry.DirectoryExistOnly;
            numericUpDownCountWarningIndicator.Value = selectedEntry.CountWarningIndicator;
            numericUpDownCountErrorIndicator.Value = selectedEntry.CountErrorIndicator;
            numericUpDownSizeWarningIndicator.Value = selectedEntry.SizeKBWarningIndicator;
            numericUpDownSizeErrorIndicator.Value = selectedEntry.SizeKBErrorIndicator;
            numericUpDownFileAgeMin.Value = selectedEntry.FileMinAgeSec;
            numericUpDownFileAgeMax.Value = selectedEntry.FileMaxAgeSec;
            numericUpDownFileSizeMin.Value = selectedEntry.FileMinSizeKB;
            numericUpDownFileSizeMax.Value = selectedEntry.FileMaxSizeKB;
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtDirectory.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void chkDirectoryExistOnly_CheckedChanged(object sender, EventArgs e)
        {
            txtFilter.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownCountWarningIndicator.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownCountErrorIndicator.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownSizeWarningIndicator.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownSizeErrorIndicator.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownFileAgeMin.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownFileAgeMax.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownFileSizeMin.Enabled = !chkDirectoryExistOnly.Checked;
            numericUpDownFileSizeMax.Enabled = !chkDirectoryExistOnly.Checked;
            CheckOKEnabled();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text.Length == 0)
            {
                txtFilter.Text = "*.*";
            }
            if (txtDirectory.Text.Contains("*"))
            {
                txtFilter.Text = FileSystemDirectoryFilterEntry.GetFilterFromPath(txtDirectory.Text);
                txtDirectory.Text = FileSystemDirectoryFilterEntry.GetDirectoryFromPath(txtDirectory.Text);
            }

            if (!Directory.Exists(txtDirectory.Text))
            {
                MessageBox.Show("Directory must exist and be accessible!", "Directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!chkDirectoryExistOnly.Checked && numericUpDownCountWarningIndicator.Value > numericUpDownCountErrorIndicator.Value)
            {
                MessageBox.Show("Error file count cannot be less than warning file count!", "Warnings/Errors", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!chkDirectoryExistOnly.Checked && numericUpDownSizeWarningIndicator.Value > numericUpDownSizeErrorIndicator.Value)
            {
                MessageBox.Show("Error file size cannot be less than warning file size!", "Warnings/Errors", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FileSystemDirectoryFilterEntry selectedEntry;
                if (SelectedEntry != null)
                    selectedEntry = (FileSystemDirectoryFilterEntry)SelectedEntry;
                else if (SelectedFilterEntry != null)
                    selectedEntry = (FileSystemDirectoryFilterEntry)SelectedFilterEntry;
                else
                {
                    selectedEntry = new FileSystemDirectoryFilterEntry();
                }

                selectedEntry.DirectoryPath = txtDirectory.Text;
                selectedEntry.FileFilter = txtFilter.Text;
                selectedEntry.CountWarningIndicator = Convert.ToInt32(numericUpDownCountWarningIndicator.Value);
                selectedEntry.CountErrorIndicator = Convert.ToInt32(numericUpDownCountErrorIndicator.Value);
                selectedEntry.SizeKBWarningIndicator = (int)numericUpDownSizeWarningIndicator.Value;
                selectedEntry.SizeKBErrorIndicator = (int)numericUpDownSizeErrorIndicator.Value;
                selectedEntry.FileMinAgeSec = (int)numericUpDownFileAgeMin.Value;
                selectedEntry.FileMaxAgeSec = (int)numericUpDownFileAgeMax.Value;
                selectedEntry.FileMinSizeKB = (int)numericUpDownFileSizeMin.Value;
                selectedEntry.FileMaxSizeKB = (int)numericUpDownFileSizeMax.Value;
                selectedEntry.DirectoryExistOnly = chkDirectoryExistOnly.Checked;

                SelectedEntry = selectedEntry;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        #region Change tracking
        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownCountWarningIndicator_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownCountErrorIndicator_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownSizeWarningIndicator_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownSizeErrorIndicator_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownFileAgeMin_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownFileAgeMax_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownFileSizeMin_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        }
        private void numericUpDownFileSizeMax_ValueChanged(object sender, EventArgs e)
        {
            CheckOKEnabled();
        } 
        #endregion

        #region Private methods
        private void CheckOKEnabled()
        {
            cmdOK.Enabled = txtDirectory.Text.Length > 0 && System.IO.Directory.Exists(txtDirectory.Text) &&
                    txtFilter.Text.Length > 0 &&
                    (chkDirectoryExistOnly.Checked ||
                        (numericUpDownCountWarningIndicator.Value > 0 && numericUpDownCountErrorIndicator.Value > 0) ||
                        (numericUpDownSizeWarningIndicator.Value > 0 && numericUpDownSizeErrorIndicator.Value > 0) ||
                        (numericUpDownFileAgeMin.Value > 0 || numericUpDownFileAgeMax.Value > 0) ||
                        (numericUpDownFileSizeMin.Value > 0 || numericUpDownFileSizeMax.Value > 0)
                        );
        }
        #endregion
    }
}
