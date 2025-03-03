

using projetoPOO_BD.Data;

namespace projetoPOO_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            Produtos form = new Produtos();
            form.ShowDialog();
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores form = new Fornecedores();
            form.ShowDialog();
        }

        private void btConfiguracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ops, esse botão não funciona :)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
