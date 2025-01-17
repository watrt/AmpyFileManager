﻿namespace AmpyFileManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnREPL = new System.Windows.Forms.Button();
            this.cboHelp = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMkdir = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.mainSplitter = new System.Windows.Forms.SplitContainer();
            this.lstDirectory = new System.Windows.Forms.ListBox();
            this.pnlPathStatus = new System.Windows.Forms.Panel();
            this.btnBackupScript = new System.Windows.Forms.Button();
            this.btnRestoreScript = new System.Windows.Forms.Button();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFolderCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPathTop = new System.Windows.Forms.Panel();
            this.lblCurrentDirectory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSaveMessage = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.pnlFileStatus = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFileToolbar = new System.Windows.Forms.Panel();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tmrMessage = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlToolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).BeginInit();
            this.mainSplitter.Panel1.SuspendLayout();
            this.mainSplitter.Panel2.SuspendLayout();
            this.mainSplitter.SuspendLayout();
            this.pnlPathStatus.SuspendLayout();
            this.pnlPathTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSaveMessage.SuspendLayout();
            this.pnlFileStatus.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlFileToolbar.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbar.Controls.Add(this.panel1);
            this.pnlToolbar.Controls.Add(this.btnExport);
            this.pnlToolbar.Controls.Add(this.btnMove);
            this.pnlToolbar.Controls.Add(this.btnRun);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.btnMkdir);
            this.pnlToolbar.Controls.Add(this.btnLoad);
            this.pnlToolbar.Controls.Add(this.btnNew);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnOpen);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1395, 44);
            this.pnlToolbar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnREPL);
            this.panel1.Controls.Add(this.cboHelp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(997, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 42);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "帮助:";
            // 
            // btnREPL
            // 
            this.btnREPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREPL.ForeColor = System.Drawing.Color.Black;
            this.btnREPL.Image = ((System.Drawing.Image)(resources.GetObject("btnREPL.Image")));
            this.btnREPL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnREPL.Location = new System.Drawing.Point(292, 2);
            this.btnREPL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnREPL.Name = "btnREPL";
            this.btnREPL.Size = new System.Drawing.Size(97, 36);
            this.btnREPL.TabIndex = 13;
            this.btnREPL.Text = "终端";
            this.btnREPL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnREPL.UseVisualStyleBackColor = true;
            this.btnREPL.Click += new System.EventHandler(this.btnREPL_Click);
            // 
            // cboHelp
            // 
            this.cboHelp.FormattingEnabled = true;
            this.cboHelp.Location = new System.Drawing.Point(55, 10);
            this.cboHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboHelp.Name = "cboHelp";
            this.cboHelp.Size = new System.Drawing.Size(217, 23);
            this.cboHelp.TabIndex = 19;
            this.cboHelp.SelectedIndexChanged += new System.EventHandler(this.cboHelp_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(252, 5);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 35);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "导出";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnMove
            // 
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMove.Location = new System.Drawing.Point(436, 5);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(92, 35);
            this.btnMove.TabIndex = 14;
            this.btnMove.Text = "移动";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(737, 5);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(72, 35);
            this.btnRun.TabIndex = 17;
            this.btnRun.Text = "运行";
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(642, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 35);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMkdir
            // 
            this.btnMkdir.Image = ((System.Drawing.Image)(resources.GetObject("btnMkdir.Image")));
            this.btnMkdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMkdir.Location = new System.Drawing.Point(534, 5);
            this.btnMkdir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMkdir.Name = "btnMkdir";
            this.btnMkdir.Size = new System.Drawing.Size(102, 35);
            this.btnMkdir.TabIndex = 15;
            this.btnMkdir.Text = "创建目录";
            this.btnMkdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMkdir.UseVisualStyleBackColor = true;
            this.btnMkdir.Click += new System.EventHandler(this.btnMkdir_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(167, 5);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 35);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "加载";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(4, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(72, 35);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "新建";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(347, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(82, 5);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 35);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "打开";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter.Location = new System.Drawing.Point(0, 44);
            this.mainSplitter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainSplitter.Name = "mainSplitter";
            // 
            // mainSplitter.Panel1
            // 
            this.mainSplitter.Panel1.Controls.Add(this.lstDirectory);
            this.mainSplitter.Panel1.Controls.Add(this.pnlPathStatus);
            this.mainSplitter.Panel1.Controls.Add(this.pnlPathTop);
            // 
            // mainSplitter.Panel2
            // 
            this.mainSplitter.Panel2.Controls.Add(this.pnlSaveMessage);
            this.mainSplitter.Panel2.Controls.Add(this.scintilla1);
            this.mainSplitter.Panel2.Controls.Add(this.pnlFileStatus);
            this.mainSplitter.Panel2.Controls.Add(this.pnlFileToolbar);
            this.mainSplitter.Size = new System.Drawing.Size(1395, 691);
            this.mainSplitter.SplitterDistance = 357;
            this.mainSplitter.SplitterWidth = 5;
            this.mainSplitter.TabIndex = 1;
            // 
            // lstDirectory
            // 
            this.lstDirectory.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lstDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDirectory.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDirectory.FormattingEnabled = true;
            this.lstDirectory.IntegralHeight = false;
            this.lstDirectory.ItemHeight = 28;
            this.lstDirectory.Location = new System.Drawing.Point(0, 36);
            this.lstDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstDirectory.Name = "lstDirectory";
            this.lstDirectory.Size = new System.Drawing.Size(357, 612);
            this.lstDirectory.TabIndex = 18;
            this.lstDirectory.DoubleClick += new System.EventHandler(this.lstDirectory_DoubleClick);
            // 
            // pnlPathStatus
            // 
            this.pnlPathStatus.Controls.Add(this.btnBackupScript);
            this.pnlPathStatus.Controls.Add(this.btnRestoreScript);
            this.pnlPathStatus.Controls.Add(this.lblFileCount);
            this.pnlPathStatus.Controls.Add(this.label6);
            this.pnlPathStatus.Controls.Add(this.lblFolderCount);
            this.pnlPathStatus.Controls.Add(this.label4);
            this.pnlPathStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPathStatus.Location = new System.Drawing.Point(0, 648);
            this.pnlPathStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPathStatus.Name = "pnlPathStatus";
            this.pnlPathStatus.Size = new System.Drawing.Size(357, 43);
            this.pnlPathStatus.TabIndex = 17;
            // 
            // btnBackupScript
            // 
            this.btnBackupScript.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupScript.Image")));
            this.btnBackupScript.Location = new System.Drawing.Point(265, 1);
            this.btnBackupScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackupScript.Name = "btnBackupScript";
            this.btnBackupScript.Size = new System.Drawing.Size(51, 39);
            this.btnBackupScript.TabIndex = 21;
            this.btnBackupScript.UseVisualStyleBackColor = true;
            this.btnBackupScript.Click += new System.EventHandler(this.btnBackupScript_Click);
            // 
            // btnRestoreScript
            // 
            this.btnRestoreScript.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreScript.Image")));
            this.btnRestoreScript.Location = new System.Drawing.Point(316, 1);
            this.btnRestoreScript.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestoreScript.Name = "btnRestoreScript";
            this.btnRestoreScript.Size = new System.Drawing.Size(51, 39);
            this.btnRestoreScript.TabIndex = 20;
            this.btnRestoreScript.UseVisualStyleBackColor = true;
            this.btnRestoreScript.Click += new System.EventHandler(this.btnRestoreScript_Click);
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCount.Location = new System.Drawing.Point(176, 14);
            this.lblFileCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(35, 17);
            this.lblFileCount.TabIndex = 3;
            this.lblFileCount.Text = "999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "文件:";
            // 
            // lblFolderCount
            // 
            this.lblFolderCount.AutoSize = true;
            this.lblFolderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderCount.Location = new System.Drawing.Point(92, 14);
            this.lblFolderCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolderCount.Name = "lblFolderCount";
            this.lblFolderCount.Size = new System.Drawing.Size(35, 17);
            this.lblFolderCount.TabIndex = 1;
            this.lblFolderCount.Text = "999";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "子目录:";
            // 
            // pnlPathTop
            // 
            this.pnlPathTop.Controls.Add(this.lblCurrentDirectory);
            this.pnlPathTop.Controls.Add(this.panel3);
            this.pnlPathTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPathTop.Location = new System.Drawing.Point(0, 0);
            this.pnlPathTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPathTop.Name = "pnlPathTop";
            this.pnlPathTop.Size = new System.Drawing.Size(357, 36);
            this.pnlPathTop.TabIndex = 15;
            // 
            // lblCurrentDirectory
            // 
            this.lblCurrentDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDirectory.Location = new System.Drawing.Point(62, 0);
            this.lblCurrentDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDirectory.Name = "lblCurrentDirectory";
            this.lblCurrentDirectory.Size = new System.Drawing.Size(295, 36);
            this.lblCurrentDirectory.TabIndex = 8;
            this.lblCurrentDirectory.Text = "路径";
            this.lblCurrentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 36);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "路径:";
            // 
            // pnlSaveMessage
            // 
            this.pnlSaveMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSaveMessage.Controls.Add(this.label5);
            this.pnlSaveMessage.Location = new System.Drawing.Point(293, 340);
            this.pnlSaveMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSaveMessage.Name = "pnlSaveMessage";
            this.pnlSaveMessage.Size = new System.Drawing.Size(392, 56);
            this.pnlSaveMessage.TabIndex = 20;
            this.pnlSaveMessage.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "文件保存和上传成功。\r\n";
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.EolMode = ScintillaNET.Eol.Lf;
            this.scintilla1.IndentationGuides = ScintillaNET.IndentView.Real;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Python;
            this.scintilla1.Location = new System.Drawing.Point(0, 36);
            this.scintilla1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(1033, 612);
            this.scintilla1.TabIndex = 19;
            this.scintilla1.TextChanged += new System.EventHandler(this.scintilla1_TextChanged);
            // 
            // pnlFileStatus
            // 
            this.pnlFileStatus.Controls.Add(this.linkLabel1);
            this.pnlFileStatus.Controls.Add(this.panel10);
            this.pnlFileStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFileStatus.Location = new System.Drawing.Point(0, 648);
            this.pnlFileStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFileStatus.Name = "pnlFileStatus";
            this.pnlFileStatus.Size = new System.Drawing.Size(1033, 43);
            this.pnlFileStatus.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnReplaceAll);
            this.panel10.Controls.Add(this.btnSaveAs);
            this.panel10.Controls.Add(this.btnSave);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(738, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(295, 43);
            this.panel10.TabIndex = 9;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(4, 5);
            this.btnReplaceAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(96, 31);
            this.btnReplaceAll.TabIndex = 17;
            this.btnReplaceAll.Text = "替换全部";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(105, 5);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(96, 31);
            this.btnSaveAs.TabIndex = 15;
            this.btnSaveAs.Text = "另存为...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 31);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFileToolbar
            // 
            this.pnlFileToolbar.Controls.Add(this.lblCurrentFile);
            this.pnlFileToolbar.Controls.Add(this.panel9);
            this.pnlFileToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFileToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlFileToolbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFileToolbar.Name = "pnlFileToolbar";
            this.pnlFileToolbar.Size = new System.Drawing.Size(1033, 36);
            this.pnlFileToolbar.TabIndex = 0;
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.Location = new System.Drawing.Point(103, 0);
            this.lblCurrentFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(930, 36);
            this.lblCurrentFile.TabIndex = 9;
            this.lblCurrentFile.Text = "当前文件";
            this.lblCurrentFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(103, 36);
            this.panel9.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "当前文件:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "py";
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|Python Files (*.py)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "导出文件";
            // 
            // tmrMessage
            // 
            this.tmrMessage.Interval = 800;
            this.tmrMessage.Tick += new System.EventHandler(this.tmrMessage_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(589, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://付坤.中国";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 735);
            this.Controls.Add(this.mainSplitter);
            this.Controls.Add(this.pnlToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ampy File Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainSplitter.Panel1.ResumeLayout(false);
            this.mainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).EndInit();
            this.mainSplitter.ResumeLayout(false);
            this.pnlPathStatus.ResumeLayout(false);
            this.pnlPathStatus.PerformLayout();
            this.pnlPathTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlSaveMessage.ResumeLayout(false);
            this.pnlSaveMessage.PerformLayout();
            this.pnlFileStatus.ResumeLayout(false);
            this.pnlFileStatus.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.pnlFileToolbar.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.SplitContainer mainSplitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMkdir;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnREPL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboHelp;
        private System.Windows.Forms.Panel pnlFileToolbar;
        private System.Windows.Forms.Panel pnlPathTop;
        private System.Windows.Forms.Label lblCurrentDirectory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lstDirectory;
        private System.Windows.Forms.Panel pnlPathStatus;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.Panel pnlFileStatus;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFolderCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSaveMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrMessage;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBackupScript;
        private System.Windows.Forms.Button btnRestoreScript;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}