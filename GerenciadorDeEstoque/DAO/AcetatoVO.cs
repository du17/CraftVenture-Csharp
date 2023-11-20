using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class AcetatoVO
    {

        private Int64 _itemidTipoMaterial;
        private String tamanho;
        private Double espessura;
        private DAO dao;
        private conexaoUso conn;

        public AcetatoVO()
        {

        }

        public Int64 itemidTipoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { _itemidTipoMaterial = value; }
        }
        public String Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public Double Espessura
        {
            get { return espessura; }
            set { espessura = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDE(Tamanho, Espessura);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADE(Tamanho, Espessura, itemidTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDE(Tamanho, Espessura, itemidTipoMaterial);
        }

    }
}
