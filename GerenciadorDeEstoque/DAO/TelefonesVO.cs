using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    class TelefonesVO
    {
        private Int64 _itemid, codCliente;
        private String telefone;
        private DAO dao;
        private conexaoUso conn;

        public TelefonesVO()
        {
            dao = new DAO();
        }
        public Int64 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public Int64 CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public void Inserir()
        {
            dao.IDT(Telefone, CodCliente);

        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADT(Telefone, CodCliente, itemid);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDT(Telefone, CodCliente, itemid);
        }

        public Int64 getLastIdTelefone()
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
