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
    public partial class AtualizarFornecedor : Form
    {
        private int idFornecedor;
        public AtualizarFornecedor(int id, string razaoSocial, string nomeFantasia, string telefone, string email, string cnpj)
        {
            InitializeComponent();

            idFornecedor = id;
            txtIdnovo.Enabled = false;
            txtIdnovo.Text = id.ToString();
            txtRazaoSocialnovo.Text = razaoSocial;
            txtNomenovo.Text = nomeFantasia;
            txtTelefonenovo.Text = telefone;
            txtEmailnovo.Text = email;
            txtCnpjnovo.Text = cnpj;

        }

        private void btCancelarnovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarnovo_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            FornecedorDAO fdao = new FornecedorDAO();

            if (txtNomenovo.Text == "" || txtRazaoSocialnovo.Text == "" || txtCnpjnovo.Text == "" || txtEmailnovo.Text == ""
                || txtTelefonenovo.Text == "")
            {
                MessageBox.Show("Campo em branco, preencha os dados corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fornecedor.idFornecedor = idFornecedor;
                fornecedor.nomeFantasia = txtNomenovo.Text;
                fornecedor.razaoSocial = txtRazaoSocialnovo.Text;
                fornecedor.telefone = txtTelefonenovo.Text;
                fornecedor.cnpj = txtCnpjnovo.Text;
                fornecedor.email = txtEmailnovo.Text;
                fdao.Update(fornecedor);

                txtNomenovo.Clear();
                txtRazaoSocialnovo.Clear();
                txtTelefonenovo.Clear();
                txtCnpjnovo.Clear();
                txtEmailnovo.Clear();
                txtIdnovo.Clear();
            }
        }
      
    }
}
