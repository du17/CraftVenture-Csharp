using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    class Conexao
    {
        private static String connectionString;

        public String getConnectionString()
        {
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["Estoque"].ConnectionString;
                return connectionString;
            }catch (Exception erro)
            {

                //cria uma string com as informações do erro
                StringBuilder sb = new StringBuilder();
                sb.Append("Tipo da Exceção: " + erro.GetType()); //Classe da Exceção
                sb.AppendLine();
                sb.AppendLine(erro.Message); //Mensagem de Erro

                //exibe uma janela de mensagem com as informções do erro ocorrido
                MessageBox.Show(sb.ToString());
                return null;
            }
        }
    }
}
