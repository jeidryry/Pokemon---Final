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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnstrt_Click(object sender, EventArgs e)
        {
            
            Choose f2 = new Choose();
            f2.Show();
            this.Hide();
            
        }

        private void btnhtp_Click(object sender, EventArgs e)
        {
            HTP htp = new HTP();
            htp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
