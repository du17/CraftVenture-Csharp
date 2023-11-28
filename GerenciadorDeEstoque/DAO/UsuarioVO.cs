using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.DAO
{
    class UsuarioVO
    {
        private Int64 _itemid;
        private String nome, senha, email;
        private DAO dao;

        public UsuarioVO()
        {

        }

        public Int64 itemid
        {
            get { return _itemid; }
            set
            {
                if (value > 0)
                {
                    _itemid = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public String Nome
        {
            get { return nome; }
            set
            {
                if (!value.Equals("Inserir Nome"))
                {
                    nome = value;
                }
                else { throw new ArgumentException("O Nome está nulo"); }
            }
        }
        public String Senha
        {
            get { return senha; }
            set
            {
                if (!value.Equals("Inserir Senha"))
                {
                    senha = value;
                }
                else { throw new ArgumentException("A Senha está nulo"); }
            }
        }
        public String Email
        {
            get { return email; }
            set
            {
                if (!value.Equals("Inserir Email"))
                {
                    email = value;
                }
                else { throw new ArgumentException("O Email está nulo"); }
            }
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
            dao.RDU(itemid);
        }

        public bool Login()
        {
            dao = new DAO();

            try
            {
                if(dao.BDU(Nome, Senha) != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("erro" + ex.Message + "ocorreu: " + ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
