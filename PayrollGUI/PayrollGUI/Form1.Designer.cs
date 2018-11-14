namespace PayrollGUI
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnterSocialSecurity = new System.Windows.Forms.Label();
            this.lblEnterHourlyPay = new System.Windows.Forms.Label();
            this.lblEnterHoursWorked = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.txtEnterSocialSecurityNumber = new System.Windows.Forms.TextBox();
            this.txtEnterHourlyPayRate = new System.Windows.Forms.TextBox();
            this.txtEnterHoursWorked = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblFederalTax = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblGrossPayResult = new System.Windows.Forms.Label();
            this.lblFederalTaxResult = new System.Windows.Forms.Label();
            this.lblStateTaxResult = new System.Windows.Forms.Label();
            this.lblNetPayResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(117, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblEnterSocialSecurity
            // 
            this.lblEnterSocialSecurity.AutoSize = true;
            this.lblEnterSocialSecurity.Location = new System.Drawing.Point(4, 65);
            this.lblEnterSocialSecurity.Name = "lblEnterSocialSecurity";
            this.lblEnterSocialSecurity.Size = new System.Drawing.Size(151, 13);
            this.lblEnterSocialSecurity.TabIndex = 1;
            this.lblEnterSocialSecurity.Text = "Social Security Number (SSN):";
            // 
            // lblEnterHourlyPay
            // 
            this.lblEnterHourlyPay.AutoSize = true;
            this.lblEnterHourlyPay.Location = new System.Drawing.Point(68, 91);
            this.lblEnterHourlyPay.Name = "lblEnterHourlyPay";
            this.lblEnterHourlyPay.Size = new System.Drawing.Size(87, 13);
            this.lblEnterHourlyPay.TabIndex = 2;
            this.lblEnterHourlyPay.Text = "Hourly Pay Rate:";
            // 
            // lblEnterHoursWorked
            // 
            this.lblEnterHoursWorked.AutoSize = true;
            this.lblEnterHoursWorked.Location = new System.Drawing.Point(76, 117);
            this.lblEnterHoursWorked.Name = "lblEnterHoursWorked";
            this.lblEnterHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblEnterHoursWorked.TabIndex = 3;
            this.lblEnterHoursWorked.Text = "Hours Worked:";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(194, 39);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 4;
            // 
            // txtEnterSocialSecurityNumber
            // 
            this.txtEnterSocialSecurityNumber.Location = new System.Drawing.Point(194, 65);
            this.txtEnterSocialSecurityNumber.Name = "txtEnterSocialSecurityNumber";
            this.txtEnterSocialSecurityNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnterSocialSecurityNumber.TabIndex = 5;
            // 
            // txtEnterHourlyPayRate
            // 
            this.txtEnterHourlyPayRate.Location = new System.Drawing.Point(194, 91);
            this.txtEnterHourlyPayRate.Name = "txtEnterHourlyPayRate";
            this.txtEnterHourlyPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtEnterHourlyPayRate.TabIndex = 6;
            // 
            // txtEnterHoursWorked
            // 
            this.txtEnterHoursWorked.Location = new System.Drawing.Point(194, 117);
            this.txtEnterHoursWorked.Name = "txtEnterHoursWorked";
            this.txtEnterHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtEnterHoursWorked.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(337, 39);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(596, 39);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(58, 13);
            this.lblGrossPay.TabIndex = 9;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblFederalTax
            // 
            this.lblFederalTax.AutoSize = true;
            this.lblFederalTax.Location = new System.Drawing.Point(499, 65);
            this.lblFederalTax.Name = "lblFederalTax";
            this.lblFederalTax.Size = new System.Drawing.Size(155, 13);
            this.lblFederalTax.TabIndex = 10;
            this.lblFederalTax.Text = "Federal Tax (15% of gross pay):";
            // 
            // lblStateTax
            // 
            this.lblStateTax.AutoSize = true;
            this.lblStateTax.Location = new System.Drawing.Point(515, 92);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(139, 13);
            this.lblStateTax.TabIndex = 11;
            this.lblStateTax.Text = "State Tax (5% of gross pay):";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(606, 124);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(48, 13);
            this.lblNetPay.TabIndex = 12;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // lblGrossPayResult
            // 
            this.lblGrossPayResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPayResult.Location = new System.Drawing.Point(676, 38);
            this.lblGrossPayResult.Name = "lblGrossPayResult";
            this.lblGrossPayResult.Size = new System.Drawing.Size(100, 23);
            this.lblGrossPayResult.TabIndex = 13;
            // 
            // lblFederalTaxResult
            // 
            this.lblFederalTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFederalTaxResult.Location = new System.Drawing.Point(676, 64);
            this.lblFederalTaxResult.Name = "lblFederalTaxResult";
            this.lblFederalTaxResult.Size = new System.Drawing.Size(100, 23);
            this.lblFederalTaxResult.TabIndex = 14;
            // 
            // lblStateTaxResult
            // 
            this.lblStateTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateTaxResult.Location = new System.Drawing.Point(676, 91);
            this.lblStateTaxResult.Name = "lblStateTaxResult";
            this.lblStateTaxResult.Size = new System.Drawing.Size(100, 23);
            this.lblStateTaxResult.TabIndex = 15;
            // 
            // lblNetPayResult
            // 
            this.lblNetPayResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPayResult.Location = new System.Drawing.Point(676, 119);
            this.lblNetPayResult.Name = "lblNetPayResult";
            this.lblNetPayResult.Size = new System.Drawing.Size(100, 23);
            this.lblNetPayResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 495);
            this.Controls.Add(this.lblNetPayResult);
            this.Controls.Add(this.lblStateTaxResult);
            this.Controls.Add(this.lblFederalTaxResult);
            this.Controls.Add(this.lblGrossPayResult);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblStateTax);
            this.Controls.Add(this.lblFederalTax);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterHoursWorked);
            this.Controls.Add(this.txtEnterHourlyPayRate);
            this.Controls.Add(this.txtEnterSocialSecurityNumber);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.lblEnterHoursWorked);
            this.Controls.Add(this.lblEnterHourlyPay);
            this.Controls.Add(this.lblEnterSocialSecurity);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEnterSocialSecurity;
        private System.Windows.Forms.Label lblEnterHourlyPay;
        private System.Windows.Forms.Label lblEnterHoursWorked;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.TextBox txtEnterSocialSecurityNumber;
        private System.Windows.Forms.TextBox txtEnterHourlyPayRate;
        private System.Windows.Forms.TextBox txtEnterHoursWorked;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblFederalTax;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblGrossPayResult;
        private System.Windows.Forms.Label lblFederalTaxResult;
        private System.Windows.Forms.Label lblStateTaxResult;
        private System.Windows.Forms.Label lblNetPayResult;
    }
}

