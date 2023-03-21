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
    public partial class pesquisafun : Form
    {
        public pesquisafun()
        {
            InitializeComponent();
        }

        private void pesquisafun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                pesquisafun frl = new pesquisafun();
                this.Visible = false;
                frl.Show();
            }
            else {
                cadastrarFuncionariosBindingSource.Filter = string.Format("cadFun_id={0}", textBox1.Text);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             if (textBox2.Text == "")
            {
                pesquisafun frl = new pesquisafun();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                cadastrarFuncionariosBindingSource.Filter = string.Format("cadFun_nm like'%{0}%'", textBox2.Text);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadfun frl = new cadfun();
            frl.Show();
            this.Visible = false;
        }

        private void cadastrarFuncionariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Visible = false;
            alterarFun frm = new alterarFun();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cadastrarFuncionariosBindingSource.RemoveCurrent();
                cadastrarFuncionariosTableAdapter.Update(mini_imports_realDataSet.cadastrarFuncionarios); //salvar
                this.cadastrarFuncionariosTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFuncionarios);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
        }
    }
}
