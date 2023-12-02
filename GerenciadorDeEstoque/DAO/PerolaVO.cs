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
        private Double tamanho, valor;
        private DAO dao;
        //private conexaoUso conn;

        public PerolaVO()
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

        public String Cor
        {
            get { return cor; }
            set
            {
                if (value.Length > 0)
                {
                    cor = value;
                }
                else { throw new ArgumentException("A cor não pode ser nula!"); }
            }
        }

        public Double Tamanho
        {
            get { return tamanho; }
            set
            {
                if (value > 0)
                {
                    tamanho = value;
                }
                else { throw new ArgumentException("O tamanho não pode ser nulo!"); }
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
            dao.IDPEROLA(itemidTipoMaterial, Cor, Tamanho);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADPEROLA(Cor, Tamanho, itemidTipoMaterial, Valor);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDPEROLA(itemidTipoMaterial);
        }

    }
}
