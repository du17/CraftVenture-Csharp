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
        private Double metragem;
        private DAO dao;
        private conexaoUso conn;

        public FitaVO()
        {

        }

        public Int64 itemidTpoMaterial
        {
            get { return _itemidTipoMaterial; }
            set
            {
                if (value > 0)
                {
                    _itemidTipoMaterial = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public Int64 Numero
        {
            get { return numero; }
            set
            {
                if (value > 0)
                {
                    numero = value;
                }
                else { throw new ArgumentException("O numero não pode ser nulo!"); }
            }
        }
        public String Tipo
        {
            get { return tipo; }
            set
            {
                if (!value.Equals("Inserir Tipo"))
                {
                    tipo = value;
                }
                else { throw new ArgumentException("Tipo está nulo"); }
            }
        }
        public String Marca
        {
            get { return marca; }
            set
            {
                if (!value.Equals("Inserir Marca"))
                {
                    marca = value;
                }
                else { throw new ArgumentException("Marca está nulo"); }
            }
        }

        public String NumeroCor
        {
            get { return numeroCor; }
            set
            {
                if (!value.Equals("Inserir Numero da cor"))
                {
                    numeroCor = value;
                }
                else { throw new ArgumentException("Numero da cor está nulo"); }
            }
        }

        public Double Metragem
        {
            get { return metragem; }
            set
            {
                if (value > 0)
                {
                    metragem = value;
                }
                else { throw new ArgumentException("Metragem não pode ser menor que 0!"); }
            }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDF(itemidTpoMaterial, Numero, Tipo, Marca, NumeroCor, Metragem);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADF(Numero, Tipo, Marca, NumeroCor, Metragem, itemidTpoMaterial);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDF(itemidTpoMaterial);
        }

    }
}
