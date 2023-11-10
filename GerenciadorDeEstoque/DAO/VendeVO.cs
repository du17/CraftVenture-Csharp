using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class VendeVO
    {

        //tipo data ficou complicado
        private Int32 _itemid, idvenda, idproduto;
        //private tipo ai complico dataEntrega, dataVenda;
        private DAO dao;
        private conexaoUso conn;

        public VendeVO()
        {

        }

        public Int32 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public Int32 IdVenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }
        public Int32 IdProduto
        {
            get { return idproduto; }
            set { idproduto = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDVENDE(IdVenda, IdProduto);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADVENDE(IdVenda, IdProduto, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDVENDE(IdVenda, IdProduto, itemid);
        }

    }
}
