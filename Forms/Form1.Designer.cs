namespace projetoPOO_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btFornecedores = new Button();
            btConfiguracao = new Button();
            btProdutos = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Javanese Text", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(-50, -4);
            label1.Name = "label1";
            label1.Size = new Size(1019, 120);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btFornecedores
            // 
            btFornecedores.BackColor = Color.DarkSeaGreen;
            btFornecedores.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btFornecedores.ForeColor = Color.DarkGreen;
            btFornecedores.Image = (Image)resources.GetObject("btFornecedores.Image");
            btFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btFornecedores.Location = new Point(157, 357);
            btFornecedores.Margin = new Padding(3, 4, 3, 4);
            btFornecedores.Name = "btFornecedores";
            btFornecedores.Size = new Size(605, 109);
            btFornecedores.TabIndex = 2;
            btFornecedores.Text = "FORNECEDORES";
            btFornecedores.UseVisualStyleBackColor = false;
            btFornecedores.Click += btFornecedores_Click;
            // 
            // btConfiguracao
            // 
            btConfiguracao.BackColor = Color.DarkSeaGreen;
            btConfiguracao.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfiguracao.ForeColor = Color.DarkGreen;
            btConfiguracao.Image = (Image)resources.GetObject("btConfiguracao.Image");
            btConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            btConfiguracao.Location = new Point(157, 505);
            btConfiguracao.Margin = new Padding(3, 4, 3, 4);
            btConfiguracao.Name = "btConfiguracao";
            btConfiguracao.RightToLeft = RightToLeft.No;
            btConfiguracao.Size = new Size(605, 109);
            btConfiguracao.TabIndex = 3;
            btConfiguracao.Text = "CONFIGURAÇÕES";
            btConfiguracao.UseVisualStyleBackColor = false;
            btConfiguracao.Click += btConfiguracao_Click;
            // 
            // btProdutos
            // 
            btProdutos.BackColor = Color.DarkSeaGreen;
            btProdutos.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProdutos.ForeColor = Color.DarkGreen;
            btProdutos.Image = (Image)resources.GetObject("btProdutos.Image");
            btProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btProdutos.Location = new Point(157, 208);
            btProdutos.Margin = new Padding(3, 4, 3, 4);
            btProdutos.Name = "btProdutos";
            btProdutos.Size = new Size(605, 109);
            btProdutos.TabIndex = 4;
            btProdutos.Text = "PRODUTOS";
            btProdutos.UseVisualStyleBackColor = false;
            btProdutos.Click += btProdutos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 792);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(942, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(94, 752);
            label2.Name = "label2";
            label2.Size = new Size(239, 33);
            label2.TabIndex = 6;
            label2.Text = "floricultura florescer";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.beija_flor;
            pictureBox2.Location = new Point(14, 709);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DarkGreen;
            linkLabel1.Location = new Point(813, 761);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "florescer.com.br";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(933, 827);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btProdutos);
            Controls.Add(btConfiguracao);
            Controls.Add(btFornecedores);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btFornecedores;
        private Button btConfiguracao;
        private Button btProdutos;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
    }
}
