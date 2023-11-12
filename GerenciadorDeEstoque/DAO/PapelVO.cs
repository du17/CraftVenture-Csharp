using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class PapelVO
    {

        private Int32 _itemidTpoMaterial;
        private String tipo, gramatura, cor, tamanho;
        private DAO dao;
        private conexaoUso conn;

        public PapelVO()
        {

        }

        public Int32 itemidTipoMaterial
        {
            get { return _itemidTpoMaterial; }
            set { _itemidTpoMaterial = value; }
        }
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public String Gramatura
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
             dao.IDPAPEL(Tipo, Gramatura, Cor, Tamanho);
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
