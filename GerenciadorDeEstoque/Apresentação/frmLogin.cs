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
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmLogin : KryptonForm
    {
        private UsuarioVO usuario;

        public frmLogin()
        {
            InitializeComponent();

            usuario = new UsuarioVO();
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

            try
            {
                string nome = txtNome.Text;
                string senha = txtSenha.Text;

                usuario.Nome = nome;
                usuario.Senha = senha;

                 if (usuario.Login())
                 {
                    frmMenuCadastro menuCadastro = new frmMenuCadastro();
                    this.Hide();
                    menuCadastro.Show();
                    this.Close();
                        
                 }
                else
                {
                    MessageBox.Show("Usuário ou senha não encontrados no banco de dados\nTente novamente ou se cadastre com o texto abaixo");
                }
                                 
            }
            catch(ArgumentNullException erro) 
            {
                MessageBox.Show("Algum dos campos está vazio", "Campos nulos");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            this.Hide();
            frmCadastro.ShowDialog();
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pbSenha_Click(object sender, EventArgs e)
        {
            if(txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.PasswordChar = '\0';
                pbSenha.BackgroundImage = GerenciadorDeEstoque.Properties.Resources.olho;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.PasswordChar = '●';
                pbSenha.BackgroundImage = GerenciadorDeEstoque.Properties.Resources.olho__1_;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? ", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFechar_Krypton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? ", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
