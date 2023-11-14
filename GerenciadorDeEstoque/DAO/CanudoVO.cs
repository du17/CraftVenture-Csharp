using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class CanudoVO
    {

        private Int32 _itemidproduto, quantidade;
        private String cor;
        private DAO dao;
        private conexaoUso conn;

        public CanudoVO()
        {

        }

        public Int32 itemidproduto
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
            dao.IDCANUDO(Quantidade, Cor);
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
