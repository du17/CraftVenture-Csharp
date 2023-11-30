using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    public class MaterialProdutoVO
    {

        private Int64 _itemid, idmaterial, idproduto;
        private List<Int64> idmaterialLista;
        private List<Int32> quantidadeLista;
        private Int32 quantidade;
        private DAO dao;

        private List<Int64> materiais;

        public MaterialProdutoVO()
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
        public Int64 IdMaterial {

            get { return idmaterial; }
            set
            {
                idmaterial = value;
            }
        }

        public Int64 IdProduto {

            get { return idproduto; }
            set
            {
                idproduto = value;
            }
        }
        public List<Int64> IdMaterialLista
        {
            get { return idmaterialLista; }
            set
            {
                idmaterialLista = value;
                
            }
        }

        public List<Int32> QuantidadeLista
        {
            get { return quantidadeLista; }
            set
            {
                quantidadeLista = value;
            }

        }

        public List<Int64> Materiais{

            get {
                return materiais;
            }

            set { materiais = value; }
        }

        public Int32 Quantidade { get; set; }

        public void Inserir()
        {
            dao = new DAO();
            for(int i = 0; i < idmaterialLista.Count(); i++)
            {
                dao.IDMPRODUTO(IdMaterialLista[i], IdProduto, quantidadeLista[i]);
            }
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

        public void AdicionarMaterial()
        {
            materiais.Add(idproduto);
        }

    }
}
