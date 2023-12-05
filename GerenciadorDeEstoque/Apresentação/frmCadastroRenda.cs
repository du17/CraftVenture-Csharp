using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastroRenda : Form
    {
        static String nome_material = "Renda";

        RendaVO renda;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        String palavra;

        public frmCadastroRenda()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetRenda();
            dgvRendaKrypton.DataSource = dt;
            ConfigurarGradeRenda();
        }

        private void ConfigurarGradeRenda()
        {
            dgvRendaKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvRendaKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvRendaKrypton.RowHeadersWidth = 20;
            dgvRendaKrypton.RowTemplate.Height = 40;

            dgvRendaKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvRendaKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvRendaKrypton.Columns["tamanho"].HeaderText = "Tamanho";
            dgvRendaKrypton.Columns["tamanho"].Width = 130;
            dgvRendaKrypton.Columns["tamanho"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvRendaKrypton.Columns["metragem"].HeaderText = "Metragem";
            dgvRendaKrypton.Columns["metragem"].Width = 100;
            dgvRendaKrypton.Columns["metragem"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvRendaKrypton.Columns["valor"].HeaderText = "Valor";
            dgvRendaKrypton.Columns["valor"].Width = 100;
            dgvRendaKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvRendaKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvRendaKrypton.Columns["foto"].Width = 70;
            dgvRendaKrypton.Columns["foto"].HeaderText = "Foto";
            if (dgvRendaKrypton.Columns["foto"] is DataGridViewImageColumn fotoColumn)
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

        private void LimpaTextos()
        {
            txtMetragem.Text = string.Empty;
            cbxTamanho.Text = "Inserir Tamanho";
            txtValor.Text = string.Empty;
            pbRenda.Image = null;
        }

        private object GetValorLinha(String campo)
        {
            return dgvRendaKrypton.Rows[dgvRendaKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            renda = new RendaVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: " + cbxTamanho.SelectedItem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    renda.idTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    renda.Remover();
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

                dv.RowFilter = String.Format("tamanho LIKE '%{0}%'", palavra);

                dgvRendaKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
        }

        private void dgvRendaKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbRenda.Image = null;
            renda = new RendaVO();
            material = new MaterialVO();

            novoClicado = false;

            try
            {

                renda.Metragem = Convert.ToDouble(GetValorLinha("metragem"));
                renda.Tamanho = GetValorLinha("tamanho").ToString();
                material.Valor = Convert.ToDouble(GetValorLinha("valor"));

                txtMetragem.Text = renda.Metragem.ToString();
                cbxTamanho.SelectedItem = renda.Tamanho.ToString();
                txtValor.Text = material.Valor.ToString();

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbRenda.Image = imagem;
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
                if (dgvRendaKrypton.Rows.Count != 0)
                {
                    dgvRendaKrypton.CurrentCell.Selected = false;
                }
               
                LimpaTextos();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                btnLimpar.Enabled = false;
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                renda = new RendaVO();


                try
                {
                    if (cbxTamanho.Text == "Inserir Tamanho" || txtMetragem.Text == string.Empty || txtValor.Text == string.Empty)
                    {
                        throw new ArgumentNullException();
                    }

                    String tamanho = cbxTamanho.Text;
                    double metragem = Convert.ToDouble(txtMetragem.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbRenda.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbRenda.ImageLocation, FileMode.Open, FileAccess.Read))
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

                    if (!(tamanho.Equals("P") || tamanho.Equals("N") || tamanho.Equals("G"))) { throw new ArgumentException("O tamanho não foi encontrado, utilize a lista"); }

                    if(metragem <= 0) { throw new ArgumentException("A metragem não deve ser negativa!"); }

                    if(valor <= 0) { throw new ArgumentException("O valor não deve ser negativo!"); }

                    renda.idTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    renda.Tamanho = tamanho;
                    renda.Metragem = metragem;

                    material.Nome = nome_material + " " + tamanho + " " + metragem + " m";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    renda.Atualizar();
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
                renda = new RendaVO();
                material = new MaterialVO();
                tipoMaterial = new TipoMaterialVO();

                long idTipoMaterial;

                try
                {
                    if (cbxTamanho.Text == "Inserir Tamanho" || txtMetragem.Text == string.Empty || txtValor.Text == string.Empty)
                    {
                        throw new ArgumentNullException();
                    }

                    String tamanho = cbxTamanho.Text.ToString();
                    Double metragem = Convert.ToDouble(txtMetragem.Text);
                    Double valor = Convert.ToDouble(txtValor.Text);
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbRenda.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbRenda.ImageLocation, FileMode.Open, FileAccess.Read))
                        using (BinaryReader breader = new BinaryReader(fstream))
                        {
                            foto = breader.ReadBytes((int)fstream.Length);
                        }
                    }
                    else
                    {
                        foto = null;
                    }

                    if (!(tamanho.Equals("P") || tamanho.Equals("N") || tamanho.Equals("G"))) { throw new ArgumentException("O tamanho não foi encontrado, utilize a lista"); }

                    if (metragem <= 0) { throw new ArgumentException("A metragem não deve ser negativa!"); }

                    if (valor <= 0) { throw new ArgumentException("O valor não deve ser negativo!"); }

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    material.IdTipoMaterial = idTipoMaterial;
                    material.Nome = nome_material + " " + tamanho + " " + metragem + " m";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.Inserir();

                    renda.idTipoMaterial = idTipoMaterial;
                    renda.Tamanho = tamanho;
                    renda.Metragem = metragem;
                    renda.Inserir();

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

        private void pbPapel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbRenda.ImageLocation = localfoto;
            }
        }
    }
}