using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GerenciadorDeEstoque.DAO
{
    class Conexao
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Estoque"].ConnectionString;
            return connectionString;
        }
    }
}
