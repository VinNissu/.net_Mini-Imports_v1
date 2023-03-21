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
    public partial class pesquisaprod : Form
    {
        public pesquisaprod()
        {
            InitializeComponent();
        }

        private void pesquisaprod_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.CadastrarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.CadastrarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            /*  this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos); */

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                pesquisaprod frl = new pesquisaprod();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                cadastrarProdutosBindingSource.Filter = string.Format("cadProd_id={0}", textBox1.Text);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
               if (textBox2.Text == "")
              {
                pesquisaprod frl = new pesquisaprod();
                this.Visible = false;
                frl.Show(); 
            }
              else
              {
                  cadastrarProdutosBindingSource.Filter = string.Format("cadProd_desc like'%{0}%'", textBox2.Text);
              }

              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadprod frl = new cadprod();
            frl.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alterarProd frl = new alterarProd();
            this.Hide();
            frl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cadastrarProdutosBindingSource.RemoveCurrent();
                cadastrarProdutosTableAdapter.Update(mini_imports_realDataSet.CadastrarProdutos); //salvar
                this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
