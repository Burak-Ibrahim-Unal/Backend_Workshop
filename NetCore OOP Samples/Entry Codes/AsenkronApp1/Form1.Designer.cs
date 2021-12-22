namespace AsenkronApp1
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
            this.btnReadTxt = new System.Windows.Forms.Button();
            this.richTextBoxTxt = new System.Windows.Forms.RichTextBox();
            this.btnCounter = new System.Windows.Forms.Button();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnReadTxt
            // 
            this.btnReadTxt.Location = new System.Drawing.Point(38, 12);
            this.btnReadTxt.Name = "btnReadTxt";
            this.btnReadTxt.Size = new System.Drawing.Size(91, 43);
            this.btnReadTxt.TabIndex = 0;
            this.btnReadTxt.Text = "Read";
            this.btnReadTxt.UseVisualStyleBackColor = true;
            this.btnReadTxt.Click += new System.EventHandler(this.btnReadTxt_Click);
            // 
            // richTextBoxTxt
            // 
            this.richTextBoxTxt.Location = new System.Drawing.Point(12, 70);
            this.richTextBoxTxt.Name = "richTextBoxTxt";
            this.richTextBoxTxt.Size = new System.Drawing.Size(154, 106);
            this.richTextBoxTxt.TabIndex = 1;
            this.richTextBoxTxt.Text = "";
            // 
            // btnCounter
            // 
            this.btnCounter.Location = new System.Drawing.Point(223, 21);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(91, 43);
            this.btnCounter.TabIndex = 0;
            this.btnCounter.Text = "Counter";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(223, 105);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.Size = new System.Drawing.Size(91, 22);
            this.textBoxCounter.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(392, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(158, 106);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 215);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.richTextBoxTxt);
            this.Controls.Add(this.btnCounter);
            this.Controls.Add(this.btnReadTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadTxt;
        private System.Windows.Forms.RichTextBox richTextBoxTxt;
        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

