namespace ToastlerBingo
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
            this.generateBtn = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.tableNumberTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(177, 12);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(102, 71);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generate Random Bingo Sheet";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(11, 27);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(153, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Number of Tables to Generate:";
            // 
            // tableNumberTxtBox
            // 
            this.tableNumberTxtBox.Location = new System.Drawing.Point(12, 44);
            this.tableNumberTxtBox.Name = "tableNumberTxtBox";
            this.tableNumberTxtBox.Size = new System.Drawing.Size(152, 20);
            this.tableNumberTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 94);
            this.Controls.Add(this.tableNumberTxtBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.generateBtn);
            this.Name = "Form1";
            this.Text = "Bingo Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox tableNumberTxtBox;
    }
}

