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
    public partial class pesquisarFeed : Form
    {
        public pesquisarFeed()
        {
            InitializeComponent();
        }

        private void alterarFeed_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.feedbackClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                pesquisarFeed frl = new pesquisarFeed();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                feedbackClientesBindingSource.Filter = string.Format("feedback_id={0}", textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                pesquisarFeed frl = new pesquisarFeed();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                feedbackClientesBindingSource.Filter = string.Format("feedback_nmCompra like'%{0}%'", textBox2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback outroform = new feedback();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
