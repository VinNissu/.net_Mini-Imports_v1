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
    public partial class encomend : Form
    {
        public encomend()
        {
            InitializeComponent();
        }
        private void ClearAllBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {

                    if (control is TextBox || control is ComboBox)
                    {
                        control.ResetText();
                    }
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu outroform = new menu();
            this.Hide();
            outroform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            encomendados outroform = new encomendados();
            this.Hide();
            outroform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void encomend_Load(object sender, EventArgs e)
        {

        }



    }
}
