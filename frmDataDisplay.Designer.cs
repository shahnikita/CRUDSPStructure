namespace DBSpy
{
    partial class frmDataDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataDisplay));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lstViews = new System.Windows.Forms.ListBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetFieldInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.LoadDataForCurrentConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenANewConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewCurrentConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertOrUpdate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lstViews);
            this.GroupBox2.Location = new System.Drawing.Point(12, 180);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(260, 147);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Database Views";
            // 
            // lstViews
            // 
            this.lstViews.FormattingEnabled = true;
            this.lstViews.Location = new System.Drawing.Point(11, 25);
            this.lstViews.Name = "lstViews";
            this.lstViews.Size = new System.Drawing.Size(237, 108);
            this.lstViews.TabIndex = 1;
            this.lstViews.SelectedIndexChanged += new System.EventHandler(this.lstViews_SelectedIndexChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lstTables);
            this.GroupBox1.Location = new System.Drawing.Point(12, 27);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(260, 147);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Database Tables";
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(13, 27);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(237, 108);
            this.lstTables.TabIndex = 0;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetFieldInformationToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(196, 26);
            // 
            // GetFieldInformationToolStripMenuItem
            // 
            this.GetFieldInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GetFieldInformationToolStripMenuItem.Image")));
            this.GetFieldInformationToolStripMenuItem.Name = "GetFieldInformationToolStripMenuItem";
            this.GetFieldInformationToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.GetFieldInformationToolStripMenuItem.Text = "Get Field Information...";
            this.GetFieldInformationToolStripMenuItem.Click += new System.EventHandler(this.GetFieldInformationToolStripMenuItem_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lstFields);
            this.GroupBox3.Location = new System.Drawing.Point(278, 27);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(260, 300);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Selected Fields";
            // 
            // lstFields
            // 
            this.lstFields.ContextMenuStrip = this.ContextMenuStrip1;
            this.lstFields.FormattingEnabled = true;
            this.lstFields.Location = new System.Drawing.Point(12, 21);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(236, 264);
            this.lstFields.TabIndex = 0;
            this.lstFields.SelectedIndexChanged += new System.EventHandler(this.lstFields_SelectedIndexChanged);
            // 
            // LoadDataForCurrentConnectionToolStripMenuItem
            // 
            this.LoadDataForCurrentConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoadDataForCurrentConnectionToolStripMenuItem.Image")));
            this.LoadDataForCurrentConnectionToolStripMenuItem.Name = "LoadDataForCurrentConnectionToolStripMenuItem";
            this.LoadDataForCurrentConnectionToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.LoadDataForCurrentConnectionToolStripMenuItem.Text = "Load &Data for Current Connection";
            this.LoadDataForCurrentConnectionToolStripMenuItem.Click += new System.EventHandler(this.LoadDataForCurrentConnectionToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CloseToolStripMenuItem.Image")));
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.CloseToolStripMenuItem.Text = "&Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ConnectionToolStripMenuItem
            // 
            this.ConnectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenANewConnectionToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ViewCurrentConnectionToolStripMenuItem});
            this.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem";
            this.ConnectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ConnectionToolStripMenuItem.Text = "Co&nnection";
            // 
            // OpenANewConnectionToolStripMenuItem
            // 
            this.OpenANewConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenANewConnectionToolStripMenuItem.Image")));
            this.OpenANewConnectionToolStripMenuItem.Name = "OpenANewConnectionToolStripMenuItem";
            this.OpenANewConnectionToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.OpenANewConnectionToolStripMenuItem.Text = "O&pen a New Connection...";
            this.OpenANewConnectionToolStripMenuItem.Click += new System.EventHandler(this.OpenANewConnectionToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // ViewCurrentConnectionToolStripMenuItem
            // 
            this.ViewCurrentConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ViewCurrentConnectionToolStripMenuItem.Image")));
            this.ViewCurrentConnectionToolStripMenuItem.Name = "ViewCurrentConnectionToolStripMenuItem";
            this.ViewCurrentConnectionToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ViewCurrentConnectionToolStripMenuItem.Text = "&View Current Connection";
            this.ViewCurrentConnectionToolStripMenuItem.Click += new System.EventHandler(this.ViewCurrentConnectionToolStripMenuItem_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ConnectionToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(806, 24);
            this.MenuStrip1.TabIndex = 4;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadDataForCurrentConnectionToolStripMenuItem});
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.LoadToolStripMenuItem.Text = "&Load";
            // 
            // btnInsertOrUpdate
            // 
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(25, 333);
            this.btnInsertOrUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(174, 36);
            this.btnInsertOrUpdate.TabIndex = 8;
            this.btnInsertOrUpdate.Text = "Generate Insert or Update";
            this.btnInsertOrUpdate.UseVisualStyleBackColor = true;
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 401);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(613, 108);
            this.txtResult.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(224, 334);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Generate Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(368, 334);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(56, 35);
            this.btnSelectAll.TabIndex = 11;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(448, 333);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(56, 32);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // frmDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 518);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnInsertOrUpdate);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Information";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ListBox lstViews;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox lstTables;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem GetFieldInformationToolStripMenuItem;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ListBox lstFields;
        internal System.Windows.Forms.ToolStripMenuItem LoadDataForCurrentConnectionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ConnectionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenANewConnectionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ViewCurrentConnectionToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.Button btnInsertOrUpdate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnGet;
    }
}