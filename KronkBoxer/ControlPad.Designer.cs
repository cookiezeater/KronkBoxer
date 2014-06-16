namespace KronkBoxer
{
    partial class ControlPad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPad));
            this.tmrSS = new System.Windows.Forms.Timer(this.components);
            this.pbxClient = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lstClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClient)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSS
            // 
            this.tmrSS.Enabled = true;
            this.tmrSS.Interval = 1;
            this.tmrSS.Tick += new System.EventHandler(this.tmrSS_Tick);
            // 
            // pbxClient
            // 
            this.pbxClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClient.Location = new System.Drawing.Point(-1, 25);
            this.pbxClient.Name = "pbxClient";
            this.pbxClient.Size = new System.Drawing.Size(385, 237);
            this.pbxClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClient.TabIndex = 0;
            this.pbxClient.TabStop = false;
            this.pbxClient.Click += new System.EventHandler(this.pbxClient_Click);
            this.pbxClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxClient_MouseDown);
            this.pbxClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxClient_MouseMove);
            this.pbxClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxClient_MouseUp);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Gray;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.numRefreshRate);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lstClients);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(384, 26);
            this.pnlHeader.TabIndex = 3;
            // 
            // lstClients
            // 
            this.lstClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClients.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(31, 2);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(63, 19);
            this.lstClients.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "View";
            // 
            // numRefreshRate
            // 
            this.numRefreshRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numRefreshRate.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.numRefreshRate.Location = new System.Drawing.Point(346, 3);
            this.numRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRefreshRate.Name = "numRefreshRate";
            this.numRefreshRate.Size = new System.Drawing.Size(34, 18);
            this.numRefreshRate.TabIndex = 7;
            this.numRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRefreshRate.ValueChanged += new System.EventHandler(this.numRefreshRate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(275, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Frame Delay";
            // 
            // ControlPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pbxClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(230, 170);
            this.Name = "ControlPad";
            this.Opacity = 0.9D;
            this.Text = "ControlPad";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPad_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlPad_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControlPad_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClient)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSS;
        private System.Windows.Forms.PictureBox pbxClient;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRefreshRate;
        private System.Windows.Forms.ComboBox lstClients;
        private System.Windows.Forms.Label label1;
    }
}