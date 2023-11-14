using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.DAO
{
    class UsuarioVO
    {
        private Int32 _itemid;
        private String nome, senha, email;
        private DAO dao;
        private conexaoUso conn;

        public UsuarioVO()
        {

        }

        public Int32 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDU(Email, Senha, Nome);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADU(Email, Senha, Nome, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDU(Nome, Senha, Email, itemid);
        }

        public void Login()
        {
            dao = new DAO();
            dao.BDU(Senha, Nome);
        }
    }
}
