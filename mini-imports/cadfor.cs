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
    public partial class cadfor : Form
    {
        public cadfor()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void cadfor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.cadastrarFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            cadastrarFornecedoresBindingSource.AddNew();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            cadastrarFornecedoresBindingSource.EndEdit();
            cadastrarFornecedoresTableAdapter.Update(mini_imports_realDataSet.cadastrarFornecedores);
            this.cadastrarFornecedoresTableAdapter.Fill(this.mini_imports_realDataSet.cadastrarFornecedores);
            cadastrarFornecedoresBindingSource.MoveLast();
            cadastrarFornecedoresBindingSource.AddNew();

            textBox2.Focus();

            cadfor frl = new cadfor();
            frl.Show();
            this.Visible = false;
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisarfor frl = new pesquisarfor();
            frl.Show();
            this.Visible = false;
        }
    }
}
