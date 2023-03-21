namespace mini_imports
{
    partial class cadfun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadfun));
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cadastrarFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mini_imports_realDataSet = new mini_imports.mini_imports_realDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cadastrarFuncionariosTableAdapter = new mini_imports.mini_imports_realDataSetTableAdapters.cadastrarFuncionariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(406, 350);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "CADASTRAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_senha", true));
            this.textBox9.Location = new System.Drawing.Point(372, 322);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(215, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // cadastrarFuncionariosBindingSource
            // 
            this.cadastrarFuncionariosBindingSource.DataMember = "cadastrarFuncionarios";
            this.cadastrarFuncionariosBindingSource.DataSource = this.mini_imports_realDataSet;
            // 
            // mini_imports_realDataSet
            // 
            this.mini_imports_realDataSet.DataSetName = "mini_imports_realDataSet";
            this.mini_imports_realDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(324, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "SENHA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(328, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "LOGIN";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_login", true));
            this.textBox8.Location = new System.Drawing.Point(372, 293);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(215, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(324, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "CARGO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(328, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "EMAIL";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_email", true));
            this.textBox6.Location = new System.Drawing.Point(372, 239);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(215, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_nm", true));
            this.textBox2.Location = new System.Drawing.Point(372, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(5, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "CADASTRAR FUNCIONARIOS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 492);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_cargo", true));
            this.textBox7.Location = new System.Drawing.Point(372, 268);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(215, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(301, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "ENDEREÇO";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_ender", true));
            this.textBox5.Location = new System.Drawing.Point(372, 209);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(215, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(604, 97);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "LIMPAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(754, 442);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "PESQUISAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_fone", true));
            this.textBox1.Location = new System.Drawing.Point(372, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(332, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "FONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(341, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(344, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(328, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOME";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_CPF", true));
            this.textBox4.Location = new System.Drawing.Point(372, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_rg", true));
            this.textBox3.Location = new System.Drawing.Point(372, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(938, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-719, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1643, 451);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cadastrarFuncionariosTableAdapter
            // 
            this.cadastrarFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // cadfun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 515);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "cadfun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cadfun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private mini_imports_realDataSet mini_imports_realDataSet;
        private System.Windows.Forms.BindingSource cadastrarFuncionariosBindingSource;
        private mini_imports_realDataSetTableAdapters.cadastrarFuncionariosTableAdapter cadastrarFuncionariosTableAdapter;
    }
}