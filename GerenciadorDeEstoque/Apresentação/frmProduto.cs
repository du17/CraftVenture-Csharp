using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            dgvProduto.DataSource = dt;

            ConfigurarGradeProdutos();

        }

        private void ConfigurarGradeProdutos()
        {
            dgvProduto.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvProduto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvProduto.RowHeadersWidth = 20;
            dgvProduto.RowTemplate.Height = 40;

            dgvProduto.Columns["id"].HeaderText = "ID";
            dgvProduto.Columns["id"].Visible = true;

            dgvProduto.Columns["tipo"].HeaderText = "Tipo";
            dgvProduto.Columns["tipo"].Width = 200;
            dgvProduto.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduto.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduto.Columns["nome"].HeaderText = "Nome";
            dgvProduto.Columns["nome"].Width = 200;
            dgvProduto.Columns["nome"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvProduto.Columns["quantidade"].HeaderText = "Quantidade";
            dgvProduto.Columns["quantidade"].Width = 120;
            dgvProduto.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduto.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduto.Columns["valor"].HeaderText = "Valor";
            dgvProduto.Columns["valor"].Width = 100;
            dgvProduto.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduto.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProduto.Columns["foto"].Width = 70;
            dgvProduto.Columns["foto"].HeaderText = "Foto";
            if (dgvProduto.Columns["foto"] is DataGridViewImageColumn fotoColumn)
            {
                fotoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }



        private void btnAcidionarMaterial_Click(object sender, EventArgs e)
        {
            if (materialProduto != null && novoClicado == true)
            {
                frmAdicionarMaterialProduto Adicionar = new frmAdicionarMaterialProduto(materialProduto);

                Adicionar.ShowDialog();
            }
            else if (materialProduto != null && novoClicado == false)
            {
                frmAdicionarMaterialProduto Adicionar = new frmAdicionarMaterialProduto(Convert.ToInt64(GetValorLinha("id")), materialProduto);

                Adicionar.ShowDialog();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = txtNome.Text;
                String tipo = txtTipo.Text;
                Int64 valor = Convert.ToInt64(txtValor.Text);
                Int64 quantidade = Convert.ToInt64(txtQuantidade.Text);
                byte[] foto = null;

                if (quantidade <= 0) { throw new ArgumentException("A quantidade está negativa!"); }

                if (valor <= 0) { throw new ArgumentException("O valor está negativo"); }

                produto = new ProdutoVO();

                if (!novoClicado)
                {
                    try
                    {
                        produto.Nome = nome;
                        produto.Valor = valor;
                        produto.Quantidade = quantidade;
                        produto.Tipo = tipo;
                        produto.Foto = foto;
                        produto.itemid = Convert.ToInt64(GetValorLinha("id"));

                        if (!string.IsNullOrEmpty(pbProduto.ImageLocation))
                        {
                            using (FileStream fstream = new FileStream(this.pbProduto.ImageLocation, FileMode.Open, FileAccess.Read))
                            using (BinaryReader breader = new BinaryReader(fstream))
                            {
                                foto = breader.ReadBytes((int)fstream.Length);
                                produto.Foto = foto;
                            }
                        }
                        else
                        {
                            foto = null;
                        }

                        produto.Atualizar();

                        materialProduto.IdProduto = Convert.ToInt64(GetValorLinha("id"));

                        materialProduto.Atualizar();

                        MessageBox.Show("Item Atualizado!");

                        Inicializar();

                    }
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    long idProduto;

                    try
                    {
                        if (!string.IsNullOrEmpty(pbProduto.ImageLocation))
                        {
                            using (FileStream fstream = new FileStream(this.pbProduto.ImageLocation, FileMode.Open, FileAccess.Read))
                            using (BinaryReader breader = new BinaryReader(fstream))
                            {
                                foto = breader.ReadBytes((int)fstream.Length);
                            }
                        }
                        else
                        {
                            foto = null;
                        }

                        produto.Nome = nome;
                        produto.Valor = valor;
                        produto.Quantidade = quantidade;
                        produto.Tipo = tipo;
                        produto.Foto = foto;

                        produto.Inserir();

                        idProduto = produto.getLastId();

                        materialProduto.IdProduto = idProduto;

                        materialProduto.Inserir();

                        MessageBox.Show("Item Cadastrado!");

                        LimpaTextos();
                        Inicializar();

                        materialProduto = null;

                        novoClicado = false;

                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                novoClicado = true;

                if (dgvProdutoKrypton.Rows.Count != 0)
                {
                    dgvProdutoKrypton.CurrentCell.Selected = false;
                }

                materialProduto = new MaterialProdutoVO();

                LimpaTextos();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;

                btnAcidionarMaterial.StateNormal.Back.Image = Properties.Resources.Adicionar_Material_btn;
                btnAcidionarMaterial.StatePressed.Back.Image = Properties.Resources.Adicionar_Material_btn;
                btnAcidionarMaterial.StateTracking.Back.Image = Properties.Resources.Adicionar_Material_Tracking;

                btnApagar.Enabled = false;
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
            return dgvProduto.Rows[dgvProduto.CurrentCell.RowIndex].Cells[campo].Value;
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

                dv.RowFilter = String.Format("nome LIKE '%{0}%' OR tipo LIKE '%{0}%'", palavra);

                dgvProduto.DataSource = dv;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria de voltar ao menu? (todas as informações não salvas serão apagadas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrindo Venda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmVenda frmVenda = new frmVenda();
                frmVenda.Show();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProduto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbProduto.Image = null;
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

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbProduto.Image = imagem;
                }

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnAcidionarMaterial.StateNormal.Back.Image = Properties.Resources.Editar_Material;
                btnAcidionarMaterial.StatePressed.Back.Image = Properties.Resources.Editar_Material;
                btnAcidionarMaterial.StateTracking.Back.Image = Properties.Resources.Editar_Material_Tracking;

                btnApagar.Enabled = true;

                materialProduto = new MaterialProdutoVO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }
        }
        public Image ByteArrayParaImagem(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Filtro = cbxFiltro.Text;

            if (Filtro.Equals("Nome"))
            {
                dgvProduto.Sort(dgvProduto.Columns["nome"], ListSortDirection.Ascending);
            }
            else if (Filtro.Equals("Tipo"))
            {
                dgvProduto.Sort(dgvProduto.Columns["tipo"], ListSortDirection.Ascending);
            }
            else if (Filtro.Equals("Quantidade"))
            {
                dgvProduto.Sort(dgvProduto.Columns["quantidade"], ListSortDirection.Ascending);
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

        private void pbProduto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbProduto.ImageLocation = localfoto;
            }
        }
    }
}
