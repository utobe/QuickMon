﻿namespace QuickMon
{
    partial class GeneralSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralSettings));
            this.concurrencyLevelNnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.chkSnapToDesktop = new System.Windows.Forms.CheckBox();
            this.chkAutosaveChanges = new System.Windows.Forms.CheckBox();
            this.chkPinToTaskbar = new System.Windows.Forms.CheckBox();
            this.chkPinToStartMenu = new System.Windows.Forms.CheckBox();
            this.chkDesktopShortcut = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.concurrencyLevelNnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // concurrencyLevelNnumericUpDown
            // 
            this.concurrencyLevelNnumericUpDown.Location = new System.Drawing.Point(113, 12);
            this.concurrencyLevelNnumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.concurrencyLevelNnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.concurrencyLevelNnumericUpDown.Name = "concurrencyLevelNnumericUpDown";
            this.concurrencyLevelNnumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.concurrencyLevelNnumericUpDown.TabIndex = 1;
            this.concurrencyLevelNnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Concurrency level";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Location = new System.Drawing.Point(319, 114);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOK.Location = new System.Drawing.Point(238, 114);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // chkSnapToDesktop
            // 
            this.chkSnapToDesktop.AutoSize = true;
            this.chkSnapToDesktop.Location = new System.Drawing.Point(25, 47);
            this.chkSnapToDesktop.Name = "chkSnapToDesktop";
            this.chkSnapToDesktop.Size = new System.Drawing.Size(131, 17);
            this.chkSnapToDesktop.TabIndex = 2;
            this.chkSnapToDesktop.Text = "Snap to desktop sides";
            this.chkSnapToDesktop.UseVisualStyleBackColor = true;
            // 
            // chkAutosaveChanges
            // 
            this.chkAutosaveChanges.AutoSize = true;
            this.chkAutosaveChanges.Location = new System.Drawing.Point(25, 70);
            this.chkAutosaveChanges.Name = "chkAutosaveChanges";
            this.chkAutosaveChanges.Size = new System.Drawing.Size(118, 17);
            this.chkAutosaveChanges.TabIndex = 3;
            this.chkAutosaveChanges.Text = "Auto save changes";
            this.chkAutosaveChanges.UseVisualStyleBackColor = true;
            // 
            // chkPinToTaskbar
            // 
            this.chkPinToTaskbar.AutoSize = true;
            this.chkPinToTaskbar.Location = new System.Drawing.Point(19, 19);
            this.chkPinToTaskbar.Name = "chkPinToTaskbar";
            this.chkPinToTaskbar.Size = new System.Drawing.Size(95, 17);
            this.chkPinToTaskbar.TabIndex = 0;
            this.chkPinToTaskbar.Text = "Pin to Taskbar";
            this.chkPinToTaskbar.UseVisualStyleBackColor = true;
            this.chkPinToTaskbar.CheckedChanged += new System.EventHandler(this.chkPinToTaskbar_CheckedChanged);
            // 
            // chkPinToStartMenu
            // 
            this.chkPinToStartMenu.AutoSize = true;
            this.chkPinToStartMenu.Location = new System.Drawing.Point(19, 42);
            this.chkPinToStartMenu.Name = "chkPinToStartMenu";
            this.chkPinToStartMenu.Size = new System.Drawing.Size(108, 17);
            this.chkPinToStartMenu.TabIndex = 1;
            this.chkPinToStartMenu.Text = "Pin to Start Menu";
            this.chkPinToStartMenu.UseVisualStyleBackColor = true;
            this.chkPinToStartMenu.CheckedChanged += new System.EventHandler(this.chkPinToStartMenu_CheckedChanged);
            // 
            // chkDesktopShortcut
            // 
            this.chkDesktopShortcut.AutoSize = true;
            this.chkDesktopShortcut.Location = new System.Drawing.Point(19, 65);
            this.chkDesktopShortcut.Name = "chkDesktopShortcut";
            this.chkDesktopShortcut.Size = new System.Drawing.Size(154, 17);
            this.chkDesktopShortcut.TabIndex = 2;
            this.chkDesktopShortcut.Text = "Create shortcut on desktop";
            this.chkDesktopShortcut.UseVisualStyleBackColor = true;
            this.chkDesktopShortcut.CheckedChanged += new System.EventHandler(this.chkDesktopShortcut_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkPinToTaskbar);
            this.groupBox1.Controls.Add(this.chkDesktopShortcut);
            this.groupBox1.Controls.Add(this.chkPinToStartMenu);
            this.groupBox1.Location = new System.Drawing.Point(194, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shortcuts";
            // 
            // GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 149);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAutosaveChanges);
            this.Controls.Add(this.chkSnapToDesktop);
            this.Controls.Add(this.concurrencyLevelNnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Settings";
            this.Load += new System.EventHandler(this.GeneralSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concurrencyLevelNnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown concurrencyLevelNnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.CheckBox chkSnapToDesktop;
        private System.Windows.Forms.CheckBox chkAutosaveChanges;
        private System.Windows.Forms.CheckBox chkPinToTaskbar;
        private System.Windows.Forms.CheckBox chkPinToStartMenu;
        private System.Windows.Forms.CheckBox chkDesktopShortcut;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}