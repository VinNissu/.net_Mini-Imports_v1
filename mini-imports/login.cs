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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);



            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);



            textBox1.Text = "";
            textBox2.Text = "";

            button2.Enabled = false;
            button1.Enabled = false;




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
            ClearAllBoxes();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome1 = textBox2.Text;

            if (nome1.Length < 3 || nome1.Length > 50)
            {
                MessageBox.Show("O nome deve ter entre 3 e 50 caracteres.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // codigo para validacao em INT

            /*if (!int.TryParse(textBox2.Text, out idade))
            {
                MessageBox.Show("A senha deve ser um número inteiro válido.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/



            string nome = textBox1.Text; 

            if (nome.Length < 3 || nome.Length > 50)
            {
                MessageBox.Show("O nome deve ter entre 3 e 50 caracteres.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string nomeCargo = comboBox1.Text;

            if (nomeCargo.Length < 3 || nomeCargo.Length > 50)
            {
                MessageBox.Show("Por Favor, escolha um CARGO", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            {
                if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Entre com os dados");
                }
                else
                {
                    cadastrarFuncionariosBindingSource.Filter = "cadFun_login='" + textBox1.Text + "'";

                    if (textBox1.Text.ToUpper() != textBox5.Text.ToUpper())
                    {
                        MessageBox.Show("USUARIO ERRADO");
                        return;
                    }
                    if (textBox2.Text.ToUpper() != textBox6.Text.ToUpper())
                    {
                        MessageBox.Show("SENHA ERRADA");
                        return;
                    }

                    menu frl = new menu();
                    this.Hide();
                    frl.Show();

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                button2.UseVisualStyleBackColor = false;
                button2.Enabled = true;
                
            }
            else
            {
                button2.Enabled = false;
                button2.UseVisualStyleBackColor = true;

            }

            if (textBox1.Text.Length >= 1)
            {
                button1.UseVisualStyleBackColor = false;
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button1.UseVisualStyleBackColor = true;

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
