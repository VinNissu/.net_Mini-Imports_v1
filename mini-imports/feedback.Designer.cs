namespace mini_imports
{
    partial class feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedback));
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.feedbackClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mini_imports_realDataSet = new mini_imports.mini_imports_realDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.feedbackClientesTableAdapter = new mini_imports.mini_imports_realDataSetTableAdapters.feedbackClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedbackClientesBindingSource, "feedback_diaHora", true));
            this.textBox4.Location = new System.Drawing.Point(304, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 20);
            this.textBox4.TabIndex = 2;
            // 
            // feedbackClientesBindingSource
            // 
            this.feedbackClientesBindingSource.DataMember = "feedbackClientes";
            this.feedbackClientesBindingSource.DataSource = this.mini_imports_realDataSet;
            // 
            // mini_imports_realDataSet
            // 
            this.mini_imports_realDataSet.DataSetName = "mini_imports_realDataSet";
            this.mini_imports_realDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEEDBACK DOS CLIENTES";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
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
            this.panel1.Size = new System.Drawing.Size(776, 429);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(638, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 38);
            this.button2.TabIndex = 34;
            this.button2.Text = "PESQUISAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedbackClientesBindingSource, "feedback_depoi", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textBox1.Location = new System.Drawing.Point(304, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 100);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(351, 285);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "REGIST";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(552, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "LIMPA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(220, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "DEPOIMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(227, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "DIA E HORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(219, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "COMPRADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(183, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "NOME DO PRODUTO";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedbackClientesBindingSource, "feedback_nmCompra", true));
            this.textBox3.Location = new System.Drawing.Point(304, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedbackClientesBindingSource, "feedback_prod", true));
            this.textBox2.Location = new System.Drawing.Point(304, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(5, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-846, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1842, 451);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // feedbackClientesTableAdapter
            // 
            this.feedbackClientesTableAdapter.ClearBeforeFill = true;
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private mini_imports_realDataSet mini_imports_realDataSet;
        private System.Windows.Forms.BindingSource feedbackClientesBindingSource;
        private mini_imports_realDataSetTableAdapters.feedbackClientesTableAdapter feedbackClientesTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}