using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.DAO
{
    class ProdutoVO
    {
        private Int64 _itemid, quantidade;
        private Double valor;
        private String nome, tipo;
        private byte[] foto;
        private DAO dao;

        public ProdutoVO()
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
                if (!value.Equals("Inserir nome"))
                {
                    nome = value;
                }
                else { throw new ArgumentException("Nome está nulo"); }
            }
        }

        public Int64 Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                {
                    quantidade = value;
                }
                else { throw new ArgumentException("A quantidade não pode ser nula!"); }
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

        public String Tipo
        {
            get { return tipo; }
            set
            {
                if (!value.Equals("Inserir tipo"))
                {
                    tipo = value;
                }
                else { throw new ArgumentException("O tipo está nulo"); }
            }
        }

        public byte[] Foto
        {
            get { return foto; }
            set
            {
                try
                {
                    foto = value ?? new byte[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());
                }

            }
        }
        public void Inserir()
        {
            dao = new DAO();
            dao.IDP(Valor, Quantidade, Nome, Tipo, Foto);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADP(Valor, Quantidade, Nome, Tipo, itemid, Foto);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDP(itemid);
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
