namespace mini_imports
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEncomendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomendarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mini_imports_realDataSet = new mini_imports.mini_imports_realDataSet();
            this.cadastrarFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrarFuncionariosTableAdapter = new mini_imports.mini_imports_realDataSetTableAdapters.cadastrarFuncionariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarFuncionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(14, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-849, -36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2560, 1502);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "BEM-VINDO";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastrarFuncionariosBindingSource, "cadFun_nm", true));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(673, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(585, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "bem-vindo->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Não se esqueça de fazer o backup todos os dias";
            // 
            // menuCadastroToolStripMenuItem
            // 
            this.menuCadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionariosToolStripMenuItem,
            this.cadastrarFornecedoresToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem});
            this.menuCadastroToolStripMenuItem.Font = new System.Drawing.Font("Monospac821 BT", 10.25F);
            this.menuCadastroToolStripMenuItem.Name = "menuCadastroToolStripMenuItem";
            this.menuCadastroToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.menuCadastroToolStripMenuItem.Text = "Menu de Cadastro";
            this.menuCadastroToolStripMenuItem.Click += new System.EventHandler(this.menuCadastroToolStripMenuItem_Click);
            // 
            // cadastrarFuncionariosToolStripMenuItem
            // 
            this.cadastrarFuncionariosToolStripMenuItem.Font = new System.Drawing.Font("Monospac821 BT", 10.25F);
            this.cadastrarFuncionariosToolStripMenuItem.Name = "cadastrarFuncionariosToolStripMenuItem";
            this.cadastrarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.cadastrarFuncionariosToolStripMenuItem.Text = "Cadastrar Funcionarios";
            this.cadastrarFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionariosToolStripMenuItem_Click);
            // 
            // cadastrarFornecedoresToolStripMenuItem
            // 
            this.cadastrarFornecedoresToolStripMenuItem.Name = "cadastrarFornecedoresToolStripMenuItem";
            this.cadastrarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.cadastrarFornecedoresToolStripMenuItem.Text = "Cadastrar Fornecedores";
            this.cadastrarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFornecedoresToolStripMenuItem_Click);
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // menuVendasToolStripMenuItem
            // 
            this.menuVendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVendasToolStripMenuItem,
            this.feedbackToolStripMenuItem});
            this.menuVendasToolStripMenuItem.Font = new System.Drawing.Font("Monospac821 BT", 10.75F);
            this.menuVendasToolStripMenuItem.Name = "menuVendasToolStripMenuItem";
            this.menuVendasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.menuVendasToolStripMenuItem.Text = "Menu de Vendas";
            // 
            // registroDeVendasToolStripMenuItem
            // 
            this.registroDeVendasToolStripMenuItem.Name = "registroDeVendasToolStripMenuItem";
            this.registroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.registroDeVendasToolStripMenuItem.Text = "Registro de Vendas";
            this.registroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVendasToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback clientes";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // menuEncomendasToolStripMenuItem
            // 
            this.menuEncomendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encomendarProdutosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.controleDeEstoqueToolStripMenuItem});
            this.menuEncomendasToolStripMenuItem.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEncomendasToolStripMenuItem.Name = "menuEncomendasToolStripMenuItem";
            this.menuEncomendasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.menuEncomendasToolStripMenuItem.Text = "Menu de encomendas";
            // 
            // encomendarProdutosToolStripMenuItem
            // 
            this.encomendarProdutosToolStripMenuItem.Name = "encomendarProdutosToolStripMenuItem";
            this.encomendarProdutosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.encomendarProdutosToolStripMenuItem.Text = "Encomendar Produtos";
            this.encomendarProdutosToolStripMenuItem.Click += new System.EventHandler(this.encomendarProdutosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.produtosToolStripMenuItem.Text = "Produtos encomendados";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem1.Text = "~~BACKUP~~";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroToolStripMenuItem,
            this.menuVendasToolStripMenuItem,
            this.menuEncomendasToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // mini_imports_realDataSet
            // 
            this.mini_imports_realDataSet.DataSetName = "mini_imports_realDataSet";
            this.mini_imports_realDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastrarFuncionariosBindingSource
            // 
            this.cadastrarFuncionariosBindingSource.DataMember = "cadastrarFuncionarios";
            this.cadastrarFuncionariosBindingSource.DataSource = this.mini_imports_realDataSet;
            // 
            // cadastrarFuncionariosTableAdapter
            // 
            this.cadastrarFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarFuncionariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEncomendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encomendarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private mini_imports_realDataSet mini_imports_realDataSet;
        private System.Windows.Forms.BindingSource cadastrarFuncionariosBindingSource;
        private mini_imports_realDataSetTableAdapters.cadastrarFuncionariosTableAdapter cadastrarFuncionariosTableAdapter;
    }
}