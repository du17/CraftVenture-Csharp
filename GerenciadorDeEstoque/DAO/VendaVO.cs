using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class VendaVO
    {

        //Metodos venda, tomara que funcione

        private Int64 _itemid, quantidade, idUsuario, codCliente, formaPagamento;
        private String nomeCliente, telefone, nomeProduto, anotacao, formaEntrega;
        private Double valorTotal;
        private DAO dao;
        private conexaoUso conn;

        VendaVO()
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

        public Int64 IdUsuario
        {
            get { return idUsuario; }
            set
            {
                if (value > 0)
                {
                    idUsuario = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }

        public Int64 CodCliente
        {
            get { return codCliente; }
            set
            {
                if (value > 0)
                {
                    codCliente = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }

        public Int64 FormaPagamento
        {
            get { return formaPagamento; }
            set
            {
                if (value > 0)
                {
                    formaPagamento = value;
                }
                else { throw new ArgumentException("O pagamento não pode ser nulo!"); }
            }
        }

        public String Nome
        {
            get { return nomeProduto; }
            set
            {
                if (!value.Equals("Inserir Nome do Produto"))
                {
                    nomeProduto = value;
                }
                else { throw new ArgumentException("Nome está nulo"); }
            }
        }

        public String NomeCliente
        {
            get { return nomeCliente; }
            set
            {
                if (!value.Equals("Inserir Nome do Cliente"))
                {
                    nomeCliente = value;
                }
                else { throw new ArgumentException("Nome está nulo"); }
            }
        }

        public String Telefone
        {
            get { return telefone; }
            set
            {
                if (!value.Equals("Inserir telefone"))
                {
                    telefone = value;
                }
                else { throw new ArgumentException("O telefone está nulo"); }
            }
        }

        public String Anotacao
        {
            get { return anotacao; }
            set { anotacao = value; }
        }

        public String FormaEntrega
        {
            get { return FormaEntrega; }
            set
            {
                if (!value.Equals("Inserir Entrega"))
                {
                    formaEntrega = value;
                }
                else { throw new ArgumentException("Entrega está nulo"); }
            }
        }

        public Double ValorTotal
        {
            get { return valorTotal; }
            set {
                if (value > 0)
                {
                    valorTotal = value;
                }
                else { throw new ArgumentException("o valor não pode ser menor que 0!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDV(Nome, Quantidade, Anotacao, ValorTotal, NomeCliente, Telefone, FormaPagamento, FormaEntrega, CodCliente, IdUsuario);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADV(Nome, Quantidade, Anotacao, ValorTotal, NomeCliente, Telefone, FormaPagamento, FormaEntrega, CodCliente, idUsuario, itemid);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDV(itemid);
        }

    }
}
