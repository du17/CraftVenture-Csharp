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
        private Double metragemAltura, metragemComprimento;
        private Double espessura, valor;
        private DAO dao;
        private conexaoUso conn;

        public AcetatoVO()
        {

        }

        public Int64 itemidTipoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { 
                
                if(value != -1)
                {
                    _itemidTipoMaterial = value;
                }
                else { throw new ArgumentException("O id não foi encontrado"); }
            
            }
        }
        public Double MetragemAltura
        {
            get { return metragemAltura; }
            set { 
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
        public Double Espessura
        {
            get { return espessura; }
            set {if(value > 0)
                {
                    espessura = value;
                }
                else { throw new ArgumentException("Espessura não pode ser menor que 0!");
}
            }
        }

        public Double Valor
        {
            get { return valor; }
            set
            {
                if (value > 0)
                {
                    valor = value;
                }
                else
                {
                    throw new ArgumentException("O valor não pode ser menor que 0!");
                }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDE(itemidTipoMaterial, MetragemAltura, MetragemComprimento, Espessura);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADE(MetragemAltura, MetragemComprimento, Espessura, itemidTipoMaterial, Valor);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDE(itemidTipoMaterial);
        }

    }
}
