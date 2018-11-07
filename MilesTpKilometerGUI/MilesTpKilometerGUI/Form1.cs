using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesTpKilometerGUI
{
    public partial class MilesToKilometers : Form
    {
        public MilesToKilometers()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometers;
            double result;

            miles = Convert.ToDouble(txtMiles.Text);

            result = miles * 1.6;
            lblResult.Text = miles + " miles is " +result + " kilometers";
        }
    }
}
