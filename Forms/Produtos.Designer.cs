namespace projetoPOO_BD
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btAddProdutos = new Button();
            txtProdutos = new TextBox();
            btPesquisarProdutos = new Button();
            btEditProdutos = new Button();
            btDeleteProdutos = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            dgvProdutos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            CATEGORIA = new DataGridViewTextBoxColumn();
            PRECO = new DataGridViewTextBoxColumn();
            UNIDADE = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // btAddProdutos
            // 
            btAddProdutos.BackColor = Color.DarkSeaGreen;
            btAddProdutos.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAddProdutos.Image = (Image)resources.GetObject("btAddProdutos.Image");
            btAddProdutos.Location = new Point(650, 28);
            btAddProdutos.Margin = new Padding(3, 4, 3, 4);
            btAddProdutos.Name = "btAddProdutos";
            btAddProdutos.Size = new Size(64, 69);
            btAddProdutos.TabIndex = 1;
            btAddProdutos.TextAlign = ContentAlignment.TopCenter;
            btAddProdutos.UseVisualStyleBackColor = false;
            btAddProdutos.Click += btAddProdutos_Click;
            // 
            // txtProdutos
            // 
            txtProdutos.Location = new Point(93, 39);
            txtProdutos.Margin = new Padding(3, 4, 3, 4);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(525, 27);
            txtProdutos.TabIndex = 2;
            // 
            // btPesquisarProdutos
            // 
            btPesquisarProdutos.BackColor = Color.DarkSeaGreen;
            btPesquisarProdutos.Image = (Image)resources.GetObject("btPesquisarProdutos.Image");
            btPesquisarProdutos.Location = new Point(24, 24);
            btPesquisarProdutos.Margin = new Padding(3, 4, 3, 4);
            btPesquisarProdutos.Name = "btPesquisarProdutos";
            btPesquisarProdutos.Size = new Size(49, 56);
            btPesquisarProdutos.TabIndex = 4;
            btPesquisarProdutos.UseVisualStyleBackColor = false;
            btPesquisarProdutos.Click += btPesquisarProdutos_Click;
            // 
            // btEditProdutos
            // 
            btEditProdutos.BackColor = Color.DarkSeaGreen;
            btEditProdutos.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEditProdutos.Image = (Image)resources.GetObject("btEditProdutos.Image");
            btEditProdutos.Location = new Point(721, 28);
            btEditProdutos.Margin = new Padding(3, 4, 3, 4);
            btEditProdutos.Name = "btEditProdutos";
            btEditProdutos.Size = new Size(64, 69);
            btEditProdutos.TabIndex = 5;
            btEditProdutos.TextAlign = ContentAlignment.TopCenter;
            btEditProdutos.UseVisualStyleBackColor = false;
            btEditProdutos.Click += btEditProdutos_Click;
            // 
            // btDeleteProdutos
            // 
            btDeleteProdutos.BackColor = Color.DarkSeaGreen;
            btDeleteProdutos.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeleteProdutos.Image = (Image)resources.GetObject("btDeleteProdutos.Image");
            btDeleteProdutos.Location = new Point(792, 28);
            btDeleteProdutos.Margin = new Padding(3, 4, 3, 4);
            btDeleteProdutos.Name = "btDeleteProdutos";
            btDeleteProdutos.Size = new Size(64, 69);
            btDeleteProdutos.TabIndex = 6;
            btDeleteProdutos.TextAlign = ContentAlignment.TopCenter;
            btDeleteProdutos.UseVisualStyleBackColor = false;
            btDeleteProdutos.Click += btDeleteProdutos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.beija_flor;
            pictureBox2.Location = new Point(14, 743);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
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
            label2.TabIndex = 8;
            label2.Text = "floricultura florescer";
            // 
            // dgvProdutos
            // 
            dgvProdutos.BackgroundColor = Color.Ivory;
            dgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.PaleGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Javanese Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, CATEGORIA, PRECO, UNIDADE });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Ivory;
            dataGridViewCellStyle2.Font = new Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProdutos.GridColor = Color.Ivory;
            dgvProdutos.Location = new Point(72, 135);
            dgvProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvProdutos.Name = "dgvProdutos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Ivory;
            dataGridViewCellStyle3.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(784, 600);
            dgvProdutos.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "idProduto";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "nomeProduto";
            dataGridViewTextBoxColumn2.HeaderText = "NOME";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CATEGORIA
            // 
            CATEGORIA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CATEGORIA.DataPropertyName = "categoria";
            CATEGORIA.HeaderText = "CATEGORIA";
            CATEGORIA.MinimumWidth = 6;
            CATEGORIA.Name = "CATEGORIA";
            // 
            // PRECO
            // 
            PRECO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PRECO.DataPropertyName = "preco";
            PRECO.HeaderText = "PREÇO";
            PRECO.MinimumWidth = 6;
            PRECO.Name = "PRECO";
            // 
            // UNIDADE
            // 
            UNIDADE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UNIDADE.DataPropertyName = "undProduto";
            UNIDADE.HeaderText = "UNIDADE";
            UNIDADE.MinimumWidth = 6;
            UNIDADE.Name = "UNIDADE";
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(933, 827);
            Controls.Add(dgvProdutos);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(btDeleteProdutos);
            Controls.Add(btEditProdutos);
            Controls.Add(btPesquisarProdutos);
            Controls.Add(txtProdutos);
            Controls.Add(btAddProdutos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Produtos";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btAddProdutos;
        private TextBox txtProdutos;
        private Button btPesquisarProdutos;
        private Button btEditProdutos;
        private Button btDeleteProdutos;
        private PictureBox pictureBox2;
        private Label label2;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn CATEGORIA;
        private DataGridViewTextBoxColumn PRECO;
        private DataGridViewTextBoxColumn UNIDADE;
    }
}