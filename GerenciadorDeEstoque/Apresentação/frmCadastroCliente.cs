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

        DataTable dt = new DataTable();

        bool novoClicado = false;


        public frmCadastroCliente()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetCliente();
            dgvClienteKrypton.DataSource = dt;
            ConfigurarGradeClientes();
        }

        private void ConfigurarGradeClientes()
        {
            dgvClienteKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvClienteKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 12, FontStyle.Bold);
            dgvClienteKrypton.RowHeadersWidth = 20;
            dgvClienteKrypton.RowTemplate.Height = 40;
            
            dgvClienteKrypton.Columns["id"].HeaderText = "ID";
            dgvClienteKrypton.Columns["id"].Visible = true;
            dgvClienteKrypton.Columns["id"].Width = 50;

            dgvClienteKrypton.Columns["nome"].HeaderText = "Nome";
            dgvClienteKrypton.Columns["nome"].Width = 200;
            dgvClienteKrypton.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClienteKrypton.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            dgvClienteKrypton.Columns["email"].HeaderText = "Email";
            dgvClienteKrypton.Columns["email"].Width = 130;
            dgvClienteKrypton.Columns["email"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            
            dgvClienteKrypton.Columns["telefone"].HeaderText = "Telefone";
            dgvClienteKrypton.Columns["telefone"].Width = 200;
            dgvClienteKrypton.Columns["telefone"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvClienteKrypton.Columns["telefone"].DefaultCellStyle.Format = "(##)#####-####";

            dgvClienteKrypton.Columns["estado"].HeaderText = "Estado";
            dgvClienteKrypton.Columns["estado"].Width = 120;
            dgvClienteKrypton.Columns["estado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClienteKrypton.Columns["estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClienteKrypton.Columns["rua"].HeaderText = "Rua";
            dgvClienteKrypton.Columns["rua"].Width = 200;
            dgvClienteKrypton.Columns["rua"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvClienteKrypton.Columns["rua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvClienteKrypton.Columns["bairro"].HeaderText = "Bairro";
            dgvClienteKrypton.Columns["bairro"].Width = 120;
            dgvClienteKrypton.Columns["bairro"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClienteKrypton.Columns["bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClienteKrypton.Columns["numero"].HeaderText = "Número";
            dgvClienteKrypton.Columns["numero"].Width = 120;
            dgvClienteKrypton.Columns["numero"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClienteKrypton.Columns["numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClienteKrypton.Columns["cep"].HeaderText = "CEP";
            dgvClienteKrypton.Columns["cep"].Visible = false;

            dgvClienteKrypton.Columns["complemento"].HeaderText = "Complemento";
            dgvClienteKrypton.Columns["complemento"].Visible = false;


        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrindo Cadastro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cliente = new ClienteVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir cliente: " + txtNome.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    cliente.itemid = Convert.ToInt64(GetValorLinha("id"));

                    cliente.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaTextos()
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
            txtCidade.Text = string.Empty;

            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) { 

            cliente = new ClienteVO();

            try
            {
                if (txtNome.Text == string.Empty || txtNumero.Text == string.Empty || txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtRua.Text == string.Empty || txtBairro.Text == string.Empty || txtCep.Text == string.Empty || cbxEstado.Text == "Inserir Estado" || txtCidade.Text == string.Empty) { throw new ArgumentNullException("Algum dos campos está nulo!"); }

                String telefone = txtTelefone.Text;
                Int64 numero = Convert.ToInt64(txtNumero.Text);
                String nome = txtNome.Text;
                String email = txtEmail.Text;
                String cep = txtCep.Text;
                String rua = txtRua.Text;
                String bairro = txtBairro.Text;
                String estado = cbxEstado.Text;
                String complemento = txtComplemento.Text;
                String cidade = txtCidade.Text;

                if (telefone.Length < 11) { throw new ArgumentException("O número de telefone é inválido"); }


                if (GetEstadoCompleto(getEstado(estado)) == "Sem Estado") { throw new ArgumentException("O estado é inválido, escolha um válido da lista"); }


                if (!novoClicado)
                {
                    cliente = new ClienteVO();


                    try
                    {


                        cliente.itemid = Convert.ToInt64(GetValorLinha("id"));
                        cliente.Telefone = telefone;
                        cliente.Numero = numero;
                        cliente.Nome = nome;
                        cliente.Email = email;
                        cliente.Cep = cep;
                        cliente.Rua = rua;
                        cliente.Bairro = bairro;
                        cliente.Estado = getEstado(estado);
                        cliente.Complemento = complemento;
                        cliente.Cidade = cidade;

                        cliente.Atualizar();

                        MessageBox.Show("Item Atualizado!");

                        Inicializar();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    cliente = new ClienteVO();

                    try
                    {
                        
                        cliente.Telefone = telefone;
                        cliente.Numero = numero;
                        cliente.Nome = nome;
                        cliente.Email = email;
                        cliente.Cep = cep;
                        cliente.Rua = rua;
                        cliente.Bairro = bairro;
                        cliente.Estado = getEstado(estado);
                        cliente.Complemento = complemento;
                        cliente.Cidade = cidade;

                        cliente.Inserir();

                        MessageBox.Show("Cliente Cadastrado!");

                        Inicializar();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { novoClicado = false; }
                }
            }catch(ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string getEstado(String estado)
        {
            string estadoSimplificado = "";

            estado.Trim();

            estadoSimplificado += estado[estado.Length - 3];
            estadoSimplificado += estado[estado.Length - 2];


            return estadoSimplificado;
        }

        public string GetEstadoCompleto(String estado)
        {
            String estadoCompleto;

            switch (estado) 
            {
                case "AC":
                    estadoCompleto = "Acre (AC)";
                    break;

                case "AL":
                    estadoCompleto = "Alagoas (AL)";
                    break;
                case "AP":
                    estadoCompleto = "Amapá (AP)";
                    break;
                case "AM":
                    estadoCompleto = "Amazonas (AM)";
                    break;
                case "BA":
                    estadoCompleto = "Bahia (BA)";
                    break;
                case "CE":
                    estadoCompleto = "Ceará (CE)";
                    break;
                case "DF":
                    estadoCompleto = "Distrito Federal (DF)";
                    break;
                case "ES":
                    estadoCompleto = "Espírito Santo (ES)";
                    break;
                case "GO":
                    estadoCompleto = "Goiás (GO)";
                    break;
                case "MA":
                    estadoCompleto = "Maranhão (MA)";
                    break;
                case "MT":
                    estadoCompleto = "Mato Grosso (MT)";
                    break;
                case "MS":
                    estadoCompleto = "Mato Grosso do Sul (MS)";
                    break;
                case "MG":
                    estadoCompleto = "Minas Gerais (MG)";
                    break;
                case "PA":
                    estadoCompleto = "Pará (PA)";
                    break;
                case "PB":
                    estadoCompleto = "Paraíba (PB)";
                    break;
                case "PR":
                    estadoCompleto = "Paraná (PR)";
                    break;
                case "PE":
                    estadoCompleto = "Pernambuco (PE)";
                    break;
                case "PI":
                    estadoCompleto = "Piauí (PI)";
                    break;
                case "RJ":
                    estadoCompleto = "Rio de Janeiro (RJ)";
                    break;
                case "RN":
                    estadoCompleto = "Rio Grande do Norte (RN)";
                    break;
                case "RS":
                    estadoCompleto = "Rio Grande do Sul (RS)";
                    break;
                case "RO":
                    estadoCompleto = "Rondônia (RO)";
                    break;
                case "RR":
                    estadoCompleto = "Roraima (RR)";
                    break;
                case "SC":
                    estadoCompleto = "Santa Catarina (SC)";
                    break;
                case "SP":
                    estadoCompleto = "São Paulo (SP)";
                    break;
                case "SE":
                    estadoCompleto = "Sergipe (SE)";
                    break;
                case "TO":
                    estadoCompleto = "Tocantins (TO)";
                    break;
                default:
                    estadoCompleto = "Sem Estado";
                    break;
            }
                

            return estadoCompleto;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClienteKrypton.Rows.Count == 0)
                {
                     dgvClienteKrypton.CurrentCell.Selected = false;
                }

                novoClicado = true;
                LimpaTextos();

                btnCadastrar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                btnCadastrar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                btnCadastrar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                btnApagar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object GetValorLinha(String campo)
        {
            return dgvClienteKrypton.Rows[dgvClienteKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void dgvClienteKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cliente = new ClienteVO();

            novoClicado = false;

            try
            {
                
                cliente.Nome = GetValorLinha("nome").ToString();
                cliente.Telefone = GetValorLinha("telefone").ToString();
                cliente.Email = GetValorLinha("email").ToString();
                cliente.Cep = GetValorLinha("cep").ToString();
                cliente.Rua = GetValorLinha("rua").ToString();
                cliente.Bairro = GetValorLinha("bairro").ToString();
                cliente.Estado = GetValorLinha("estado").ToString();
                cliente.Complemento = GetValorLinha("complemento").ToString();
                cliente.Numero = Convert.ToInt32(GetValorLinha("numero"));
                cliente.Cidade = GetValorLinha("cidade").ToString();

                txtNome.Text = cliente.Nome;
                txtTelefone.Text = cliente.Telefone.ToString();
                txtEmail.Text = cliente.Email;
                txtCep.Text = cliente.Cep;
                txtRua.Text = cliente.Rua;
                txtBairro.Text = cliente.Bairro;
                cbxEstado.SelectedItem = GetEstadoCompleto(cliente.Estado);
                txtComplemento.Text = cliente.Complemento;
                txtNumero.Text = cliente.Numero.ToString();
                txtCidade.Text = cliente.Cidade;

                btnCadastrar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnCadastrar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnCadastrar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnApagar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        String palavra;

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                DataView dv = new DataView(dt);


                if (e.KeyChar != '\b')
                {
                    palavra += e.KeyChar;

                }
                else if (palavra.Length != 0)
                {
                    palavra = palavra.Remove(palavra.Length - 1);
                }

                dv.RowFilter = String.Format("nome LIKE '%{0}%'", palavra);

                dgvClienteKrypton.DataSource = dv;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrindo Venda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmVenda venda = new frmVenda();
                venda.Show();
                this.Close();
            }
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

        private void btnHistórico_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrir Histórico", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmHistorico historico = new frmHistorico();
                historico.Show();
                this.Close();
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
