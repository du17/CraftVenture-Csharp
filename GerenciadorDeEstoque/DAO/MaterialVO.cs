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
        private Int64 _itemid, idTipoMaterial;
        private String nome;
        private Double valor;
        private DAO dao;
        //private conexaoUso conn;

        public MaterialVO()
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
        public String Nome
        {
            get { return nome; }
            set
            {
                if (!value.Equals("Inserir Nome"))
                {
                    nome = value;
                }
                else { throw new ArgumentException("O Nome está nulo"); }
            }
        }
        public Int64 IdTipoMaterial
        {
            get { return idTipoMaterial; }
            set
            {
                if (value > 0)
                {
                    idTipoMaterial = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public Double Valor
        {
            get { return valor; }
            set
            {
                if (value > 0)
                {
                    valor = value;
                }
                else { throw new ArgumentException("O valor não pode ser nulo!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDM(IdTipoMaterial, Nome, Valor);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADM(IdTipoMaterial, Nome, Valor);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDM(itemid);
        }

    }
}
