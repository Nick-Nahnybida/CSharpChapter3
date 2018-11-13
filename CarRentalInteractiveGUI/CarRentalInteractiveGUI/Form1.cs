using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class CarRentalInteractiveGUI : Form
    {
        public CarRentalInteractiveGUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double miles;
            double days;
            double price;
            double milePrice = 0.25;
            double dayPrice = 20;

            miles = Convert.ToDouble(txtMiles.Text);
            days = Convert.ToDouble(txtDays.Text);

            price = (days * dayPrice) + (miles * milePrice);

            lblResult.Text = "Your total price is " + price.ToString("C");
        }
    }
}
