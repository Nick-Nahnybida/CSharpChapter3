using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            string outputLabel1;

            outputLabel1 = txtEnterName.Text;

            outputLabel.Text = "Hello, " + outputLabel1 + "!";
        }


        private void goodbyeButton_Click_1(object sender, EventArgs e)
        {
            outputLabel.Text = "Goodbye, " + txtEnterName.Text + "!";
        }
    }
}
