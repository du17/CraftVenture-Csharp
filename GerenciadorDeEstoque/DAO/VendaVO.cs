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

        //Metodos venda, tomara que funcione

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
            set { _itemid = value; }
        }

        public Int64 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Int64 IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public Int64 CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public String FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        public String FormaEntrega
        {
            get { return formaEntrega; }
            set { formaEntrega = value; }
        }

        public String NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public String NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
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
            set { valorTotal = value; }
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
