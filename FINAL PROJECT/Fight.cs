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
        int yourHP = 100;
        int foeHP = 100;
        int yourDmg = 0;
        int foeDmg = 0;
        


        public Fight()
        {
            InitializeComponent();

            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();


            Choose cho = new Choose();


            switch (cho.choPokemon)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources._004;
                    pictureBox1.Show();
                    label1.Text = "CHARMANDER HP: ";
                    break;

                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources._007;
                    pictureBox1.Show();
                    label1.Text = "SQUIRTLE HP: ";
                    break;

                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._001;
                    pictureBox1.Show();
                    label1.Text = "BULBASAUR HP: ";
                    break;
            }

            Travel tra = new Travel();

            switch (tra.foePokemon)
            {
                case 0:
                    pictureBox2.BackgroundImage = Properties.Resources._001;
                    pictureBox2.Show();
                    label2.Text = "FOE BULBASAUR HP: ";
                    break;

                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources._025;
                    pictureBox2.Show();
                    label2.Text = "FOE PIKACHU HP: ";
                    break;

                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources._007;
                    pictureBox2.Show();
                    label2.Text = "FOE SQUIRTLE HP: ";
                    break;

                case 3:
                    pictureBox2.BackgroundImage = Properties.Resources._004;
                    pictureBox2.Show();
                    label2.Text = "FOE CHARMANDER HP: ";
                    break;

                case 4:
                    pictureBox2.BackgroundImage = Properties.Resources._022;
                    pictureBox2.Show();
                    label2.Text = "FOE FEAROW HP: ";
                    break;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void YourTackle()
        {
            label9.Text = "You used TACKLE.";
            label9.Show();

            Random rnd = new Random();

            int yourAtk = rnd.Next(0, 15);

            foeDmg += yourAtk;

            foeHP = foeHP - foeDmg;
            foeHP = Math.Max(0, foeHP);

            
            label5.Text = Convert.ToString(foeHP);



        }

        private void YourGrowl()
        {
            label9.Text = "You used GROWL.";
            label9.Show();


            label6.Text = "Foe's ATK Speed lessen.";
            label6.Show();
            label5.Text = Convert.ToString(foeHP);
        }

        private void FoeGrowl()
        {
            label10.Text = "Foe used GROWL.";
            label10.Show();

            label6.Text = "Your ATK Speed lessen.";
            label6.Show();
            label4.Text = Convert.ToString(yourHP);

        }
        private void FoeTackle()
        {
            label10.Text = "Foe used TACKLE.";
            label10.Show();
            Random rand = new Random();

            int foeAtk = rand.Next(0, 15);
            yourDmg += foeAtk;

            yourHP = yourHP - yourDmg;
            yourHP = Math.Max(0, yourHP);

            label4.Text = Convert.ToString(yourHP);

        }

        private void FoeAttack()
        {
            Random rando = new Random();
            int r = rando.Next(0, 1);

            if (r == 0)
            {
                FoeTackle();
            }
            else if (r == 1)
            {
                FoeGrowl();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            
            YourTackle();
            FoeAttack();


            if (yourHP <= 0 && foeHP <= 0)
            {

                label8.Text = "It's a draw!";
                label8.Show();
            }
            else if (yourHP <= 0)
            {

                label8.Text = "You lost!";
                label8.Show();
            }
            else if (foeHP <= 0)
            {

                label8.Text = "You won!";
                label8.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YourGrowl();
            FoeAttack();

            if (yourHP <= 0 && foeHP <= 0)
            {

                label8.Text = "It's a draw!";
                label8.Show();
            }
            else if (yourHP <= 0)
            {

                label8.Text = "You lost!";
                label8.Show();
            }
            else if (foeHP <= 0)
            {

                label8.Text = "You won!";
                label8.Show();
            }
        }
    }
}
