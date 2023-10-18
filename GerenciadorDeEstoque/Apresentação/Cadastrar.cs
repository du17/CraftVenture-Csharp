using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GerenciadorDeEstoque.Apresentação;
using GerenciadorDeEstoque.Modelo;
using System.Data.SqlClient;
using GerenciadorDeEstoque.DAO;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciadorDeEstoque
{
    public partial class Form1 : KryptonForm
    {
        Thread TelaCadastro; // Criando tela cadastro
        public Form1()
        {
            InitializeComponent();
            //ChecarLoginSalvo();
        }

        /*int savedados = 0;
        SqlCommand comando = new SqlCommand();
        public bool check = false;
        public string mensagem = "";
        Conexao connect = new Conexao();
        Controle controle = new Controle(); // Instanciando a classe controle
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = estoque; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        int CodSalvoLogin;

        private void ChecarLoginSalvo() // Método para checar se o usuário marcou para lembrar os dados de login
        {
            con.Open();
            SqlCommand comando = new SqlCommand("select salvar from salvar_dados where id = 1;", con);
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            for(int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                CodSalvoLogin = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
            }

            if(CodSalvoLogin == 1)
            {
                EmailSalvo();
                SenhaSalva();
                checkBoxDadosLogin.Checked = true;
            }
        }

        private void EmailSalvo() // Método para obter o registro do e-mail do login caso tenha sido memorizado
        {
            con.Open();
            SqlCommand comandologin = new SqlCommand("select email from salvar_dados where id = 1;", con);
            da = new SqlDataAdapter(comandologin);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txb_email.Text = Convert.ToString(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        private void SenhaSalva() // Método para obter o registro da senha do login caso tenha sido memorizado
        {
            con.Open();
            SqlCommand comandosenha = new SqlCommand("select senha from salvar_dados where id = 1;", con);
            da = new SqlDataAdapter(comandosenha);
            ds = new DataSet();
            da.Fill(ds, "estoque");
            con.Close();
            dt = ds.Tables["estoque"];

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                txb_password.Text = Convert.ToString(dt.Rows[i].ItemArray[0].ToString());
            }
        }

        private void txb_register_Click(object sender, EventArgs e) // Botão "Cadastrar"
        {
            TelaCadastro = new Thread(OpenCadastro);
            TelaCadastro.SetApartmentState(ApartmentState.MTA);
            TelaCadastro.Start();
            this.Close();
        }

        public void OpenCadastro() // Método para abrir a tela "Cadastrar"
        {
            Application.Run(new Cadastrar());
        }

        private void button1_Click(object sender, EventArgs e) // Botão sair
        {
            this.Close();
        }

        private void txb_join_Click(object sender, EventArgs e) // Botão entrar
        {
            if (!txb_email.Text.Equals(""))
            {
                if (!txb_password.Text.Equals(""))
                {
                    controle.Acessar(txb_email.Text, txb_password.Text);

                    if (controle.mensagem.Equals(""))
                    {
                        if (controle.verificacao)
                        {
                            if (checkBoxDadosLogin.Checked == true) // Se a pessoa marcou para salvar os dados do user
                            {
                                mensagem = controle.ChecarSaveDadosLogin(txb_email.Text, txb_password.Text, "1");
                                this.Hide(); // Esconder a Form1 após o usuário validar o login
                            }

                            else // Se a pessoa não marcou para salvar os dados do user
                            {
                                mensagem = controle.ChecarSaveDadosLogin(txb_email.Text, txb_password.Text, "0");
                                this.Hide(); // Esconder a Form1 após o usuário validar o login
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dados incorretos!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem);
                    }
                    }
                else
                {
                        MessageBox.Show("Por favor, digite uma senha!");
                }
                }
            else
            {
                    MessageBox.Show("Por favor, digite um e-mail!");
            }
        }
        

        private void txb_email_Click(object sender, EventArgs e) // Quando o user clica no text box e-mail, limpa a escrita "Email"
        {
            txb_email.Clear();
        }

        private void txb_password_Click_1(object sender, EventArgs e) // Quando o user clica no text box senha, limpa a escrita "Senha"
        {
            txb_password.Clear();
        }

        private void txb_password_TextChanged_1(object sender, EventArgs e) // Quando altera o texto da text box senha
        {
            txb_password.PasswordChar = '*'; // Os caracteres da senha saem com *
        }*/

        public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            if (c != null)
            {
                Type typeTB = typeof(Control);
                System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (misSetStyle != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
            }
            return retval;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
         
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
           lblSenha.Visible = false;
            
        }

        private void txtRepetirSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
           lblRepetirSenha.Visible = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
               
            lblEmail.Visible = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
                lblNome.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();

            Login.ShowDialog();
        }
    }
}
