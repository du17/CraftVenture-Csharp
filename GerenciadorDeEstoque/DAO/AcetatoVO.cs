using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class AcetatoVO
    {

        private Int32 _itemidTipoMaterial;
        private String tamanho;
        private Double espessura;
        private DAO dao;
        private conexaoUso conn;

        public AcetatoVO()
        {

        }

        public Int32 itemidTipoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { _itemidTipoMaterial = value; }
        }
        public String Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public Double Espessura
        {
            get { return espessura; }
            set { espessura = value; }
        }

        /*public void Inserir()
        {
            dao = new DAO();
            dao.IDU(Email, Senha, Nome);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADU(Email, Senha, Nome, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDU(Nome, Senha, Email, itemid);
        }*/

    }
}
