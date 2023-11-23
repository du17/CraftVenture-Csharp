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
    public partial class frmCadastroOpcoes : Form
    {
        public frmCadastroOpcoes()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadastrarPapel frmPapel = new frmCadastrarPapel();
            this.Hide();
            frmPapel.ShowDialog();
            this.Show();
        }

        private void btnRenda_Click(object sender, EventArgs e)
        {
            frmCadastroRenda frmRenda = new frmCadastroRenda();
            this.Hide();
            frmRenda.ShowDialog();
            this.Show();
        }

        private void btnPerola_Click(object sender, EventArgs e)
        {
            frmCadastroPerola frmRenda = new frmCadastroPerola();
            this.Hide();
            frmRenda.ShowDialog();
            this.Show();
        }

        private void btnAcetato_Click(object sender, EventArgs e)
        {
            frmCadastroAcetato frmAcetato = new frmCadastroAcetato();
            this.Hide();
            frmAcetato.ShowDialog();
            this.Show();
        }

        private void btnFita_Click(object sender, EventArgs e)
        {
            frmCadastrarFita frmFita = new frmCadastrarFita();  
            this.Hide();
            frmFita.ShowDialog();
            this.Show();
        }

        private void btnTecido_Click(object sender, EventArgs e)
        {
            frmCadastroTecido frmTecido = new frmCadastroTecido();
            this.Hide();
            frmTecido.ShowDialog();
            this.Show();
        }

        private void btnCanudo_Click_1(object sender, EventArgs e)
        {
            frmCadastroCanudo frmCanudo = new frmCadastroCanudo();
            this.Hide();
            frmCanudo.ShowDialog();
            this.Show();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair?", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmMenuCadastro menuCadastro = new frmMenuCadastro();
            menuCadastro.Show();
            this.Close();
        }
    }
}
