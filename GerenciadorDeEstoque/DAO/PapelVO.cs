using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.DAO
{
    class PapelVO
    {

        private Int64 _itemidTpoMaterial;
        private String tipo, cor, tamanho;
        private Int32 gramatura;
        private Double valor;
        private DAO dao;
        private conexaoUso conn;

        public PapelVO()
        {

        }

        public Int64 itemidTipoMaterial
        {
            get { return _itemidTpoMaterial; }
            set { 
            if ( value > 0)
                {
                    _itemidTpoMaterial = value;
                }
                else { throw new ArgumentException("O id não pode ser nulo!"); }
            }
        }
        public String Tipo
        {
            get { return tipo; }
            set {
                if (!value.Equals("Inserir Tipo"))
                {
                    tipo = value;
                }
                else { throw new ArgumentException("Tipo está nulo"); }
            }
        }
        public Int32 Gramatura
        {
            get { return gramatura; }
            set { 
            if( value > 0)
                {
                    gramatura = value;
                }
                else { throw new ArgumentException("Gramatura não pode ser menor que 0!"); }
            }
        }
        public String Cor
        {
            get { return cor; }
            set { 
            if(value.Length > 0)
                {
                    cor = value;
                }
                else { throw new ArgumentException("A cor não pode ser nula!"); }
            }
        }

        public String Tamanho
        {
            get { return tamanho; }
            set {
                if (!value.Equals("Inserir"))
                {
                    tamanho = value;
                }
                else { throw new ArgumentException("Escolha um tamanho!"); }
            }
        }

        public Double Valor 
        { 
            get { return valor; }
            set {  valor = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDPAPEL(itemidTipoMaterial, Tipo, Gramatura, Cor, Tamanho);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADPAPEL(Tipo, Gramatura, Cor, Tamanho, Valor, itemidTipoMaterial);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDPAPEL(itemidTipoMaterial);
        }

    }
}
