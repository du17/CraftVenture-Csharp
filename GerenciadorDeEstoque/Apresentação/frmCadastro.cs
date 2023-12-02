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
        DAO.UsuarioVO usuario;
        public frmCadastro()
        {
            InitializeComponent();
            usuario = new DAO.UsuarioVO();
        }

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

                if(nome == string.Empty ||  email == string.Empty || senha == string.Empty || txtRepetirSenha.Text == string.Empty) { throw new ArgumentException("Valores nulos, tente novamente!"); }
                if (senha.Equals( txtRepetirSenha.Text))
                {
                    usuario.Nome = nome;
                    usuario.Email = email;
                    usuario.Senha = senha;

                    usuario.Inserir();

                    MessageBox.Show("Cadastrado com sucesso!!");
                }
                else
                {
                    throw new ArgumentException("Senhas são diferentes!!");

                }
                
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }  
            catch(Exception erro)
            {
                //cria uma string com as informações do erro
                StringBuilder sb = new StringBuilder();
                sb.Append("Tipo da Exceção: " + erro.GetType()); //Classe da Exceção
                sb.AppendLine();
                sb.AppendLine(erro.Message); //Mensagem de Erro

                //exibe uma janela de mensagem com as informções do erro ocorrido
                MessageBox.Show(sb.ToString());
                emptyText();
            }
        }

        private void emptyText()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtRepetirSenha.Text = string.Empty;
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
