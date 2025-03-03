using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projetoPOO_BD.Data
{
    class Conexao
    {
        static MySqlConnection? conexao;
        static string strconexao = "server=localhost;uid=root;pwd=root;database=floriculturaFlorescer";

        public static MySqlConnection Conectar()
        {
            try
            {
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar conectar. " + ex.Message);
            }
        }

        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}
