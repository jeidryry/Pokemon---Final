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
        public Choose()
        {
            InitializeComponent();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button9.Hide();
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
            MainGame mainGame = new MainGame(); 
            mainGame.Show();
        }
    }
}
