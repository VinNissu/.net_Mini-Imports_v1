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
    public partial class alterarFor : Form
    {
        public alterarFor()
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

        private void alterarFor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);

          /*  this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            if (Class1.codigo == "")//
            { cadastrarFornecedoresBindingSource.AddNew(); }//
            else//
            { cadastrarFornecedoresBindingSource.Filter = string.Format("cadFor_id={0}", Class1.codigo); }*/

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrarFornecedoresBindingSource.EndEdit();
            cadastrarFornecedoresTableAdapter.Update(mini_imports_realDataSet.cadastrarFornecedores);
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            cadastrarFornecedoresBindingSource.MoveLast();

            textBox2.Focus();


            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisarfor frl = new pesquisarfor();
            this.Hide();
            frl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
