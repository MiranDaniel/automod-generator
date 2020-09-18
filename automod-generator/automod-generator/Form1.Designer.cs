namespace automod_generator
{
    partial class Form1
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
            this.boxType = new System.Windows.Forms.GroupBox();
            this.listType = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCase = new System.Windows.Forms.CheckBox();
            this.boxFind = new System.Windows.Forms.RichTextBox();
            this.checkRegex = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.actionList = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.boxReason = new System.Windows.Forms.RichTextBox();
            this.checkReason = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.moreactionList = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addList = new System.Windows.Forms.CheckedListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.standardList = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.userisList = new System.Windows.Forms.CheckedListBox();
            this.ifNotButton = new System.Windows.Forms.Button();
            this.ifButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.clroutButton = new System.Windows.Forms.Button();
            this.clrselButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.repoButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.contactButton = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.debugButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.modifierButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boxType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxType
            // 
            this.boxType.Controls.Add(this.listType);
            this.boxType.Location = new System.Drawing.Point(3, 3);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(139, 90);
            this.boxType.TabIndex = 0;
            this.boxType.TabStop = false;
            this.boxType.Text = "Type";
            // 
            // listType
            // 
            this.listType.FormattingEnabled = true;
            this.listType.Location = new System.Drawing.Point(6, 19);
            this.listType.Name = "listType";
            this.listType.Size = new System.Drawing.Size(120, 64);
            this.listType.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkList);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 154);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Checks";
            // 
            // checkList
            // 
            this.checkList.CausesValidation = false;
            this.checkList.CheckOnClick = true;
            this.checkList.FormattingEnabled = true;
            this.checkList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.checkList.Location = new System.Drawing.Point(6, 19);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(195, 124);
            this.checkList.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCase);
            this.groupBox1.Controls.Add(this.boxFind);
            this.groupBox1.Controls.Add(this.checkRegex);
            this.groupBox1.Location = new System.Drawing.Point(211, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Checks Regex";
            // 
            // checkCase
            // 
            this.checkCase.AutoSize = true;
            this.checkCase.Location = new System.Drawing.Point(69, 19);
            this.checkCase.Name = "checkCase";
            this.checkCase.Size = new System.Drawing.Size(96, 17);
            this.checkCase.TabIndex = 3;
            this.checkCase.Text = "Case Sensitive";
            this.checkCase.UseVisualStyleBackColor = true;
            // 
            // boxFind
            // 
            this.boxFind.Location = new System.Drawing.Point(6, 42);
            this.boxFind.Name = "boxFind";
            this.boxFind.Size = new System.Drawing.Size(303, 101);
            this.boxFind.TabIndex = 2;
            this.boxFind.Text = "";
            // 
            // checkRegex
            // 
            this.checkRegex.AutoSize = true;
            this.checkRegex.Location = new System.Drawing.Point(6, 19);
            this.checkRegex.Name = "checkRegex";
            this.checkRegex.Size = new System.Drawing.Size(57, 17);
            this.checkRegex.TabIndex = 2;
            this.checkRegex.Text = "Regex";
            this.checkRegex.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Dock = System.Windows.Forms.DockStyle.Top;
            this.output.Location = new System.Drawing.Point(0, 0);
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.output.Size = new System.Drawing.Size(1062, 275);
            this.output.TabIndex = 2;
            this.output.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.actionList);
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // actionList
            // 
            this.actionList.CausesValidation = false;
            this.actionList.CheckOnClick = true;
            this.actionList.FormattingEnabled = true;
            this.actionList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.actionList.Location = new System.Drawing.Point(6, 19);
            this.actionList.Name = "actionList";
            this.actionList.Size = new System.Drawing.Size(120, 124);
            this.actionList.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.boxReason);
            this.groupBox4.Controls.Add(this.checkReason);
            this.groupBox4.Location = new System.Drawing.Point(147, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 154);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action reasons";
            // 
            // boxReason
            // 
            this.boxReason.Location = new System.Drawing.Point(6, 42);
            this.boxReason.Name = "boxReason";
            this.boxReason.Size = new System.Drawing.Size(303, 101);
            this.boxReason.TabIndex = 2;
            this.boxReason.Text = "";
            // 
            // checkReason
            // 
            this.checkReason.AutoSize = true;
            this.checkReason.Location = new System.Drawing.Point(6, 19);
            this.checkReason.Name = "checkReason";
            this.checkReason.Size = new System.Drawing.Size(128, 17);
            this.checkReason.TabIndex = 2;
            this.checkReason.Text = "Action/Report reason";
            this.checkReason.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.moreactionList);
            this.groupBox5.Location = new System.Drawing.Point(3, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 163);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sets";
            // 
            // moreactionList
            // 
            this.moreactionList.CausesValidation = false;
            this.moreactionList.CheckOnClick = true;
            this.moreactionList.FormattingEnabled = true;
            this.moreactionList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.moreactionList.Location = new System.Drawing.Point(6, 19);
            this.moreactionList.Name = "moreactionList";
            this.moreactionList.Size = new System.Drawing.Size(120, 124);
            this.moreactionList.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.addList);
            this.groupBox6.Location = new System.Drawing.Point(3, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(139, 90);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Modifiers";
            // 
            // addList
            // 
            this.addList.CheckOnClick = true;
            this.addList.FormattingEnabled = true;
            this.addList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.addList.Location = new System.Drawing.Point(6, 19);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(120, 64);
            this.addList.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.standardList);
            this.groupBox7.Location = new System.Drawing.Point(3, 163);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(207, 154);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Standards";
            // 
            // standardList
            // 
            this.standardList.CausesValidation = false;
            this.standardList.CheckOnClick = true;
            this.standardList.FormattingEnabled = true;
            this.standardList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.standardList.Location = new System.Drawing.Point(6, 19);
            this.standardList.Name = "standardList";
            this.standardList.Size = new System.Drawing.Size(195, 124);
            this.standardList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.ifNotButton);
            this.panel1.Controls.Add(this.ifButton);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(302, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 375);
            this.panel1.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.userisList);
            this.groupBox8.Location = new System.Drawing.Point(211, 163);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(207, 154);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "User Checks";
            // 
            // userisList
            // 
            this.userisList.CausesValidation = false;
            this.userisList.CheckOnClick = true;
            this.userisList.FormattingEnabled = true;
            this.userisList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.userisList.Location = new System.Drawing.Point(6, 19);
            this.userisList.Name = "userisList";
            this.userisList.Size = new System.Drawing.Size(195, 124);
            this.userisList.TabIndex = 2;
            // 
            // ifNotButton
            // 
            this.ifNotButton.Location = new System.Drawing.Point(3, 343);
            this.ifNotButton.Name = "ifNotButton";
            this.ifNotButton.Size = new System.Drawing.Size(75, 23);
            this.ifNotButton.TabIndex = 5;
            this.ifNotButton.Text = "IF NOT";
            this.ifNotButton.UseVisualStyleBackColor = true;
            this.ifNotButton.Click += new System.EventHandler(this.ifNotButton_Click);
            // 
            // ifButton
            // 
            this.ifButton.Location = new System.Drawing.Point(3, 323);
            this.ifButton.Name = "ifButton";
            this.ifButton.Size = new System.Drawing.Size(75, 23);
            this.ifButton.TabIndex = 4;
            this.ifButton.Text = "IF";
            this.ifButton.UseVisualStyleBackColor = true;
            this.ifButton.Click += new System.EventHandler(this.ifButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.actionButton);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(835, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 375);
            this.panel2.TabIndex = 7;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(3, 343);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "ADD ";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Condition maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(835, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Action maker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Controls.Add(this.clroutButton);
            this.panel3.Controls.Add(this.clrselButton);
            this.panel3.Controls.Add(this.resetButton);
            this.panel3.Controls.Add(this.output);
            this.panel3.Location = new System.Drawing.Point(302, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 304);
            this.panel3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(22, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(712, 55);
            this.label6.TabIndex = 16;
            this.label6.Text = "DEBUGGING MODE ENABLED";
            this.label6.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(757, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(305, 275);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // clroutButton
            // 
            this.clroutButton.Location = new System.Drawing.Point(533, 278);
            this.clroutButton.Name = "clroutButton";
            this.clroutButton.Size = new System.Drawing.Size(529, 23);
            this.clroutButton.TabIndex = 14;
            this.clroutButton.Text = "Clear Output";
            this.clroutButton.UseVisualStyleBackColor = true;
            this.clroutButton.Click += new System.EventHandler(this.clroutButton_Click);
            // 
            // clrselButton
            // 
            this.clrselButton.Location = new System.Drawing.Point(0, 278);
            this.clrselButton.Name = "clrselButton";
            this.clrselButton.Size = new System.Drawing.Size(529, 23);
            this.clrselButton.TabIndex = 13;
            this.clrselButton.Text = "Clear Selection";
            this.clrselButton.UseVisualStyleBackColor = true;
            this.clrselButton.Click += new System.EventHandler(this.clrselButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(643, 23);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset Memory";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.boxType);
            this.panel4.Location = new System.Drawing.Point(8, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 101);
            this.panel4.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(296, 44);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Created by u/mirandanielcz\nVersion: 0.0.2 beta\nMade with love and C#\n\n\n\n";
            // 
            // repoButton
            // 
            this.repoButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repoButton.Location = new System.Drawing.Point(0, 42);
            this.repoButton.Name = "repoButton";
            this.repoButton.Size = new System.Drawing.Size(75, 40);
            this.repoButton.TabIndex = 17;
            this.repoButton.Text = "Open Repository\r\n";
            this.repoButton.UseVisualStyleBackColor = true;
            this.repoButton.Click += new System.EventHandler(this.repoButton_Click);
            // 
            // feedbackButton
            // 
            this.feedbackButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feedbackButton.Location = new System.Drawing.Point(75, 42);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(75, 42);
            this.feedbackButton.TabIndex = 18;
            this.feedbackButton.Text = "Report issue/bug";
            this.feedbackButton.UseVisualStyleBackColor = true;
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
            // 
            // contactButton
            // 
            this.contactButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contactButton.Location = new System.Drawing.Point(217, -11);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(75, 40);
            this.contactButton.TabIndex = 19;
            this.contactButton.Text = "Contact dev";
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.button1);
            this.infoPanel.Controls.Add(this.debugButton);
            this.infoPanel.Controls.Add(this.richTextBox1);
            this.infoPanel.Controls.Add(this.repoButton);
            this.infoPanel.Controls.Add(this.feedbackButton);
            this.infoPanel.Controls.Add(this.contactButton);
            this.infoPanel.Location = new System.Drawing.Point(0, 641);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(296, 82);
            this.infoPanel.TabIndex = 21;
            // 
            // debugButton
            // 
            this.debugButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.debugButton.Location = new System.Drawing.Point(225, 43);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 42);
            this.debugButton.TabIndex = 20;
            this.debugButton.Text = "Toggle DEBUG";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.modifierButton);
            this.panel5.Controls.Add(this.groupBox6);
            this.panel5.Location = new System.Drawing.Point(8, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 245);
            this.panel5.TabIndex = 12;
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(3, 213);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(75, 23);
            this.modifierButton.TabIndex = 7;
            this.modifierButton.Text = "ADD ";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Modifiers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.settings);
            this.panel6.Location = new System.Drawing.Point(8, 435);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 200);
            this.panel6.TabIndex = 24;
            // 
            // settings
            // 
            this.settings.CheckOnClick = true;
            this.settings.FormattingEnabled = true;
            this.settings.ImeMode = System.Windows.Forms.ImeMode.On;
            this.settings.Location = new System.Drawing.Point(3, 8);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(280, 169);
            this.settings.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Settings";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(150, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Contact dev";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1386, 760);
            this.MinimumSize = new System.Drawing.Size(1386, 760);
            this.Name = "Form1";
            this.Text = "Reddit Automoderator Generator beta0.0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxType.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxType;
        private System.Windows.Forms.CheckedListBox listType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkRegex;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.RichTextBox boxFind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox actionList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox boxReason;
        private System.Windows.Forms.CheckBox checkReason;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox moreactionList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox addList;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox standardList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckedListBox userisList;
        private System.Windows.Forms.Button ifNotButton;
        private System.Windows.Forms.Button ifButton;
        private System.Windows.Forms.CheckBox checkCase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button repoButton;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox settings;
        private System.Windows.Forms.Button clroutButton;
        private System.Windows.Forms.Button clrselButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button button1;
    }
}