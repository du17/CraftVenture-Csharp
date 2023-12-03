using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.Apresentação.Menu
{
    public partial class frmMenuCadastro : KryptonForm
    {
        public frmMenuCadastro()
        {
            InitializeComponent();
        }

        private void frmMenuCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmCadastroOpcoes frmOpcoesmaterial = new frmCadastroOpcoes();
            frmOpcoesmaterial.Show();
            this.Close();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadastroCliente = new frmCadastroCliente();
            cadastroCliente.Show();
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

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.Show();
            this.Close();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda();
            frmVenda.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair?\nVocê será deslogado", "Voltando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }
        }

        private void btnHistórico_Click(object sender, EventArgs e)
        {
            frmHistorico frmHistorico = new frmHistorico();
            frmHistorico.Show();
            this.Close();
        }
    }
}
