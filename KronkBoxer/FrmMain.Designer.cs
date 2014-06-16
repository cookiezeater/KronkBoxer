namespace KronkBoxer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitTop = new System.Windows.Forms.SplitContainer();
            this.splitBottom = new System.Windows.Forms.SplitContainer();
            this.stsBottom = new System.Windows.Forms.StatusStrip();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tbxMainPlayer = new System.Windows.Forms.TextBox();
            this.lblTPCountdown = new System.Windows.Forms.Label();
            this.chkAutoTeleport = new System.Windows.Forms.CheckBox();
            this.btnConfigKeys = new System.Windows.Forms.Button();
            this.numClients = new System.Windows.Forms.NumericUpDown();
            this.btnToggle = new System.Windows.Forms.Button();
            this.imlToggle = new System.Windows.Forms.ImageList(this.components);
            this.lblPerformance = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrChecker = new System.Windows.Forms.Timer(this.components);
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lstTPAllKey = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbxKeysToSend = new System.Windows.Forms.TextBox();
            this.lstKeys = new System.Windows.Forms.ComboBox();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxClientPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKeysInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).BeginInit();
            this.splitTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBottom)).BeginInit();
            this.splitBottom.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClients)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.BackColor = System.Drawing.Color.DimGray;
            this.splitMain.Location = new System.Drawing.Point(0, 39);
            this.splitMain.Name = "splitMain";
            this.splitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitTop);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitBottom);
            this.splitMain.Size = new System.Drawing.Size(784, 500);
            this.splitMain.SplitterDistance = 247;
            this.splitMain.TabIndex = 0;
            // 
            // splitTop
            // 
            this.splitTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTop.Location = new System.Drawing.Point(0, 0);
            this.splitTop.Name = "splitTop";
            // 
            // splitTop.Panel1
            // 
            this.splitTop.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // splitTop.Panel2
            // 
            this.splitTop.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitTop.Size = new System.Drawing.Size(784, 247);
            this.splitTop.SplitterDistance = 390;
            this.splitTop.TabIndex = 3;
            // 
            // splitBottom
            // 
            this.splitBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBottom.Location = new System.Drawing.Point(0, 0);
            this.splitBottom.Name = "splitBottom";
            // 
            // splitBottom.Panel1
            // 
            this.splitBottom.Panel1.BackColor = System.Drawing.Color.Silver;
            // 
            // splitBottom.Panel2
            // 
            this.splitBottom.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitBottom.Size = new System.Drawing.Size(784, 249);
            this.splitBottom.SplitterDistance = 390;
            this.splitBottom.TabIndex = 4;
            // 
            // stsBottom
            // 
            this.stsBottom.Location = new System.Drawing.Point(0, 539);
            this.stsBottom.Name = "stsBottom";
            this.stsBottom.Size = new System.Drawing.Size(784, 22);
            this.stsBottom.TabIndex = 1;
            this.stsBottom.Text = "statusStrip1";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.Gray;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.tbxMainPlayer);
            this.pnlHeader.Controls.Add(this.lblTPCountdown);
            this.pnlHeader.Controls.Add(this.chkAutoTeleport);
            this.pnlHeader.Controls.Add(this.btnConfigKeys);
            this.pnlHeader.Controls.Add(this.numClients);
            this.pnlHeader.Controls.Add(this.btnToggle);
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(786, 39);
            this.pnlHeader.TabIndex = 2;
            // 
            // tbxMainPlayer
            // 
            this.tbxMainPlayer.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMainPlayer.Location = new System.Drawing.Point(236, 3);
            this.tbxMainPlayer.Name = "tbxMainPlayer";
            this.tbxMainPlayer.Size = new System.Drawing.Size(67, 18);
            this.tbxMainPlayer.TabIndex = 7;
            this.tbxMainPlayer.TabStop = false;
            this.tbxMainPlayer.Text = "PlayerName";
            // 
            // lblTPCountdown
            // 
            this.lblTPCountdown.AutoSize = true;
            this.lblTPCountdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTPCountdown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTPCountdown.Location = new System.Drawing.Point(122, 19);
            this.lblTPCountdown.Name = "lblTPCountdown";
            this.lblTPCountdown.Size = new System.Drawing.Size(126, 15);
            this.lblTPCountdown.TabIndex = 10;
            this.lblTPCountdown.Text = "Able to teleport in 10...";
            // 
            // chkAutoTeleport
            // 
            this.chkAutoTeleport.AutoSize = true;
            this.chkAutoTeleport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkAutoTeleport.Location = new System.Drawing.Point(123, 3);
            this.chkAutoTeleport.Name = "chkAutoTeleport";
            this.chkAutoTeleport.Size = new System.Drawing.Size(113, 19);
            this.chkAutoTeleport.TabIndex = 9;
            this.chkAutoTeleport.Text = "Auto teleport to:";
            this.chkAutoTeleport.UseVisualStyleBackColor = true;
            // 
            // btnConfigKeys
            // 
            this.btnConfigKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfigKeys.FlatAppearance.BorderSize = 0;
            this.btnConfigKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigKeys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigKeys.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfigKeys.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigKeys.Image")));
            this.btnConfigKeys.Location = new System.Drawing.Point(717, 3);
            this.btnConfigKeys.Name = "btnConfigKeys";
            this.btnConfigKeys.Size = new System.Drawing.Size(64, 31);
            this.btnConfigKeys.TabIndex = 8;
            this.btnConfigKeys.TabStop = false;
            this.btnConfigKeys.UseVisualStyleBackColor = false;
            this.btnConfigKeys.Click += new System.EventHandler(this.btnConfigKeys_Click);
            // 
            // numClients
            // 
            this.numClients.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.numClients.Location = new System.Drawing.Point(71, 3);
            this.numClients.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClients.Name = "numClients";
            this.numClients.Size = new System.Drawing.Size(43, 32);
            this.numClients.TabIndex = 3;
            this.numClients.TabStop = false;
            this.numClients.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToggle.ImageIndex = 0;
            this.btnToggle.ImageList = this.imlToggle;
            this.btnToggle.Location = new System.Drawing.Point(3, 3);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(64, 31);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.TabStop = false;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // imlToggle
            // 
            this.imlToggle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlToggle.ImageStream")));
            this.imlToggle.TransparentColor = System.Drawing.Color.Transparent;
            this.imlToggle.Images.SetKeyName(0, "play-32.gif");
            this.imlToggle.Images.SetKeyName(1, "stop-32.gif");
            // 
            // lblPerformance
            // 
            this.lblPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformance.Location = new System.Drawing.Point(647, 543);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPerformance.Size = new System.Drawing.Size(115, 15);
            this.lblPerformance.TabIndex = 0;
            this.lblPerformance.Text = "CPU 0%  |  RAM 50%";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 543);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Stopped";
            // 
            // tmrChecker
            // 
            this.tmrChecker.Enabled = true;
            this.tmrChecker.Interval = 1000;
            this.tmrChecker.Tick += new System.EventHandler(this.tmrChecker_Tick);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.BackColor = System.Drawing.Color.Gray;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSettings.Controls.Add(this.lblKeysInfo);
            this.pnlSettings.Controls.Add(this.label5);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.lstTPAllKey);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Controls.Add(this.btnApply);
            this.pnlSettings.Controls.Add(this.tbxKeysToSend);
            this.pnlSettings.Controls.Add(this.lstKeys);
            this.pnlSettings.Controls.Add(this.btnAddKey);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.tbxClientPath);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.btnClientBrowse);
            this.pnlSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSettings.Location = new System.Drawing.Point(508, 37);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(276, 332);
            this.pnlSettings.TabIndex = 4;
            this.pnlSettings.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(34, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Teleport all clients";
            // 
            // lstTPAllKey
            // 
            this.lstTPAllKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTPAllKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTPAllKey.FormattingEnabled = true;
            this.lstTPAllKey.Location = new System.Drawing.Point(171, 193);
            this.lstTPAllKey.Name = "lstTPAllKey";
            this.lstTPAllKey.Size = new System.Drawing.Size(98, 23);
            this.lstTPAllKey.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "HotKeys:";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.DarkGray;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApply.ImageIndex = 0;
            this.btnApply.Location = new System.Drawing.Point(11, 288);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(252, 33);
            this.btnApply.TabIndex = 14;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbxKeysToSend
            // 
            this.tbxKeysToSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKeysToSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxKeysToSend.Location = new System.Drawing.Point(11, 87);
            this.tbxKeysToSend.Name = "tbxKeysToSend";
            this.tbxKeysToSend.Size = new System.Drawing.Size(252, 23);
            this.tbxKeysToSend.TabIndex = 10;
            this.tbxKeysToSend.TabStop = false;
            // 
            // lstKeys
            // 
            this.lstKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstKeys.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.Location = new System.Drawing.Point(110, 108);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(98, 23);
            this.lstKeys.TabIndex = 13;
            // 
            // btnAddKey
            // 
            this.btnAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddKey.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddKey.FlatAppearance.BorderSize = 0;
            this.btnAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKey.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddKey.ImageIndex = 0;
            this.btnAddKey.Location = new System.Drawing.Point(208, 105);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(54, 26);
            this.btnAddKey.TabIndex = 12;
            this.btnAddKey.TabStop = false;
            this.btnAddKey.Text = "Add";
            this.btnAddKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddKey.UseVisualStyleBackColor = false;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Keys to send";
            // 
            // tbxClientPath
            // 
            this.tbxClientPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxClientPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxClientPath.Location = new System.Drawing.Point(11, 11);
            this.tbxClientPath.Name = "tbxClientPath";
            this.tbxClientPath.Size = new System.Drawing.Size(252, 23);
            this.tbxClientPath.TabIndex = 7;
            this.tbxClientPath.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Client";
            // 
            // btnClientBrowse
            // 
            this.btnClientBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientBrowse.BackColor = System.Drawing.Color.DarkGray;
            this.btnClientBrowse.FlatAppearance.BorderSize = 0;
            this.btnClientBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientBrowse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientBrowse.ImageIndex = 0;
            this.btnClientBrowse.Location = new System.Drawing.Point(186, 28);
            this.btnClientBrowse.Name = "btnClientBrowse";
            this.btnClientBrowse.Size = new System.Drawing.Size(76, 26);
            this.btnClientBrowse.TabIndex = 8;
            this.btnClientBrowse.TabStop = false;
            this.btnClientBrowse.Text = "Browse";
            this.btnClientBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientBrowse.UseVisualStyleBackColor = false;
            this.btnClientBrowse.Click += new System.EventHandler(this.btnClientBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(8, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Info on keys:";
            // 
            // lblKeysInfo
            // 
            this.lblKeysInfo.AutoSize = true;
            this.lblKeysInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKeysInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(160)))));
            this.lblKeysInfo.Location = new System.Drawing.Point(77, 134);
            this.lblKeysInfo.Name = "lblKeysInfo";
            this.lblKeysInfo.Size = new System.Drawing.Size(70, 15);
            this.lblKeysInfo.TabIndex = 19;
            this.lblKeysInfo.TabStop = true;
            this.lblKeysInfo.Text = "CLICK HERE";
            this.lblKeysInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblKeysInfo_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPerformance);
            this.Controls.Add(this.stsBottom);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.Text = "KronkBoxer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTop)).EndInit();
            this.splitTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBottom)).EndInit();
            this.splitBottom.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClients)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitBottom;
        private System.Windows.Forms.SplitContainer splitTop;
        private System.Windows.Forms.StatusStrip stsBottom;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.ImageList imlToggle;
        private System.Windows.Forms.NumericUpDown numClients;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrChecker;
        private System.Windows.Forms.TextBox tbxMainPlayer;
        private System.Windows.Forms.CheckBox chkAutoTeleport;
        private System.Windows.Forms.Label lblTPCountdown;
        private System.Windows.Forms.Button btnConfigKeys;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.TextBox tbxClientPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientBrowse;
        private System.Windows.Forms.TextBox tbxKeysToSend;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lstKeys;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lstTPAllKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblKeysInfo;
        private System.Windows.Forms.Label label5;


    }
}

