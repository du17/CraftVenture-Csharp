using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class TecidoVO
    {

        private Int32 _itemidTipoMaterial;
        private String tipo, tipoEstampa; 
        private Double metragem;
        private DAO dao;
        private conexaoUso conn;

        public TecidoVO()
        {

        }

        public Int32 itemidTipoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { _itemidTipoMaterial = value; }
        }
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public String TipoEstampa
        {
            get { return tipoEstampa; }
            set { tipoEstampa = value; }
        }
        public Double Metragem
        {
            get { return metragem; }
            set { metragem = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDTECIDO(Tipo, TipoEstampa, Metragem);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADTECIDO(Tipo, TipoEstampa, Metragem, itemidTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDTECIDO(Tipo, TipoEstampa, Metragem, itemidTipoMaterial);
        }

    }
}
