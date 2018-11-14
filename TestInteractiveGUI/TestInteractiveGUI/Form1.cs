using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double score1;
            double score2;
            double score3;
            double score4;
            double score5;
            double average;

            score1 = Convert.ToDouble(txtEnterScore1.Text);
            score2 = Convert.ToDouble(txtEnterScore2.Text);
            score3 = Convert.ToDouble(txtEnterScore3.Text);
            score4 = Convert.ToDouble(txtEnterScore4.Text);
            score5 = Convert.ToDouble(txtEnterScore5.Text);

            average = (score1 + score2 + score3 + score4 + score5) / 5;

            lblResult.Text = "Your average score is " + average + ".";
        }
    }
}
