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
    class ProdutoDAO
    {
        public void SalvarProduto(Produto produto)
        {
            try
            {
                string sql = "INSERT INTO Produtos (nomeProduto, categoria, descricao, preco, undProduto, fkidFornecedor) VALUES " +
                    "(@nomeProduto, @categoria, @descricao, @preco, @undProduto, @fkidFornecedor)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nomeProduto", produto.nomeProduto);
                comando.Parameters.AddWithValue("@categoria", produto.categoria);
                comando.Parameters.AddWithValue("@descricao", produto.descricao);
                comando.Parameters.AddWithValue("@preco", produto.preco);
                comando.Parameters.AddWithValue("@undProduto", produto.undProduto);
                comando.Parameters.AddWithValue("@fkidFornecedor", produto._fornecedor.idFornecedor);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cadastro! {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public List<Produto> Listar()
        {
            List<Produto> listaProdutos = new List<Produto>();

            try
            {
                var sql = "SELECT * FROM Produtos ORDER BY idProduto ASC";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Produto produto = new Produto();
                    produto.idProduto = reader.GetInt32("idProduto");
                    produto.nomeProduto = reader.GetString("nomeProduto");
                    produto.categoria = reader.GetString("categoria");
                    produto.descricao = reader.GetString("descricao");
                    produto.preco = reader.GetDouble("preco");
                    produto.undProduto = reader.GetString("undProduto");
                    int idFornecedor = reader.GetInt32("fkidFornecedor");
                    produto._fornecedor = new Fornecedor { idFornecedor = idFornecedor };
                 

                    listaProdutos.Add(produto);
                }

                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listar cadastros! {ex.Message}");
            }

            return listaProdutos;

        }

        public void UpdateProduto(Produto produtos)
        {

            try
            {
                string sql = "UPDATE Produtos SET idProduto = @idProduto, nomeProduto = @nomeProduto, categoria = @categoria, " +
                    "descricao = @descricao, preco = @preco, undProduto = @undProduto, fkidFornecedor = @fkidFornecedor WHERE idProduto = @idProduto";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nomeProduto", produtos.nomeProduto);
                comando.Parameters.AddWithValue("@categoria", produtos.categoria);
                comando.Parameters.AddWithValue("@descricao", produtos.descricao);
                comando.Parameters.AddWithValue("@preco", produtos.preco);
                comando.Parameters.AddWithValue("@undProduto", produtos.undProduto);
                comando.Parameters.AddWithValue("@idProduto", produtos.idProduto);
                comando.Parameters.AddWithValue("@fkidFornecedor", produtos._fornecedor.idFornecedor);

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

        public void Delete(int idProduto)
        {
            try
            {
                string sql = "DELETE FROM Produtos WHERE idProduto = @idProduto";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@idProduto", idProduto);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir cadastro! {ex.Message}", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
