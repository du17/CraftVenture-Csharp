using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class CanudoVO
    {

        private Int64 _itemidproduto;
        private Int64 quantidade;

        private String cor;
        private DAO dao;
        //private conexaoUso conn;

        public CanudoVO()
        {

        }

        public Int64 itemidproduto
        {
            get { return _itemidproduto; }
            set
            {
                if (value > 0)
                {
                    _itemidproduto = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public String Cor
        {
            get { return cor; }
            set {if(value.Length > 0)
                {
                    cor = value;
                }
                else { throw new ArgumentException("A cor não pode ser nula!");
}
            }
        }
        public Int64 Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                {
                    quantidade = value;
                }
                else { throw new ArgumentException("A quantidade não pode ser nula!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDCANUDO(itemidproduto, Quantidade, Cor);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADCANUDO(Quantidade, Cor, itemidproduto);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDCANUDO(itemidproduto);
        }

    }
}
