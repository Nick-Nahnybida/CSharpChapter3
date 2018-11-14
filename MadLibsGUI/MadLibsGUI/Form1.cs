using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class frmMadLibsGUI : Form
    {
        public frmMadLibsGUI()
        {
            InitializeComponent();
        }

        private void btnCreateStory_Click(object sender, EventArgs e)
        {
            string color;
            string wordest;
            string bodyPartPlural;
            string Animal;
            string Noun;
            string pluralNoun;
            int numberA;
            int numberB;
            int NumberC;

            color = txtColor.Text;
            wordest = txtWordEST.Text;
            bodyPartPlural = txtBodyPartPlural.Text;
            Animal = txtAnimal.Text;
            Noun = txtNoun.Text;
            pluralNoun = txtPluralNoun.Text;
            numberA = Convert.ToInt32(txtNumberA.Text);
            numberB = Convert.ToInt32(txtNumberB.Text);
            NumberC = (numberA - numberB);

            lblStoryResult.Text = "The " + color + " Dragon is the " + wordest + " Dragon of all. It has " + NumberC + " " + bodyPartPlural + ", and a " + Animal + " shaped like a " + Noun + ". It loves to eat " + pluralNoun + ", although it will feast on nearly anything.";
        }
    }
}
