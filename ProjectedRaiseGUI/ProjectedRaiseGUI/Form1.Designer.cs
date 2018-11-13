namespace ProjectedRaiseGUI
{
    partial class ProjectedRaises
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
            this.lvlCurrentSalary = new System.Windows.Forms.Label();
            this.txtCurrentSalary = new System.Windows.Forms.TextBox();
            this.lblNextSalary = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlCurrentSalary
            // 
            this.lvlCurrentSalary.AutoSize = true;
            this.lvlCurrentSalary.Location = new System.Drawing.Point(109, 100);
            this.lvlCurrentSalary.Name = "lvlCurrentSalary";
            this.lvlCurrentSalary.Size = new System.Drawing.Size(73, 13);
            this.lvlCurrentSalary.TabIndex = 0;
            this.lvlCurrentSalary.Text = "Current Salary";
            // 
            // txtCurrentSalary
            // 
            this.txtCurrentSalary.Location = new System.Drawing.Point(112, 152);
            this.txtCurrentSalary.Name = "txtCurrentSalary";
            this.txtCurrentSalary.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentSalary.TabIndex = 1;
            // 
            // lblNextSalary
            // 
            this.lblNextSalary.AutoSize = true;
            this.lblNextSalary.Location = new System.Drawing.Point(361, 100);
            this.lblNextSalary.Name = "lblNextSalary";
            this.lblNextSalary.Size = new System.Drawing.Size(93, 13);
            this.lblNextSalary.TabIndex = 2;
            this.lblNextSalary.Text = "Next Year\'s Salary";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(364, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(252, 23);
            this.lblResult.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(112, 223);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert Salary";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ProjectedRaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNextSalary);
            this.Controls.Add(this.txtCurrentSalary);
            this.Controls.Add(this.lvlCurrentSalary);
            this.Name = "ProjectedRaises";
            this.Text = "Projected Raises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlCurrentSalary;
        private System.Windows.Forms.TextBox txtCurrentSalary;
        private System.Windows.Forms.Label lblNextSalary;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnConvert;
    }
}

