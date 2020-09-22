namespace automod_generator
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.versionButton = new System.Windows.Forms.Button();
            this.contactButton = new System.Windows.Forms.Button();
            this.bugButton = new System.Windows.Forms.Button();
            this.repoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.versionButton);
            this.groupBox1.Controls.Add(this.contactButton);
            this.groupBox1.Controls.Add(this.bugButton);
            this.groupBox1.Controls.Add(this.repoButton);
            this.groupBox1.Location = new System.Drawing.Point(106, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(311, 155);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Created by u/mirandanielcz\n\nContributors:\n   u/Davis_Schina\n   u/Cosmic--Ice\n";
            // 
            // versionButton
            // 
            this.versionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.versionButton.Location = new System.Drawing.Point(3, 177);
            this.versionButton.Name = "versionButton";
            this.versionButton.Size = new System.Drawing.Size(311, 23);
            this.versionButton.TabIndex = 3;
            this.versionButton.Text = "Download new version";
            this.versionButton.UseVisualStyleBackColor = true;
            this.versionButton.Click += new System.EventHandler(this.versionButton_Click);
            // 
            // contactButton
            // 
            this.contactButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactButton.Location = new System.Drawing.Point(3, 200);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(311, 23);
            this.contactButton.TabIndex = 2;
            this.contactButton.Text = "Contact developer";
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // bugButton
            // 
            this.bugButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bugButton.Location = new System.Drawing.Point(3, 223);
            this.bugButton.Name = "bugButton";
            this.bugButton.Size = new System.Drawing.Size(311, 23);
            this.bugButton.TabIndex = 1;
            this.bugButton.Text = "Report bug";
            this.bugButton.UseVisualStyleBackColor = true;
            this.bugButton.Click += new System.EventHandler(this.bugButton_Click);
            // 
            // repoButton
            // 
            this.repoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.repoButton.Location = new System.Drawing.Point(3, 246);
            this.repoButton.Name = "repoButton";
            this.repoButton.Size = new System.Drawing.Size(311, 23);
            this.repoButton.TabIndex = 0;
            this.repoButton.Text = "Open Repository";
            this.repoButton.UseVisualStyleBackColor = true;
            this.repoButton.Click += new System.EventHandler(this.repoButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 212);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(95, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Join\r\nour\r\nDiscord\r\nserver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 272);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "beta0.0.4\r\n\r\n(22.09.2020)\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button repoButton;
        private System.Windows.Forms.Button bugButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button versionButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
