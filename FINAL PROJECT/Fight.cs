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
        int yourAtk;
        int foeAtk;
        bool fGrowl = false;
        bool yGrowl = false;
        
        Random rnd = new Random();

        public Fight()
        {
            InitializeComponent();

            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            button3.Hide();
            button5.Hide();


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

            
            

            if (fGrowl == false)
            {
                yourAtk = rnd.Next(0, 10);
                foeHP = foeHP - yourAtk;
            }

            else if(fGrowl == true)
            {
                yourAtk = rnd.Next(0, 5);
                foeHP = foeHP - yourAtk;
                fGrowl = false;
            }

            
            foeHP = Math.Max(0, foeHP);
            label5.Text = Convert.ToString(foeHP);

            if(yourAtk == 0)
            {
                label6.Text = "But nothing happened";
                label6.Show();
            }
            else if (yourAtk >=1 && yourAtk <= 4)
            {
                label6.Text = "It's effective";
                label6.Show();
            }
            else if (yourAtk >= 5 && yourAtk <= 7)
            {
                label6.Text = "It's very effective";
                label6.Show();
            }
            else if (yourAtk >= 8 )
            {
                label6.Text = "It's SUPER effective";
                label6.Show();
            }




        }

        private void YourGrowl()
        {
            label9.Text = "You used GROWL.";
            label9.Show();


            label6.Text = "Foe's ATK Speed lessen.";
            label6.Show();
            label5.Text = Convert.ToString(foeHP);

            yGrowl = true;
        }

        private void FoeGrowl()
        {
            label10.Text = "Foe used GROWL.";
            label10.Show();

            label7.Text = "Your ATK Speed lessen.";
            label7.Show();
            label4.Text = Convert.ToString(yourHP);

            fGrowl = true;
        }
        private void FoeTackle()
        {
            label10.Text = "Foe used TACKLE.";
            label10.Show();

           
            

            if (yGrowl == false)
            {
                foeAtk = rnd.Next(0, 10);
                yourHP = yourHP - foeAtk;
            }

            else if (yGrowl == true)
            {
                foeAtk = rnd.Next(0, 5);
                yourHP = yourHP - foeAtk;
                yGrowl = false;
            }

            
            yourHP = Math.Max(0, yourHP);
            label4.Text = Convert.ToString(yourHP);


            if (foeAtk == 0)
            {
                label7.Text = "But nothing happened";
                label7.Show();
            }
            else if (foeAtk >= 1 && foeAtk <= 4)
            {
                label7.Text = "It's effective";
                label7.Show();
            }
            else if (foeAtk >= 5 && foeAtk <= 7)
            {
                label7.Text = "It's very effective";
                label7.Show();
            }
            else if (foeAtk >= 8)
            {
                label7.Text = "It's SUPER effective";
                label7.Show();
            }

        }

        private void FoeAttack()
        {
            
            int r = rnd.Next(0, 10);

            if (r >= 0 && r <= 7)
            {
                FoeTackle();
            }
            else if (r >= 8 )
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
                button3.Show();
                button5.Show();

                button1.Hide();
                button2.Hide();
                button4.Hide();
            }
            else if (yourHP <= 0)
            {

                label8.Text = "You lost!";
                label8.Show();
                button3.Show();
                button5.Show();

                button1.Hide();
                button2.Hide();
                button4.Hide();
            }
            else if (foeHP <= 0)
            {

                label8.Text = "You won!";
                label8.Show();
                button3.Show();
                button5.Show();

                button1.Hide();
                button2.Hide();
                button4.Hide();
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
                button3.Show();
                button5.Show();

                button1.Hide();
                button2.Hide();
                button4.Hide();
            }
            else if (yourHP <= 0)
            {

                label8.Text = "You lost!";
                label8.Show();
                button3.Show();
                button5.Show();

                button1.Hide();
                button2.Hide();
                button4.Hide();
            }
            else if (foeHP <= 0)
            {

                label8.Text = "You won!";
                label8.Show();
                button3.Show();
                button5.Show();

                button1.Hide();
                button2.Hide();
                button4.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Travel().Show();
        }
    }
}
