namespace DBSpy
{
    partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.gbxSqlServer3 = new System.Windows.Forms.GroupBox();
            this.txtSqlServerInitialCat = new System.Windows.Forms.TextBox();
            this.lblSqlServerInitialCat = new System.Windows.Forms.Label();
            this.TabSqlServer = new System.Windows.Forms.TabPage();
            this.gbxSqlServer1 = new System.Windows.Forms.GroupBox();
            this.txtSqlServerProvider = new System.Windows.Forms.TextBox();
            this.lblSqlServerProvider = new System.Windows.Forms.Label();
            this.gbxSqlServer5 = new System.Windows.Forms.GroupBox();
            this.btnSQLserverCancel = new System.Windows.Forms.Button();
            this.btnSqlServerTest = new System.Windows.Forms.Button();
            this.btnSqlServerOK = new System.Windows.Forms.Button();
            this.gbxSqlServer4 = new System.Windows.Forms.GroupBox();
            this.cbxIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.txtSqlServerPassword = new System.Windows.Forms.TextBox();
            this.txtSqlServerUserID = new System.Windows.Forms.TextBox();
            this.lblSqlServerPassword = new System.Windows.Forms.Label();
            this.lblSqlServerUserID = new System.Windows.Forms.Label();
            this.gbxSqlServer2 = new System.Windows.Forms.GroupBox();
            this.txtSqlServerDBName = new System.Windows.Forms.TextBox();
            this.lblSqlServerName = new System.Windows.Forms.Label();
            this.lblAccessProvider = new System.Windows.Forms.Label();
            this.txtAccessProvider = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbxAccess2 = new System.Windows.Forms.GroupBox();
            this.txtAccessDBname = new System.Windows.Forms.TextBox();
            this.lblAccessDBname = new System.Windows.Forms.Label();
            this.gbxAccess1 = new System.Windows.Forms.GroupBox();
            this.lblAccessUserID = new System.Windows.Forms.Label();
            this.btnOracleCancel = new System.Windows.Forms.Button();
            this.btnOracleTest = new System.Windows.Forms.Button();
            this.gbxOracle4 = new System.Windows.Forms.GroupBox();
            this.btnOracleOK = new System.Windows.Forms.Button();
            this.txtOraclePassword = new System.Windows.Forms.TextBox();
            this.txtOracleUserID = new System.Windows.Forms.TextBox();
            this.gbxOracle3 = new System.Windows.Forms.GroupBox();
            this.lblOraclePassword = new System.Windows.Forms.Label();
            this.lblOracleUserID = new System.Windows.Forms.Label();
            this.txtAccessPassword = new System.Windows.Forms.TextBox();
            this.txtAccessUserID = new System.Windows.Forms.TextBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabAccess = new System.Windows.Forms.TabPage();
            this.gbxAccess4 = new System.Windows.Forms.GroupBox();
            this.btnAccessCancel = new System.Windows.Forms.Button();
            this.btnAccessTest = new System.Windows.Forms.Button();
            this.btnAccessOK = new System.Windows.Forms.Button();
            this.gbxAccess3 = new System.Windows.Forms.GroupBox();
            this.lblAccessPassword = new System.Windows.Forms.Label();
            this.tabOracle = new System.Windows.Forms.TabPage();
            this.gbxOracle1 = new System.Windows.Forms.GroupBox();
            this.txtOracleProvider = new System.Windows.Forms.TextBox();
            this.lblOracleProvider = new System.Windows.Forms.Label();
            this.gbxOracle2 = new System.Windows.Forms.GroupBox();
            this.txtOracleDBname = new System.Windows.Forms.TextBox();
            this.lblOracleDBname = new System.Windows.Forms.Label();
            this.gbxSqlServer3.SuspendLayout();
            this.TabSqlServer.SuspendLayout();
            this.gbxSqlServer1.SuspendLayout();
            this.gbxSqlServer5.SuspendLayout();
            this.gbxSqlServer4.SuspendLayout();
            this.gbxSqlServer2.SuspendLayout();
            this.gbxAccess2.SuspendLayout();
            this.gbxAccess1.SuspendLayout();
            this.gbxOracle4.SuspendLayout();
            this.gbxOracle3.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabAccess.SuspendLayout();
            this.gbxAccess4.SuspendLayout();
            this.gbxAccess3.SuspendLayout();
            this.tabOracle.SuspendLayout();
            this.gbxOracle1.SuspendLayout();
            this.gbxOracle2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSqlServer3
            // 
            this.gbxSqlServer3.Controls.Add(this.txtSqlServerInitialCat);
            this.gbxSqlServer3.Controls.Add(this.lblSqlServerInitialCat);
            this.gbxSqlServer3.Location = new System.Drawing.Point(8, 184);
            this.gbxSqlServer3.Name = "gbxSqlServer3";
            this.gbxSqlServer3.Size = new System.Drawing.Size(336, 80);
            this.gbxSqlServer3.TabIndex = 17;
            this.gbxSqlServer3.TabStop = false;
            this.gbxSqlServer3.Text = "Initial Catalog";
            // 
            // txtSqlServerInitialCat
            // 
            this.txtSqlServerInitialCat.Location = new System.Drawing.Point(40, 43);
            this.txtSqlServerInitialCat.Name = "txtSqlServerInitialCat";
            this.txtSqlServerInitialCat.Size = new System.Drawing.Size(248, 20);
            this.txtSqlServerInitialCat.TabIndex = 3;
            // 
            // lblSqlServerInitialCat
            // 
            this.lblSqlServerInitialCat.Location = new System.Drawing.Point(24, 24);
            this.lblSqlServerInitialCat.Name = "lblSqlServerInitialCat";
            this.lblSqlServerInitialCat.Size = new System.Drawing.Size(176, 16);
            this.lblSqlServerInitialCat.TabIndex = 0;
            this.lblSqlServerInitialCat.Text = "SQL Server Initial Catalog";
            // 
            // TabSqlServer
            // 
            this.TabSqlServer.Controls.Add(this.gbxSqlServer3);
            this.TabSqlServer.Controls.Add(this.gbxSqlServer1);
            this.TabSqlServer.Controls.Add(this.gbxSqlServer5);
            this.TabSqlServer.Controls.Add(this.gbxSqlServer4);
            this.TabSqlServer.Controls.Add(this.gbxSqlServer2);
            this.TabSqlServer.Location = new System.Drawing.Point(4, 22);
            this.TabSqlServer.Name = "TabSqlServer";
            this.TabSqlServer.Size = new System.Drawing.Size(352, 438);
            this.TabSqlServer.TabIndex = 1;
            this.TabSqlServer.Text = "SQL Server";
            this.TabSqlServer.UseVisualStyleBackColor = true;
            this.TabSqlServer.Visible = false;
            // 
            // gbxSqlServer1
            // 
            this.gbxSqlServer1.Controls.Add(this.txtSqlServerProvider);
            this.gbxSqlServer1.Controls.Add(this.lblSqlServerProvider);
            this.gbxSqlServer1.Location = new System.Drawing.Point(8, 15);
            this.gbxSqlServer1.Name = "gbxSqlServer1";
            this.gbxSqlServer1.Size = new System.Drawing.Size(336, 80);
            this.gbxSqlServer1.TabIndex = 16;
            this.gbxSqlServer1.TabStop = false;
            this.gbxSqlServer1.Text = "SQL Server Data Provider";
            // 
            // txtSqlServerProvider
            // 
            this.txtSqlServerProvider.Location = new System.Drawing.Point(40, 43);
            this.txtSqlServerProvider.Name = "txtSqlServerProvider";
            this.txtSqlServerProvider.Size = new System.Drawing.Size(256, 20);
            this.txtSqlServerProvider.TabIndex = 6;
            this.txtSqlServerProvider.Text = "SQLOLEDB";
            // 
            // lblSqlServerProvider
            // 
            this.lblSqlServerProvider.Location = new System.Drawing.Point(24, 24);
            this.lblSqlServerProvider.Name = "lblSqlServerProvider";
            this.lblSqlServerProvider.Size = new System.Drawing.Size(96, 16);
            this.lblSqlServerProvider.TabIndex = 4;
            this.lblSqlServerProvider.Text = "Provider Name: ";
            // 
            // gbxSqlServer5
            // 
            this.gbxSqlServer5.Controls.Add(this.btnSQLserverCancel);
            this.gbxSqlServer5.Controls.Add(this.btnSqlServerTest);
            this.gbxSqlServer5.Controls.Add(this.btnSqlServerOK);
            this.gbxSqlServer5.Location = new System.Drawing.Point(8, 384);
            this.gbxSqlServer5.Name = "gbxSqlServer5";
            this.gbxSqlServer5.Size = new System.Drawing.Size(336, 48);
            this.gbxSqlServer5.TabIndex = 15;
            this.gbxSqlServer5.TabStop = false;
            // 
            // btnSQLserverCancel
            // 
            this.btnSQLserverCancel.Location = new System.Drawing.Point(16, 16);
            this.btnSQLserverCancel.Name = "btnSQLserverCancel";
            this.btnSQLserverCancel.Size = new System.Drawing.Size(80, 23);
            this.btnSQLserverCancel.TabIndex = 2;
            this.btnSQLserverCancel.Text = "Cancel";
            this.btnSQLserverCancel.Click += new System.EventHandler(this.btnSQLserverCancel_Click);
            // 
            // btnSqlServerTest
            // 
            this.btnSqlServerTest.Location = new System.Drawing.Point(126, 16);
            this.btnSqlServerTest.Name = "btnSqlServerTest";
            this.btnSqlServerTest.Size = new System.Drawing.Size(75, 23);
            this.btnSqlServerTest.TabIndex = 1;
            this.btnSqlServerTest.Text = "Test";
            this.btnSqlServerTest.Click += new System.EventHandler(this.btnSqlServerTest_Click);
            // 
            // btnSqlServerOK
            // 
            this.btnSqlServerOK.Location = new System.Drawing.Point(231, 16);
            this.btnSqlServerOK.Name = "btnSqlServerOK";
            this.btnSqlServerOK.Size = new System.Drawing.Size(75, 23);
            this.btnSqlServerOK.TabIndex = 0;
            this.btnSqlServerOK.Text = "OK";
            this.btnSqlServerOK.Click += new System.EventHandler(this.btnSqlServerOK_Click);
            // 
            // gbxSqlServer4
            // 
            this.gbxSqlServer4.Controls.Add(this.cbxIntegratedSecurity);
            this.gbxSqlServer4.Controls.Add(this.txtSqlServerPassword);
            this.gbxSqlServer4.Controls.Add(this.txtSqlServerUserID);
            this.gbxSqlServer4.Controls.Add(this.lblSqlServerPassword);
            this.gbxSqlServer4.Controls.Add(this.lblSqlServerUserID);
            this.gbxSqlServer4.Location = new System.Drawing.Point(8, 272);
            this.gbxSqlServer4.Name = "gbxSqlServer4";
            this.gbxSqlServer4.Size = new System.Drawing.Size(336, 104);
            this.gbxSqlServer4.TabIndex = 14;
            this.gbxSqlServer4.TabStop = false;
            this.gbxSqlServer4.Text = "User Credentials";
            // 
            // cbxIntegratedSecurity
            // 
            this.cbxIntegratedSecurity.AutoSize = true;
            this.cbxIntegratedSecurity.Location = new System.Drawing.Point(88, 81);
            this.cbxIntegratedSecurity.Name = "cbxIntegratedSecurity";
            this.cbxIntegratedSecurity.Size = new System.Drawing.Size(137, 17);
            this.cbxIntegratedSecurity.TabIndex = 4;
            this.cbxIntegratedSecurity.Text = "Use Integrated Security";
            this.cbxIntegratedSecurity.UseVisualStyleBackColor = true;
            this.cbxIntegratedSecurity.CheckedChanged += new System.EventHandler(this.cbxIntegratedSecurity_CheckedChanged);
            // 
            // txtSqlServerPassword
            // 
            this.txtSqlServerPassword.Location = new System.Drawing.Point(88, 51);
            this.txtSqlServerPassword.Name = "txtSqlServerPassword";
            this.txtSqlServerPassword.PasswordChar = '*';
            this.txtSqlServerPassword.Size = new System.Drawing.Size(200, 20);
            this.txtSqlServerPassword.TabIndex = 3;
            // 
            // txtSqlServerUserID
            // 
            this.txtSqlServerUserID.Location = new System.Drawing.Point(88, 22);
            this.txtSqlServerUserID.Name = "txtSqlServerUserID";
            this.txtSqlServerUserID.Size = new System.Drawing.Size(200, 20);
            this.txtSqlServerUserID.TabIndex = 2;
            // 
            // lblSqlServerPassword
            // 
            this.lblSqlServerPassword.Location = new System.Drawing.Point(23, 49);
            this.lblSqlServerPassword.Name = "lblSqlServerPassword";
            this.lblSqlServerPassword.Size = new System.Drawing.Size(64, 23);
            this.lblSqlServerPassword.TabIndex = 1;
            this.lblSqlServerPassword.Text = "Password:";
            this.lblSqlServerPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSqlServerUserID
            // 
            this.lblSqlServerUserID.Location = new System.Drawing.Point(23, 21);
            this.lblSqlServerUserID.Name = "lblSqlServerUserID";
            this.lblSqlServerUserID.Size = new System.Drawing.Size(64, 23);
            this.lblSqlServerUserID.TabIndex = 0;
            this.lblSqlServerUserID.Text = "User ID:";
            this.lblSqlServerUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxSqlServer2
            // 
            this.gbxSqlServer2.Controls.Add(this.txtSqlServerDBName);
            this.gbxSqlServer2.Controls.Add(this.lblSqlServerName);
            this.gbxSqlServer2.Location = new System.Drawing.Point(8, 103);
            this.gbxSqlServer2.Name = "gbxSqlServer2";
            this.gbxSqlServer2.Size = new System.Drawing.Size(336, 80);
            this.gbxSqlServer2.TabIndex = 13;
            this.gbxSqlServer2.TabStop = false;
            this.gbxSqlServer2.Text = "Data Source";
            // 
            // txtSqlServerDBName
            // 
            this.txtSqlServerDBName.Location = new System.Drawing.Point(40, 43);
            this.txtSqlServerDBName.Name = "txtSqlServerDBName";
            this.txtSqlServerDBName.Size = new System.Drawing.Size(248, 20);
            this.txtSqlServerDBName.TabIndex = 3;
            // 
            // lblSqlServerName
            // 
            this.lblSqlServerName.Location = new System.Drawing.Point(24, 24);
            this.lblSqlServerName.Name = "lblSqlServerName";
            this.lblSqlServerName.Size = new System.Drawing.Size(80, 16);
            this.lblSqlServerName.TabIndex = 0;
            this.lblSqlServerName.Text = "Server Name: ";
            // 
            // lblAccessProvider
            // 
            this.lblAccessProvider.Location = new System.Drawing.Point(24, 24);
            this.lblAccessProvider.Name = "lblAccessProvider";
            this.lblAccessProvider.Size = new System.Drawing.Size(96, 16);
            this.lblAccessProvider.TabIndex = 4;
            this.lblAccessProvider.Text = "Provider Name: ";
            // 
            // txtAccessProvider
            // 
            this.txtAccessProvider.Location = new System.Drawing.Point(40, 48);
            this.txtAccessProvider.Name = "txtAccessProvider";
            this.txtAccessProvider.Size = new System.Drawing.Size(256, 20);
            this.txtAccessProvider.TabIndex = 6;
            this.txtAccessProvider.Text = "Microsoft.Jet.OLEDB.4.0";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(256, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(64, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gbxAccess2
            // 
            this.gbxAccess2.Controls.Add(this.btnBrowse);
            this.gbxAccess2.Controls.Add(this.txtAccessDBname);
            this.gbxAccess2.Controls.Add(this.lblAccessDBname);
            this.gbxAccess2.Location = new System.Drawing.Point(8, 104);
            this.gbxAccess2.Name = "gbxAccess2";
            this.gbxAccess2.Size = new System.Drawing.Size(336, 80);
            this.gbxAccess2.TabIndex = 18;
            this.gbxAccess2.TabStop = false;
            this.gbxAccess2.Text = "Database";
            // 
            // txtAccessDBname
            // 
            this.txtAccessDBname.Location = new System.Drawing.Point(40, 40);
            this.txtAccessDBname.Name = "txtAccessDBname";
            this.txtAccessDBname.Size = new System.Drawing.Size(208, 20);
            this.txtAccessDBname.TabIndex = 3;
            // 
            // lblAccessDBname
            // 
            this.lblAccessDBname.Location = new System.Drawing.Point(24, 24);
            this.lblAccessDBname.Name = "lblAccessDBname";
            this.lblAccessDBname.Size = new System.Drawing.Size(104, 16);
            this.lblAccessDBname.TabIndex = 0;
            this.lblAccessDBname.Text = "Database Name: ";
            // 
            // gbxAccess1
            // 
            this.gbxAccess1.Controls.Add(this.txtAccessProvider);
            this.gbxAccess1.Controls.Add(this.lblAccessProvider);
            this.gbxAccess1.Location = new System.Drawing.Point(8, 16);
            this.gbxAccess1.Name = "gbxAccess1";
            this.gbxAccess1.Size = new System.Drawing.Size(336, 80);
            this.gbxAccess1.TabIndex = 17;
            this.gbxAccess1.TabStop = false;
            this.gbxAccess1.Text = "Access Data Provider";
            // 
            // lblAccessUserID
            // 
            this.lblAccessUserID.Location = new System.Drawing.Point(16, 32);
            this.lblAccessUserID.Name = "lblAccessUserID";
            this.lblAccessUserID.Size = new System.Drawing.Size(64, 23);
            this.lblAccessUserID.TabIndex = 0;
            this.lblAccessUserID.Text = "User ID:";
            this.lblAccessUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOracleCancel
            // 
            this.btnOracleCancel.Location = new System.Drawing.Point(16, 16);
            this.btnOracleCancel.Name = "btnOracleCancel";
            this.btnOracleCancel.Size = new System.Drawing.Size(80, 23);
            this.btnOracleCancel.TabIndex = 2;
            this.btnOracleCancel.Text = "Cancel";
            this.btnOracleCancel.Click += new System.EventHandler(this.btnOracleCancel_Click);
            // 
            // btnOracleTest
            // 
            this.btnOracleTest.Location = new System.Drawing.Point(126, 16);
            this.btnOracleTest.Name = "btnOracleTest";
            this.btnOracleTest.Size = new System.Drawing.Size(75, 23);
            this.btnOracleTest.TabIndex = 1;
            this.btnOracleTest.Text = "Test";
            this.btnOracleTest.Click += new System.EventHandler(this.btnOracleTest_Click);
            // 
            // gbxOracle4
            // 
            this.gbxOracle4.Controls.Add(this.btnOracleCancel);
            this.gbxOracle4.Controls.Add(this.btnOracleTest);
            this.gbxOracle4.Controls.Add(this.btnOracleOK);
            this.gbxOracle4.Location = new System.Drawing.Point(8, 304);
            this.gbxOracle4.Name = "gbxOracle4";
            this.gbxOracle4.Size = new System.Drawing.Size(336, 48);
            this.gbxOracle4.TabIndex = 7;
            this.gbxOracle4.TabStop = false;
            // 
            // btnOracleOK
            // 
            this.btnOracleOK.Location = new System.Drawing.Point(231, 16);
            this.btnOracleOK.Name = "btnOracleOK";
            this.btnOracleOK.Size = new System.Drawing.Size(75, 23);
            this.btnOracleOK.TabIndex = 0;
            this.btnOracleOK.Text = "OK";
            this.btnOracleOK.Click += new System.EventHandler(this.btnOracleOK_Click);
            // 
            // txtOraclePassword
            // 
            this.txtOraclePassword.Location = new System.Drawing.Point(88, 64);
            this.txtOraclePassword.Name = "txtOraclePassword";
            this.txtOraclePassword.PasswordChar = '*';
            this.txtOraclePassword.Size = new System.Drawing.Size(200, 20);
            this.txtOraclePassword.TabIndex = 3;
            // 
            // txtOracleUserID
            // 
            this.txtOracleUserID.Location = new System.Drawing.Point(88, 32);
            this.txtOracleUserID.Name = "txtOracleUserID";
            this.txtOracleUserID.Size = new System.Drawing.Size(200, 20);
            this.txtOracleUserID.TabIndex = 2;
            // 
            // gbxOracle3
            // 
            this.gbxOracle3.Controls.Add(this.txtOraclePassword);
            this.gbxOracle3.Controls.Add(this.txtOracleUserID);
            this.gbxOracle3.Controls.Add(this.lblOraclePassword);
            this.gbxOracle3.Controls.Add(this.lblOracleUserID);
            this.gbxOracle3.Location = new System.Drawing.Point(8, 192);
            this.gbxOracle3.Name = "gbxOracle3";
            this.gbxOracle3.Size = new System.Drawing.Size(336, 104);
            this.gbxOracle3.TabIndex = 6;
            this.gbxOracle3.TabStop = false;
            this.gbxOracle3.Text = "User Credentials";
            // 
            // lblOraclePassword
            // 
            this.lblOraclePassword.Location = new System.Drawing.Point(16, 61);
            this.lblOraclePassword.Name = "lblOraclePassword";
            this.lblOraclePassword.Size = new System.Drawing.Size(64, 23);
            this.lblOraclePassword.TabIndex = 1;
            this.lblOraclePassword.Text = "Password:";
            this.lblOraclePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOracleUserID
            // 
            this.lblOracleUserID.Location = new System.Drawing.Point(16, 32);
            this.lblOracleUserID.Name = "lblOracleUserID";
            this.lblOracleUserID.Size = new System.Drawing.Size(64, 23);
            this.lblOracleUserID.TabIndex = 0;
            this.lblOracleUserID.Text = "User ID:";
            this.lblOracleUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccessPassword
            // 
            this.txtAccessPassword.Location = new System.Drawing.Point(88, 64);
            this.txtAccessPassword.Name = "txtAccessPassword";
            this.txtAccessPassword.PasswordChar = '*';
            this.txtAccessPassword.Size = new System.Drawing.Size(200, 20);
            this.txtAccessPassword.TabIndex = 3;
            // 
            // txtAccessUserID
            // 
            this.txtAccessUserID.Location = new System.Drawing.Point(88, 32);
            this.txtAccessUserID.Name = "txtAccessUserID";
            this.txtAccessUserID.Size = new System.Drawing.Size(200, 20);
            this.txtAccessUserID.TabIndex = 2;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabSqlServer);
            this.TabControl1.Controls.Add(this.TabAccess);
            this.TabControl1.Controls.Add(this.tabOracle);
            this.TabControl1.Location = new System.Drawing.Point(3, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(360, 464);
            this.TabControl1.TabIndex = 8;
            // 
            // TabAccess
            // 
            this.TabAccess.Controls.Add(this.gbxAccess4);
            this.TabAccess.Controls.Add(this.gbxAccess3);
            this.TabAccess.Controls.Add(this.gbxAccess2);
            this.TabAccess.Controls.Add(this.gbxAccess1);
            this.TabAccess.Location = new System.Drawing.Point(4, 22);
            this.TabAccess.Name = "TabAccess";
            this.TabAccess.Size = new System.Drawing.Size(352, 438);
            this.TabAccess.TabIndex = 2;
            this.TabAccess.Text = "Access";
            this.TabAccess.UseVisualStyleBackColor = true;
            this.TabAccess.Visible = false;
            // 
            // gbxAccess4
            // 
            this.gbxAccess4.Controls.Add(this.btnAccessCancel);
            this.gbxAccess4.Controls.Add(this.btnAccessTest);
            this.gbxAccess4.Controls.Add(this.btnAccessOK);
            this.gbxAccess4.Location = new System.Drawing.Point(8, 304);
            this.gbxAccess4.Name = "gbxAccess4";
            this.gbxAccess4.Size = new System.Drawing.Size(336, 48);
            this.gbxAccess4.TabIndex = 20;
            this.gbxAccess4.TabStop = false;
            // 
            // btnAccessCancel
            // 
            this.btnAccessCancel.Location = new System.Drawing.Point(16, 16);
            this.btnAccessCancel.Name = "btnAccessCancel";
            this.btnAccessCancel.Size = new System.Drawing.Size(80, 23);
            this.btnAccessCancel.TabIndex = 2;
            this.btnAccessCancel.Text = "Cancel";
            this.btnAccessCancel.Click += new System.EventHandler(this.btnAccessCancel_Click);
            // 
            // btnAccessTest
            // 
            this.btnAccessTest.Location = new System.Drawing.Point(126, 16);
            this.btnAccessTest.Name = "btnAccessTest";
            this.btnAccessTest.Size = new System.Drawing.Size(75, 23);
            this.btnAccessTest.TabIndex = 1;
            this.btnAccessTest.Text = "Test";
            this.btnAccessTest.Click += new System.EventHandler(this.btnAccessTest_Click);
            // 
            // btnAccessOK
            // 
            this.btnAccessOK.Location = new System.Drawing.Point(231, 16);
            this.btnAccessOK.Name = "btnAccessOK";
            this.btnAccessOK.Size = new System.Drawing.Size(75, 23);
            this.btnAccessOK.TabIndex = 0;
            this.btnAccessOK.Text = "OK";
            this.btnAccessOK.Click += new System.EventHandler(this.btnAccessOK_Click);
            // 
            // gbxAccess3
            // 
            this.gbxAccess3.Controls.Add(this.txtAccessPassword);
            this.gbxAccess3.Controls.Add(this.txtAccessUserID);
            this.gbxAccess3.Controls.Add(this.lblAccessPassword);
            this.gbxAccess3.Controls.Add(this.lblAccessUserID);
            this.gbxAccess3.Location = new System.Drawing.Point(8, 192);
            this.gbxAccess3.Name = "gbxAccess3";
            this.gbxAccess3.Size = new System.Drawing.Size(336, 104);
            this.gbxAccess3.TabIndex = 19;
            this.gbxAccess3.TabStop = false;
            this.gbxAccess3.Text = "User Credentials";
            // 
            // lblAccessPassword
            // 
            this.lblAccessPassword.Location = new System.Drawing.Point(16, 61);
            this.lblAccessPassword.Name = "lblAccessPassword";
            this.lblAccessPassword.Size = new System.Drawing.Size(64, 23);
            this.lblAccessPassword.TabIndex = 1;
            this.lblAccessPassword.Text = "Password:";
            this.lblAccessPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabOracle
            // 
            this.tabOracle.Controls.Add(this.gbxOracle1);
            this.tabOracle.Controls.Add(this.gbxOracle4);
            this.tabOracle.Controls.Add(this.gbxOracle3);
            this.tabOracle.Controls.Add(this.gbxOracle2);
            this.tabOracle.Location = new System.Drawing.Point(4, 22);
            this.tabOracle.Name = "tabOracle";
            this.tabOracle.Size = new System.Drawing.Size(352, 438);
            this.tabOracle.TabIndex = 0;
            this.tabOracle.Text = "Oracle";
            this.tabOracle.UseVisualStyleBackColor = true;
            // 
            // gbxOracle1
            // 
            this.gbxOracle1.Controls.Add(this.txtOracleProvider);
            this.gbxOracle1.Controls.Add(this.lblOracleProvider);
            this.gbxOracle1.Location = new System.Drawing.Point(8, 16);
            this.gbxOracle1.Name = "gbxOracle1";
            this.gbxOracle1.Size = new System.Drawing.Size(336, 80);
            this.gbxOracle1.TabIndex = 8;
            this.gbxOracle1.TabStop = false;
            this.gbxOracle1.Text = "Oracle Data Provider";
            // 
            // txtOracleProvider
            // 
            this.txtOracleProvider.Location = new System.Drawing.Point(40, 48);
            this.txtOracleProvider.Name = "txtOracleProvider";
            this.txtOracleProvider.Size = new System.Drawing.Size(248, 20);
            this.txtOracleProvider.TabIndex = 5;
            this.txtOracleProvider.Text = "OraOLEDB.Oracle";
            // 
            // lblOracleProvider
            // 
            this.lblOracleProvider.Location = new System.Drawing.Point(24, 24);
            this.lblOracleProvider.Name = "lblOracleProvider";
            this.lblOracleProvider.Size = new System.Drawing.Size(96, 16);
            this.lblOracleProvider.TabIndex = 4;
            this.lblOracleProvider.Text = "Provider Name: ";
            // 
            // gbxOracle2
            // 
            this.gbxOracle2.Controls.Add(this.txtOracleDBname);
            this.gbxOracle2.Controls.Add(this.lblOracleDBname);
            this.gbxOracle2.Location = new System.Drawing.Point(8, 104);
            this.gbxOracle2.Name = "gbxOracle2";
            this.gbxOracle2.Size = new System.Drawing.Size(336, 80);
            this.gbxOracle2.TabIndex = 5;
            this.gbxOracle2.TabStop = false;
            this.gbxOracle2.Text = "Database";
            // 
            // txtOracleDBname
            // 
            this.txtOracleDBname.Location = new System.Drawing.Point(40, 40);
            this.txtOracleDBname.Name = "txtOracleDBname";
            this.txtOracleDBname.Size = new System.Drawing.Size(248, 20);
            this.txtOracleDBname.TabIndex = 3;
            // 
            // lblOracleDBname
            // 
            this.lblOracleDBname.Location = new System.Drawing.Point(24, 24);
            this.lblOracleDBname.Name = "lblOracleDBname";
            this.lblOracleDBname.Size = new System.Drawing.Size(104, 16);
            this.lblOracleDBname.TabIndex = 0;
            this.lblOracleDBname.Text = "Database Name: ";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 468);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.gbxSqlServer3.ResumeLayout(false);
            this.gbxSqlServer3.PerformLayout();
            this.TabSqlServer.ResumeLayout(false);
            this.gbxSqlServer1.ResumeLayout(false);
            this.gbxSqlServer1.PerformLayout();
            this.gbxSqlServer5.ResumeLayout(false);
            this.gbxSqlServer4.ResumeLayout(false);
            this.gbxSqlServer4.PerformLayout();
            this.gbxSqlServer2.ResumeLayout(false);
            this.gbxSqlServer2.PerformLayout();
            this.gbxAccess2.ResumeLayout(false);
            this.gbxAccess2.PerformLayout();
            this.gbxAccess1.ResumeLayout(false);
            this.gbxAccess1.PerformLayout();
            this.gbxOracle4.ResumeLayout(false);
            this.gbxOracle3.ResumeLayout(false);
            this.gbxOracle3.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabAccess.ResumeLayout(false);
            this.gbxAccess4.ResumeLayout(false);
            this.gbxAccess3.ResumeLayout(false);
            this.gbxAccess3.PerformLayout();
            this.tabOracle.ResumeLayout(false);
            this.gbxOracle1.ResumeLayout(false);
            this.gbxOracle1.PerformLayout();
            this.gbxOracle2.ResumeLayout(false);
            this.gbxOracle2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbxSqlServer3;
        internal System.Windows.Forms.TextBox txtSqlServerInitialCat;
        internal System.Windows.Forms.Label lblSqlServerInitialCat;
        internal System.Windows.Forms.TabPage TabSqlServer;
        internal System.Windows.Forms.GroupBox gbxSqlServer1;
        internal System.Windows.Forms.TextBox txtSqlServerProvider;
        internal System.Windows.Forms.Label lblSqlServerProvider;
        internal System.Windows.Forms.GroupBox gbxSqlServer5;
        internal System.Windows.Forms.Button btnSQLserverCancel;
        internal System.Windows.Forms.Button btnSqlServerTest;
        internal System.Windows.Forms.Button btnSqlServerOK;
        internal System.Windows.Forms.GroupBox gbxSqlServer4;
        internal System.Windows.Forms.TextBox txtSqlServerPassword;
        internal System.Windows.Forms.TextBox txtSqlServerUserID;
        internal System.Windows.Forms.Label lblSqlServerPassword;
        internal System.Windows.Forms.Label lblSqlServerUserID;
        internal System.Windows.Forms.GroupBox gbxSqlServer2;
        internal System.Windows.Forms.TextBox txtSqlServerDBName;
        internal System.Windows.Forms.Label lblSqlServerName;
        internal System.Windows.Forms.Label lblAccessProvider;
        internal System.Windows.Forms.TextBox txtAccessProvider;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.GroupBox gbxAccess2;
        internal System.Windows.Forms.TextBox txtAccessDBname;
        internal System.Windows.Forms.Label lblAccessDBname;
        internal System.Windows.Forms.GroupBox gbxAccess1;
        internal System.Windows.Forms.Label lblAccessUserID;
        internal System.Windows.Forms.Button btnOracleCancel;
        internal System.Windows.Forms.Button btnOracleTest;
        internal System.Windows.Forms.GroupBox gbxOracle4;
        internal System.Windows.Forms.Button btnOracleOK;
        internal System.Windows.Forms.TextBox txtOraclePassword;
        internal System.Windows.Forms.TextBox txtOracleUserID;
        internal System.Windows.Forms.GroupBox gbxOracle3;
        internal System.Windows.Forms.Label lblOraclePassword;
        internal System.Windows.Forms.Label lblOracleUserID;
        internal System.Windows.Forms.TextBox txtAccessPassword;
        internal System.Windows.Forms.TextBox txtAccessUserID;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tabOracle;
        internal System.Windows.Forms.GroupBox gbxOracle1;
        internal System.Windows.Forms.TextBox txtOracleProvider;
        internal System.Windows.Forms.Label lblOracleProvider;
        internal System.Windows.Forms.GroupBox gbxOracle2;
        internal System.Windows.Forms.TextBox txtOracleDBname;
        internal System.Windows.Forms.Label lblOracleDBname;
        internal System.Windows.Forms.TabPage TabAccess;
        internal System.Windows.Forms.GroupBox gbxAccess4;
        internal System.Windows.Forms.Button btnAccessCancel;
        internal System.Windows.Forms.Button btnAccessTest;
        internal System.Windows.Forms.Button btnAccessOK;
        internal System.Windows.Forms.GroupBox gbxAccess3;
        internal System.Windows.Forms.Label lblAccessPassword;
        private System.Windows.Forms.CheckBox cbxIntegratedSecurity;
    }
}

