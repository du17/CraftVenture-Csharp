using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class TecidoVO
    {

        private Int64 _itemidTipoMaterial;
        private String tipo, tipoEstampa; 
        private Double metragem;
        private DAO dao;
        private conexaoUso conn;

        public TecidoVO()
        {

        }

        public Int64 itemidTipoMaterial
        {
            get { return _itemidTipoMaterial; }
            set
            {
                if (value > 0)
                {
                    _itemidTipoMaterial = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public String Tipo
        {
            get { return tipo; }
            set
            {
                if (!value.Equals("Inserir Tipo"))
                {
                    tipo = value;
                }
                else { throw new ArgumentException("Tipo está nulo"); }
            }
        }
        public String TipoEstampa
        {
            get { return tipoEstampa; }
            set
            {
                if (!value.Equals("Inserir Tipo da estampa"))
                {
                    tipoEstampa = value;
                }
                else { throw new ArgumentException("Tipo da estampa está nulo"); }
            }
        }
        public Double Metragem
        {
            get { return metragem; }
            set
            {
                if (value > 0)
                {
                    metragem = value;
                }
                else { throw new ArgumentException("Metragem não pode ser menor que 0!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDTECIDO(itemidTipoMaterial, Tipo, TipoEstampa, Metragem);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADTECIDO(Tipo, TipoEstampa, Metragem, itemidTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDTECIDO(itemidTipoMaterial);
        }

    }
}
