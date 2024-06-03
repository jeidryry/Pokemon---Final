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
    public partial class Choose : Form
    {
        private static int choPo;

        public int choPokemon
        {
            get
            {
                return choPo;
            }
            set
            {
                choPo = value;
            }
        }
        public Choose()
        {
            InitializeComponent();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button9.Hide();

        }
        private bool btn3_Click()
        {
            return true;
        }
        private bool btn2_Click()
        {
            return true;
        }
        private bool btn1_Click()
        {
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide(); 
            button3.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            button8.Hide();


            label5.Text = "YOU HAVE CHOSEN BULBASAUR";
            label5.Show();
            button4.Show();
            button7.Show();
            button9.Show();
            choPo = 3;

            bool btnClick3 = btn3_Click();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            button8.Hide();


            label5.Text = "YOU HAVE CHOSEN CHARMANDER";
            label5.Show();
            button4.Show();
            button5.Show();
            button9.Show();

            choPo = 1;

            bool btnClick2 = btn2_Click();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            button8.Hide();


            label5.Text = "YOU HAVE CHOSEN SQUIRTLE";
            label5.Show();
            button4.Show();
            button6.Show();
            button9.Show();
            choPo = 2;

            bool btnClick1 = btn1_Click();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            button8.Show();

            label5.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button9.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Travel mainGame = new Travel(); 
            mainGame.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label6.Text = "Invalid. Please Enter your Name: ";
            }
            else
            {
                label1.Text = "Hello " + textBox1.Text + ", Choose your starter Pokemon";
                button1.Show();
                button2.Show();
                button3.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                button8.Show();

                label6.Hide();
                textBox1.Hide();
                button10.Hide();
                panel1.Hide();
            }

        }
    }
}
