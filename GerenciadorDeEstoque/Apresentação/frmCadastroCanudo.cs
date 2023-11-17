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
    public partial class frmCadastroCanudo : Form
    {
        static String nome_material = "Canudo";
        CanudoVO canudo;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        public frmCadastroCanudo()
        {
            InitializeComponent();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroOpcoes menuOpcoes = new frmCadastroOpcoes();
            menuOpcoes.Show();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtCor.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            canudo = new CanudoVO();
            material = new MaterialVO();   
            tipoMaterial = new TipoMaterialVO();

            try
            {
                string cor = txtCor.Text;
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                double valor = Convert.ToDouble(txtValor.Text);

                canudo.Cor = cor;
                canudo.Quantidade = quantidade;

                material.Valor = valor;
                material.Nome = string.Empty;

                tipoMaterial.Nome = nome_material;

                tipoMaterial.Inserir();

                canudo.Inserir();

            }
            catch(ArgumentNullException ex) { }
        }
    }
}
