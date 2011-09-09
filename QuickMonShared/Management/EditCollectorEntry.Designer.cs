﻿namespace QuickMon.Management
{
    partial class EditCollectorEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCollectorEntry));
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cboParentCollector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCollector = new System.Windows.Forms.ComboBox();
            this.chkCollectOnParentWarning = new System.Windows.Forms.CheckBox();
            this.numericUpDownRepeatAlertInXMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdConfig = new System.Windows.Forms.Button();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblConfigWarn = new System.Windows.Forms.Label();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.backgroundWorkerCheckOk = new System.ComponentModel.BackgroundWorker();
            this.cmdCancelConfig = new System.Windows.Forms.Button();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.linkLabelServiceWindows = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.manualEditlinkLabel = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AlertOnceInXMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.importLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatAlertInXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertOnceInXMinNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkEnabled.Location = new System.Drawing.Point(127, 38);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(63, 17);
            this.chkEnabled.TabIndex = 2;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(127, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(437, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Location = new System.Drawing.Point(497, 427);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 20;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Enabled = false;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOK.Location = new System.Drawing.Point(416, 427);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 19;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cboParentCollector
            // 
            this.cboParentCollector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboParentCollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParentCollector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboParentCollector.FormattingEnabled = true;
            this.cboParentCollector.Location = new System.Drawing.Point(127, 61);
            this.cboParentCollector.Name = "cboParentCollector";
            this.cboParentCollector.Size = new System.Drawing.Size(437, 21);
            this.cboParentCollector.TabIndex = 5;
            this.cboParentCollector.SelectedIndexChanged += new System.EventHandler(this.cboParentCollector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Depends on";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 432);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Collector type";
            // 
            // cboCollector
            // 
            this.cboCollector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCollector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCollector.FormattingEnabled = true;
            this.cboCollector.Location = new System.Drawing.Point(115, 17);
            this.cboCollector.Name = "cboCollector";
            this.cboCollector.Size = new System.Drawing.Size(436, 21);
            this.cboCollector.TabIndex = 1;
            this.cboCollector.SelectedIndexChanged += new System.EventHandler(this.cboCollector_SelectedIndexChanged);
            // 
            // chkCollectOnParentWarning
            // 
            this.chkCollectOnParentWarning.AutoSize = true;
            this.chkCollectOnParentWarning.Checked = true;
            this.chkCollectOnParentWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCollectOnParentWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkCollectOnParentWarning.Location = new System.Drawing.Point(115, 44);
            this.chkCollectOnParentWarning.Name = "chkCollectOnParentWarning";
            this.chkCollectOnParentWarning.Size = new System.Drawing.Size(270, 17);
            this.chkCollectOnParentWarning.TabIndex = 2;
            this.chkCollectOnParentWarning.Text = "Continue checking dependant collectors on warning";
            this.chkCollectOnParentWarning.UseVisualStyleBackColor = true;
            this.chkCollectOnParentWarning.CheckedChanged += new System.EventHandler(this.chkCollectOnParentWarning_CheckedChanged);
            // 
            // numericUpDownRepeatAlertInXMin
            // 
            this.numericUpDownRepeatAlertInXMin.Location = new System.Drawing.Point(115, 67);
            this.numericUpDownRepeatAlertInXMin.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownRepeatAlertInXMin.Name = "numericUpDownRepeatAlertInXMin";
            this.numericUpDownRepeatAlertInXMin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownRepeatAlertInXMin.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numericUpDownRepeatAlertInXMin, "If the Error or Alert status does not change then a repeat alert is raised after " +
        "the specified number of minutes");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repeat alert after";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minutes (0 = never)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id";
            // 
            // cmdConfig
            // 
            this.cmdConfig.Enabled = false;
            this.cmdConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdConfig.Location = new System.Drawing.Point(15, 230);
            this.cmdConfig.Name = "cmdConfig";
            this.cmdConfig.Size = new System.Drawing.Size(75, 23);
            this.cmdConfig.TabIndex = 9;
            this.cmdConfig.Text = "Configure";
            this.cmdConfig.UseVisualStyleBackColor = true;
            this.cmdConfig.Click += new System.EventHandler(this.cmdConfig_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfig.Location = new System.Drawing.Point(12, 279);
            this.txtConfig.Multiline = true;
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConfig.Size = new System.Drawing.Size(560, 142);
            this.txtConfig.TabIndex = 14;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(12, 264);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(69, 13);
            this.lblConfig.TabIndex = 12;
            this.lblConfig.Text = "Configuration";
            // 
            // lblConfigWarn
            // 
            this.lblConfigWarn.AutoSize = true;
            this.lblConfigWarn.ForeColor = System.Drawing.Color.Red;
            this.lblConfigWarn.Location = new System.Drawing.Point(87, 264);
            this.lblConfigWarn.Name = "lblConfigWarn";
            this.lblConfigWarn.Size = new System.Drawing.Size(224, 13);
            this.lblConfigWarn.TabIndex = 13;
            this.lblConfigWarn.Text = "Warning! Manual editing can break the agent!";
            this.lblConfigWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSaveConfig.Image = global::QuickMon.Properties.Resources.DISK04;
            this.cmdSaveConfig.Location = new System.Drawing.Point(494, 254);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(39, 23);
            this.cmdSaveConfig.TabIndex = 15;
            this.cmdSaveConfig.UseVisualStyleBackColor = true;
            this.cmdSaveConfig.Click += new System.EventHandler(this.cmdSaveConfig_Click);
            // 
            // backgroundWorkerCheckOk
            // 
            this.backgroundWorkerCheckOk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCheckOk_DoWork);
            // 
            // cmdCancelConfig
            // 
            this.cmdCancelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancelConfig.Image = global::QuickMon.Properties.Resources.whack;
            this.cmdCancelConfig.Location = new System.Drawing.Point(533, 254);
            this.cmdCancelConfig.Name = "cmdCancelConfig";
            this.cmdCancelConfig.Size = new System.Drawing.Size(39, 23);
            this.cmdCancelConfig.TabIndex = 16;
            this.cmdCancelConfig.UseVisualStyleBackColor = true;
            this.cmdCancelConfig.Click += new System.EventHandler(this.cmdCancelConfig_Click);
            // 
            // chkFolder
            // 
            this.chkFolder.AutoSize = true;
            this.chkFolder.Checked = true;
            this.chkFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkFolder.Location = new System.Drawing.Point(201, 38);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(53, 17);
            this.chkFolder.TabIndex = 3;
            this.chkFolder.Text = "Folder";
            this.chkFolder.UseVisualStyleBackColor = true;
            this.chkFolder.CheckedChanged += new System.EventHandler(this.chkFolder_CheckedChanged);
            // 
            // linkLabelServiceWindows
            // 
            this.linkLabelServiceWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelServiceWindows.AutoEllipsis = true;
            this.linkLabelServiceWindows.Location = new System.Drawing.Point(124, 207);
            this.linkLabelServiceWindows.Name = "linkLabelServiceWindows";
            this.linkLabelServiceWindows.Size = new System.Drawing.Size(440, 23);
            this.linkLabelServiceWindows.TabIndex = 8;
            this.linkLabelServiceWindows.TabStop = true;
            this.linkLabelServiceWindows.Text = "None";
            this.toolTip1.SetToolTip(this.linkLabelServiceWindows, "Only operate within specified times. Return \'disabled\' status otherwise");
            this.linkLabelServiceWindows.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelServiceWindows_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Service window(s)";
            // 
            // manualEditlinkLabel
            // 
            this.manualEditlinkLabel.AutoSize = true;
            this.manualEditlinkLabel.Location = new System.Drawing.Point(96, 235);
            this.manualEditlinkLabel.Name = "manualEditlinkLabel";
            this.manualEditlinkLabel.Size = new System.Drawing.Size(62, 13);
            this.manualEditlinkLabel.TabIndex = 10;
            this.manualEditlinkLabel.TabStop = true;
            this.manualEditlinkLabel.Text = "Manual edit";
            this.toolTip1.SetToolTip(this.manualEditlinkLabel, "Manually edit configuration (not recommended)");
            this.manualEditlinkLabel.Click += new System.EventHandler(this.cmdManualConfig_Click);
            // 
            // AlertOnceInXMinNumericUpDown
            // 
            this.AlertOnceInXMinNumericUpDown.Location = new System.Drawing.Point(391, 67);
            this.AlertOnceInXMinNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.AlertOnceInXMinNumericUpDown.Name = "AlertOnceInXMinNumericUpDown";
            this.AlertOnceInXMinNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.AlertOnceInXMinNumericUpDown.TabIndex = 7;
            this.toolTip1.SetToolTip(this.AlertOnceInXMinNumericUpDown, "Only allow 1 alert to be raised withing the specified number of minutes");
            // 
            // importLinkLabel
            // 
            this.importLinkLabel.AutoSize = true;
            this.importLinkLabel.Enabled = false;
            this.importLinkLabel.Location = new System.Drawing.Point(175, 235);
            this.importLinkLabel.Name = "importLinkLabel";
            this.importLinkLabel.Size = new System.Drawing.Size(36, 13);
            this.importLinkLabel.TabIndex = 11;
            this.importLinkLabel.TabStop = true;
            this.importLinkLabel.Text = "Import";
            this.toolTip1.SetToolTip(this.importLinkLabel, "Import configuration of similar collector agents");
            this.importLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.importLinkLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlertOnceInXMinNumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboCollector);
            this.groupBox1.Controls.Add(this.chkCollectOnParentWarning);
            this.groupBox1.Controls.Add(this.numericUpDownRepeatAlertInXMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gatherer settings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Only alert once in";
            // 
            // EditCollectorEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.importLinkLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manualEditlinkLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabelServiceWindows);
            this.Controls.Add(this.chkFolder);
            this.Controls.Add(this.cmdCancelConfig);
            this.Controls.Add(this.cmdSaveConfig);
            this.Controls.Add(this.lblConfigWarn);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.txtConfig);
            this.Controls.Add(this.cmdConfig);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboParentCollector);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "EditCollectorEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Collector Entry";
            this.Load += new System.EventHandler(this.EditCollectorEntry_Load);
            this.Shown += new System.EventHandler(this.EditCollectorEntry_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatAlertInXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertOnceInXMinNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.ComboBox cboParentCollector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCollector;
        private System.Windows.Forms.CheckBox chkCollectOnParentWarning;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeatAlertInXMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdConfig;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblConfigWarn;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCheckOk;
        private System.Windows.Forms.Button cmdCancelConfig;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.LinkLabel linkLabelServiceWindows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel manualEditlinkLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown AlertOnceInXMinNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel importLinkLabel;
    }
}