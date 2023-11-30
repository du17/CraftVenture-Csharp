using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;
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
    public partial class frmProduto : Form
    {
        DataTable dt = new DataTable();

        ProdutoVO produto;
        MaterialProdutoVO materialProduto = null;

        bool novoClicado = false;

        public frmProduto()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetProduto(false);
            dgvProdutoKrypton.DataSource = dt;
            
            ConfigurarGradeProdutos();
            
        }

        private void ConfigurarGradeProdutos()
        {
            dgvProdutoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvProdutoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvProdutoKrypton.RowHeadersWidth = 20;
            dgvProdutoKrypton.RowTemplate.Height = 40;

            dgvProdutoKrypton.Columns["id"].HeaderText = "ID";
            dgvProdutoKrypton.Columns["id"].Visible = true;

            dgvProdutoKrypton.Columns["tipo"].HeaderText = "Tipo";
            dgvProdutoKrypton.Columns["tipo"].Width = 200;
            dgvProdutoKrypton.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProdutoKrypton.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProdutoKrypton.Columns["nome"].HeaderText = "Nome";
            dgvProdutoKrypton.Columns["nome"].Width = 130;
            dgvProdutoKrypton.Columns["nome"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvProdutoKrypton.Columns["quantidade"].HeaderText = "Quantidade";
            dgvProdutoKrypton.Columns["quantidade"].Width = 120;
            dgvProdutoKrypton.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProdutoKrypton.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProdutoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvProdutoKrypton.Columns["valor"].Width = 100;
            dgvProdutoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProdutoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        

        private void btnAcidionarMaterial_Click(object sender, EventArgs e)
        {
            if (materialProduto != null)
            {
                frmAdicionarMaterialProduto Adicionar = new frmAdicionarMaterialProduto(materialProduto);

                Adicionar.ShowDialog();
            }
        }

        private void dgvPapelKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            produto = new ProdutoVO();

            novoClicado = false;

            try
            {

                produto.Nome = GetValorLinha("nome").ToString();
                produto.Valor = Convert.ToInt64(GetValorLinha("valor"));
                produto.Quantidade = Convert.ToInt64(GetValorLinha("quantidade"));
                produto.Tipo = GetValorLinha("tipo").ToString();
                produto.itemid = Convert.ToInt64(GetValorLinha("id"));

                txtNome.Text = produto.Nome;
                txtValor.Text = produto.Valor.ToString();
                txtQuantidade.Text = produto.Quantidade.ToString();
                txtTipo.Text = produto.Tipo;

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnApagar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                produto = new ProdutoVO();


                try
                {

                    String nome = txtNome.Text;
                    Int64 valor = Convert.ToInt64(txtValor.Text);
                    Int64 quantidade = Convert.ToInt64(txtQuantidade.Text);

                    produto.Nome = nome;
                    produto.Valor = valor;
                    produto.Quantidade = quantidade;

                    produto.Atualizar();

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
                produto = new ProdutoVO();
                

                long idProduto;

                try
                {
                    String nome = txtNome.Text;
                    String tipo = txtTipo.Text;
                    Int64 valor = Convert.ToInt64(txtValor.Text);
                    Int64 quantidade = Convert.ToInt64(txtQuantidade.Text);

                    produto.Nome = nome;
                    produto.Valor = valor;
                    produto.Quantidade = quantidade;
                    produto.Tipo = tipo;

                    produto.Inserir();

                    idProduto = produto.getLastId();

                    materialProduto.IdProduto = idProduto;

                    materialProduto.Inserir();

                    MessageBox.Show("Item Cadastrado!");

                    LimpaTextos();
                    Inicializar();

                    materialProduto = null;

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "erro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    produto.itemid = produto.getLastId();
                    produto.Remover();
                }
                finally { novoClicado = false; }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutoKrypton.Rows.Count == 0)
                {
                    novoClicado = true;

                    materialProduto = new MaterialProdutoVO();

                    LimpaTextos();

                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                    btnApagar.Enabled = false;
                }
                else
                {
                    novoClicado = true;
                    dgvProdutoKrypton.CurrentCell.Selected = false;

                    materialProduto = new MaterialProdutoVO();

                    LimpaTextos();

                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                    btnApagar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaTextos()
        {
            txtNome.Text = String.Empty;
            txtQuantidade.Text = String.Empty;
            txtValor.Text = String.Empty;
            pbProduto.Image = null;
            txtTipo.Text = String.Empty;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            produto = new ProdutoVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: " + txtNome.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    produto.itemid = Convert.ToInt64(GetValorLinha("id"));

                    produto.Remover();

                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object GetValorLinha(String campo)
        {
            return dgvProdutoKrypton.Rows[dgvProdutoKrypton.CurrentCell.RowIndex].Cells[campo].Value;
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

                    dv.RowFilter = String.Format("nome LIKE '%{0}%'", palavra);

                }
                else if (palavra.Length != 0)
                {
                    palavra = palavra.Remove(palavra.Length - 1);

                    dv.RowFilter = String.Format("nome LIKE '%{0}%'", palavra);

                }

                dgvProdutoKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
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
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria de voltar ao menu? (todas as informações não salvas serão apagadas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
