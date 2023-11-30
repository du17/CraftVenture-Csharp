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

        private Int64 _itemid, telefone, numero;
        private String nome, email, cep, rua, bairro, estado, complemento;
        private DAO dao;

        public ClienteVO()
        {
            dao = new DAO();
        }

        public Int64 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }

        public Int64 Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Int64 Numero
        {
            get { return numero; }
            set { numero = value; }
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

        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public void Inserir()
        {
            dao.IDC(Telefone, Numero, Email, Nome, Cep, Rua, Bairro, Estado, Complemento);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADC(Telefone, Numero, Email, Nome, Cep, Rua, Bairro, Estado, Complemento, itemid);
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
