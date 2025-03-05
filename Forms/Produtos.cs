using projetoPOO_BD.DAO;
using projetoPOO_BD.Forms;
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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            AtualizarProduto();
        }

        private void AtualizarProduto()
        {
            dgvProdutos.Rows.Clear();
            List<Produto> listaProdutos = new List<Produto>();
            ProdutoDAO pdao = new ProdutoDAO();
            listaProdutos = pdao.Listar();
            
            foreach (var item in listaProdutos )
            {
                dgvProdutos.Rows.Add(item.idProduto, item.nomeProduto,
                     item.categoria, item.descricao, item.preco, item.undProduto, item._fornecedor.idFornecedor);
            }
        }

        private void btAddProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos form = new CadastroProdutos();
            form.ShowDialog();
            AtualizarProduto();
        }

        private void btPesquisarProdutos_Click(object sender, EventArgs e)
        {
            string pesquisa = txtProdutos.Text.Trim();
            dgvProdutos.Rows.Clear();
       
            ProdutoDAO pdao = new ProdutoDAO();
            List<Produto> lista = pdao.Listar();
            List<Produto> produtosFiltrados;

            if (string.IsNullOrEmpty(pesquisa))
            {
                produtosFiltrados = lista;
            }
            else
            {
                produtosFiltrados = lista.Where(f => f.nomeProduto.Contains(pesquisa, StringComparison.OrdinalIgnoreCase) || f.categoria.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var item in produtosFiltrados)
            {
                dgvProdutos.Rows.Add(item.idProduto, item.nomeProduto,
                     item.categoria, item.descricao, item.preco, item.undProduto, item._fornecedor.idFornecedor);
            }
        }

        private void btEditProdutos_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {

                int idSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                ProdutoDAO pdao = new ProdutoDAO();
                List<Produto> listaProduto = pdao.Listar();
                Produto p = listaProduto.FirstOrDefault(p => p.idProduto == idSelecionado);

                if (p != null)
                {
                    AtualizarProduto form = new AtualizarProduto(p.idProduto, p.categoria, p.descricao, 
                        p.preco, p.undProduto, p.nomeProduto, p._fornecedor.idFornecedor);

                    form.ShowDialog();
                    AtualizarProduto();
                }
                else
                {
                    MessageBox.Show("A linha selecionada não contém um produto válido para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto na lista para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btDeleteProdutos_Click(object sender, EventArgs e)
        {
            ProdutoDAO pdao = new ProdutoDAO();

            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);

                if (idSelecionado > 0)
                {
                    var confirmacao = MessageBox.Show($"Deseja realmente excluir o produto com ID {idSelecionado}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacao == DialogResult.Yes)
                    {
                        pdao.Delete(idSelecionado);
                        AtualizarProduto();
                    }
                }
                else
                {
                    MessageBox.Show("A linha selecionada não contém um produto válido para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
