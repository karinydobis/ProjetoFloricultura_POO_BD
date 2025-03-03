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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
            AtualizarFornecedores();
        }

        private void btAddFornecedor_Click(object sender, EventArgs e)
        {
            CadastroFornecedores form = new CadastroFornecedores();
            form.ShowDialog();
            AtualizarFornecedores();
        }

        private void btPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            string pesquisa = txtClientes.Text.Trim();
            dgvFornecedor.Rows.Clear();

            FornecedorDAO fdao = new FornecedorDAO();
            List<Fornecedor> lista = fdao.Listar();
            List<Fornecedor> fornecedoresFiltrados;

            if (string.IsNullOrEmpty(pesquisa))
            {
                fornecedoresFiltrados = lista;
            }
            else
            {
                fornecedoresFiltrados = lista.Where(f => f.nomeFantasia.Contains(pesquisa, StringComparison.OrdinalIgnoreCase) || f.cnpj.Contains(pesquisa)).ToList();
            }

            foreach (var item in fornecedoresFiltrados)
            {
                dgvFornecedor.Rows.Add(item.idFornecedor, item.nomeFantasia,
                     item.telefone, item.email, item.cnpj);
            }
        }

        private void btEditFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
           
                int idSelecionado = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells[0].Value);
                FornecedorDAO fornDAO = new FornecedorDAO();
                List<Fornecedor> listaFornecedores = fornDAO.Listar();
                Fornecedor f = listaFornecedores.FirstOrDefault(f => f.idFornecedor == idSelecionado);
                
                if(f != null)
                {
                    AtualizarFornecedor form = new AtualizarFornecedor(f.idFornecedor, f.razaoSocial, f.nomeFantasia, f.telefone, f.email, f.cnpj);
                    form.ShowDialog();
                    AtualizarFornecedores();
                }
                else
                {
                    MessageBox.Show("A linha selecionada não contém um fornecedor válido para edição.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                } 

            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor na lista para editar.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void AtualizarFornecedores()
        {
            dgvFornecedor.Rows.Clear();

            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            FornecedorDAO fornDAO = new FornecedorDAO();
            listaFornecedor = fornDAO.Listar();

            foreach (var item in listaFornecedor)
            {
                dgvFornecedor.Rows.Add(item.idFornecedor, item.nomeFantasia,
                     item.telefone, item.email, item.cnpj);
            }
        }

        private void btDeleteFornecedor_Click(object sender, EventArgs e)
        {
            FornecedorDAO fornDAO = new FornecedorDAO();

            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                int idSelecionado = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells[0].Value);

                if(idSelecionado >  0)
                {
                    var confirmacao = MessageBox.Show($"Deseja realmente excluir o fornecedor com ID {idSelecionado}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacao == DialogResult.Yes)
                    {
                        fornDAO.Delete(idSelecionado);
                        AtualizarFornecedores();
                    }
                }
                else
                {
                    MessageBox.Show("A linha selecionada não contém um fornecedor válido para exclusão.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor na lista para excluir.","Atenção", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
