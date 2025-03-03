using projetoPOO_BD.DAO;
using projetoPOO_BD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoPOO_BD
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

       
        private void btSalvar_Click(object sender, EventArgs e)
        {
            ProdutoDAO pdao = new ProdutoDAO();
            Produto produto = new Produto();
           

            if (txtNome.Text == "" || txtCategoria.Text == "" || txtDescricao.Text == "" || txtUnidade.Text == "" || txtPreco.Text == "" || 
                cbFornecedor.SelectedIndex < 0)
            {

                MessageBox.Show("Campo em branco, preencha os dados corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                produto.nomeProduto = txtNome.Text;
                produto.categoria = txtCategoria.Text;
                produto.descricao = txtDescricao.Text;
                produto.undProduto = txtUnidade.Text;
                produto.preco = Convert.ToDouble(txtPreco.Text);
                produto._fornecedor = (Fornecedor)cbFornecedor.SelectedItem;
                int fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);

                pdao.SalvarProduto(produto);

                txtNome.Clear();
                txtCategoria.Clear();
                txtUnidade.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                cbFornecedor.SelectedIndex = -1;

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CbFornecedores()
        {
           
            FornecedorDAO fdao = new FornecedorDAO();
            List<Fornecedor> listForn = fdao.Listar();
            Fornecedor forn = new Fornecedor();

            cbFornecedor.DataSource = null;
            cbFornecedor.DataSource = listForn;
            cbFornecedor.DisplayMember = "nomeFantasia";
            cbFornecedor.ValueMember = "idFornecedor";
            cbFornecedor.SelectedIndex = -1;     
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            CbFornecedores();
        }
    }
}
