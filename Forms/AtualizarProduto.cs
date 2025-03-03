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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projetoPOO_BD.Forms
{
    public partial class AtualizarProduto : Form
    {
        private int idforn;
        public AtualizarProduto(int id, string categoria, string descricao, double preco, 
            string undProduto, string nomeProduto, int id1)
        {
            InitializeComponent();

            idforn = id1;
            txtId.Enabled = false;
            txtId.Text = id.ToString();
            txtCategoria.Text = categoria;
            txtDescricao.Text = descricao;
            txtPreco.Text = preco.ToString();
            txtUnidade.Text = undProduto;
            txtNome.Text = nomeProduto;
           
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AtualizarProdutoCb()
        {
            FornecedorDAO fdao = new FornecedorDAO();
            List<Fornecedor> listForn = fdao.Listar();

            cbFornecedorNovo.DataSource = null;
            cbFornecedorNovo.DataSource = listForn;
            cbFornecedorNovo.DisplayMember = "nomeFantasia";
            cbFornecedorNovo.ValueMember = "idFornecedor";
            cbFornecedorNovo.SelectedIndex = -1;
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ProdutoDAO pdao = new ProdutoDAO();
            Produto produto = new Produto();


            if (txtNome.Text == "" || txtCategoria.Text == "" || txtDescricao.Text == "" || txtUnidade.Text == "" || txtPreco.Text == ""
                || cbFornecedorNovo.SelectedIndex < 0)
            {

                MessageBox.Show("Campo em branco, preencha os dados corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                produto.idProduto = Convert.ToInt32(txtId.Text);
                produto.nomeProduto = txtNome.Text;
                produto.categoria = txtCategoria.Text;
                produto.descricao = txtDescricao.Text;
                produto.undProduto = txtUnidade.Text;
                produto.preco = Convert.ToDouble(txtPreco.Text);
                int fornecedor = Convert.ToInt32(cbFornecedorNovo.SelectedValue);
                produto._fornecedor = (Fornecedor)cbFornecedorNovo.SelectedItem;
                pdao.UpdateProduto(produto);

                txtId.Clear();
                txtNome.Clear();
                txtCategoria.Clear();
                txtUnidade.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                cbFornecedorNovo.SelectedIndex = -1;
            }
        }

        private void AtualizarProduto_Load(object sender, EventArgs e)
        {
            AtualizarProdutoCb();
            cbFornecedorNovo.SelectedValue = idforn;
        }
    }
}
