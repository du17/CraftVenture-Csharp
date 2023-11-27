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
        private Double tamanho;
        private Double espessura;
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
        public Double Tamanho
        {
            get { return tamanho; }
            set { 
                if (value > 1)
                {
                    tamanho = value;
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

        public void Inserir()
        {
            dao = new DAO();
            dao.IDE(itemidTipoMaterial, Tamanho, Espessura);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADE(Tamanho, Espessura, itemidTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDE(itemidTipoMaterial);
        }

    }
}
