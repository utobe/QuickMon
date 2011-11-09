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
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblConfigWarn = new System.Windows.Forms.Label();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.backgroundWorkerCheckOk = new System.ComponentModel.BackgroundWorker();
            this.cmdCancelConfig = new System.Windows.Forms.Button();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.linkLabelServiceWindows = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AlertOnceInXMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayAlertSecNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.manualEditPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAgent = new System.Windows.Forms.TabPage();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageAlerts = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConfig = new FastColoredTextBoxNS.FastColoredTextBox();
            this.configureEditButtonCollector = new QuickMon.Controls.ConfigureEditButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatAlertInXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertOnceInXMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayAlertSecNumericUpDown)).BeginInit();
            this.manualEditPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAgent.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageAlerts.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkEnabled.Location = new System.Drawing.Point(67, 38);
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
            this.txtName.Location = new System.Drawing.Point(64, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(510, 20);
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
            this.cmdCancel.Location = new System.Drawing.Point(497, 291);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Enabled = false;
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOK.Location = new System.Drawing.Point(416, 291);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 9;
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
            this.cboParentCollector.Location = new System.Drawing.Point(112, 9);
            this.cboParentCollector.Name = "cboParentCollector";
            this.cboParentCollector.Size = new System.Drawing.Size(441, 21);
            this.cboParentCollector.TabIndex = 1;
            this.cboParentCollector.SelectedIndexChanged += new System.EventHandler(this.cboParentCollector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depends on";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 296);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 13);
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
            this.cboCollector.Location = new System.Drawing.Point(112, 10);
            this.cboCollector.Name = "cboCollector";
            this.cboCollector.Size = new System.Drawing.Size(437, 21);
            this.cboCollector.TabIndex = 1;
            this.cboCollector.SelectedIndexChanged += new System.EventHandler(this.cboCollector_SelectedIndexChanged);
            // 
            // chkCollectOnParentWarning
            // 
            this.chkCollectOnParentWarning.AutoSize = true;
            this.chkCollectOnParentWarning.Checked = true;
            this.chkCollectOnParentWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCollectOnParentWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkCollectOnParentWarning.Location = new System.Drawing.Point(112, 38);
            this.chkCollectOnParentWarning.Name = "chkCollectOnParentWarning";
            this.chkCollectOnParentWarning.Size = new System.Drawing.Size(270, 17);
            this.chkCollectOnParentWarning.TabIndex = 4;
            this.chkCollectOnParentWarning.Text = "Continue checking dependant collectors on warning";
            this.chkCollectOnParentWarning.UseVisualStyleBackColor = true;
            this.chkCollectOnParentWarning.CheckedChanged += new System.EventHandler(this.chkCollectOnParentWarning_CheckedChanged);
            // 
            // numericUpDownRepeatAlertInXMin
            // 
            this.numericUpDownRepeatAlertInXMin.Location = new System.Drawing.Point(108, 13);
            this.numericUpDownRepeatAlertInXMin.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownRepeatAlertInXMin.Name = "numericUpDownRepeatAlertInXMin";
            this.numericUpDownRepeatAlertInXMin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownRepeatAlertInXMin.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numericUpDownRepeatAlertInXMin, "If the Error or Alert status does not change then a repeat alert is raised after " +
        "the specified number of minutes");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Repeat alert after";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Minutes (0 = never, Only applies to Errors and Warnings)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Id";
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(3, 9);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(69, 13);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "Configuration";
            // 
            // lblConfigWarn
            // 
            this.lblConfigWarn.AutoSize = true;
            this.lblConfigWarn.ForeColor = System.Drawing.Color.Red;
            this.lblConfigWarn.Location = new System.Drawing.Point(78, 9);
            this.lblConfigWarn.Name = "lblConfigWarn";
            this.lblConfigWarn.Size = new System.Drawing.Size(224, 13);
            this.lblConfigWarn.TabIndex = 1;
            this.lblConfigWarn.Text = "Warning! Manual editing can break the agent!";
            this.lblConfigWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSaveConfig.Image = global::QuickMon.Properties.Resources.Checkmark2;
            this.cmdSaveConfig.Location = new System.Drawing.Point(472, 1);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(39, 23);
            this.cmdSaveConfig.TabIndex = 3;
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
            this.cmdCancelConfig.Location = new System.Drawing.Point(511, 1);
            this.cmdCancelConfig.Name = "cmdCancelConfig";
            this.cmdCancelConfig.Size = new System.Drawing.Size(39, 23);
            this.cmdCancelConfig.TabIndex = 4;
            this.cmdCancelConfig.UseVisualStyleBackColor = true;
            this.cmdCancelConfig.Click += new System.EventHandler(this.cmdCancelConfig_Click);
            // 
            // chkFolder
            // 
            this.chkFolder.AutoSize = true;
            this.chkFolder.Checked = true;
            this.chkFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkFolder.Location = new System.Drawing.Point(14, 43);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(64, 17);
            this.chkFolder.TabIndex = 2;
            this.chkFolder.Text = "Is Folder";
            this.chkFolder.UseVisualStyleBackColor = true;
            this.chkFolder.CheckedChanged += new System.EventHandler(this.chkFolder_CheckedChanged);
            // 
            // linkLabelServiceWindows
            // 
            this.linkLabelServiceWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelServiceWindows.AutoEllipsis = true;
            this.linkLabelServiceWindows.Location = new System.Drawing.Point(244, 40);
            this.linkLabelServiceWindows.Name = "linkLabelServiceWindows";
            this.linkLabelServiceWindows.Size = new System.Drawing.Size(328, 23);
            this.linkLabelServiceWindows.TabIndex = 4;
            this.linkLabelServiceWindows.TabStop = true;
            this.linkLabelServiceWindows.Text = "None";
            this.toolTip1.SetToolTip(this.linkLabelServiceWindows, "Only operate within specified times. Return \'disabled\' status otherwise");
            this.linkLabelServiceWindows.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelServiceWindows_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Service window(s):";
            // 
            // AlertOnceInXMinNumericUpDown
            // 
            this.AlertOnceInXMinNumericUpDown.Location = new System.Drawing.Point(108, 39);
            this.AlertOnceInXMinNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.AlertOnceInXMinNumericUpDown.Name = "AlertOnceInXMinNumericUpDown";
            this.AlertOnceInXMinNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.AlertOnceInXMinNumericUpDown.TabIndex = 4;
            this.toolTip1.SetToolTip(this.AlertOnceInXMinNumericUpDown, "Only allow 1 alert to be raised withing the specified number of minutes");
            // 
            // delayAlertSecNumericUpDown
            // 
            this.delayAlertSecNumericUpDown.Location = new System.Drawing.Point(108, 65);
            this.delayAlertSecNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.delayAlertSecNumericUpDown.Name = "delayAlertSecNumericUpDown";
            this.delayAlertSecNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.delayAlertSecNumericUpDown.TabIndex = 7;
            this.toolTip1.SetToolTip(this.delayAlertSecNumericUpDown, "Delay raising alert - only raise if error/warning state continue");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Only alert once in";
            // 
            // manualEditPanel
            // 
            this.manualEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manualEditPanel.Controls.Add(this.txtConfig);
            this.manualEditPanel.Controls.Add(this.lblConfig);
            this.manualEditPanel.Controls.Add(this.lblConfigWarn);
            this.manualEditPanel.Controls.Add(this.cmdSaveConfig);
            this.manualEditPanel.Controls.Add(this.cmdCancelConfig);
            this.manualEditPanel.Location = new System.Drawing.Point(3, 69);
            this.manualEditPanel.Name = "manualEditPanel";
            this.manualEditPanel.Size = new System.Drawing.Size(550, 126);
            this.manualEditPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageAgent);
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageAlerts);
            this.tabControl1.Location = new System.Drawing.Point(11, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 224);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageAgent
            // 
            this.tabPageAgent.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAgent.Controls.Add(this.label3);
            this.tabPageAgent.Controls.Add(this.manualEditPanel);
            this.tabPageAgent.Controls.Add(this.cboCollector);
            this.tabPageAgent.Controls.Add(this.chkFolder);
            this.tabPageAgent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgent.Name = "tabPageAgent";
            this.tabPageAgent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgent.Size = new System.Drawing.Size(559, 198);
            this.tabPageAgent.TabIndex = 0;
            this.tabPageAgent.Text = "Agent details";
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGeneral.Controls.Add(this.chkCollectOnParentWarning);
            this.tabPageGeneral.Controls.Add(this.cboParentCollector);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(559, 198);
            this.tabPageGeneral.TabIndex = 2;
            this.tabPageGeneral.Text = "Dependencies ";
            // 
            // tabPageAlerts
            // 
            this.tabPageAlerts.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAlerts.Controls.Add(this.delayAlertSecNumericUpDown);
            this.tabPageAlerts.Controls.Add(this.label10);
            this.tabPageAlerts.Controls.Add(this.label11);
            this.tabPageAlerts.Controls.Add(this.AlertOnceInXMinNumericUpDown);
            this.tabPageAlerts.Controls.Add(this.label4);
            this.tabPageAlerts.Controls.Add(this.label9);
            this.tabPageAlerts.Controls.Add(this.label5);
            this.tabPageAlerts.Controls.Add(this.label8);
            this.tabPageAlerts.Controls.Add(this.numericUpDownRepeatAlertInXMin);
            this.tabPageAlerts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlerts.Name = "tabPageAlerts";
            this.tabPageAlerts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlerts.Size = new System.Drawing.Size(559, 198);
            this.tabPageAlerts.TabIndex = 1;
            this.tabPageAlerts.Text = "Alerts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Seconds (Only raise alert if Error/Warning state persists)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Delay alert";
            // 
            // txtConfig
            // 
            this.txtConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfig.AutoScrollMinSize = new System.Drawing.Size(0, 15);
            this.txtConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfig.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfig.Language = FastColoredTextBoxNS.Language.HTML;
            this.txtConfig.Location = new System.Drawing.Point(0, 25);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.PreferredLineWidth = 0;
            this.txtConfig.Size = new System.Drawing.Size(550, 101);
            this.txtConfig.TabIndex = 2;
            this.txtConfig.WordWrap = true;
            // 
            // configureEditButtonCollector
            // 
            this.configureEditButtonCollector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.configureEditButtonCollector.Location = new System.Drawing.Point(324, 291);
            this.configureEditButtonCollector.Name = "configureEditButtonCollector";
            this.configureEditButtonCollector.Size = new System.Drawing.Size(86, 23);
            this.configureEditButtonCollector.TabIndex = 8;
            this.configureEditButtonCollector.ConfigureClicked += new System.EventHandler(this.cmdConfig_Click);
            this.configureEditButtonCollector.ManualConfigureClicked += new System.EventHandler(this.cmdManualConfig_Click);
            this.configureEditButtonCollector.ImportConfigurationClicked += new System.EventHandler(this.configureEditButton1_ImportConfigurationClicked);
            // 
            // EditCollectorEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 326);
            this.Controls.Add(this.configureEditButtonCollector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabelServiceWindows);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 260);
            this.Name = "EditCollectorEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Collector Entry";
            this.Load += new System.EventHandler(this.EditCollectorEntry_Load);
            this.Shown += new System.EventHandler(this.EditCollectorEntry_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeatAlertInXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertOnceInXMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayAlertSecNumericUpDown)).EndInit();
            this.manualEditPanel.ResumeLayout(false);
            this.manualEditPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAgent.ResumeLayout(false);
            this.tabPageAgent.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageAlerts.ResumeLayout(false);
            this.tabPageAlerts.PerformLayout();
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
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblConfigWarn;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCheckOk;
        private System.Windows.Forms.Button cmdCancelConfig;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.LinkLabel linkLabelServiceWindows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown AlertOnceInXMinNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel manualEditPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAgent;
        private System.Windows.Forms.TabPage tabPageAlerts;
        private System.Windows.Forms.NumericUpDown delayAlertSecNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private Controls.ConfigureEditButton configureEditButtonCollector;
        private FastColoredTextBoxNS.FastColoredTextBox txtConfig;
    }
}