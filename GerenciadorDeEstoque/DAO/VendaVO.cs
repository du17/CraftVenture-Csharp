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
        private String nomeCliente, telefone, nomeProduto, anotacao;
        private Double valorTotal;
        private DAO dao;
        private conexaoUso conn;

        VendaVO()
        {

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

        public Int64 FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        public String Nome
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

        public Double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDV(Nome, Quantidade, Anotacao, ValorTotal, NomeCliente, Telefone, FormaPagamento, CodCliente);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADV(Nome, Quantidade, Anotacao, ValorTotal, NomeCliente, Telefone, FormaPagamento, CodCliente, itemid);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDV(Nome, Quantidade, Anotacao, ValorTotal, NomeCliente, Telefone, FormaPagamento, CodCliente, itemid);
        }

    }
}
