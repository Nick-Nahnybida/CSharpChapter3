using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class EggsInteractiveGUI : Form
    {
        public EggsInteractiveGUI()
        {
            InitializeComponent();
        }

        private void lblNumberOfEggs_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int chicken1;
            int chicken2;
            int chicken3;
            int chicken4;
            int chicken5;
            int dozen;
            int spareEggs;
            int totalEggs;

            chicken1 = Convert.ToInt32(txtChicken1.Text);
            chicken2 = Convert.ToInt32(txtChicken2.Text);
            chicken3 = Convert.ToInt32(txtChicken3.Text);
            chicken4 = Convert.ToInt32(txtChicken4.Text);
            chicken5 = Convert.ToInt32(txtChicken5.Text);

            totalEggs = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;

            dozen = totalEggs / 12;
            spareEggs = totalEggs % 12;

            lblResult.Text = "Your chickens have produced " + dozen +" dozen eggs and " + spareEggs +" extra eggs";
        }
    }
}
