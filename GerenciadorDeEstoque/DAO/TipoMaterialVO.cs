using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    class TipoMaterialVO
    {
        private Int64 _itemid;
        private String nome;
        private DAO dao;
        private conexaoUso conn;

        public TipoMaterialVO()
        {
            dao = new DAO();
        }

        public Int64 itemid
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

        public Int64 getLastId()
        {
            try
            {
                return dao.getLastId();
            }
            catch (ArgumentNullException ex) 
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }
        

    }
}
