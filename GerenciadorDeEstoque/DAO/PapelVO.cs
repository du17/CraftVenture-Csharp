using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class PapelVO
    {

        private Int64 _itemidTpoMaterial;
        private String tipo, cor, tamanho;
        private Int32 gramatura;
        private DAO dao;
        private conexaoUso conn;

        public PapelVO()
        {

        }

        public Int64 itemidTipoMaterial
        {
            get { return _itemidTpoMaterial; }
            set { _itemidTpoMaterial = value; }
        }
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public Int32 Gramatura
        {
            get { return gramatura; }
            set { gramatura = value; }
        }
        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public String Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public void Inserir()
         {
             dao = new DAO();
             dao.IDPAPEL(itemidTipoMaterial, Tipo, Gramatura, Cor, Tamanho);
         }

         public void Atualizar()
         {
             dao = new DAO();
             dao.ADPAPEL(Tipo, Gramatura, Cor, Tamanho, itemidTipoMaterial);
         }

         public void Remover()
         {
             dao = new DAO();
             dao.RDPAPEL(Tipo, Gramatura, Cor, Tamanho, itemidTipoMaterial);
         }

    }
}
