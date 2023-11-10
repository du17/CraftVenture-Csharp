using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class FitaVO
    {

        private Int32 _itemidTipoMaterial, numero;
        private String tipo, marca, numeroCor;
        private Double metragem;
        private DAO dao;
        private conexaoUso conn;

        public FitaVO()
        {

        }

        public Int32 itemidTpoMaterial
        {
            get { return _itemidTipoMaterial; }
            set { _itemidTipoMaterial = value; }
        }
        public Int32 Numero
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

        /*public void Inserir()
        {
            dao = new DAO();
            dao.IDU(Email, Senha, Nome);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADU(Email, Senha, Nome, itemid);
        }
        public void Remover()
        {
            dao = new DAO();
            dao.RDU(Nome, Senha, Email, itemid);
        }*/

    }
}
