namespace FixedDebugThree3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.lblEnterANumber = new System.Windows.Forms.Label();
            this.txtEnterNumber = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "This application keeps a running total\r\nof entered numbers";
            // 
            // lblEnterANumber
            // 
            this.lblEnterANumber.AutoSize = true;
            this.lblEnterANumber.Location = new System.Drawing.Point(39, 99);
            this.lblEnterANumber.Name = "lblEnterANumber";
            this.lblEnterANumber.Size = new System.Drawing.Size(79, 13);
            this.lblEnterANumber.TabIndex = 1;
            this.lblEnterANumber.Text = "Enter a number";
            // 
            // txtEnterNumber
            // 
            this.txtEnterNumber.Location = new System.Drawing.Point(145, 98);
            this.txtEnterNumber.Name = "txtEnterNumber";
            this.txtEnterNumber.Size = new System.Drawing.Size(57, 20);
            this.txtEnterNumber.TabIndex = 2;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(42, 144);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(177, 23);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "Click to get running total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(61, 206);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(76, 13);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Running total :";
            // 
            // outputLabel2
            // 
            this.outputLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel2.Location = new System.Drawing.Point(170, 206);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(100, 23);
            this.outputLabel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.txtEnterNumber);
            this.Controls.Add(this.lblEnterANumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Running Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnterANumber;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label outputLabel2;
    }
}

