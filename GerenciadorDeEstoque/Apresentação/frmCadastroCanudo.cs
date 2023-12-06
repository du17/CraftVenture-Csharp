using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using MetroFramework;
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
    public partial class frmCadastroCanudo : Form
    {
        static String nome_material = "Canudo";
        CanudoVO canudo;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;
        String palavra;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroCanudo()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetCanudo();
            dgvCanudoKrypton.DataSource = dt;
            ConfigurarGradeLivros();
        }

        private void ConfigurarGradeLivros()
        {
            dgvCanudoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvCanudoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvCanudoKrypton.RowHeadersWidth = 20;
            dgvCanudoKrypton.RowTemplate.Height = 40;

            dgvCanudoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvCanudoKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvCanudoKrypton.Columns["quantidade"].HeaderText = "Quantidade";
            dgvCanudoKrypton.Columns["quantidade"].Width = 200;
            dgvCanudoKrypton.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCanudoKrypton.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCanudoKrypton.Columns["cor"].HeaderText = "Cor";
            dgvCanudoKrypton.Columns["cor"].Width = 200;
            dgvCanudoKrypton.Columns["cor"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvCanudoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvCanudoKrypton.Columns["valor"].Width = 100;
            dgvCanudoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCanudoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvCanudoKrypton.Columns["foto"].Width = 70;
            dgvCanudoKrypton.Columns["foto"].HeaderText = "Foto";
            if (dgvCanudoKrypton.Columns["foto"] is DataGridViewImageColumn fotoColumn)
            {
                fotoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private object GetValorLinha(String campo)
        {
            return dgvCanudoKrypton.Rows[dgvCanudoKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrindo Venda", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            canudo = new CanudoVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir canudo: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    canudo.itemidproduto = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    canudo.Remover();
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
            txtValor.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            pbCanudo.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!novoClicado)
            {
                canudo = new CanudoVO();
                material = new MaterialVO();


                try
                {
                    if (txtCor.Text == string.Empty || txtQuantidade.Text == string.Empty || txtValor.Text == string.Empty)
                    {
                        throw new ArgumentNullException();
                    }

                    string cor = txtCor.Text;
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbCanudo.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbCanudo.ImageLocation, FileMode.Open, FileAccess.Read))
                        using (BinaryReader breader = new BinaryReader(fstream))
                        {
                            foto = breader.ReadBytes((int)fstream.Length);
                            material.Foto = foto;
                        }
                    }
                    else
                    {
                        foto = null;
                    }

                    if (quantidade <= 0) { throw new ArgumentException("A quantidade não deve ser negativa"); }

                    if(valor <= 0) { throw new ArgumentException("O valor não deve ser negativo!"); }

                    canudo.itemidproduto = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    canudo.Quantidade = quantidade;
                    canudo.Cor = cor;
                    canudo.Valor = valor;

                    material.Nome = nome_material + " " + cor + " " + quantidade + " Canudo(s)";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    material.Atualizar();
                    canudo.Atualizar();

                    MessageBox.Show("Item Atualizado!");

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
                catch (MySqlException ex)
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
                canudo = new CanudoVO();
                material = new MaterialVO();
                tipoMaterial = new TipoMaterialVO();

                try
                {
                    if (txtCor.Text == string.Empty || txtQuantidade.Text == string.Empty || txtValor.Text == string.Empty)
                    {
                        throw new ArgumentNullException();
                    }

                    string cor = txtCor.Text;
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    long idTipoMaterial;
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbCanudo.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbCanudo.ImageLocation, FileMode.Open, FileAccess.Read))
                        using (BinaryReader breader = new BinaryReader(fstream))
                        {
                            foto = breader.ReadBytes((int)fstream.Length);
                        }
                    }
                    else
                    {
                        foto = null;
                    }


                    if (quantidade <= 0) { throw new ArgumentException("A quantidade não deve ser negativa"); }

                    if (valor <= 0) { throw new ArgumentException("O valor não deve ser negativo!"); }

                    canudo.Cor = cor;
                    canudo.Quantidade = quantidade;

                    material.Valor = valor;
                    material.Foto = foto;
                    material.Nome = nome_material + " " + cor + " " + quantidade + " Canudo(s)";

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    canudo.itemidproduto = idTipoMaterial;
                    material.IdTipoMaterial = idTipoMaterial;

                    material.Inserir();

                    canudo.Inserir();

                    MessageBox.Show("Item Cadastrado!");

                    novoClicado = false;

                    LimpaTextos();
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                novoClicado = true;

                if (dgvCanudoKrypton.Rows.Count != 0)
                {
                    dgvCanudoKrypton.CurrentCell.Selected = false;
                }

                LimpaTextos();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                btnLimpar.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

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

                dv.RowFilter = String.Format("espessura LIKE '%{0}%'", palavra);

                dgvCanudoKrypton.DataSource = dv;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvCanudoKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbCanudo.Image = null;
            canudo = new CanudoVO();

            novoClicado = false;

            try
            {

                canudo.Cor = GetValorLinha("cor").ToString();
                canudo.Quantidade = Convert.ToInt32(GetValorLinha("quantidade"));


                txtQuantidade.Text = canudo.Quantidade.ToString();
                txtCor.Text = canudo.Cor;
                txtValor.Text = GetValorLinha("valor").ToString();

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbCanudo.Image = imagem;
                }

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnLimpar.Enabled = true;

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Voltando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmCadastroOpcoes menuOpcoes = new frmCadastroOpcoes();
                menuOpcoes.Show();
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

        private void pbCanudo_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbCanudo.ImageLocation = localfoto;
            }
        }

    }
}
