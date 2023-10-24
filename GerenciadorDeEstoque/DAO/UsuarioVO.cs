using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.Apresentação
{
    class UsuarioVO
    {
        private Int32 _itemid;
        private String nome, senha, email;
        private DAO.DAO dao;

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
            dao = new DAO.DAO();
            dao.InserirDados(email, senha, nome);
        }
        public void Atualizar()
        {
            dao = new DAO.DAO();
            dao.AtualizarDados(email, senha, nome);
        }
        public void Remover()
        {
            dao = new DAO.DAO();
            dao.RemoverDados(email, senha, nome);
        }
    }
}
