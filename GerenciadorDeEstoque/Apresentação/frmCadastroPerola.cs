
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
    public partial class frmCadastroPerola : Form
    {
        static String nome_material = "Pérola";
        PerolaVO perola;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;
        String palavra;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroPerola()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetPerola();
            dgvPerolaKrypton.DataSource = dt;
            ConfigurarGradeFitas();
        }

        private void ConfigurarGradeFitas()
        {
            dgvPerolaKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvPerolaKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvPerolaKrypton.RowHeadersWidth = 20;
            dgvPerolaKrypton.RowTemplate.Height = 40;

            dgvPerolaKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvPerolaKrypton.Columns["idTipoMaterial"].Visible = true;
            dgvPerolaKrypton.Columns["idTipoMaterial"].Width = 80;

            dgvPerolaKrypton.Columns["tamanho"].HeaderText = "Tamanho";
            dgvPerolaKrypton.Columns["tamanho"].Width = 130;
            dgvPerolaKrypton.Columns["tamanho"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvPerolaKrypton.Columns["cor"].HeaderText = "Cor";
            dgvPerolaKrypton.Columns["cor"].Width = 200;
            dgvPerolaKrypton.Columns["cor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerolaKrypton.Columns["cor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPerolaKrypton.Columns["valor"].HeaderText = "Valor";
            dgvPerolaKrypton.Columns["valor"].Width = 100;
            dgvPerolaKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPerolaKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPerolaKrypton.Columns["foto"].Width = 70;
            dgvPerolaKrypton.Columns["foto"].HeaderText = "Foto";
            if (dgvPerolaKrypton.Columns["foto"] is DataGridViewImageColumn fotoColumn)
            {
                fotoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
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

        private object GetValorLinha(String campo)
        {
            return dgvPerolaKrypton.Rows[dgvPerolaKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                perola = new PerolaVO();
                material = new MaterialVO();

                try
                {
                    if (txtCor.Text == String.Empty || txtTamanho.Text == String.Empty || txtValor.Text == String.Empty)
                    {
                        throw new ArgumentNullException("Um ou mais campos estão sem dados, por favor preencha-os");
                    }

                    double tamanho = Convert.ToDouble(txtTamanho.Text);;
                    String cor = txtCor.Text;
                    double valor = Convert.ToDouble(txtValor.Text);
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbPerola.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbPerola.ImageLocation, FileMode.Open, FileAccess.Read))
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
                    if (tamanho <= 0) { throw new ArgumentException("O tamanho não deve ser negativo!"); }

                    if(valor <= 0) { throw new ArgumentException("O valor não deve ser negativo"); }

                    perola.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    perola.Tamanho = tamanho;
                    perola.Cor = cor;
                    perola.Valor = valor;

                    material.Nome = nome_material + " " + cor + " " + tamanho + " cm";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    perola.Atualizar();
                    material.Atualizar();

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
                perola = new PerolaVO();
                tipoMaterial = new TipoMaterialVO();
                material = new MaterialVO();

                long idTipoMaterial;

                try
                {
                    if (txtCor.Text == String.Empty || txtTamanho.Text == String.Empty || txtValor.Text == String.Empty)
                    {
                        throw new ArgumentNullException("Um ou mais campos estão sem dados, por favor preencha-os");
                    }

                    String cor = txtCor.Text;
                    Double tamanho = Convert.ToDouble(txtTamanho.Text);
                    Double valor = Convert.ToDouble(txtValor.Text);
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbPerola.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbPerola.ImageLocation, FileMode.Open, FileAccess.Read))
                        using (BinaryReader breader = new BinaryReader(fstream))
                        {
                            foto = breader.ReadBytes((int)fstream.Length);
                        }
                    }
                    else
                    {
                        foto = null;
                    }

                    if (tamanho <= 0) { throw new ArgumentException("O tamanho não deve ser negativo!"); }

                    if (valor <= 0) { throw new ArgumentException("O valor não deve ser negativo"); }

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    material.IdTipoMaterial = idTipoMaterial;
                    material.Nome = nome_material + " " + cor + " " + tamanho + " cm";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.Inserir();

                    perola.itemidTipoMaterial = idTipoMaterial;
                    perola.Cor = cor;
                    perola.Tamanho = tamanho;
                    perola.Inserir();

                    MessageBox.Show("Item Cadastrado!");

                    novoClicado = false;

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

        private void LimpaTextos()
        {
            txtCor.Text = string.Empty;
            txtTamanho.Text = string.Empty;
            txtValor.Text = string.Empty;
            pbPerola.Image = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            perola = new PerolaVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    perola.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    perola.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                else if (palavra.Length != 0)
                {
                    palavra = palavra.Remove(palavra.Length - 1);

                    dv.RowFilter = String.Format("espessura LIKE '%{0}%'", palavra);

                }

                dgvPerolaKrypton.DataSource = dv;

                dv.RowFilter = String.Format("cor LIKE '%{0}%'", palavra);

                dgvPerolaKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
        }

        private void dgvPerolaKrypton_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPerolaKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbPerola.Image = null;
            perola = new PerolaVO();
            novoClicado = false;

            try
            {

                perola.Tamanho = Convert.ToDouble(GetValorLinha("tamanho"));
                perola.Cor = GetValorLinha("cor").ToString();
                perola.Valor = Convert.ToDouble(GetValorLinha("valor"));

                txtCor.Text = perola.Cor.ToString();
                txtTamanho.Text = perola.Tamanho.ToString();
                txtValor.Text = perola.Valor.ToString();

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbPerola.Image = imagem;
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
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            novoClicado = true;

            try
            {
                if (dgvPerolaKrypton.Rows.Count == 0)
                {
                    LimpaTextos();

                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;

                    btnLimpar.Enabled = false;
                }
                else
                {
                    
                    dgvPerolaKrypton.CurrentCell.Selected = false;
                    LimpaTextos();


                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                    btnLimpar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void pbPerola_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbPerola.ImageLocation = localfoto;
            }
        }
    }
}
