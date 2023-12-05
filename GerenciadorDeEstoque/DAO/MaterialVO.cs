using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    class MaterialVO
    {
        //tipo foto não tem, agora fudeu
        private Int64 _itemid, idTipoMaterial;
        private String nome;
        private Double valor;
        private DAO dao;
        private byte[] foto;
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

        public byte[] Foto
        {
            get { return foto; }
            set
            {
                try
                {
                    foto = value;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());
                }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDM(IdTipoMaterial, Nome, Valor, Foto);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADM(IdTipoMaterial, Nome, Valor, Foto);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDM(itemid);
        }

    }
}
