﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastroPerola : Form
    {
        public frmCadastroPerola()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroOpcoes menuOpcoes = new frmCadastroOpcoes();
            menuOpcoes.Show();
            this.Close();
        }
    }
}
