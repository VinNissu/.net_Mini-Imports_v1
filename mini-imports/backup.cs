using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace mini_imports
{
    public partial class backup : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = " ";
        string connectionStrig = "";

        public backup()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectionStrig = "Data Source = " + textBox1.Text + "; User Id=" + textBox2.Text + "; Password=" + textBox3.Text + "";
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                //sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE  d.database_id>4";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                comboBox1.Enabled = true;
                button6.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = true;
                button3.Enabled = false;
                {
                    MessageBox.Show("Please, select a DataBase");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = dlg.SelectedPath;
                button3.Enabled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please, select a DataBase");
                    return;
                }
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                sql = "BACKUP DATABASE " + comboBox1.Text + " TO DISK= '" + textBox6.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                //sql = "BACKUP DATABASE" + comboBox1.Text + " TO DISK= " + textBox6.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + " .bak";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Successufully Database Backup Completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox9.Text = dlg.FileName;
            }
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please, select a DATABASE.");
                    return;
                }
                conn = new SqlConnection(connectionStrig);
                conn.Open();
                sql = "Alter DATABASE " + comboBox1.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore DATABASE " + comboBox1.Text + " FROM DISK = '" + textBox9.Text + "' WITH REPLACE;";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Sucessefully Restore Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            comboBox1.Enabled = false;
            button1.Enabled = false;
            button7.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu frl = new menu();
            this.Hide();
            frl.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ClearAllBoxes();
        }
    }
}
