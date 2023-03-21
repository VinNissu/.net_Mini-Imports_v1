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
    public partial class alterarProd : Form
    {
        public alterarProd()
        {
            InitializeComponent();
        }


        //--------------

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


        //-----------

        private void alterarProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.CadastrarProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrarProdutosBindingSource.EndEdit();
            cadastrarProdutosTableAdapter.Update(mini_imports_realDataSet.CadastrarProdutos);
            this.cadastrarProdutosTableAdapter.Fill(this.mini_imports_realDataSet.CadastrarProdutos);
            cadastrarProdutosBindingSource.MoveLast();

            
            textBox2.Focus();
            ClearAllBoxes();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisaprod frl = new pesquisaprod();
            this.Hide();
            frl.ShowDialog();
        }
    }
}
