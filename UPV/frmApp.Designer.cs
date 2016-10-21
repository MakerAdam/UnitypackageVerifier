namespace UPV
{
    partial class frmApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlYeah = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblUnityVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pnlSup = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.pnlNope = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlYeah.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNope.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // pnlYeah
            // 
            this.pnlYeah.Controls.Add(this.panel3);
            this.pnlYeah.Controls.Add(this.pictureBox2);
            this.pnlYeah.Location = new System.Drawing.Point(15, 30);
            this.pnlYeah.Name = "pnlYeah";
            this.pnlYeah.Size = new System.Drawing.Size(508, 216);
            this.pnlYeah.TabIndex = 4;
            this.pnlYeah.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAuthor);
            this.panel3.Controls.Add(this.lblUnityVersion);
            this.panel3.Controls.Add(this.lblVersion);
            this.panel3.Controls.Add(this.lblAssetName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(175, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 201);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "This is a valid Unity Asset Store Package!  Here some details ; ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(2, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "YEY !";
            // 
            // lblAssetName
            // 
            this.lblAssetName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetName.Location = new System.Drawing.Point(5, 100);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(311, 22);
            this.lblAssetName.TabIndex = 2;
            this.lblAssetName.Text = "[Asset Name]";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(5, 145);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(311, 22);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "[Version: 1234]";
            // 
            // lblUnityVersion
            // 
            this.lblUnityVersion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnityVersion.Location = new System.Drawing.Point(5, 167);
            this.lblUnityVersion.Name = "lblUnityVersion";
            this.lblUnityVersion.Size = new System.Drawing.Size(311, 22);
            this.lblUnityVersion.TabIndex = 4;
            this.lblUnityVersion.Text = "[Unity Version: 5.0.2]";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(5, 123);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(311, 22);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "[Author  Name]";
            // 
            // pnlSup
            // 
            this.pnlSup.Controls.Add(this.label5);
            this.pnlSup.Location = new System.Drawing.Point(0, 30);
            this.pnlSup.Name = "pnlSup";
            this.pnlSup.Size = new System.Drawing.Size(523, 223);
            this.pnlSup.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 223);
            this.label5.TabIndex = 1;
            this.label5.Text = "Drag a unitypackage file here...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UPV.Properties.Resources.ic_checkmark;
            this.pictureBox2.InitialImage = global::UPV.Properties.Resources.ic_checkmark;
            this.pictureBox2.Location = new System.Drawing.Point(3, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPV.Properties.Resources.ic_cross;
            this.pictureBox1.InitialImage = global::UPV.Properties.Resources.ic_cross;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHeader);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(175, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 212);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORRY :(";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 164);
            this.label2.TabIndex = 1;
            this.label2.Text = "This package is not valid Unity Asset Store package!";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 54);
            this.label6.TabIndex = 2;
            this.label6.Text = "However, there\'s a slight chance to this tool may fail. So here a cunk of the hea" +
    "der. If you see json stuff inside, probably it is good package and this tool fai" +
    "led. \r\nWell, shit happens...";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(7, 150);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHeader.Size = new System.Drawing.Size(314, 62);
            this.txtHeader.TabIndex = 2;
            // 
            // pnlNope
            // 
            this.pnlNope.Controls.Add(this.panel1);
            this.pnlNope.Controls.Add(this.pictureBox1);
            this.pnlNope.Location = new System.Drawing.Point(15, 30);
            this.pnlNope.Name = "pnlNope";
            this.pnlNope.Size = new System.Drawing.Size(508, 233);
            this.pnlNope.TabIndex = 3;
            this.pnlNope.Visible = false;
            // 
            // frmApp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 261);
            this.Controls.Add(this.pnlNope);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlSup);
            this.Controls.Add(this.pnlYeah);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".unitypackage Verifier";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmApp_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmApp_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlYeah.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNope.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlYeah;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUnityVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Panel pnlSup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNope;
    }
}

