namespace TekScopeIVITest
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
            this.button1 = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tek_lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tek_lbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tek_lbl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Record Legnth?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(98, 194);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(56, 19);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 134);
            this.listBox1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tek_lbl1,
            this.tek_lbl2,
            this.tek_lbl3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(401, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tek_lbl1
            // 
            this.tek_lbl1.Name = "tek_lbl1";
            this.tek_lbl1.Size = new System.Drawing.Size(29, 17);
            this.tek_lbl1.Text = "tek1";
            // 
            // tek_lbl2
            // 
            this.tek_lbl2.Name = "tek_lbl2";
            this.tek_lbl2.Size = new System.Drawing.Size(29, 17);
            this.tek_lbl2.Text = "tek2";
            // 
            // tek_lbl3
            // 
            this.tek_lbl3.Name = "tek_lbl3";
            this.tek_lbl3.Size = new System.Drawing.Size(29, 17);
            this.tek_lbl3.Text = "tek3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 241);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TekSCopeIVITest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tek_lbl1;
        private System.Windows.Forms.ToolStripStatusLabel tek_lbl2;
        private System.Windows.Forms.ToolStripStatusLabel tek_lbl3;
    }
}

