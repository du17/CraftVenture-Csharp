﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.DAO
{
    class TelefonesVO
    {
        private Int32 _itemid, codCliente;
        private String telefone;
        private DAO dao;
        private conexaoUso conn;

        public TelefonesVO()
        {

        }
        public Int32 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public Int32 CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public void Inserir()
        {
            dao = new DAO();
            dao.IDT(Telefone, CodCliente);
        }

        public void Atualizar()
        {
            dao = new DAO();
            dao.ADT(Telefone, CodCliente, itemid);
        }

        public void Remover()
        {
            dao = new DAO();
            dao.RDT(Telefone, CodCliente, itemid);
        }

    }
}