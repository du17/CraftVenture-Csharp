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
    public partial class frmCadastrarFita : Form
    {
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
    }
}
