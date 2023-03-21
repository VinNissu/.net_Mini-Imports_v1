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
    public partial class feedback : Form
    {
        public feedback()
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

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu outroform = new menu();
            this.Hide();
            outroform.ShowDialog();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.feedbackClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            feedbackClientesBindingSource.EndEdit();
            feedbackClientesTableAdapter.Update(mini_imports_realDataSet.feedbackClientes);
            this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);
            feedbackClientesBindingSource.MoveLast();
            feedbackClientesBindingSource.AddNew();

            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisarFeed outroform = new pesquisarFeed();
            this.Hide();
            outroform.ShowDialog();
        }
    }
}
