using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
            
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] wildPokemons = new string[]{
                "Bulbasaur",
                "Pikachu",
                "Squirtle",
                "Charmander",
                "Fearow"
            };

            while (!(rand.Next(5) == 0))
            {
                label1.Show();
            }

            int x = rand.Next(5);
            label1.Text = "A wild " + wildPokemons[x] + " appered!";
            button3.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Hide();
            button1.Hide();
            button3.Hide();
            button2.Hide();

            button4.Show();
            button5.Show();
            button6.Show();
            label2.Show();
            label3.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            int yourHP = 20;
            int enemyHP = 20;

            while (yourHP > 0 && enemyHP > 0)
            {
                Random rnd = new Random();
                int enemydamage = rnd.Next(0,3);

                enemyHP = Math.Max(0, enemyHP - enemydamage);
                label3.Text = "ENEMY POKEMON HP: " + enemyHP;

                if (enemydamage == 0)
                {
                    label4.Text = "But nothing happened.";
                    label4.Show();
                }
                else if (enemydamage >= 1 && enemydamage <= 5)
                {
                    label4.Text = "It's not effective.";
                    label4.Show();
                }
                else if (enemydamage >= 6 && enemydamage <= 10)
                {
                    label4.Text = "It's very effective!";
                    label4.Show();
                }
                else if (enemydamage >= 11 && enemydamage <= 15)
                {
                    label4.Text = "It's SUPER effective!";
                    label4.Show();
                }
            }

        }
    }
}
