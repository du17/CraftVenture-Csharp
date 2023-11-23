using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
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
    public partial class frmCadastrarFita : Form
    {

        private static String nome_material = "Fita";
        FitaVO fita;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;


        public frmCadastrarFita()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMarca.Text = string.Empty;
            txtMetragem.Text = string.Empty;
            txtNumCor.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cbxTipo.Text = "Inserir Tipo";
            txtValor.Text = string.Empty;
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
            fita = new FitaVO();
            material = new MaterialVO();
            tipoMaterial = new TipoMaterialVO();

            long idTipoMaterial;

            try
            {
                String tipo = cbxTipo.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                double metragem = Convert.ToDouble(txtMetragem.Text);
                String marca = txtMarca.Text;
                String numeroCor = txtNumCor.Text;
                double valor = Convert.ToDouble(txtValor.Text);

                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();

                idTipoMaterial = tipoMaterial.getLastId();

                material.IdMaterial= idTipoMaterial;
                material.Nome = nome_material;
                material.Valor = valor;
                material.Inserir();

                fita.itemidTpoMaterial = idTipoMaterial;
                fita.Tipo = tipo;
                fita.Numero = numero;
                fita.Metragem = metragem;
                fita.Marca = marca;
                fita.NumeroCor = numeroCor;
                fita.Inserir();

                MessageBox.Show("Item Cadastrado!");
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
