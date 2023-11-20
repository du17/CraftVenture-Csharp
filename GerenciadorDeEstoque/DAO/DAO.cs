using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEstoque.Apresentação.Menu;
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

        private long idLastInsert = -1;

        public DAO()
        {
        }

        #region Usuario
        public void IDU(String email, String nome, String senha)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
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

        public void ADU(String email, String nome, String senha, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE usuario SET email = ?email, senha = ?senha, nome = ?nome";
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

        public void RDU(String email, String nome, String senha, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM usuario";
            query += "WHERE nome = ?nome, email = ?email, senha = ?senha, itemid = ?itemid";
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

        public int BDU(String nome, String senha)
        {
            try
            {
                conexao = new Conexao();
                con = new MySqlConnection();

                con.ConnectionString = conexao.getConnectionString();

                con.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;

                cmd.CommandText = "SELECT id FROM usuario WHERE nome LIKE @nome OR senha LIKE @senha";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);


                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader.GetString(0));
                    con.Close();

                    return id;
                }
                else
                {
                    con.Close();

                    return -1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("erro" + ex.Message + "ocorreu: " + ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex.Message + "ocorreu: " + ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally { con.Close(); }

        }

        #endregion

        #region Cliente
        public void IDC(String email, String nome)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO cliente (email, nome) VALUES";
            query += "(?email, ?nome)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADC(String email, String nome, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET email = ?email, senha = ?senha, nome = ?nome";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDC(String email, String nome, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += "WHERE nome = ?nome, itemid = ?itemid, email = ?email";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Venda

        public void IDV(String nome, Int64 quantidade, String anotacao, Double valorTotal, String nomeCliente, String telefone, Int64 formaPagamento, Int64 CodCliente)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (nome, quantidade, anotacao, valorTotal, nomeCliente, telefone, formaPagamento, CodCliente) VALUES";
            query += "(?nome, ?quantidade, ?anotacao, ?valorTotal, ?nomeCliente, ?telefone, ?formaPagamento, ?CodCliente)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?anotacao", anotacao);
                cmd.Parameters.AddWithValue("?valorTotal", valorTotal);
                cmd.Parameters.AddWithValue("?nomeCliente", nomeCliente);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?formaPagamento", formaPagamento);
                cmd.Parameters.AddWithValue("?CodCliente", CodCliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADV(String nome, Int64 quantidade, String anotacao, Double valorTotal, String nomeCliente, String telefone, Int64 formaPagamento, Int64 CodCliente, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET quantidade = ?quantidade, anotacao = ?anotacao, nome = ?nome, valorTotal = ?valorTotal, nomeCliente = ?nomeCliente, " +
                "                              telefone = ?telefone, formaPagamento = ?formaPagamento, CodCliente = ?CodCliente";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?anotacao", anotacao);
                cmd.Parameters.AddWithValue("?valorTotal", valorTotal);
                cmd.Parameters.AddWithValue("?nomeCliente", nomeCliente);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?formaPagamento", formaPagamento);
                cmd.Parameters.AddWithValue("?CodCliente", CodCliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }


        public void RDV(String nome, Int64 quantidade, String anotacao, Double valorTotal, String nomeCliente, String telefone, Int64 formaPagamento, Int64 CodCliente, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += "WHERE itemid = ?itemid, quantidade = ?quantidade, anotacao = ?anotacao, nome = ?nome, valorTotal = ?valorTotal, nomeCliente = ?nomeCliente, " +
                "                              telefone = ?telefone, formaPagamento = ?formaPagamento, CodCliente = ?CodCliente";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?anotacao", anotacao);
                cmd.Parameters.AddWithValue("?valorTotal", valorTotal);
                cmd.Parameters.AddWithValue("?nomeCliente", nomeCliente);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?formaPagamento", formaPagamento);
                cmd.Parameters.AddWithValue("?CodCliente", CodCliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Produto

        public void IDP(Double valor, Int64 quantidade, String nome, String materialUsado, String tipo)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (valor, quantidade, nome, materialUsado, tipo) VALUES";
            query += "(?valor, ?quantidade, ?nome, ?materialUsado, ?tipo)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?materialUsado", materialUsado);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADP(Double valor, Int64 quantidade, String nome, String materialUsado, String tipo, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET quantidade = ?quantidade, tipo = ?tipo, nome = ?nome, valor = ?valor, materialUsado = ?materialUsado";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?materialUsado", materialUsado);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }


        public void RDP(Double valor, Int64 quantidade, String nome, String materialUsado, String tipo, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid, quantidade = ?quantidade, tipo = ?tipo, nome = ?nome, valor = ?valor, materialUsado = ?materialUsado";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?materialUsado", materialUsado);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Telefones

        public void IDT(String telefone, Int64 codCliente)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (telefone, codCliente) VALUES";
            query += "(?telefone, ?codCliente)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?codCliente", codCliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADT(String telefone, Int64 codCliente, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET codCLiente = ?codCliente, telefone = ?telefone";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?codCliente", codCliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDT(String telefone, Int64 codCliente, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid, codCliente = ?codCliente, telefone = ?telefone";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?codCliente", codCliente);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Vende

        public void IDVENDE(Int64 idvenda, Int64 idproduto)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (idvenda, idproduto) VALUES";
            query += "(?idvenda, ?idproduto)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?idvenda", idvenda);
                cmd.Parameters.AddWithValue("?idproduto", idproduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADVENDE(Int64 idvenda, Int64 idproduto, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET idvenda = ?idvenda, idproduto = ?idproduto";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?idvenda", idvenda);
                cmd.Parameters.AddWithValue("?idproduto", idproduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDVENDE(Int64 idvenda, Int64 idproduto, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid, idvenda = ?idvenda, idproduto = ?idproduto";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?idvenda", idvenda);
                cmd.Parameters.AddWithValue("?idproduto", idproduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Tipo Material

        public void IDTIPO(String nome)
        {
            conexao = new Conexao();
            con = new MySqlConnection();

            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO tipoMaterial (nome) VALUES";
            query += "(?nome)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                
                idLastInsert = cmd.LastInsertedId;

                cmd.Dispose();

                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                con.Close();
            }
        }

        public void ADTIPO(String nome, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET nome = ?nome";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDTIPO(String nome, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid, nome = ?nome";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Material

        public void IDM(Int64 idmaterial, String nome, Double valor)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO material (idTipoMaterial, nome, valor) VALUES";
            query += "(?idTipoMaterial, ?nome, ?valor)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?idTipoMaterial", idmaterial);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADM(Int64 idmaterial, String nome, Double valor, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET nome = ?nome";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?idmaterial", idmaterial);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDM(Int64 idmaterial, String nome, Double valor, Int64 itemid)
        {
            conexao = new Conexao();
            con = new MySqlConnection();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?idmaterial", idmaterial);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Material Produto

        public void IDMPRODUTO(Int64 idmaterial, Int64 idproduto)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (idmaterial, idproduto) VALUES";
            query += "(?idmaterial, ?idproduto)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?idmaterial", idmaterial);
                cmd.Parameters.AddWithValue("?idproduto", idproduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADMPRODUTO(Int64 idmaterial, Int64 idproduto, Int64 itemid)

        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET idmaterial = ?idmaterial, idproduto = ?idproduto";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?idmaterial", idmaterial);
                cmd.Parameters.AddWithValue("?idproduto", idproduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDMPRODUTO(Int64 idmaterial, Int64 idproduto, Int64 itemid)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid, idmaterial = ?idmaterial, idproduto = ?idproduto";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?idmaterial", idmaterial);
                cmd.Parameters.AddWithValue("?idproduto", idproduto);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Renda

        public void IDR(String tamanho, Double metragem)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (tamanho, metragem) VALUES";
            query += "(?tamanho, ?metragem)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tamamnho", tamanho);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADR(String tamanho, Double metragem, Int64 itemid)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET tamanho = ?tamanho, metragem = ?metragem";
            query += " WHERE itemid = ?itemid";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?tamamnho", tamanho);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDR(String tamanho, Double metragem, Int64 itemid)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemid = ?itemid, tamanho = ?tamanho, metragem = ?metragem";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemid", itemid);
                cmd.Parameters.AddWithValue("?tamamnho", tamanho);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Canudo

      
        public void IDCANUDO(Int64 idtipomaterial, Int64 quantidade, String cor)

        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO canudo (idTipoMaterial, quantidade, cor) VALUES";
            query += "(?idTipoMaterial, ?quantidade, ?cor)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?idTipoMaterial", idtipomaterial);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public long getLastId()
        {
            if (idLastInsert != -1)
            {
                long lastId = idLastInsert;

                idLastInsert = -1;

                return lastId;
            }
            else
            {
                throw new ArgumentNullException("O valor não foi encontrado! Algo deu errado com o lastInsertid");
            }
        }

        public void ADCANUDO(Int64 quantidade, String cor, Int64 itemidproduto)

        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET quantidade = ?quantidade, cor = ?cor";
            query += " WHERE itemidproduto = ?itemidproduto";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidproduto", itemidproduto);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDCANUDO(Int64 quantidade, String cor, Int64 itemidproduto)

        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemidproduto = ?itemidproduto, quantidade = ?quantidade, cor = ?cor";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidproduto", itemidproduto);
                cmd.Parameters.AddWithValue("?quantidade", quantidade);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Fita

        public void IDF(Int64 numero, String tipo, String marca, String numeroCor, Double metragem)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (numero, tipo, marca, numeroCor, metragem) VALUES";
            query += "(?numero, ?tipo, ?marca, ?numeroCor, ?metragem)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?marca", marca);
                cmd.Parameters.AddWithValue("?numeroCor", numeroCor);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADF(Int64 numero, String tipo, String marca, String numeroCor, Double metragem, Int64 itemidTipoMaterial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET numero = ?numero, tipo = ?tipo, marca = ?marca, numeroCor = ?numeroCor, metragem = ?metragem";
            query += " WHERE itemidTipoMaterial = ?itemidTipoMaterial";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMaterial", itemidTipoMaterial);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?marca", marca);
                cmd.Parameters.AddWithValue("?numeroCor", numeroCor);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDF(Int64 numero, String tipo, String marca, String numeroCor, Double metragem, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreia, numero = ?numero, tipo = ?tipo, marca = ?marca, numeroCor = ?numeroCor, metragem = ?metragem";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?numero", numero);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?marca", marca);
                cmd.Parameters.AddWithValue("?numeroCor", numeroCor);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Papel

        public void IDPAPEL(String tipo, String gramatura, String cor, String tamanho)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (tipo, gramatura, cor, tamanho) VALUES";
            query += "(?tipo, ?gramatura, ?cor, ?tamanho)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?gramatura", gramatura);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADPAPEL(String tipo, String gramatura, String cor, String tamanho, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET tipo = ?tipo, gramatura = ?gramatura, cor = ?cor, tamanho = ?tamanho";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreial";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?gramatura", gramatura);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDPAPEL(String tipo, String gramatura, String cor, String tamanho, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreia, tipo = ?tipo, gramatura = ?gramatura, cor = ?cor, tamanho = ?tamanho";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?gramatura", gramatura);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Tecido

        public void IDTECIDO(String tipo, String tipoEstampa, Double metragem)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (tipo, tipoEstampa, metragem) VALUES";
            query += "(?tipo, ?tipoEstampa, ?metragem)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?tipoEstampa", tipoEstampa);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADTECIDO(String tipo, String tipoEstampa, Double metragem, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET tipo = ?tipo, tipoEstampa = ?tipoEstampa, metragem = ?metragem";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreial";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?tipoEstampa", tipoEstampa);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDTECIDO(String tipo, String tipoEstampa, Double metragem, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreia, tipo = ?tipo, tipoEstampa = ?tipoEstampa, metragem = ?metragem";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?tipo", tipo);
                cmd.Parameters.AddWithValue("?tipoEstampa", tipoEstampa);
                cmd.Parameters.AddWithValue("?metragem", metragem);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Acetato

        public void IDE(String tamanho, Double espessura)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (tamanho, espessura) VALUES";
            query += "(?tamanho, ?espessura)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.Parameters.AddWithValue("?espessura", espessura);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADE(String tamanho, Double espessura, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET tamanho = ?tamanho, espessura = ?espessura";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreial";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.Parameters.AddWithValue("?espessura", espessura);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDE(String tamanho, Double espessura, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreia, tamanho = ?tamanho, espessura = ?espessura";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.Parameters.AddWithValue("?espessura", espessura);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #region Perola

        public void IDPEROLA(String cor, Double tamanho)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();

            String query = "INSERT INTO pedido (cor, tamanho) VALUES";
            query += "(?cor, ?tamanho)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void ADPEROLA(String cor, Double tamanho, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "UPDATE estoque SET cor = ?cor, tamanho = ?tamanho";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreial";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        public void RDPEROLA(String cor, Double tamanho, Int64 itemidTipoMatreial)
        {
            con = new MySqlConnection();
            conexao = new Conexao();
            con.ConnectionString = conexao.getConnectionString();
            String query = "DELETE FROM estoque";
            query += " WHERE itemidTipoMatreial = ?itemidTipoMatreial, cor = ?cor, espessura = ?espessura";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemidTipoMatreial", itemidTipoMatreial);
                cmd.Parameters.AddWithValue("?cor", cor);
                cmd.Parameters.AddWithValue("?tamanho", tamanho);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

    }
}
