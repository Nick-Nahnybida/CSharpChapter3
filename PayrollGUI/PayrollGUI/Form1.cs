using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double stateTax = 0.05;
            double fedTax = 0.15;
            double grossPay;
            double netPay;
            double hoursWorked;
            double hourlyRate;

            hoursWorked = Convert.ToDouble(txtEnterHoursWorked.Text);
            hourlyRate = Convert.ToDouble(txtEnterHourlyPayRate.Text);

            grossPay = hoursWorked * hourlyRate;
            fedTax = grossPay * fedTax;
            stateTax = grossPay * stateTax;
            netPay = grossPay - (fedTax + stateTax);

            lblGrossPayResult.Text = grossPay.ToString("C");
            lblFederalTaxResult.Text = fedTax.ToString("C");
            lblStateTaxResult.Text = stateTax.ToString("C");
            lblNetPayResult.Text = netPay.ToString("C");
        }
    }
}
