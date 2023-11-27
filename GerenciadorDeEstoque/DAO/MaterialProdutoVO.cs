using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class MaterialProdutoVO
    {

        private Int64 _itemid, idmaterial, idproduto;
        private DAO dao;
        private conexaoUso conn;

        MaterialProdutoVO()
        {

        }

        public Int64 itemid
        {
            get { return _itemid; }
            set
            {
                if (value > 0)
                {
                    _itemid = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public Int64 IdMaterial
        {
            get { return idmaterial; }
            set
            {
                if (value > 0)
                {
                    idmaterial = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public Int64 IdProduto
        {
            get { return idproduto; }
            set
            {
                if (value > 0)
                {
                    idproduto = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDMPRODUTO(IdMaterial, IdProduto);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADMPRODUTO(IdMaterial, IdProduto, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDMPRODUTO(itemid);
        }

    }
}
