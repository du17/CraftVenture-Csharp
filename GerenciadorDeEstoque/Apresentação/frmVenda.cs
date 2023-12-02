using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using Google.Protobuf.WellKnownTypes;
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
    public partial class frmVenda : Form
    {

        VendaVO venda;
        VendeVO vende = null;

        DataTable dt = new DataTable();
        DataTable dtNome = new DataTable();

        bool novoClicado = false;

        public frmVenda()
        {
            InitializeComponent();

            Inicializar();
            cbxNomeCliente.Text = "Escolher cliente";
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetVenda();
            dtNome = DAO.DAO.GetNomeCliente();
            dgvVendaKrypton.DataSource = dt;

            cbxNomeCliente.DataSource = dtNome;
            cbxNomeCliente.DisplayMember = "nome";
            cbxNomeCliente.ValueMember = "id";

            

            ConfigurarGradeClientes();
        }

        private void ConfigurarGradeClientes()
        {
            dgvVendaKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12, FontStyle.Bold);
            dgvVendaKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 10, FontStyle.Bold);
            dgvVendaKrypton.RowHeadersWidth = 20;
            dgvVendaKrypton.RowTemplate.Height = 40;
            
            dgvVendaKrypton.Columns["id"].HeaderText = "ID";
            dgvVendaKrypton.Columns["id"].Visible = true;
            dgvVendaKrypton.Columns["id"].Width = 50;
            
            dgvVendaKrypton.Columns["nomeCliente"].HeaderText = "Nome do cliente";
            dgvVendaKrypton.Columns["nomeCliente"].Width = 200;
            dgvVendaKrypton.Columns["nomeCliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendaKrypton.Columns["nomeCliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvVendaKrypton.Columns["dataVenda"].HeaderText = "Data de Venda";
            dgvVendaKrypton.Columns["dataVenda"].Width = 120;
            dgvVendaKrypton.Columns["dataVenda"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendaKrypton.Columns["dataVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVendaKrypton.Columns["dataEntrega"].HeaderText = "Data de Entrega";
            dgvVendaKrypton.Columns["dataEntrega"].Width = 120;
            dgvVendaKrypton.Columns["dataEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendaKrypton.Columns["dataEntrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVendaKrypton.Columns["formaPagamento"].HeaderText = "Forma de Pagamento";
            dgvVendaKrypton.Columns["formaPagamento"].Width = 120;
            dgvVendaKrypton.Columns["formaPagamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvVendaKrypton.Columns["formaPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
            dgvVendaKrypton.Columns["formaEntrega"].HeaderText = "Forma de Entrega";
            dgvVendaKrypton.Columns["formaEntrega"].Width = 120;
            dgvVendaKrypton.Columns["formaEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendaKrypton.Columns["formaEntrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvVendaKrypton.Columns["valorTotal"].HeaderText = "Valor Total";
            dgvVendaKrypton.Columns["valorTotal"].Width = 90;
            dgvVendaKrypton.Columns["valorTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVendaKrypton.Columns["valorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvVendaKrypton.Columns["anotacao"].HeaderText = "Anotação";
            dgvVendaKrypton.Columns["anotacao"].Visible = true;
            
            dgvVendaKrypton.Columns["idUsuario"].HeaderText = "idUsuario";
            dgvVendaKrypton.Columns["idUsuario"].Visible = false;

            dgvVendaKrypton.Columns["codigoCliente"].HeaderText = "codigoCliente";
            dgvVendaKrypton.Columns["codigoCliente"].Visible = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                
                venda = new VendaVO();

                try
                {

                    if (cbxNomeCliente.Text == "Escolher Cliente" || cbxFormaEntrega.Text == String.Empty || cbxFormaPagamento.Text == String.Empty || txtValor.Text == String.Empty)
                    {
                        throw new ArgumentNullException("Algum ou vários campos está vazio!");
                    }
                    else if (vende.IdProdutoLista == null || vende.IdProdutoLista.Count <= 0)
                    {
                        throw new ArgumentNullException("Você não escolheu nenhum material que faz parte do produto");
                    }

                    String nomeCliente = cbxNomeCliente.Text;
                    String formaPagamento = cbxFormaPagamento.Text;
                    String formaEntrega = cbxFormaEntrega.Text;
                    String anotacao = txtAnotacao.Text;

                    Int64 valor = Convert.ToInt64(txtValor.Text);
                    Int64 idCliente = Convert.ToInt64(cbxNomeCliente.SelectedValue);
                    DateTime dataEntrega = dtpDateEntrega.Value;
                    DateTime dataVenda = dtpDataVenda.Value;

                    venda.itemid = Convert.ToInt64(GetValorLinha("id"));
                    venda.NomeCliente = nomeCliente;
                    venda.FormaPagamento = formaPagamento;
                    venda.FormaEntrega = formaEntrega;
                    venda.Anotacao = anotacao;
                    venda.ValorTotal = valor;
                    venda.DataVenda = dataVenda;
                    venda.DataEntrega = dataEntrega;
                    venda.CodCliente = idCliente;

                    vende.IdVenda = Convert.ToInt64(GetValorLinha("id"));

                    vende.Atualizar();

                    venda.Atualizar();

                    

                    MessageBox.Show("Venda Atualizada!");

                    Inicializar();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
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
                venda = new VendaVO();

                long idLastInsert;
                
                try
                {

                    if (cbxNomeCliente.Text == "Escolher Cliente" || cbxFormaEntrega.Text == String.Empty || cbxFormaPagamento.Text == String.Empty || txtValor.Text == String.Empty)
                    {
                        throw new ArgumentNullException("Algum ou vários campos está vazio!");
                    }
                    else if (vende.IdProdutoLista == null || vende.IdProdutoLista.Count <= 0)
                    {
                        throw new ArgumentNullException("Você não escolheu nenhum material que faz parte do produto");
                    }

                    String nomeCliente = cbxNomeCliente.Text;
                    String formaPagamento = cbxFormaPagamento.Text;
                    String formaEntrega = cbxFormaEntrega.Text;
                    String anotacao = txtAnotacao.Text;

                    Int64 valor = Convert.ToInt64(txtValor.Text);
                    Int64 idCliente = Convert.ToInt64(cbxNomeCliente.SelectedValue);
                    DateTime dataEntrega = dtpDateEntrega.Value;
                    DateTime dataVenda = dtpDataVenda.Value;

                    venda.NomeCliente = nomeCliente;
                    venda.FormaPagamento = formaPagamento;
                    venda.FormaEntrega = formaEntrega;
                    venda.Anotacao = anotacao;
                    venda.ValorTotal = valor;
                    venda.DataVenda = dataVenda;
                    venda.DataEntrega = dataEntrega;
                    venda.CodCliente = idCliente;

                    venda.Inserir();

                    idLastInsert = venda.getLastId();

                    vende.IdVenda = idLastInsert;

                    vende.Inserir();

                    MessageBox.Show("Venda Cadastrada!");

                    novoClicado = false;

                    Inicializar();
                }
                catch(ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
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
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            venda = new VendaVO();
            vende = new VendeVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR esta venda?\nEsta ação não pode ser desfeita", "Excluir Venda do cliente: " + cbxNomeCliente.SelectedItem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    venda.itemid = Convert.ToInt64(GetValorLinha("id"));
                    vende.IdVenda = Convert.ToInt64(GetValorLinha("id"));
                                        
                    venda.Remover();
                    vende.Remover();

                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendaKrypton.Rows.Count == 0)
                {
                    novoClicado = true;
                    LimpaTextos();

                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;

                    btnAdicionarProduto.StateNormal.Back.Image = Properties.Resources.Adicionar_Produtos;
                    btnAdicionarProduto.StatePressed.Back.Image = Properties.Resources.Adicionar_Produtos;
                    btnAdicionarProduto.StateTracking.Back.Image = Properties.Resources.Adicionar_Produtos_Tracking;

                    btnApagar.Enabled = false;
                }
                else
                {
                    novoClicado = true;
                    dgvVendaKrypton.CurrentCell.Selected = false;
                    LimpaTextos();

                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;

                    btnAdicionarProduto.StateNormal.Back.Image = Properties.Resources.Adicionar_Produtos;
                    btnAdicionarProduto.StatePressed.Back.Image = Properties.Resources.Adicionar_Produtos;
                    btnAdicionarProduto.StateTracking.Back.Image = Properties.Resources.Adicionar_Produtos_Tracking;

                    btnApagar.Enabled = false;
                }

                vende = new VendeVO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaTextos()
        {
            cbxNomeCliente.Text = "Escolher Cliente";
            cbxFormaPagamento.Text = string.Empty;
            cbxFormaEntrega.Text = string.Empty;

            dtpDataVenda.Value = DateTime.Now;
            dtpDateEntrega.Value = DateTime.Now;

            txtAnotacao.Text = string.Empty;
            txtValor.Text = string.Empty;

            cbxNomeCliente.Focus();
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

                    dv.RowFilter = String.Format("nomeCliente LIKE '%{0}%'", palavra);

                }
                else if (palavra.Length != 0)
                {
                    palavra = palavra.Remove(palavra.Length - 1);

                    dv.RowFilter = String.Format("nomeCliente LIKE '%{0}%'", palavra);

                }

                dgvVendaKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (vende != null && novoClicado == true)
            {
                frmAdicionarProdutos Adicionar = new frmAdicionarProdutos(vende);

                Adicionar.ShowDialog();
            }
            else if(vende != null && novoClicado == false)
            {
                frmAdicionarProdutos Adicionar = new frmAdicionarProdutos(Convert.ToInt64(GetValorLinha("id")), vende);

                Adicionar.ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão apagadas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão apagadas)", "Abrir Cadastro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
            }
        }

        private void dgvVendaKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            venda = new VendaVO();

            novoClicado = false;

            try
            {

                venda.itemid = Convert.ToInt64(GetValorLinha("id"));
                venda.NomeCliente = GetValorLinha("nomeCliente").ToString();
                venda.FormaPagamento = GetValorLinha("formaPagamento").ToString();
                venda.FormaEntrega = GetValorLinha("formaEntrega").ToString();
                venda.Anotacao = GetValorLinha("anotacao").ToString();
                venda.ValorTotal = Convert.ToInt64(GetValorLinha("valorTotal"));
                venda.DataVenda = Convert.ToDateTime(GetValorLinha("dataVenda"));
                venda.DataEntrega = Convert.ToDateTime(GetValorLinha("dataEntrega"));
                venda.CodCliente = Convert.ToInt64(GetValorLinha("codigoCliente"));

                cbxNomeCliente.Text = venda.NomeCliente;
                cbxFormaPagamento.SelectedItem = venda.FormaPagamento;
                cbxFormaEntrega.SelectedItem = venda.FormaEntrega;
                txtAnotacao.Text = venda.Anotacao;
                txtValor.Text = venda.ValorTotal.ToString();
                dtpDataVenda.Value = venda.DataVenda;
                dtpDateEntrega.Value = venda.DataEntrega;

                

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnAdicionarProduto.StateNormal.Back.Image = Properties.Resources.Editar_Produtos;
                btnAdicionarProduto.StatePressed.Back.Image = Properties.Resources.Editar_Produtos;
                btnAdicionarProduto.StateTracking.Back.Image = Properties.Resources.Editar_Produtos_Tracking;

                btnApagar.Enabled = true;

                vende = new VendeVO();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private object GetValorLinha(String campo)
        {
            return dgvVendaKrypton.Rows[dgvVendaKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }
    }
}
