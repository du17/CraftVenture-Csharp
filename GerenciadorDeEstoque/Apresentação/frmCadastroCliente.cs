using GerenciadorDeEstoque.Apresentação.Menu;
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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmMenuCadastro menuCadastro = new frmMenuCadastro();
            menuCadastro.Show();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbxEstado.Text = "Inserir Estado";
            txtNome.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtTelefone.Text = string.Empty;
        }
    }
}
