namespace FlePTopicReviewArrays
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
            this.btnGetNewNumbers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSmallestNumber = new System.Windows.Forms.TextBox();
            this.txtCountSmallNumb = new System.Windows.Forms.TextBox();
            this.txtArrayLocation = new System.Windows.Forms.TextBox();
            this.txtNumbers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetNewNumbers
            // 
            this.btnGetNewNumbers.Location = new System.Drawing.Point(32, 100);
            this.btnGetNewNumbers.Name = "btnGetNewNumbers";
            this.btnGetNewNumbers.Size = new System.Drawing.Size(115, 24);
            this.btnGetNewNumbers.TabIndex = 0;
            this.btnGetNewNumbers.Text = "Get New Numbers";
            this.btnGetNewNumbers.UseVisualStyleBackColor = true;
            this.btnGetNewNumbers.Click += new System.EventHandler(this.btnGetNewNumbers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(32, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSmallestNumber
            // 
            this.txtSmallestNumber.Location = new System.Drawing.Point(218, 184);
            this.txtSmallestNumber.Name = "txtSmallestNumber";
            this.txtSmallestNumber.ReadOnly = true;
            this.txtSmallestNumber.Size = new System.Drawing.Size(226, 20);
            this.txtSmallestNumber.TabIndex = 3;
            this.txtSmallestNumber.TabStop = false;
            // 
            // txtCountSmallNumb
            // 
            this.txtCountSmallNumb.Location = new System.Drawing.Point(218, 210);
            this.txtCountSmallNumb.Name = "txtCountSmallNumb";
            this.txtCountSmallNumb.ReadOnly = true;
            this.txtCountSmallNumb.Size = new System.Drawing.Size(226, 20);
            this.txtCountSmallNumb.TabIndex = 4;
            this.txtCountSmallNumb.TabStop = false;
            // 
            // txtArrayLocation
            // 
            this.txtArrayLocation.Location = new System.Drawing.Point(218, 236);
            this.txtArrayLocation.Name = "txtArrayLocation";
            this.txtArrayLocation.ReadOnly = true;
            this.txtArrayLocation.Size = new System.Drawing.Size(226, 20);
            this.txtArrayLocation.TabIndex = 5;
            this.txtArrayLocation.TabStop = false;
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(218, 12);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ReadOnly = true;
            this.txtNumbers.Size = new System.Drawing.Size(226, 166);
            this.txtNumbers.TabIndex = 6;
            this.txtNumbers.TabStop = false;
            this.txtNumbers.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 287);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.txtArrayLocation);
            this.Controls.Add(this.txtCountSmallNumb);
            this.Controls.Add(this.txtSmallestNumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetNewNumbers);
            this.Name = "Form1";
            this.Text = "9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetNewNumbers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSmallestNumber;
        private System.Windows.Forms.TextBox txtCountSmallNumb;
        private System.Windows.Forms.TextBox txtArrayLocation;
        private System.Windows.Forms.RichTextBox txtNumbers;
    }
}

