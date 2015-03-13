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
            this.printBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(12, 12);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(102, 71);
            this.printBtn.TabIndex = 0;
            this.printBtn.Text = "Print Random Bingo Sheet";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 98);
            this.Controls.Add(this.printBtn);
            this.Name = "Form1";
            this.Text = "Bingo Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printBtn;
    }
}

