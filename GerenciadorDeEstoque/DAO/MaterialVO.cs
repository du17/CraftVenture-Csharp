using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class MaterialVO
    {
        //tipo foto não tem, agora fudeu
        private Int32 _itemid, idmaterial;
        private String nome;
        private Double valor;
        private DAO dao;
        private conexaoUso conn;

        public MaterialVO()
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
        public Int32 IdMaterial
        {
            get { return idmaterial; }
            set { idmaterial = value; }
        }
        public Double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDM(IdMaterial, Nome, Valor);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADM(IdMaterial, Nome, Valor, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDM(IdMaterial, Nome, Valor, itemid);
        }

    }
}
