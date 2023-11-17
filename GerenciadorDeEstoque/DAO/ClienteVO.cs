using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GerenciadorDeEstoque.DAO;

namespace GerenciadorDeEstoque.DAO
{
    class ClienteVO
    {

        //metodos do cliente!!!!!!

        private Int64 _itemid;
        private String nome, email;
        private DAO dao;
        private conexaoUso conn;

        public ClienteVO()
        {

        }

        public Int64 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDC(Email, Nome);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADC(Email, Nome, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDC(Email, Nome, itemid);
        }

    }
}
