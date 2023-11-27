using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class FitaVO
    {

        private Int64 _itemidTipoMaterial, numero;
        private String tipo, marca, numeroCor;
        private Double metragem, valor;
        private DAO dao;
        private conexaoUso conn;

        public FitaVO()
        {

        }

        public Int64 itemidTpoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { _itemidTipoMaterial = value; }
        }
        public Int64 Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public String NumeroCor
        {
            get { return numeroCor; }
            set { numeroCor = value; }
        }

        public Double Metragem
        {
            get { return metragem; }
            set { metragem = value; }
        }

        public Double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public void Inserir()
        {
            dao = new DAO();
            dao.IDF(itemidTpoMaterial, Numero, Tipo, Marca, NumeroCor, Metragem);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADF(Numero, Tipo, Marca, NumeroCor, Metragem, itemidTpoMaterial, Valor);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDF(Numero, Tipo, Marca, NumeroCor, Metragem, itemidTpoMaterial);
        }

    }
}
