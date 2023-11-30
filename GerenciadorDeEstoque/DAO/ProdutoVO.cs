using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.DAO
{
    class ProdutoVO
    {
        private Int64 _itemid, quantidade;
        private Double valor;
        private String nome, tipo;
        private DAO dao;

        public ProdutoVO()
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

        public Int64 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDP(Valor, Quantidade, Nome, Tipo);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADP(Valor, Quantidade, Nome, Tipo, itemid);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDP(itemid);
        }

        public Int64 getLastId()
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
