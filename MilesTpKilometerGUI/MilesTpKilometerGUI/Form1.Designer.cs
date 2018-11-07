namespace MilesTpKilometerGUI
{
    partial class MilesToKilometers
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(224, 35);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblKilometers
            // 
            this.lblKilometers.AutoSize = true;
            this.lblKilometers.Location = new System.Drawing.Point(302, 90);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(55, 13);
            this.lblKilometers.TabIndex = 1;
            this.lblKilometers.Text = "Kilometers";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(129, 90);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(31, 13);
            this.lblMiles.TabIndex = 2;
            this.lblMiles.Text = "Miles";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(132, 123);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(305, 123);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 5;
            // 
            // MilesToKilometers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 238);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.btnConvert);
            this.Name = "MilesToKilometers";
            this.Text = "Miles to Kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblKilometers;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblResult;
    }
}

