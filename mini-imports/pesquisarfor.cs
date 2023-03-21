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
    public partial class pesquisarfor : Form
    {
        public pesquisarfor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadfor frl = new cadfor();
            frl.Show();
            this.Visible = false;
        }

        private void pesquisarfor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            /*
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet1.cadastrarFornecedores'. Você pode movê-la ou removê-la conforme necessári
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                pesquisarfor frl = new pesquisarfor();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                cadastrarFornecedoresBindingSource.Filter = string.Format("cadFor_id={0}", textBox1.Text);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")
            {
                pesquisarfor frl = new pesquisarfor();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                cadastrarFornecedoresBindingSource.Filter = string.Format("cadFor_repre like'%{0}%'", textBox2.Text);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastrarFuncionariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            alterarFor frl = new alterarFor();
            this.Hide();
            frl.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cadastrarFornecedoresBindingSource.RemoveCurrent();
                cadastrarFornecedoresTableAdapter.Update(mini_imports_realDataSet.cadastrarFornecedores); //salvar
                this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
