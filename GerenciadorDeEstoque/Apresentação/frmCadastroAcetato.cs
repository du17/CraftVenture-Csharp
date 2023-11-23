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
    public partial class frmCadastroAcetato : Form
    {

        static String nome_material = "Acetato";
        AcetatoVO acetato;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        public frmCadastroAcetato()
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
            zerarCampos();
        }

        private void zerarCampos()
        {
            txtEspessura.Text = string.Empty;
            txtMetragemAltura.Text = string.Empty;
            txtMetragemComprimento.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            acetato = new AcetatoVO();
            tipoMaterial = new TipoMaterialVO();
            material = new MaterialVO();

            try
            {
                double espessura = Convert.ToDouble(txtEspessura.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                double tamanho = Convert.ToDouble(txtMetragemAltura.Text) * Convert.ToDouble(txtMetragemComprimento.Text);
                long idTipoMaterial;

                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();
                idTipoMaterial = tipoMaterial.getLastId();

                acetato.Espessura = espessura;
                acetato.Tamanho = tamanho;

                material.Nome = nome_material;
                material.Valor = valor;

                material.IdMaterial = idTipoMaterial;
                acetato.itemidTipoMaterial = idTipoMaterial;

                material.Inserir();

                acetato.Inserir();

                MessageBox.Show("Item cadastrado!");

            }catch(ArgumentException ex)
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
