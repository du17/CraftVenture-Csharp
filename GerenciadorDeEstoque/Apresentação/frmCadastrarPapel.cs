using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastrarPapel : Form
    {
        static String nome_material = "Papel";
        PapelVO papel;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        public frmCadastrarPapel()
        {
            InitializeComponent();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnHistórico_Click(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão apagadas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtGramatura.Text = string.Empty;
            cbxTamanho.Text = string.Empty;
            cbxTipo.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            papel = new PapelVO();
            material = new MaterialVO();
            tipoMaterial = new TipoMaterialVO();

            long idTipoMaterial;

            try
            {
                String tipo = cbxTipo.Text;
                String cor = txtCor.Text;
                String tamanho = cbxTamanho.Text;
                int gramatura = Convert.ToInt32(txtGramatura.Text);
                double valor = Convert.ToDouble(txtValor.Text); 


                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();

                idTipoMaterial = tipoMaterial.getLastId();

                material.Nome = nome_material;
                material.Valor = valor;
                material.IdMaterial = idTipoMaterial;
                material.Inserir();

                papel.itemidTipoMaterial = idTipoMaterial;
                papel.Tipo = tipo;
                papel.Cor = cor;
                papel.Tamanho = tamanho;    
                papel.Gramatura = gramatura;

                papel.Inserir();

                MessageBox.Show("Item Cadastrado!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
