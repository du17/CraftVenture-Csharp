using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class RendaVO
    {

        private Int64 _idTipoMaterial;
        private String tamanho;
        private Double metragem;
        private DAO dao;

        public RendaVO()
        {

        }

        public Int64 idTipoMaterial
        {
            get { return _idTipoMaterial; }
            set
            {
                if (value > 0)
                {
                    _idTipoMaterial = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public String Tamanho
        {
            get { return tamanho; }
            set
            {
                if (value.Length > 0)
                {
                    tamanho = value;
                }
                else { throw new ArgumentException("O tamanho não pode ser nulo!"); }
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
                else { throw new ArgumentException("A metragem não pode ser nulo!"); }
            }
        }


        public void Inserir()
        {
            dao = new DAO();
            dao.IDR(idTipoMaterial, Tamanho, Metragem);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADR(Tamanho, Metragem, idTipoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDR(idTipoMaterial);
        }

    }
}
