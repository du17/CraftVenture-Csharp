using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GerenciadorDeEstoque.DAO
{
    class DAO
    {
        private Conexao conexao;
        private MySqlConnection con;
        MySqlCommand cmd;
        private MySqlDataReader dr;

        public DAO()
        {
        }

        #region Usuario
        public void IDU(String email, String nome, String senha)
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

        public void ADU(String email, String nome, String senha, Int32 itemid)
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

        public void RDU(String nome, Int32 itemid)
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

        public bool BDU(String nome, string senha)
        {
            conexaoUso busca = new conexaoUso();
            cmd = new MySqlCommand();

            busca.Open();
            cmd.CommandText = "select email, senha, nome WHERE nome ='" + nome + "' AND senha ='" + senha + "'";
            
            if (dr.Read())
            {
                busca.Close();
                return true;
            }
            else
            {
                busca.Close();
                return false;
            }
            
        }

        #endregion

        #region Cliente
        /*public void IDC(String email, String nome, String senha)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO cliente (email, nome, senha) VALUES";
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

        public void ADC(String email, String nome, String senha, Int32 itemid)
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

        public void RDC(String nome, Int32 itemid)
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

        }*/

        #endregion

        #region Pedido

        /*public void IDP(String email, String nome, String senha)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (email, nome, senha) VALUES";
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

        public void ADP(String email, String nome, String senha, Int32 itemid)
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

        public void RDP(String nome, Int32 itemid)
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

        }*/

        #endregion

    }
}
