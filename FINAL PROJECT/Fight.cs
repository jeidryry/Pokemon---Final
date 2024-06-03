using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class Fight : Form
    {
        public Fight()
        {
            InitializeComponent();

            Choose cho = new Choose();


            if (cho.choPokemon == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources._004;
                pictureBox1.Show();
                label1.Text = "YOUR CHARMANDER HP: ";
            }
            else if (cho.choPokemon == 2)
            {
                pictureBox1.BackgroundImage = Properties.Resources._007;
                pictureBox1.Show();
                label1.Text = "YOUR SUIRTLE HP: ";
            }
            else if (cho.choPokemon == 3)
            {
                pictureBox1.BackgroundImage = Properties.Resources._001;
                pictureBox1.Show();
                label1.Text = "YOUR BULBASAUR HP: ";
            }
            
        }

    }
}
