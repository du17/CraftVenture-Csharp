using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class TipoMaterialVO
    {
        private Int32 _itemid;
        private String nome;
        private DAO dao;
        private conexaoUso conn;

        public TipoMaterialVO()
        {

        }

        public Int32 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDTIPO(Nome);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADTIPO(Nome, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDTIPO(Nome, itemid);
        }

    }
}
