namespace projetoPOO_BD
{
    partial class Fornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedores));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btAddClientes = new Button();
            btDeleteFornecedor = new Button();
            btEditFornecedor = new Button();
            btPesquisarFornecedor = new Button();
            txtClientes = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dgvFornecedor = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            TELEFONE = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // btAddClientes
            // 
            btAddClientes.BackColor = Color.DarkSeaGreen;
            btAddClientes.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddClientes.Image = (Image)resources.GetObject("btAddClientes.Image");
            btAddClientes.Location = new Point(653, 27);
            btAddClientes.Margin = new Padding(3, 4, 3, 4);
            btAddClientes.Name = "btAddClientes";
            btAddClientes.Size = new Size(64, 69);
            btAddClientes.TabIndex = 19;
            btAddClientes.TextAlign = ContentAlignment.TopCenter;
            btAddClientes.UseVisualStyleBackColor = false;
            btAddClientes.Click += btAddFornecedor_Click;
            // 
            // btDeleteFornecedor
            // 
            btDeleteFornecedor.BackColor = Color.DarkSeaGreen;
            btDeleteFornecedor.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteFornecedor.Image = (Image)resources.GetObject("btDeleteFornecedor.Image");
            btDeleteFornecedor.Location = new Point(794, 27);
            btDeleteFornecedor.Margin = new Padding(3, 4, 3, 4);
            btDeleteFornecedor.Name = "btDeleteFornecedor";
            btDeleteFornecedor.Size = new Size(64, 69);
            btDeleteFornecedor.TabIndex = 16;
            btDeleteFornecedor.TextAlign = ContentAlignment.TopCenter;
            btDeleteFornecedor.UseVisualStyleBackColor = false;
            btDeleteFornecedor.Click += btDeleteFornecedor_Click;
            // 
            // btEditFornecedor
            // 
            btEditFornecedor.BackColor = Color.DarkSeaGreen;
            btEditFornecedor.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEditFornecedor.Image = (Image)resources.GetObject("btEditFornecedor.Image");
            btEditFornecedor.Location = new Point(723, 27);
            btEditFornecedor.Margin = new Padding(3, 4, 3, 4);
            btEditFornecedor.Name = "btEditFornecedor";
            btEditFornecedor.Size = new Size(64, 69);
            btEditFornecedor.TabIndex = 15;
            btEditFornecedor.TextAlign = ContentAlignment.TopCenter;
            btEditFornecedor.UseVisualStyleBackColor = false;
            btEditFornecedor.Click += btEditFornecedor_Click;
            // 
            // btPesquisarFornecedor
            // 
            btPesquisarFornecedor.BackColor = Color.DarkSeaGreen;
            btPesquisarFornecedor.Image = (Image)resources.GetObject("btPesquisarFornecedor.Image");
            btPesquisarFornecedor.Location = new Point(25, 23);
            btPesquisarFornecedor.Margin = new Padding(3, 4, 3, 4);
            btPesquisarFornecedor.Name = "btPesquisarFornecedor";
            btPesquisarFornecedor.Size = new Size(49, 56);
            btPesquisarFornecedor.TabIndex = 14;
            btPesquisarFornecedor.UseVisualStyleBackColor = false;
            btPesquisarFornecedor.Click += btPesquisarFornecedor_Click;
            // 
            // txtClientes
            // 
            txtClientes.Location = new Point(94, 37);
            txtClientes.Margin = new Padding(3, 4, 3, 4);
            txtClientes.Name = "txtClientes";
            txtClientes.Size = new Size(525, 27);
            txtClientes.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.beija_flor;
            pictureBox2.Location = new Point(14, 743);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(94, 785);
            label2.Name = "label2";
            label2.Size = new Size(239, 33);
            label2.TabIndex = 20;
            label2.Text = "floricultura florescer";
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.BackgroundColor = Color.Ivory;
            dgvFornecedor.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.PaleGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Javanese Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, TELEFONE, EMAIL, CNPJ });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Ivory;
            dataGridViewCellStyle2.Font = new Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFornecedor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFornecedor.GridColor = Color.Ivory;
            dgvFornecedor.Location = new Point(74, 135);
            dgvFornecedor.Margin = new Padding(3, 4, 3, 4);
            dgvFornecedor.Name = "dgvFornecedor";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Ivory;
            dataGridViewCellStyle3.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFornecedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFornecedor.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFornecedor.Size = new Size(784, 600);
            dgvFornecedor.TabIndex = 23;
           
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "idFornecedor";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "nomeFantasia";
            dataGridViewTextBoxColumn2.HeaderText = "NOME";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TELEFONE
            // 
            TELEFONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TELEFONE.DataPropertyName = "telefone";
            TELEFONE.HeaderText = "TELEFONE";
            TELEFONE.MinimumWidth = 6;
            TELEFONE.Name = "TELEFONE";
            // 
            // EMAIL
            // 
            EMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EMAIL.DataPropertyName = "email";
            EMAIL.HeaderText = "EMAIL";
            EMAIL.MinimumWidth = 6;
            EMAIL.Name = "EMAIL";
            // 
            // CNPJ
            // 
            CNPJ.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CNPJ.DataPropertyName = "cnpj";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.MinimumWidth = 6;
            CNPJ.Name = "CNPJ";
            // 
            // Fornecedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(933, 827);
            Controls.Add(dgvFornecedor);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(btAddClientes);
            Controls.Add(btDeleteFornecedor);
            Controls.Add(btEditFornecedor);
            Controls.Add(btPesquisarFornecedor);
            Controls.Add(txtClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Fornecedores";
            Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddClientes;
        private Button btDeleteFornecedor;
        private Button btEditFornecedor;
        private Button btPesquisarFornecedor;
        private TextBox txtClientes;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dgvFornecedor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn TELEFONE;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn CNPJ;
    }
}