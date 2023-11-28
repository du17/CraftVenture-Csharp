using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.DAO
{
    class ProdutoVO
    {
        private Int64 _itemid, quantidade;
        private Double valor;
        private String nome, materialUsado, tipo;
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

        public String MaterialUsado
        {
            get{ return materialUsado; }
            set
            {
                if (!value.Equals("Inserir Material Usado"))
                {
                    materialUsado = value;
                }
                else { throw new ArgumentException("O material está nulo"); }
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

        public void Inserir()
        {
            dao = new DAO();
            dao.IDP(Valor, Quantidade, Nome, MaterialUsado, Tipo);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADP(Valor, Quantidade, Nome, MaterialUsado, Tipo, itemid);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDP(itemid);
        }
    }
}
