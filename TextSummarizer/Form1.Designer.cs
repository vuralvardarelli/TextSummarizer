
namespace TextSummarizer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerTextBox = new System.Windows.Forms.TextBox();
            this.bodyTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.summarizeButton = new System.Windows.Forms.Button();
            this.summaryTextBox = new System.Windows.Forms.RichTextBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Header of Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body of Text";
            // 
            // headerTextBox
            // 
            this.headerTextBox.Location = new System.Drawing.Point(61, 34);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(383, 20);
            this.headerTextBox.TabIndex = 2;
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(61, 96);
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(557, 172);
            this.bodyTextBox.TabIndex = 3;
            this.bodyTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Summary";
            // 
            // summarizeButton
            // 
            this.summarizeButton.Location = new System.Drawing.Point(299, 286);
            this.summarizeButton.Name = "summarizeButton";
            this.summarizeButton.Size = new System.Drawing.Size(75, 23);
            this.summarizeButton.TabIndex = 5;
            this.summarizeButton.Text = "Summarize";
            this.summarizeButton.UseVisualStyleBackColor = true;
            this.summarizeButton.Click += new System.EventHandler(this.summarizeButton_Click);
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Enabled = false;
            this.summaryTextBox.Location = new System.Drawing.Point(61, 353);
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(557, 147);
            this.summaryTextBox.TabIndex = 6;
            this.summaryTextBox.Text = "";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(299, 512);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 547);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.summarizeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Summarizer!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headerTextBox;
        private System.Windows.Forms.RichTextBox bodyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button summarizeButton;
        public System.Windows.Forms.RichTextBox summaryTextBox;
        private System.Windows.Forms.Button restartButton;
    }
}

