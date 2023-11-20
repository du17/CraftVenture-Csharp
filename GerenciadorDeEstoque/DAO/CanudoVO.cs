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
        private Int32 quantidade;
        private String cor;
        private DAO dao;
        private conexaoUso conn;

        public CanudoVO()
        {

        }

        public Int64 itemidproduto
        {
            get { return _itemidproduto; }
            set { _itemidproduto = value; }
        }
        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public Int32 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
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
            dao.RDCANUDO(Quantidade, Cor, itemidproduto);
        }

    }
}
