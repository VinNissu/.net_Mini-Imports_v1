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
    public partial class encomendados : Form
    {
        public encomendados()
        {
            InitializeComponent();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            encomend outroform = new encomend();
            this.Hide();
            outroform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu outroform = new menu();
            this.Hide();
            outroform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void encomendados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.encomendarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.encomendarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.encomendarProdutos);
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.encomendarProdutos'. /*  Você pode movê-la ou removê-la conforme necessário.
            /*  this.encomendarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.encomendarProdutos);  */

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }


            /* encomendarProdutosBindingSource.Filter = string.Format("encomend_id={0}", textBox1.Text); */
        }


        private void button6_Click(object sender, EventArgs e)
        {
            /*  if (textBox2.Text.Length == 0)
             {
                 encomendarProdutosBindingSource.Filter = "";
             }
             else
             {
                 encomendarProdutosBindingSource.Filter = string.Format("cadProd_id like'%{0}%'", textBox2.Text);
             }
            */
        }
    }
}
