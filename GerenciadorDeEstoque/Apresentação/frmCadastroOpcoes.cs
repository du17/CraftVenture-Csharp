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

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadastrarPapel frmPapel = new frmCadastrarPapel();
            frmPapel.Show();
            this.Close();
        }

        private void btnRenda_Click(object sender, EventArgs e)
        {
            frmCadastroRenda frmRenda = new frmCadastroRenda();
            frmRenda.Show();
            this.Close();
        }

        private void btnPerola_Click(object sender, EventArgs e)
        {
            frmCadastroPerola frmRenda = new frmCadastroPerola();
            frmRenda.Show();
            this.Close();

        }

        private void btnAcetato_Click(object sender, EventArgs e)
        {
            frmCadastroAcetato frmAcetato = new frmCadastroAcetato();
            frmAcetato.Show();
            this.Close();
        }

        private void btnFita_Click(object sender, EventArgs e)
        {
            frmCadastrarFita frmFita = new frmCadastrarFita();  
            frmFita.Show();
            this.Close();
        }

        private void btnTecido_Click(object sender, EventArgs e)
        {
            frmCadastroTecido frmTecido = new frmCadastroTecido();
            frmTecido.Show();
            this.Close();
        }

        private void btnCanudo_Click_1(object sender, EventArgs e)
        {
            frmCadastroCanudo frmCanudo = new frmCadastroCanudo();
            frmCanudo.Show();
            this.Close();
            
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Voltando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
            }
        }
    }
}
