using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class frmGreenvilleRevenueGUI : Form
    {
        public frmGreenvilleRevenueGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double previous;
            double present;
            double revenue;
            string revenueMoney;

            previous = Convert.ToDouble(txtPrevContestants.Text);
            present = Convert.ToDouble(txtCurrentContestants.Text);
            revenue = present * 25;
            revenueMoney = revenue.ToString("C");

            lblRevenueResult.Text = "This year's revenue is " + revenueMoney;

            if (present > previous)
            {
                lblNumberContestants.Text = "This year's turnout was greater than last year's";
            }
            else
            {
                lblNumberContestants.Text = "This year's turnout was less than last year's";
            }
        }
    }
}
