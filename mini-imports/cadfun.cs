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
    public partial class cadfun : Form
    {
        public cadfun()
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void cadfun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            cadastrarFuncionariosBindingSource.AddNew();

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    TextBox textBox = (TextBox)controle;
                    textBox.Text = string.Empty;
                }
            }

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;

            if (nome.Length < 3 || nome.Length > 50)
            {
                MessageBox.Show("O nome deve ter entre 3 e 50 caracteres.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Validate();
            cadastrarFuncionariosBindingSource.EndEdit();
            cadastrarFuncionariosTableAdapter.Update(mini_imports_realDataSet.cadastrarFuncionarios);
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);
            cadastrarFuncionariosBindingSource.MoveLast();
            cadastrarFuncionariosBindingSource.AddNew();

            textBox2.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pesquisafun frl = new pesquisafun();
            this.Visible = false;
            frl.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 40;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 15;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 15;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 15;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 50;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 50;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 50;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 50;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.MaxLength = 50;
        }
    }
}
