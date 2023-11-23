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
        static String nome_material = "Fita";
        FitaVO fita;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;
        string tipo, marca, numeroCor;
        double metragem, valor;
        int numero;
        long idTipoMaterial;

        public frmCadastrarFita()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroOpcoes menuOpcoes = new frmCadastroOpcoes();
            menuOpcoes.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMarca.Text = string.Empty;
            txtMetragem.Text = string.Empty;
            txtNumCor.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtTipo.Text = string.Empty;
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

            try
            {
                tipo = txtTipo.Text;
                marca = txtMarca.Text;
                numeroCor = txtNumCor.Text;
                metragem = Convert.ToDouble(txtMetragem.Text);
                numero = Convert.ToInt32(txtNumero.Text);

                valor = Convert.ToDouble(txtValor.Text);

                fita.Tipo = tipo;
                fita.Marca = marca;
                fita.Metragem = metragem;
                fita.Numero = numero;
                fita.NumeroCor = numeroCor;

                material.Valor = valor;

                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();

                idTipoMaterial = tipoMaterial.getLastId();

                fita.itemidTpoMaterial = idTipoMaterial;
                material.IdMaterial = idTipoMaterial;

                material.Inserir();

                fita.Inserir();

                MessageBox.Show("Item cadastrado!");

            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
