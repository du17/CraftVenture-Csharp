using GerenciadorDeEstoque.Apresentação.Menu;
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
    public partial class frmCadastroCliente : Form
    {
        ClienteVO cliente;
        TelefonesVO telefones;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
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

            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cliente = new ClienteVO();
            telefones = new TelefonesVO();

            try
            {
                Int64 telefone = Convert.ToInt64(txtTelefone.Text);
                Int64 numero = Convert.ToInt64(txtNumero.Text);
                String nome = txtNome.Text;
                String email = txtEmail.Text;
                String cep = txtCep.Text;
                String rua = txtRua.Text;
                String bairro = txtBairro.Text;
                String estado = cbxEstado.Text;
                String complemento = txtComplemento.Text;

                cliente.Telefone = telefone;
                cliente.Numero = numero;
                cliente.Nome = nome;
                cliente.Email = email;
                cliente.Cep = cep;
                cliente.Rua = rua;
                cliente.Bairro = bairro;
                cliente.Estado = getEstado(estado);
                cliente.Complemento = complemento;

                cliente.Inserir();

                MessageBox.Show("Cliente Cadastrado!");


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getEstado(String estado)
        {
            string estadoSimplificado = "";

            estado.Trim();

            estadoSimplificado += estado[estado.Length - 3];
            estadoSimplificado += estado[estado.Length - 2];


            return estadoSimplificado;
        }
    }
}
