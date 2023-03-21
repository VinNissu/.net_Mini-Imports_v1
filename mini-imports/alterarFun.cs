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
    public partial class alterarFun : Form
    {
        public alterarFun()
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



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void alterarFun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrarFuncionariosBindingSource.EndEdit();
            cadastrarFuncionariosTableAdapter.Update(mini_imports_realDataSet.cadastrarFuncionarios);
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);
            cadastrarFuncionariosBindingSource.MoveLast();

            textBox2.Focus();
            ClearAllBoxes();

            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //limpar tela
            //    textBox1.Text = "";
            //  textbox.Text = (" ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisafun frl = new pesquisafun();
            this.Visible = false;
            frl.ShowDialog();
        }
    }
}
