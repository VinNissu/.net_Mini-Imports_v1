using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_imports
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            pbar.Parent = pictureBox2;
            pbar.BackColor = Color.Transparent;
            pbar.Value = 0;


            lblCarregando.Parent = pictureBox2;
            lblCarregando.BackColor = Color.Transparent;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 102)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                login frl = new login();
                frl.Show();
                this.Visible = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pbar.Value < 100)
            {
                pbar.Value = pbar.Value + 10;
            }
            else
            {
                timer1.Enabled = false;
                login frl = new login();
                frl.Show();
                this.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbar_Click(object sender, EventArgs e)
        {

        }

        private void lblCarregando_Click(object sender, EventArgs e)
        {

        }
    }
}
