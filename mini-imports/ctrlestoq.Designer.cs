namespace mini_imports
{
    partial class ctrlestoq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlestoq));
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctrlEstoqidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadProdidFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlEstoqdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlEstoqdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlEstoqdataEntrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadForidFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadForrzSocialFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctrlEstoquniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDeEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mini_imports_realDataSet = new mini_imports.mini_imports_realDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.controleDeEstoqueTableAdapter = new mini_imports.mini_imports_realDataSetTableAdapters.controleDeEstoqueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 492);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctrlEstoqidDataGridViewTextBoxColumn,
            this.cadProdidFKDataGridViewTextBoxColumn,
            this.ctrlEstoqdescDataGridViewTextBoxColumn,
            this.ctrlEstoqdataDataGridViewTextBoxColumn,
            this.ctrlEstoqdataEntrDataGridViewTextBoxColumn,
            this.cadForidFKDataGridViewTextBoxColumn,
            this.cadForrzSocialFKDataGridViewTextBoxColumn,
            this.ctrlEstoquniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.controleDeEstoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ctrlEstoqidDataGridViewTextBoxColumn
            // 
            this.ctrlEstoqidDataGridViewTextBoxColumn.DataPropertyName = "ctrlEstoq_id";
            this.ctrlEstoqidDataGridViewTextBoxColumn.HeaderText = "ctrlEstoq_id";
            this.ctrlEstoqidDataGridViewTextBoxColumn.Name = "ctrlEstoqidDataGridViewTextBoxColumn";
            this.ctrlEstoqidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadProdidFKDataGridViewTextBoxColumn
            // 
            this.cadProdidFKDataGridViewTextBoxColumn.DataPropertyName = "cadProd_id_FK";
            this.cadProdidFKDataGridViewTextBoxColumn.HeaderText = "cadProd_id_FK";
            this.cadProdidFKDataGridViewTextBoxColumn.Name = "cadProdidFKDataGridViewTextBoxColumn";
            // 
            // ctrlEstoqdescDataGridViewTextBoxColumn
            // 
            this.ctrlEstoqdescDataGridViewTextBoxColumn.DataPropertyName = "ctrlEstoq_desc";
            this.ctrlEstoqdescDataGridViewTextBoxColumn.HeaderText = "ctrlEstoq_desc";
            this.ctrlEstoqdescDataGridViewTextBoxColumn.Name = "ctrlEstoqdescDataGridViewTextBoxColumn";
            // 
            // ctrlEstoqdataDataGridViewTextBoxColumn
            // 
            this.ctrlEstoqdataDataGridViewTextBoxColumn.DataPropertyName = "ctrlEstoq_data";
            this.ctrlEstoqdataDataGridViewTextBoxColumn.HeaderText = "ctrlEstoq_data";
            this.ctrlEstoqdataDataGridViewTextBoxColumn.Name = "ctrlEstoqdataDataGridViewTextBoxColumn";
            // 
            // ctrlEstoqdataEntrDataGridViewTextBoxColumn
            // 
            this.ctrlEstoqdataEntrDataGridViewTextBoxColumn.DataPropertyName = "ctrlEstoq_dataEntr";
            this.ctrlEstoqdataEntrDataGridViewTextBoxColumn.HeaderText = "ctrlEstoq_dataEntr";
            this.ctrlEstoqdataEntrDataGridViewTextBoxColumn.Name = "ctrlEstoqdataEntrDataGridViewTextBoxColumn";
            // 
            // cadForidFKDataGridViewTextBoxColumn
            // 
            this.cadForidFKDataGridViewTextBoxColumn.DataPropertyName = "cadFor_id_FK";
            this.cadForidFKDataGridViewTextBoxColumn.HeaderText = "cadFor_id_FK";
            this.cadForidFKDataGridViewTextBoxColumn.Name = "cadForidFKDataGridViewTextBoxColumn";
            // 
            // cadForrzSocialFKDataGridViewTextBoxColumn
            // 
            this.cadForrzSocialFKDataGridViewTextBoxColumn.DataPropertyName = "cadFor_rzSocial_FK";
            this.cadForrzSocialFKDataGridViewTextBoxColumn.HeaderText = "cadFor_rzSocial_FK";
            this.cadForrzSocialFKDataGridViewTextBoxColumn.Name = "cadForrzSocialFKDataGridViewTextBoxColumn";
            // 
            // ctrlEstoquniDataGridViewTextBoxColumn
            // 
            this.ctrlEstoquniDataGridViewTextBoxColumn.DataPropertyName = "ctrlEstoq_uni";
            this.ctrlEstoquniDataGridViewTextBoxColumn.HeaderText = "ctrlEstoq_uni";
            this.ctrlEstoquniDataGridViewTextBoxColumn.Name = "ctrlEstoquniDataGridViewTextBoxColumn";
            // 
            // controleDeEstoqueBindingSource
            // 
            this.controleDeEstoqueBindingSource.DataMember = "controleDeEstoque";
            this.controleDeEstoqueBindingSource.DataSource = this.mini_imports_realDataSet;
            // 
            // mini_imports_realDataSet
            // 
            this.mini_imports_realDataSet.DataSetName = "mini_imports_realDataSet";
            this.mini_imports_realDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONTROLE DE ESTOQUE";
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
            // controleDeEstoqueTableAdapter
            // 
            this.controleDeEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // ctrlestoq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 515);
            this.Controls.Add(this.panel1);
            this.Name = "ctrlestoq";
            this.Text = "ctrlestoq";
            this.Load += new System.EventHandler(this.ctrlestoq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_imports_realDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mini_imports_realDataSet mini_imports_realDataSet;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource;
        private mini_imports_realDataSetTableAdapters.controleDeEstoqueTableAdapter controleDeEstoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlEstoqidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadProdidFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlEstoqdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlEstoqdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlEstoqdataEntrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadForidFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadForrzSocialFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctrlEstoquniDataGridViewTextBoxColumn;
    }
}