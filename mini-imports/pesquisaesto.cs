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
    public partial class pesquisaesto : Form
    {
        public pesquisaesto()
        {
            InitializeComponent();
        }

        private void pesquisaesto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.controleDeEstoque'. Você pode movê-la ou removê-la conforme necessário.
            this.controleDeEstoqueTableAdapter.Fill(this.mini_imports_realDataSet.controleDeEstoque);
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.controleDeEstoque'. Você pode movê-la ou removê-la conforme necessário.
            /*  this.controleDeEstoqueTableAdapter.Fill(this.mini_imports_realDataSet.controleDeEstoque); */

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                pesquisaesto frl = new pesquisaesto();
                this.Visible = false;
                frl.Show();
            }
            else{ 
                
                controleDeEstoqueBindingSource.Filter = string.Format("ctrlEstoq_id={0}", textBox1.Text);
                
                }

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (textBox2.Text == "")
              {
                pesquisaesto frl = new pesquisaesto();
                this.Visible = false;
                frl.Show();
            }
              else
              {
                  controleDeEstoqueBindingSource.Filter = string.Format("ctrlEstoq_desc like'%{0}%'", textBox2.Text);
              }

              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                controleDeEstoqueBindingSource.RemoveCurrent();
                controleDeEstoqueTableAdapter.Update(mini_imports_realDataSet.controleDeEstoque); //salvar
                this.controleDeEstoqueTableAdapter.Fill(this.mini_imports_realDataSet.controleDeEstoque);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            feedback frl = new feedback();
            this.Visible = false;
            frl.Show();
        }
    }
}
