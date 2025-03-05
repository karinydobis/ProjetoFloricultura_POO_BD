namespace projetoPOO_BD
{
    partial class CadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            pictureBox2 = new PictureBox();
            label13 = new Label();
            btSalvar = new Button();
            btCancelar = new Button();
            label10 = new Label();
            txtNome = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCategoria = new TextBox();
            txtDescricao = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtUnidade = new TextBox();
            txtPreco = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cbFornecedor = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.beija_flor;
            pictureBox2.Location = new Point(14, 744);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 51;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkOliveGreen;
            label13.Location = new Point(94, 787);
            label13.Name = "label13";
            label13.Size = new Size(239, 33);
            label13.TabIndex = 50;
            label13.Text = "floricultura florescer";
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.Lime;
            btSalvar.Font = new Font("Javanese Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.Image = (Image)resources.GetObject("btSalvar.Image");
            btSalvar.Location = new Point(699, 707);
            btSalvar.Margin = new Padding(3, 4, 3, 4);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(89, 85);
            btSalvar.TabIndex = 49;
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Red;
            btCancelar.Font = new Font("Javanese Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Image = (Image)resources.GetObject("btCancelar.Image");
            btCancelar.Location = new Point(588, 707);
            btCancelar.Margin = new Padding(3, 4, 3, 4);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(89, 85);
            btCancelar.TabIndex = 48;
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Javanese Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(59, 112);
            label10.Name = "label10";
            label10.Size = new Size(0, 54);
            label10.TabIndex = 44;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(59, 335);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 44);
            txtNome.TabIndex = 29;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(59, 233);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(330, 44);
            txtId.TabIndex = 28;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Javanese Text", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(-45, -1);
            label2.Name = "label2";
            label2.Size = new Size(1019, 120);
            label2.TabIndex = 27;
            label2.Text = "CADASTRO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(59, 196);
            label1.Name = "label1";
            label1.Size = new Size(48, 45);
            label1.TabIndex = 30;
            label1.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(59, 299);
            label3.Name = "label3";
            label3.Size = new Size(88, 45);
            label3.TabIndex = 31;
            label3.Text = "NOME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(59, 403);
            label4.Name = "label4";
            label4.Size = new Size(142, 45);
            label4.TabIndex = 53;
            label4.Text = "CATEGORIA:";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(59, 439);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(330, 44);
            txtCategoria.TabIndex = 52;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(59, 543);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(330, 44);
            txtDescricao.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(59, 507);
            label5.Name = "label5";
            label5.Size = new Size(140, 45);
            label5.TabIndex = 55;
            label5.Text = "DESCRIÇÃO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(467, 403);
            label7.Name = "label7";
            label7.Size = new Size(163, 45);
            label7.TabIndex = 61;
            label7.Text = "FORNECEDOR:";
            // 
            // txtUnidade
            // 
            txtUnidade.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnidade.Location = new Point(467, 335);
            txtUnidade.Margin = new Padding(3, 4, 3, 4);
            txtUnidade.Name = "txtUnidade";
            txtUnidade.Size = new Size(330, 44);
            txtUnidade.TabIndex = 57;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.White;
            txtPreco.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(467, 233);
            txtPreco.Margin = new Padding(3, 4, 3, 4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(330, 44);
            txtPreco.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(467, 196);
            label8.Name = "label8";
            label8.Size = new Size(92, 45);
            label8.TabIndex = 58;
            label8.Text = "PREÇO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(467, 299);
            label9.Name = "label9";
            label9.Size = new Size(120, 45);
            label9.TabIndex = 59;
            label9.Text = "UNIDADE:";
            // 
            // cbFornecedor
            // 
            cbFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFornecedor.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFornecedor.FormattingEnabled = true;
            cbFornecedor.Location = new Point(467, 441);
            cbFornecedor.Name = "cbFornecedor";
            cbFornecedor.Size = new Size(330, 42);
            cbFornecedor.TabIndex = 62;
            // 
            // CadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(933, 827);
            Controls.Add(cbFornecedor);
            Controls.Add(label7);
            Controls.Add(txtUnidade);
            Controls.Add(txtPreco);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtDescricao);
            Controls.Add(label5);
            Controls.Add(txtCategoria);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label13);
            Controls.Add(btSalvar);
            Controls.Add(btCancelar);
            Controls.Add(label10);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroProdutos";
            Text = "CadastroProdutos";
            Load += CadastroProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label13;
        private Button btSalvar;
        private Button btCancelar;
        private Label label10;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtCategoria;
        private TextBox txtDescricao;
        private Label label5;
        private Label label7;
        private TextBox txtUnidade;
        private TextBox txtPreco;
        private Label label8;
        private Label label9;
        private ComboBox cbFornecedor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}