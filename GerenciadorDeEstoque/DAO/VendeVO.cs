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
        private Int64 _itemid, idvenda, idproduto;
        private Int32 quantidade;
        //private tipo ai complico dataEntrega, dataVenda;
        private DAO dao;
        //private conexaoUso conn;

        public VendeVO()
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
        public Int64 IdVenda
        {
            get { return idvenda; }
            set
            {
                if (value > 0)
                {
                    idvenda = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public Int64 IdProduto
        {
            get { return idproduto; }
            set
            {
                if (value > 0)
                {
                    idproduto = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }

        public Int32 Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                {
                    quantidade = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDVENDE(IdVenda, IdProduto, Quantidade);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADVENDE(IdVenda, IdProduto, Quantidade, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDVENDE(itemid);
        }

    }
}
