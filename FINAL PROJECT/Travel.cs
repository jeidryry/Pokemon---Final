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
    public partial class Travel : Form
    {
        
        public Travel()
        {
            InitializeComponent();
            
            button3.Hide();
            label2.Hide();

            
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
            string[] messsage = new string[]{
                "Try Again",
                "No Pokemon found. Search again.",
                "Travel more to find Pokemons",
                "Nothing. Search again.",
                "There must be something out there. Try again."
            };

            while (!(rand.Next(0, 5) == 0))
            {
                int i = rand.Next(5);
                label1.Text = messsage[i];
                label1.Show();
            }

            if (rand.Next(0, 5) == 0)
            {
                int x = rand.Next(5);
                label2.Text = "A wild " + wildPokemons[x] + " appeared!";
                label2.Show();
                label1.Hide();
                button3.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Fight().Show();
           
        }

       
        }
    }

