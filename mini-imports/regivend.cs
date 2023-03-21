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
    public partial class regivend : Form
    {
        public regivend()
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

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }

        private void regivend_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.registroVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet.registroVendas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            registroVendasBindingSource.EndEdit();
            registroVendasTableAdapter.Update(mini_imports_realDataSet.registroVendas);
            this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet.registroVendas);
            registroVendasBindingSource.MoveLast();
            registroVendasBindingSource.AddNew();
        }
    }
}
