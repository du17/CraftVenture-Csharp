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
using GerenciadorDeEstoque.Apresentação.Menu;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmLogin : KryptonForm
    {
        CadastroUsuario cadastro;

        public frmLogin(CadastroUsuario cadastro)
        {
            InitializeComponent();

            this.cadastro = cadastro;
            
        }

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            lblNome.Visible = false;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSenha.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "adm" && txtSenha.Text == "adm")
            {
                frmMenuCadastro Menu = new frmMenuCadastro();

                Menu.Show();
            }

            else
            {
                MessageBox.Show("Login invalido");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro(cadastro);

            frmCadastro.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
