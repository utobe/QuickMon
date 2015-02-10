﻿namespace QuickMon.Collectors
{
    partial class SqlQueryCollectorEditEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlQueryCollectorEditEntry));
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataSourceTabControl = new System.Windows.Forms.TabControl();
            this.dataSourceTabPage = new System.Windows.Forms.TabPage();
            this.dataSourceExtrasPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCmndTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkUsePersistentConnection = new System.Windows.Forms.CheckBox();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.OLEDBDataSourcePanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cmdBuildConnStr = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.sqlServerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIntegratedSec = new System.Windows.Forms.CheckBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.optSqlServer = new System.Windows.Forms.RadioButton();
            this.optOLEDb = new System.Windows.Forms.RadioButton();
            this.stateQueryTabPage = new System.Windows.Forms.TabPage();
            this.txtStateQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkUseSPForState = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabelQueryTips = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtErrorValueOrMacro = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboErrorMatchType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtWarningValueOrMacro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboWarningMatchType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGoodValueOrMacro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboSuccessMatchType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboReturnType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.optEWG = new System.Windows.Forms.RadioButton();
            this.optGWE = new System.Windows.Forms.RadioButton();
            this.detailQueryTabPage = new System.Windows.Forms.TabPage();
            this.txtDetailQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkUseSPForDetail = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmdTest = new System.Windows.Forms.Button();
            this.dataSourceTabControl.SuspendLayout();
            this.dataSourceTabPage.SuspendLayout();
            this.dataSourceExtrasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCmndTimeOut)).BeginInit();
            this.OLEDBDataSourcePanel.SuspendLayout();
            this.sqlServerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.stateQueryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateQuery)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.detailQueryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailQuery)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Location = new System.Drawing.Point(577, 417);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOK.Location = new System.Drawing.Point(496, 417);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
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
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(83, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(569, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dataSourceTabControl
            // 
            this.dataSourceTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSourceTabControl.Controls.Add(this.dataSourceTabPage);
            this.dataSourceTabControl.Controls.Add(this.stateQueryTabPage);
            this.dataSourceTabControl.Controls.Add(this.detailQueryTabPage);
            this.dataSourceTabControl.Location = new System.Drawing.Point(12, 38);
            this.dataSourceTabControl.Name = "dataSourceTabControl";
            this.dataSourceTabControl.SelectedIndex = 0;
            this.dataSourceTabControl.Size = new System.Drawing.Size(640, 373);
            this.dataSourceTabControl.TabIndex = 2;
            // 
            // dataSourceTabPage
            // 
            this.dataSourceTabPage.Controls.Add(this.dataSourceExtrasPanel);
            this.dataSourceTabPage.Controls.Add(this.OLEDBDataSourcePanel);
            this.dataSourceTabPage.Controls.Add(this.sqlServerPanel);
            this.dataSourceTabPage.Controls.Add(this.panel2);
            this.dataSourceTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataSourceTabPage.Name = "dataSourceTabPage";
            this.dataSourceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataSourceTabPage.Size = new System.Drawing.Size(632, 347);
            this.dataSourceTabPage.TabIndex = 0;
            this.dataSourceTabPage.Text = "Data source";
            this.dataSourceTabPage.UseVisualStyleBackColor = true;
            // 
            // dataSourceExtrasPanel
            // 
            this.dataSourceExtrasPanel.Controls.Add(this.label13);
            this.dataSourceExtrasPanel.Controls.Add(this.label7);
            this.dataSourceExtrasPanel.Controls.Add(this.numericUpDownCmndTimeOut);
            this.dataSourceExtrasPanel.Controls.Add(this.label6);
            this.dataSourceExtrasPanel.Controls.Add(this.chkUsePersistentConnection);
            this.dataSourceExtrasPanel.Controls.Add(this.txtApplicationName);
            this.dataSourceExtrasPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataSourceExtrasPanel.Location = new System.Drawing.Point(3, 254);
            this.dataSourceExtrasPanel.Name = "dataSourceExtrasPanel";
            this.dataSourceExtrasPanel.Size = new System.Drawing.Size(626, 90);
            this.dataSourceExtrasPanel.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Application name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sec";
            // 
            // numericUpDownCmndTimeOut
            // 
            this.numericUpDownCmndTimeOut.Location = new System.Drawing.Point(138, 36);
            this.numericUpDownCmndTimeOut.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDownCmndTimeOut.Name = "numericUpDownCmndTimeOut";
            this.numericUpDownCmndTimeOut.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownCmndTimeOut.TabIndex = 3;
            this.numericUpDownCmndTimeOut.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time out value";
            // 
            // chkUsePersistentConnection
            // 
            this.chkUsePersistentConnection.AutoSize = true;
            this.chkUsePersistentConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkUsePersistentConnection.Location = new System.Drawing.Point(138, 62);
            this.chkUsePersistentConnection.Name = "chkUsePersistentConnection";
            this.chkUsePersistentConnection.Size = new System.Drawing.Size(147, 17);
            this.chkUsePersistentConnection.TabIndex = 5;
            this.chkUsePersistentConnection.Text = "Use persistent connection";
            this.chkUsePersistentConnection.UseVisualStyleBackColor = true;
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApplicationName.Location = new System.Drawing.Point(138, 10);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(473, 20);
            this.txtApplicationName.TabIndex = 1;
            // 
            // OLEDBDataSourcePanel
            // 
            this.OLEDBDataSourcePanel.Controls.Add(this.linkLabel2);
            this.OLEDBDataSourcePanel.Controls.Add(this.cmdBuildConnStr);
            this.OLEDBDataSourcePanel.Controls.Add(this.label16);
            this.OLEDBDataSourcePanel.Controls.Add(this.txtConnectionString);
            this.OLEDBDataSourcePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OLEDBDataSourcePanel.Location = new System.Drawing.Point(3, 175);
            this.OLEDBDataSourcePanel.Name = "OLEDBDataSourcePanel";
            this.OLEDBDataSourcePanel.Size = new System.Drawing.Size(626, 169);
            this.OLEDBDataSourcePanel.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(274, 7);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(194, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "See connectionstrings.com for help/tips";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cmdBuildConnStr
            // 
            this.cmdBuildConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBuildConnStr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBuildConnStr.Location = new System.Drawing.Point(474, 2);
            this.cmdBuildConnStr.Name = "cmdBuildConnStr";
            this.cmdBuildConnStr.Size = new System.Drawing.Size(137, 23);
            this.cmdBuildConnStr.TabIndex = 2;
            this.cmdBuildConnStr.Text = "Build connection string";
            this.cmdBuildConnStr.UseVisualStyleBackColor = true;
            this.cmdBuildConnStr.Click += new System.EventHandler(this.cmdBuildConnStr_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Connection string";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(22, 30);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConnectionString.Size = new System.Drawing.Size(589, 43);
            this.txtConnectionString.TabIndex = 3;
            this.txtConnectionString.TextChanged += new System.EventHandler(this.txtConnectionString_TextChanged);
            // 
            // sqlServerPanel
            // 
            this.sqlServerPanel.Controls.Add(this.label2);
            this.sqlServerPanel.Controls.Add(this.chkIntegratedSec);
            this.sqlServerPanel.Controls.Add(this.txtDatabase);
            this.sqlServerPanel.Controls.Add(this.label3);
            this.sqlServerPanel.Controls.Add(this.txtServer);
            this.sqlServerPanel.Controls.Add(this.txtUserName);
            this.sqlServerPanel.Controls.Add(this.label5);
            this.sqlServerPanel.Controls.Add(this.txtPassword);
            this.sqlServerPanel.Controls.Add(this.label4);
            this.sqlServerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlServerPanel.Location = new System.Drawing.Point(3, 37);
            this.sqlServerPanel.Name = "sqlServerPanel";
            this.sqlServerPanel.Size = new System.Drawing.Size(626, 138);
            this.sqlServerPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sql Server\\Instance";
            // 
            // chkIntegratedSec
            // 
            this.chkIntegratedSec.AutoSize = true;
            this.chkIntegratedSec.Checked = true;
            this.chkIntegratedSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntegratedSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkIntegratedSec.Location = new System.Drawing.Point(138, 61);
            this.chkIntegratedSec.Name = "chkIntegratedSec";
            this.chkIntegratedSec.Size = new System.Drawing.Size(111, 17);
            this.chkIntegratedSec.TabIndex = 4;
            this.chkIntegratedSec.Text = "Integrated security";
            this.chkIntegratedSec.UseVisualStyleBackColor = true;
            this.chkIntegratedSec.CheckedChanged += new System.EventHandler(this.chkIntegratedSec_CheckedChanged);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabase.Location = new System.Drawing.Point(138, 35);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(473, 20);
            this.txtDatabase.TabIndex = 3;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(138, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(473, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(138, 84);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(473, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(138, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(473, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.optSqlServer);
            this.panel2.Controls.Add(this.optOLEDb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 34);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type";
            // 
            // optSqlServer
            // 
            this.optSqlServer.AutoSize = true;
            this.optSqlServer.Checked = true;
            this.optSqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optSqlServer.Location = new System.Drawing.Point(144, 8);
            this.optSqlServer.Name = "optSqlServer";
            this.optSqlServer.Size = new System.Drawing.Size(73, 17);
            this.optSqlServer.TabIndex = 1;
            this.optSqlServer.TabStop = true;
            this.optSqlServer.Text = "Sql Server";
            this.optSqlServer.UseVisualStyleBackColor = true;
            this.optSqlServer.CheckedChanged += new System.EventHandler(this.optSqlServer_CheckedChanged);
            // 
            // optOLEDb
            // 
            this.optOLEDb.AutoSize = true;
            this.optOLEDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optOLEDb.Location = new System.Drawing.Point(223, 8);
            this.optOLEDb.Name = "optOLEDb";
            this.optOLEDb.Size = new System.Drawing.Size(63, 17);
            this.optOLEDb.TabIndex = 2;
            this.optOLEDb.Text = "OLE DB";
            this.optOLEDb.UseVisualStyleBackColor = true;
            this.optOLEDb.CheckedChanged += new System.EventHandler(this.optOLEDb_CheckedChanged);
            // 
            // stateQueryTabPage
            // 
            this.stateQueryTabPage.Controls.Add(this.txtStateQuery);
            this.stateQueryTabPage.Controls.Add(this.panel3);
            this.stateQueryTabPage.Controls.Add(this.panel1);
            this.stateQueryTabPage.Location = new System.Drawing.Point(4, 22);
            this.stateQueryTabPage.Name = "stateQueryTabPage";
            this.stateQueryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.stateQueryTabPage.Size = new System.Drawing.Size(632, 347);
            this.stateQueryTabPage.TabIndex = 1;
            this.stateQueryTabPage.Text = "State query";
            this.stateQueryTabPage.UseVisualStyleBackColor = true;
            // 
            // txtStateQuery
            // 
            this.txtStateQuery.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtStateQuery.AutoIndentCharsPatterns = "";
            this.txtStateQuery.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txtStateQuery.BackBrush = null;
            this.txtStateQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStateQuery.CharHeight = 14;
            this.txtStateQuery.CharWidth = 8;
            this.txtStateQuery.CommentPrefix = "--";
            this.txtStateQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStateQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtStateQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStateQuery.IsReplaceMode = false;
            this.txtStateQuery.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtStateQuery.LeftBracket = '(';
            this.txtStateQuery.Location = new System.Drawing.Point(3, 55);
            this.txtStateQuery.Name = "txtStateQuery";
            this.txtStateQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.txtStateQuery.RightBracket = ')';
            this.txtStateQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtStateQuery.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtStateQuery.ServiceColors")));
            this.txtStateQuery.Size = new System.Drawing.Size(626, 155);
            this.txtStateQuery.TabIndex = 1;
            this.txtStateQuery.Zoom = 100;
            this.txtStateQuery.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtStateQuery_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkUseSPForState);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.linkLabelQueryTips);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 52);
            this.panel3.TabIndex = 0;
            // 
            // chkUseSPForState
            // 
            this.chkUseSPForState.AutoSize = true;
            this.chkUseSPForState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkUseSPForState.Location = new System.Drawing.Point(12, 9);
            this.chkUseSPForState.Name = "chkUseSPForState";
            this.chkUseSPForState.Size = new System.Drawing.Size(135, 17);
            this.chkUseSPForState.TabIndex = 0;
            this.chkUseSPForState.Text = "Use stored procuredure";
            this.chkUseSPForState.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Query text";
            // 
            // linkLabelQueryTips
            // 
            this.linkLabelQueryTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelQueryTips.AutoSize = true;
            this.linkLabelQueryTips.Location = new System.Drawing.Point(416, 36);
            this.linkLabelQueryTips.Name = "linkLabelQueryTips";
            this.linkLabelQueryTips.Size = new System.Drawing.Size(207, 13);
            this.linkLabelQueryTips.TabIndex = 2;
            this.linkLabelQueryTips.TabStop = true;
            this.linkLabelQueryTips.Text = "click here to see query tips and restrictions";
            this.linkLabelQueryTips.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQueryTips_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtErrorValueOrMacro);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cboErrorMatchType);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtWarningValueOrMacro);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cboWarningMatchType);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtGoodValueOrMacro);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cboSuccessMatchType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cboReturnType);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.optEWG);
            this.panel1.Controls.Add(this.optGWE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 134);
            this.panel1.TabIndex = 2;
            // 
            // txtErrorValueOrMacro
            // 
            this.txtErrorValueOrMacro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrorValueOrMacro.Location = new System.Drawing.Point(365, 107);
            this.txtErrorValueOrMacro.Name = "txtErrorValueOrMacro";
            this.txtErrorValueOrMacro.Size = new System.Drawing.Size(247, 20);
            this.txtErrorValueOrMacro.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(281, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Value or macro";
            // 
            // cboErrorMatchType
            // 
            this.cboErrorMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboErrorMatchType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboErrorMatchType.FormattingEnabled = true;
            this.cboErrorMatchType.Items.AddRange(new object[] {
            "Match",
            "Contains",
            "StartsWith",
            "EndsWith",
            "RegEx",
            "IsNumber",
            "LargerThan",
            "SmallerThan",
            "Between"});
            this.cboErrorMatchType.Location = new System.Drawing.Point(150, 107);
            this.cboErrorMatchType.Name = "cboErrorMatchType";
            this.cboErrorMatchType.Size = new System.Drawing.Size(125, 21);
            this.cboErrorMatchType.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Error match type";
            // 
            // txtWarningValueOrMacro
            // 
            this.txtWarningValueOrMacro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarningValueOrMacro.Location = new System.Drawing.Point(365, 80);
            this.txtWarningValueOrMacro.Name = "txtWarningValueOrMacro";
            this.txtWarningValueOrMacro.Size = new System.Drawing.Size(247, 20);
            this.txtWarningValueOrMacro.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Value or macro";
            // 
            // cboWarningMatchType
            // 
            this.cboWarningMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarningMatchType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboWarningMatchType.FormattingEnabled = true;
            this.cboWarningMatchType.Items.AddRange(new object[] {
            "Match",
            "Contains",
            "StartsWith",
            "EndsWith",
            "RegEx",
            "IsNumber",
            "LargerThan",
            "SmallerThan",
            "Between"});
            this.cboWarningMatchType.Location = new System.Drawing.Point(150, 80);
            this.cboWarningMatchType.Name = "cboWarningMatchType";
            this.cboWarningMatchType.Size = new System.Drawing.Size(125, 21);
            this.cboWarningMatchType.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Warning match type";
            // 
            // txtGoodValueOrMacro
            // 
            this.txtGoodValueOrMacro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoodValueOrMacro.Location = new System.Drawing.Point(365, 53);
            this.txtGoodValueOrMacro.Name = "txtGoodValueOrMacro";
            this.txtGoodValueOrMacro.Size = new System.Drawing.Size(247, 20);
            this.txtGoodValueOrMacro.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Value or macro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Return type";
            // 
            // cboSuccessMatchType
            // 
            this.cboSuccessMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuccessMatchType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSuccessMatchType.FormattingEnabled = true;
            this.cboSuccessMatchType.Items.AddRange(new object[] {
            "Match",
            "Contains",
            "StartsWith",
            "EndsWith",
            "RegEx",
            "IsNumber",
            "LargerThan",
            "SmallerThan",
            "Between"});
            this.cboSuccessMatchType.Location = new System.Drawing.Point(150, 53);
            this.cboSuccessMatchType.Name = "cboSuccessMatchType";
            this.cboSuccessMatchType.Size = new System.Drawing.Size(125, 21);
            this.cboSuccessMatchType.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Good  match type";
            // 
            // cboReturnType
            // 
            this.cboReturnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReturnType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboReturnType.FormattingEnabled = true;
            this.cboReturnType.Items.AddRange(new object[] {
            "Raw Value",
            "Row count",
            "Query time (ms)"});
            this.cboReturnType.Location = new System.Drawing.Point(150, 26);
            this.cboReturnType.Name = "cboReturnType";
            this.cboReturnType.Size = new System.Drawing.Size(125, 21);
            this.cboReturnType.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Check sequence";
            // 
            // optEWG
            // 
            this.optEWG.AutoSize = true;
            this.optEWG.Location = new System.Drawing.Point(294, 5);
            this.optEWG.Name = "optEWG";
            this.optEWG.Size = new System.Drawing.Size(143, 17);
            this.optEWG.TabIndex = 2;
            this.optEWG.Text = "Error,Warning then Good";
            this.optEWG.UseVisualStyleBackColor = true;
            // 
            // optGWE
            // 
            this.optGWE.AutoSize = true;
            this.optGWE.Checked = true;
            this.optGWE.Location = new System.Drawing.Point(145, 5);
            this.optGWE.Name = "optGWE";
            this.optGWE.Size = new System.Drawing.Size(143, 17);
            this.optGWE.TabIndex = 1;
            this.optGWE.TabStop = true;
            this.optGWE.Text = "Good,Warning then Error";
            this.optGWE.UseVisualStyleBackColor = true;
            // 
            // detailQueryTabPage
            // 
            this.detailQueryTabPage.Controls.Add(this.txtDetailQuery);
            this.detailQueryTabPage.Controls.Add(this.panel4);
            this.detailQueryTabPage.Location = new System.Drawing.Point(4, 22);
            this.detailQueryTabPage.Name = "detailQueryTabPage";
            this.detailQueryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailQueryTabPage.Size = new System.Drawing.Size(632, 347);
            this.detailQueryTabPage.TabIndex = 2;
            this.detailQueryTabPage.Text = "Detail query";
            this.detailQueryTabPage.UseVisualStyleBackColor = true;
            // 
            // txtDetailQuery
            // 
            this.txtDetailQuery.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtDetailQuery.AutoIndentCharsPatterns = "";
            this.txtDetailQuery.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txtDetailQuery.BackBrush = null;
            this.txtDetailQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetailQuery.CharHeight = 14;
            this.txtDetailQuery.CharWidth = 8;
            this.txtDetailQuery.CommentPrefix = "--";
            this.txtDetailQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetailQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDetailQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetailQuery.IsReplaceMode = false;
            this.txtDetailQuery.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtDetailQuery.LeftBracket = '(';
            this.txtDetailQuery.Location = new System.Drawing.Point(3, 55);
            this.txtDetailQuery.Name = "txtDetailQuery";
            this.txtDetailQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.txtDetailQuery.RightBracket = ')';
            this.txtDetailQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtDetailQuery.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtDetailQuery.ServiceColors")));
            this.txtDetailQuery.Size = new System.Drawing.Size(626, 289);
            this.txtDetailQuery.TabIndex = 2;
            this.txtDetailQuery.Zoom = 100;
            this.txtDetailQuery.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtDetailQuery_TextChangedDelayed);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkUseSPForDetail);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(626, 52);
            this.panel4.TabIndex = 1;
            // 
            // chkUseSPForDetail
            // 
            this.chkUseSPForDetail.AutoSize = true;
            this.chkUseSPForDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkUseSPForDetail.Location = new System.Drawing.Point(12, 9);
            this.chkUseSPForDetail.Name = "chkUseSPForDetail";
            this.chkUseSPForDetail.Size = new System.Drawing.Size(135, 17);
            this.chkUseSPForDetail.TabIndex = 0;
            this.chkUseSPForDetail.Text = "Use stored procuredure";
            this.chkUseSPForDetail.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Query text";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(416, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(207, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "click here to see query tips and restrictions";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQueryTips_LinkClicked);
            // 
            // cmdTest
            // 
            this.cmdTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdTest.Location = new System.Drawing.Point(415, 417);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 3;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // SqlQueryCollectorEditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 452);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.dataSourceTabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 490);
            this.Name = "SqlQueryCollectorEditEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Sql Query Collector Entry";
            this.Load += new System.EventHandler(this.SqlQueryCollectorEditEntry_Load);
            this.dataSourceTabControl.ResumeLayout(false);
            this.dataSourceTabPage.ResumeLayout(false);
            this.dataSourceExtrasPanel.ResumeLayout(false);
            this.dataSourceExtrasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCmndTimeOut)).EndInit();
            this.OLEDBDataSourcePanel.ResumeLayout(false);
            this.OLEDBDataSourcePanel.PerformLayout();
            this.sqlServerPanel.ResumeLayout(false);
            this.sqlServerPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.stateQueryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStateQuery)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.detailQueryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailQuery)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabControl dataSourceTabControl;
        private System.Windows.Forms.TabPage dataSourceTabPage;
        private System.Windows.Forms.TabPage stateQueryTabPage;
        private System.Windows.Forms.TabPage detailQueryTabPage;
        private System.Windows.Forms.RadioButton optOLEDb;
        private System.Windows.Forms.RadioButton optSqlServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.CheckBox chkUsePersistentConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIntegratedSec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownCmndTimeOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel sqlServerPanel;
        private System.Windows.Forms.Panel dataSourceExtrasPanel;
        private System.Windows.Forms.Panel OLEDBDataSourcePanel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button cmdBuildConnStr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Panel panel2;
        private FastColoredTextBoxNS.FastColoredTextBox txtStateQuery;
        private System.Windows.Forms.LinkLabel linkLabelQueryTips;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkUseSPForState;
        private System.Windows.Forms.ComboBox cboReturnType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton optEWG;
        private System.Windows.Forms.RadioButton optGWE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboSuccessMatchType;
        private System.Windows.Forms.TextBox txtGoodValueOrMacro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtErrorValueOrMacro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboErrorMatchType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtWarningValueOrMacro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboWarningMatchType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private FastColoredTextBoxNS.FastColoredTextBox txtDetailQuery;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkUseSPForDetail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button cmdTest;
    }
}