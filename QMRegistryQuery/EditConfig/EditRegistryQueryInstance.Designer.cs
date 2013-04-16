﻿namespace QuickMon
{
    partial class EditRegistryQueryInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRegistryQueryInstance));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.chkUseRemoteServer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cboRegistryHive = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.chkValueIsANumber = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboErrorValue = new System.Windows.Forms.ComboBox();
            this.cboWarningValue = new System.Windows.Forms.ComboBox();
            this.cboSuccessValue = new System.Windows.Forms.ComboBox();
            this.chkReturnValueNotInverted = new System.Windows.Forms.CheckBox();
            this.chkValueIsInARange = new System.Windows.Forms.CheckBox();
            this.cmdTest = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.chkExpandEnvNames = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name/description";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(138, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(433, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(138, 38);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(187, 20);
            this.txtServer.TabIndex = 3;
            // 
            // chkUseRemoteServer
            // 
            this.chkUseRemoteServer.AutoSize = true;
            this.chkUseRemoteServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkUseRemoteServer.Location = new System.Drawing.Point(9, 39);
            this.chkUseRemoteServer.Name = "chkUseRemoteServer";
            this.chkUseRemoteServer.Size = new System.Drawing.Size(111, 17);
            this.chkUseRemoteServer.TabIndex = 2;
            this.chkUseRemoteServer.Text = "Use remote server";
            this.chkUseRemoteServer.UseVisualStyleBackColor = true;
            this.chkUseRemoteServer.CheckedChanged += new System.EventHandler(this.chkUseRemoteServer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(138, 92);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(433, 20);
            this.txtPath.TabIndex = 7;
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // cboRegistryHive
            // 
            this.cboRegistryHive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegistryHive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboRegistryHive.FormattingEnabled = true;
            this.cboRegistryHive.Items.AddRange(new object[] {
            "LocalMachine",
            "ClassesRoot",
            "CurrentUser",
            "Users",
            "CurrentConfig"});
            this.cboRegistryHive.Location = new System.Drawing.Point(138, 65);
            this.cboRegistryHive.Name = "cboRegistryHive";
            this.cboRegistryHive.Size = new System.Drawing.Size(187, 21);
            this.cboRegistryHive.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registry Hive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Location = new System.Drawing.Point(138, 118);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(433, 20);
            this.txtKey.TabIndex = 9;
            // 
            // chkValueIsANumber
            // 
            this.chkValueIsANumber.AutoSize = true;
            this.chkValueIsANumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkValueIsANumber.Location = new System.Drawing.Point(19, 19);
            this.chkValueIsANumber.Name = "chkValueIsANumber";
            this.chkValueIsANumber.Size = new System.Drawing.Size(109, 17);
            this.chkValueIsANumber.TabIndex = 0;
            this.chkValueIsANumber.Text = "Value is a number";
            this.chkValueIsANumber.UseVisualStyleBackColor = true;
            this.chkValueIsANumber.CheckedChanged += new System.EventHandler(this.chkValueIsANumber_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboErrorValue);
            this.groupBox1.Controls.Add(this.cboWarningValue);
            this.groupBox1.Controls.Add(this.cboSuccessValue);
            this.groupBox1.Controls.Add(this.chkReturnValueNotInverted);
            this.groupBox1.Controls.Add(this.chkValueIsInARange);
            this.groupBox1.Controls.Add(this.chkValueIsANumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 78);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Returned value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Error";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Warning";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Values: Success";
            // 
            // cboErrorValue
            // 
            this.cboErrorValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboErrorValue.FormattingEnabled = true;
            this.cboErrorValue.Items.AddRange(new object[] {
            "[null]",
            "[any]",
            "[exists]",
            "[notExists]"});
            this.cboErrorValue.Location = new System.Drawing.Point(424, 42);
            this.cboErrorValue.Name = "cboErrorValue";
            this.cboErrorValue.Size = new System.Drawing.Size(105, 21);
            this.cboErrorValue.TabIndex = 8;
            // 
            // cboWarningValue
            // 
            this.cboWarningValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboWarningValue.FormattingEnabled = true;
            this.cboWarningValue.Items.AddRange(new object[] {
            "[null]",
            "[any]",
            "[exists]",
            "[notExists]"});
            this.cboWarningValue.Location = new System.Drawing.Point(287, 42);
            this.cboWarningValue.Name = "cboWarningValue";
            this.cboWarningValue.Size = new System.Drawing.Size(96, 21);
            this.cboWarningValue.TabIndex = 6;
            // 
            // cboSuccessValue
            // 
            this.cboSuccessValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSuccessValue.FormattingEnabled = true;
            this.cboSuccessValue.Items.AddRange(new object[] {
            "[null]",
            "[any]",
            "[exists]",
            "[notExists]"});
            this.cboSuccessValue.Location = new System.Drawing.Point(126, 42);
            this.cboSuccessValue.Name = "cboSuccessValue";
            this.cboSuccessValue.Size = new System.Drawing.Size(102, 21);
            this.cboSuccessValue.TabIndex = 4;
            // 
            // chkReturnValueNotInverted
            // 
            this.chkReturnValueNotInverted.AutoSize = true;
            this.chkReturnValueNotInverted.Checked = true;
            this.chkReturnValueNotInverted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReturnValueNotInverted.Enabled = false;
            this.chkReturnValueNotInverted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkReturnValueNotInverted.Location = new System.Drawing.Point(287, 19);
            this.chkReturnValueNotInverted.Name = "chkReturnValueNotInverted";
            this.chkReturnValueNotInverted.Size = new System.Drawing.Size(152, 17);
            this.chkReturnValueNotInverted.TabIndex = 2;
            this.chkReturnValueNotInverted.Text = "Success < Warning < Error";
            this.chkReturnValueNotInverted.UseVisualStyleBackColor = true;
            // 
            // chkValueIsInARange
            // 
            this.chkValueIsInARange.AutoSize = true;
            this.chkValueIsInARange.Enabled = false;
            this.chkValueIsInARange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkValueIsInARange.Location = new System.Drawing.Point(153, 19);
            this.chkValueIsInARange.Name = "chkValueIsInARange";
            this.chkValueIsInARange.Size = new System.Drawing.Size(112, 17);
            this.chkValueIsInARange.TabIndex = 1;
            this.chkValueIsInARange.Text = "Value is in a range";
            this.chkValueIsInARange.UseVisualStyleBackColor = true;
            // 
            // cmdTest
            // 
            this.cmdTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdTest.Location = new System.Drawing.Point(334, 252);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 11;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Location = new System.Drawing.Point(496, 252);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 13;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOK.Location = new System.Drawing.Point(415, 252);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 12;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // chkExpandEnvNames
            // 
            this.chkExpandEnvNames.AutoSize = true;
            this.chkExpandEnvNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkExpandEnvNames.Location = new System.Drawing.Point(138, 145);
            this.chkExpandEnvNames.Name = "chkExpandEnvNames";
            this.chkExpandEnvNames.Size = new System.Drawing.Size(164, 17);
            this.chkExpandEnvNames.TabIndex = 14;
            this.chkExpandEnvNames.Text = "Expand environmental names";
            this.chkExpandEnvNames.UseVisualStyleBackColor = true;
            // 
            // EditRegistryQueryInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 283);
            this.Controls.Add(this.chkExpandEnvNames);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRegistryHive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.chkUseRemoteServer);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRegistryQueryInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Registry Query Instance";
            this.Shown += new System.EventHandler(this.EditRegistryQueryInstance_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.CheckBox chkUseRemoteServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cboRegistryHive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.CheckBox chkValueIsANumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkValueIsInARange;
        private System.Windows.Forms.CheckBox chkReturnValueNotInverted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboErrorValue;
        private System.Windows.Forms.ComboBox cboWarningValue;
        private System.Windows.Forms.ComboBox cboSuccessValue;
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.CheckBox chkExpandEnvNames;
    }
}