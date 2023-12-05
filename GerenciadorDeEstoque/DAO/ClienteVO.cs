using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GerenciadorDeEstoque.DAO;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    class ClienteVO
    {

        //queria dormir

        private Int64 _itemid, numero;
        private String nome, email, cep, rua, bairro, estado, complemento, telefone, cidade;
        private DAO dao;


        public ClienteVO()
        {
            dao = new DAO();
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

        public String Telefone
        {
            get { return telefone; }
            set
            {
                if (value != string.Empty)
                {
                    telefone = value;
                }
                else { throw new ArgumentException("O telefone não pode ser nulo!"); }
            }
        }

        public Int64 Numero
        {
            get { return numero; }
            set
            {
                if (value > 0)
                {
                    numero = value;
                }
                else { throw new ArgumentException("O numero não pode ser nulo!"); }
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

        public String Cidade
        {
            get { return cidade; }
            set
            {
                    cidade = value;
                
            }
        }

        public String Cep
        {
            get { return cep; }
            set
            {
                if (!value.Equals("Inserir Cep"))
                {
                    cep = value;
                }
                else { throw new ArgumentException("O Cep está nulo"); }
            }
        }

        public String Rua
        {
            get { return rua; }
            set
            {
                if (!value.Equals("Inserir Rua"))
                {
                    rua = value;
                }
                else { throw new ArgumentException("A Rua está nula"); }
            }
        }

        public String Bairro
        {
            get { return bairro; }
            set
            {
                if (!value.Equals("Inserir Bairro"))
                {
                    bairro = value;
                }
                else { throw new ArgumentException("O Bairro está nulo"); }
            }
        }

        public String Estado
        {
            get { return estado; }
            set
            {
                if (!value.Equals("Inserir Estado"))
                {
                    estado = value;
                }
                else { throw new ArgumentException("O Estado está nulo"); }
            }
        }

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public void Inserir()
        {
            dao.IDC(Telefone, Numero, Email, Nome, Cep, Rua, Bairro, Estado, Complemento, Cidade);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADC(Telefone, Numero, Email, Nome, Cep, Rua, Bairro, Estado, Complemento, itemid, Cidade);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDC(itemid);
        }

        public Int64 getLastIdCliente()
        {
            try
            {
                return dao.getLastId();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }

    }
}