using System;

namespace TekScopeIVITest
{
    partial class TekOscopeData
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tekInfoLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tekInfoLbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tekInfoLbl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ch1CheckBox = new System.Windows.Forms.CheckBox();
            this.ch2CheckBox = new System.Windows.Forms.CheckBox();
            this.ch3CheckBox = new System.Windows.Forms.CheckBox();
            this.ch4CheckBox = new System.Windows.Forms.CheckBox();
            this.chGroupBox = new System.Windows.Forms.GroupBox();
            this.setupBtn = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.TextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.tmRead = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.chGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(357, 11);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(93, 24);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(357, 39);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(93, 27);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 56);
            this.listBox1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekInfoLbl1,
            this.tekInfoLbl2,
            this.tekInfoLbl3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(465, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tekInfoLbl1
            // 
            this.tekInfoLbl1.Name = "tekInfoLbl1";
            this.tekInfoLbl1.Size = new System.Drawing.Size(29, 17);
            this.tekInfoLbl1.Text = "tek1";
            // 
            // tekInfoLbl2
            // 
            this.tekInfoLbl2.Name = "tekInfoLbl2";
            this.tekInfoLbl2.Size = new System.Drawing.Size(29, 17);
            this.tekInfoLbl2.Text = "tek2";
            // 
            // tekInfoLbl3
            // 
            this.tekInfoLbl3.Name = "tekInfoLbl3";
            this.tekInfoLbl3.Size = new System.Drawing.Size(29, 17);
            this.tekInfoLbl3.Text = "tek3";
            // 
            // ch1CheckBox
            // 
            this.ch1CheckBox.AutoSize = true;
            this.ch1CheckBox.Checked = true;
            this.ch1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch1CheckBox.Location = new System.Drawing.Point(4, 19);
            this.ch1CheckBox.Name = "ch1CheckBox";
            this.ch1CheckBox.Size = new System.Drawing.Size(47, 17);
            this.ch1CheckBox.TabIndex = 4;
            this.ch1CheckBox.Text = "CH1";
            this.ch1CheckBox.UseVisualStyleBackColor = true;
            this.ch1CheckBox.CheckedChanged += new System.EventHandler(this.ch1CheckBox_CheckedChanged);
            // 
            // ch2CheckBox
            // 
            this.ch2CheckBox.AutoSize = true;
            this.ch2CheckBox.Location = new System.Drawing.Point(59, 19);
            this.ch2CheckBox.Name = "ch2CheckBox";
            this.ch2CheckBox.Size = new System.Drawing.Size(47, 17);
            this.ch2CheckBox.TabIndex = 5;
            this.ch2CheckBox.Text = "CH2";
            this.ch2CheckBox.UseVisualStyleBackColor = true;
            this.ch2CheckBox.CheckedChanged += new System.EventHandler(this.ch2CheckBox_CheckedChanged);
            // 
            // ch3CheckBox
            // 
            this.ch3CheckBox.AutoSize = true;
            this.ch3CheckBox.Location = new System.Drawing.Point(112, 19);
            this.ch3CheckBox.Name = "ch3CheckBox";
            this.ch3CheckBox.Size = new System.Drawing.Size(47, 17);
            this.ch3CheckBox.TabIndex = 6;
            this.ch3CheckBox.Text = "CH3";
            this.ch3CheckBox.UseVisualStyleBackColor = true;
            this.ch3CheckBox.CheckedChanged += new System.EventHandler(this.ch3CheckBox_CheckedChanged);
            // 
            // ch4CheckBox
            // 
            this.ch4CheckBox.AutoSize = true;
            this.ch4CheckBox.Location = new System.Drawing.Point(165, 19);
            this.ch4CheckBox.Name = "ch4CheckBox";
            this.ch4CheckBox.Size = new System.Drawing.Size(47, 17);
            this.ch4CheckBox.TabIndex = 7;
            this.ch4CheckBox.Text = "CH4";
            this.ch4CheckBox.UseVisualStyleBackColor = true;
            this.ch4CheckBox.CheckedChanged += new System.EventHandler(this.ch4CheckBox_CheckedChanged);
            // 
            // chGroupBox
            // 
            this.chGroupBox.Controls.Add(this.ch2CheckBox);
            this.chGroupBox.Controls.Add(this.ch1CheckBox);
            this.chGroupBox.Controls.Add(this.ch4CheckBox);
            this.chGroupBox.Controls.Add(this.ch3CheckBox);
            this.chGroupBox.Location = new System.Drawing.Point(12, 71);
            this.chGroupBox.Name = "chGroupBox";
            this.chGroupBox.Size = new System.Drawing.Size(219, 51);
            this.chGroupBox.TabIndex = 8;
            this.chGroupBox.TabStop = false;
            this.chGroupBox.Text = "Channel On/Off";
            // 
            // setupBtn
            // 
            this.setupBtn.Location = new System.Drawing.Point(237, 69);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(116, 51);
            this.setupBtn.TabIndex = 8;
            this.setupBtn.Text = "Setup for Measurement";
            this.setupBtn.UseVisualStyleBackColor = true;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.SystemColors.InfoText;
            this.infoText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.ForeColor = System.Drawing.Color.LimeGreen;
            this.infoText.Location = new System.Drawing.Point(0, 126);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoText.Size = new System.Drawing.Size(465, 57);
            this.infoText.TabIndex = 9;
//            this.infoText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(357, 69);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(93, 51);
            this.readBtn.TabIndex = 10;
            this.readBtn.Text = "Start Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // tmRead
            // 
            this.tmRead.Interval = 500;
            this.tmRead.Tick += new System.EventHandler(this.tmRead_Tick);
            // 
            // TekOscopeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 205);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.setupBtn);
            this.Controls.Add(this.chGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TekOscopeData";
            this.Text = "TekScopeIVITest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.chGroupBox.ResumeLayout(false);
            this.chGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

//        private void textBox1_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tekInfoLbl1;
        private System.Windows.Forms.ToolStripStatusLabel tekInfoLbl2;
        private System.Windows.Forms.ToolStripStatusLabel tekInfoLbl3;
        private System.Windows.Forms.CheckBox ch1CheckBox;
        private System.Windows.Forms.CheckBox ch2CheckBox;
        private System.Windows.Forms.CheckBox ch3CheckBox;
        private System.Windows.Forms.CheckBox ch4CheckBox;
        private System.Windows.Forms.GroupBox chGroupBox;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Timer tmRead;

        public EventHandler textBox1_TextChanged { get; private set; }
    }
}

