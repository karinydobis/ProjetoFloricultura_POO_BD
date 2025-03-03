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
    public partial class CadastroFornecedores : Form
    {
        public CadastroFornecedores()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        private void AtualizarFornecedor()
        {
            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            FornecedorDAO fornDAO = new FornecedorDAO();
            listaFornecedor = fornDAO.Listar();

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            FornecedorDAO fdao = new FornecedorDAO();
            Fornecedor fornecedor = new Fornecedor();
            List<Fornecedor> listaForn = new List<Fornecedor>();
            AtualizarFornecedor();

            if (txtNome.Text == "" || txtTelefone.Text == "" || txtCnpj.Text == ""|| txtEmail.Text == "" || txtRazaoSocial.Text == "")
            {

                MessageBox.Show("Campo em branco, preencha os dados corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                fornecedor.nomeFantasia = txtNome.Text;
                fornecedor.razaoSocial = txtRazaoSocial.Text;
                fornecedor.telefone = txtTelefone.Text;
                fornecedor.cnpj = txtCnpj.Text;
                fornecedor.email = txtEmail.Text;
                fdao.Salvar(fornecedor);
                foreach (var item in listaForn)
                {
                    listaForn.Add(item);
                }

                txtNome.Clear();
                txtRazaoSocial.Clear();
                txtTelefone.Clear();
                txtCnpj.Clear();
                txtEmail.Clear();

                AtualizarFornecedor();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
