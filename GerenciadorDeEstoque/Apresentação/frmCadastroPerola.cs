
﻿using GerenciadorDeEstoque.DAO;
using System;
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
        static String nome_material = "Pérola";
        PerolaVO perola;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        public frmCadastroPerola()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão apagadas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            perola = new PerolaVO();
            tipoMaterial = new TipoMaterialVO();
            material = new MaterialVO();

            long idTipoMaterial;

            try
            {
                String cor = txtCor.Text;
                Double tamanho = Convert.ToDouble(txtTamanho.Text);
                double valor = Convert.ToDouble(txtValor.Text);

                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();

                idTipoMaterial = tipoMaterial.getLastId();

                material.IdMaterial = idTipoMaterial;
                material.Nome = nome_material;
                material.Valor = valor;
                material.Inserir();

                perola.itemidTipoMaterial = idTipoMaterial;
                perola.Cor = cor;
                perola.Tamanho = tamanho;
                perola.Inserir();

                MessageBox.Show("Item Cadastrado!");

            }catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
