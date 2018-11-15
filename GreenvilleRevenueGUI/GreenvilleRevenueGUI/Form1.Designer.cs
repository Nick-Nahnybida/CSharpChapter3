namespace GreenvilleRevenueGUI
{
    partial class frmGreenvilleRevenueGUI
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
            this.lblPrevContestants = new System.Windows.Forms.Label();
            this.lblCurrentContestants = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPrevContestants = new System.Windows.Forms.TextBox();
            this.txtCurrentContestants = new System.Windows.Forms.TextBox();
            this.lblRevenueResult = new System.Windows.Forms.Label();
            this.lblNumberContestants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrevContestants
            // 
            this.lblPrevContestants.AutoSize = true;
            this.lblPrevContestants.Location = new System.Drawing.Point(79, 70);
            this.lblPrevContestants.Name = "lblPrevContestants";
            this.lblPrevContestants.Size = new System.Drawing.Size(235, 13);
            this.lblPrevContestants.TabIndex = 0;
            this.lblPrevContestants.Text = "Please enter the number of previous contestants";
            // 
            // lblCurrentContestants
            // 
            this.lblCurrentContestants.AutoSize = true;
            this.lblCurrentContestants.Location = new System.Drawing.Point(82, 147);
            this.lblCurrentContestants.Name = "lblCurrentContestants";
            this.lblCurrentContestants.Size = new System.Drawing.Size(228, 13);
            this.lblCurrentContestants.TabIndex = 1;
            this.lblCurrentContestants.Text = "Please enter the number of current contestants";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(378, 211);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtPrevContestants
            // 
            this.txtPrevContestants.Location = new System.Drawing.Point(364, 70);
            this.txtPrevContestants.Name = "txtPrevContestants";
            this.txtPrevContestants.Size = new System.Drawing.Size(100, 20);
            this.txtPrevContestants.TabIndex = 3;
            // 
            // txtCurrentContestants
            // 
            this.txtCurrentContestants.Location = new System.Drawing.Point(364, 147);
            this.txtCurrentContestants.Name = "txtCurrentContestants";
            this.txtCurrentContestants.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentContestants.TabIndex = 4;
            // 
            // lblRevenueResult
            // 
            this.lblRevenueResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRevenueResult.Location = new System.Drawing.Point(364, 268);
            this.lblRevenueResult.Name = "lblRevenueResult";
            this.lblRevenueResult.Size = new System.Drawing.Size(318, 23);
            this.lblRevenueResult.TabIndex = 5;
            // 
            // lblNumberContestants
            // 
            this.lblNumberContestants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberContestants.Location = new System.Drawing.Point(364, 331);
            this.lblNumberContestants.Name = "lblNumberContestants";
            this.lblNumberContestants.Size = new System.Drawing.Size(318, 23);
            this.lblNumberContestants.TabIndex = 6;
            // 
            // frmGreenvilleRevenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberContestants);
            this.Controls.Add(this.lblRevenueResult);
            this.Controls.Add(this.txtCurrentContestants);
            this.Controls.Add(this.txtPrevContestants);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCurrentContestants);
            this.Controls.Add(this.lblPrevContestants);
            this.Name = "frmGreenvilleRevenueGUI";
            this.Text = "Greenvile Revenue GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrevContestants;
        private System.Windows.Forms.Label lblCurrentContestants;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPrevContestants;
        private System.Windows.Forms.TextBox txtCurrentContestants;
        private System.Windows.Forms.Label lblRevenueResult;
        private System.Windows.Forms.Label lblNumberContestants;
    }
}

