using MySql.Data.MySqlClient;
using projetoPOO_BD.Data;
using projetoPOO_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPOO_BD.DAO
{
    class FornecedorDAO
    {
        public void Salvar(Fornecedor fornecedor)
        {
            try
            {
                string sql = "INSERT INTO Fornecedores (nomeFantasia, razaoSocial, cnpj, telefone, email) VALUES (@nomeFantasia, @razaoSocial, @cnpj, @telefone, @email)";
               
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nomeFantasia", fornecedor.nomeFantasia);
                comando.Parameters.AddWithValue("@razaoSocial", fornecedor.razaoSocial);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                comando.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                comando.Parameters.AddWithValue("@email", fornecedor.email);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cadastro! {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Update(Fornecedor fornecedores)
        {

            try
            {
                string sql = "UPDATE Fornecedores SET idFornecedor = @idFornecedor, nomeFantasia = @nomeFantasia, razaoSocial = @razaoSocial, cnpj = @cnpj, telefone = @telefone, " +
                    "email = @email WHERE idFornecedor = @idFornecedor";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nomeFantasia", fornecedores.nomeFantasia);
                comando.Parameters.AddWithValue("@razaoSocial", fornecedores.razaoSocial);
                comando.Parameters.AddWithValue("@cnpj", fornecedores.cnpj);
                comando.Parameters.AddWithValue("@telefone", fornecedores.telefone);
                comando.Parameters.AddWithValue("@email", fornecedores.email);
                comando.Parameters.AddWithValue("@idFornecedor", fornecedores.idFornecedor);

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar cadastro! {ex.Message}", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        public void Delete(int idFornecedor)
        {
            try
            {
                string sql = "DELETE FROM Fornecedores WHERE idFornecedor = @idFornecedor";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@idFornecedor", idFornecedor);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir cadastro! {ex.Message}", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public List<Fornecedor> Listar()
        {
            List<Fornecedor> listaFornecedor = new List<Fornecedor>();

            try
            {
                var sql = "SELECT * FROM Fornecedores ORDER BY idFornecedor ASC";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Fornecedor forn = new Fornecedor();
                    forn.idFornecedor = reader.GetInt32("idFornecedor");
                    forn.nomeFantasia = reader.GetString("nomeFantasia");
                    forn.razaoSocial = reader.GetString("razaoSocial");
                    forn.cnpj = reader.GetString("cnpj");
                    forn.telefone = reader.GetString("telefone");
                    forn.email = reader.GetString("email");
                  
               
                    listaFornecedor.Add(forn);
                }

                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listar cadastros! {ex.Message}");
            }

            return listaFornecedor;

        }
    
    }
}
