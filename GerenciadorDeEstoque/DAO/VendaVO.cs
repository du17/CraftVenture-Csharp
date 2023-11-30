using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    public class VendaVO
    {


        private Int64 _itemid, quantidade, idUsuario, codCliente;
        private String nomeCliente, telefone, nomeProduto, anotacao, formaPagamento, formaEntrega;
        private DateTime dataEntrega, dataVenda;
        private Double valorTotal;
        private DAO dao;
        private conexaoUso conn;

        public VendaVO()
        {
            dao = new DAO();

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

        public String FormaPagamento
        {
            get { return formaPagamento; }
            set
            {
                    formaPagamento = value;
                
            }
        }

        public String FormaEntrega
        {
            get { return formaEntrega; }
            set { formaEntrega = value; }
        }

        public String NomeProduto
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

        public DateTime DataEntrega
        {
            get { return dataEntrega; }
            set { dataEntrega = value; }
        }

        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
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
            
            dao.IDV( Anotacao, ValorTotal, NomeCliente, FormaPagamento, formaEntrega, CodCliente, DataEntrega.ToString("yyyy-MM-dd"), DataVenda.ToString("yyyy-MM-dd"));

        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADV(NomeProduto, Anotacao, ValorTotal, NomeCliente, Telefone, FormaPagamento, CodCliente, itemid, dataEntrega, DataVenda);

        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDV(itemid);
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
