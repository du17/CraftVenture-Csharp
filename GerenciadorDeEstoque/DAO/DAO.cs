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
        public void InserirDados(String email, String nome, String senha)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO usuario (email, nome, senha) VALUES";
            query += "(?email, ?nome, ?senha)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void AtualizarDados(String email, String nome, String senha, Int32 itemid)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET email = ?email, senha = ?senha, nome = ?nome";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RemoverDados(String nome, Int32 itemid)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += "WHERE nome = ?nome AND itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?itemid", itemid);
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
