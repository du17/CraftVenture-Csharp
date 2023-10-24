using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.DAO
{
    class DAO
    {
        private Conexao conexao;
        private MySqlConnection con;

        public DAO()
        {
        }

           //  Usuario
        public void InserirDados(String itemcodigo, String itemdescricao, Double itempreco)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO inventario (itemcodigo, itemdescricao, itempreco) VALUES";
            query += "(?itemcodigo, ?itemdescricao, ?itempreco)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemcodigo", itemcodigo);
                cmd.Parameters.AddWithValue("?itemdescricao", itemdescricao);
                cmd.Parameters.AddWithValue("?itempreco", itempreco);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

    }
}
