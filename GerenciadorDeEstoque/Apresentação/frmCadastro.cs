using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEstoque.DAO;
using MetroFramework;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastro : Form
    {
        /*CadastroUsuario cadastro;
        public frmCadastro(CadastroUsuario cadastro)
        {
            InitializeComponent();

            this.cadastro = cadastro;
        }*/

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblNome.Visible = false;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblEmail.Visible = false;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSenha.Visible = false;
        }

        private void txtRepetirSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblRepetirSenha.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                
                
            }
            catch(FormatException erro) 
            {

                MessageBox.Show("Algum dos campos está errado, cheque e tente novamente", "Campos nulos");
                
                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtRepetirSenha.Text = "";
            }  
            catch(Exception erro) {
                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                txtRepetirSenha.Text = "";
            }
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

        private void pbRepetirSenha_Click(object sender, EventArgs e)
        {
            if (txtRepetirSenha.UseSystemPasswordChar == true)
            {
                txtRepetirSenha.UseSystemPasswordChar = false;
                txtRepetirSenha.PasswordChar = '\0';
                pbRepetirSenha.BackgroundImage = GerenciadorDeEstoque.Properties.Resources.olho;
            }
            else
            {
                txtRepetirSenha.UseSystemPasswordChar = true;
                txtRepetirSenha.PasswordChar = '●';
                pbRepetirSenha.BackgroundImage = GerenciadorDeEstoque.Properties.Resources.olho__1_;
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
