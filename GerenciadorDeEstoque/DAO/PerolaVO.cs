using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class PerolaVO
    {

        private Int64 _itemidTipoMaterial;
        private String cor;
        private Double tamanho;
        private DAO dao;
        private conexaoUso conn;

        public PerolaVO()
        {

        }

        public Int64 itemidTipoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { _itemidTipoMaterial = value; }
        }

        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public Double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDPEROLA(itemidTipoMaterial, Cor, Tamanho);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADPEROLA(Cor, Tamanho, itemidTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDPEROLA(Cor, Tamanho, itemidTipoMaterial);
        }

    }
}
