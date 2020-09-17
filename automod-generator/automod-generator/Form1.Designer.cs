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
            this.boxFind = new System.Windows.Forms.RichTextBox();
            this.checkRegex = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.userisList = new System.Windows.Forms.CheckedListBox();
            this.checkCase = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.SuspendLayout();
            // 
            // boxType
            // 
            this.boxType.Controls.Add(this.listType);
            this.boxType.Location = new System.Drawing.Point(12, 12);
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
            this.listType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listType_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkList);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 154);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            this.groupBox1.Text = "groupBox1";
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1062, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.actionList);
            this.groupBox3.Location = new System.Drawing.Point(3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
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
            this.groupBox4.Text = "groupBox4";
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
            this.groupBox5.Text = "groupBox5";
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
            this.groupBox6.Location = new System.Drawing.Point(157, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(139, 90);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Type";
            // 
            // addList
            // 
            this.addList.FormattingEnabled = true;
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
            this.groupBox7.Text = "groupBox7";
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
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(302, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 375);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "IF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "IF NOT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.userisList);
            this.groupBox8.Location = new System.Drawing.Point(211, 163);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(207, 154);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(835, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 375);
            this.panel2.TabIndex = 7;
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
            this.panel3.Controls.Add(this.output);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(302, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 304);
            this.panel3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 759);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.boxType);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkCase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}

