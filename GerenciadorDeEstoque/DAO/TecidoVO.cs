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
        private Double metragemComprimento, metragemAltura;
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

        public Double MetragemAltura
        {
            get { return metragemAltura; }
            set
            {
                if (value > 1)
                {
                    metragemAltura = value;
                }
                else { throw new ArgumentException("O tamanho não pode ser menor que 1"); }

            }
        }

        public Double MetragemComprimento
        {
            get { return metragemComprimento; }
            set
            {
                if (value > 1)
                {
                    metragemComprimento = value;
                }
                else { throw new ArgumentException("O tamanho não pode ser menor que 1"); }

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
                    tipoEstampa = value;
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDTECIDO(itemidTipoMaterial, Tipo, TipoEstampa, MetragemComprimento, MetragemAltura);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADTECIDO(Tipo, TipoEstampa, MetragemComprimento, MetragemAltura, itemidTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDTECIDO(itemidTipoMaterial);
        }

    }
}
