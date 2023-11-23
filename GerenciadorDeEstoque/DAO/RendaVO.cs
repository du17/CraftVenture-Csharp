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
        private conexaoUso conn;

        public RendaVO()
        {

        }

        public Int64 idTipoMaterial
        {
            get { return idTipoMaterial; }
            set { idTipoMaterial = value; }
        }
        public String Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public Double Metragem
        {
            get { return metragem; }
            set { metragem = value; }
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
            dao.RDR(Tamanho, Metragem, idTipoMaterial);
        }

    }
}
