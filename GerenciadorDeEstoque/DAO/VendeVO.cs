using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    public class VendeVO
    {
        private Int64 _itemid, idvenda, idproduto;
        private List<Int64> idProdutoLista = new List<Int64>();
        private List<Int32> quantidadeLista = new List<Int32>();
        private DAO dao;

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

        public List<Int64> IdProdutoLista 
        {        
            get { return idProdutoLista;}
            set { idProdutoLista = value; }
        }

        public List<Int32> QuantidadeLista
        {
            get { return quantidadeLista; }
            set { quantidadeLista = value; }
        }


        public void Inserir()
        {
            dao = new DAO();
            try
            {
                for (int i = 0; i < IdProdutoLista.Count(); i++)
                {
                    dao.IDVENDE(IdVenda, IdProdutoLista[i], QuantidadeLista[i]);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
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
