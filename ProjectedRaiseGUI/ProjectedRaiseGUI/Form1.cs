using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaiseGUI
{
    public partial class ProjectedRaises : Form
    {
        public ProjectedRaises()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double currentSal;
            double raisedSal;
            double raise = 1.04;

            currentSal = Convert.ToDouble(txtCurrentSalary.Text);
           
            raisedSal = currentSal * raise;

            lblResult.Text = "Your total salary for next year is " + raisedSal.ToString("C");
        }
    }
}
