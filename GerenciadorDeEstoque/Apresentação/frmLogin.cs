﻿using System;
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

                try
                {
                    if(usuario.Login() == true)
                    {
                        
                        frmMenuCadastro menu = new frmMenuCadastro();
                        this.Hide();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("O login falhou", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (ArgumentException erro)
                {
                    MessageBox.Show(erro.ToString(), "Valor inválido");
                }
                

            }catch(ArgumentNullException erro) 
            {
                MessageBox.Show("Algum dos campos está vazio", "Campos nulos");
            }

            
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();

            frmCadastro.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*try
            {
                var strConexao = @"server=localhost;uid=root;pwd=root;database=bd_venture;ConnectionTimeout=1";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var comando = new MySqlCommand("SELECT * FROM arroz", conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show($"{reader["id"]} => {reader["nome"]}");
                }
                MessageBox.Show("Conexão Ok");
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível conectar ao servidor.");
                        break;
                    case 1045:
                        MessageBox.Show("Credenciais de acesso inválidas.");
                        break;
                    default:
                        MessageBox.Show($"Erro MySQL: {ex.Number} - {ex.Message}");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Data} - {ex.Message}");
            }*/

        }
    }
}
