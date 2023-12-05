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
    public partial class frmCadastroAcetato : Form
    {

        static String nome_material = "Acetato";
        AcetatoVO acetato;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;
        String palavra;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroAcetato()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetAcetado();
            dgvAcetatoKrypton.DataSource = dt;
            ConfigurarGradeLivros();
        }

        private void ConfigurarGradeLivros()
        {
            dgvAcetatoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvAcetatoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvAcetatoKrypton.RowHeadersWidth = 20;
            dgvAcetatoKrypton.RowTemplate.Height = 40;

            dgvAcetatoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvAcetatoKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvAcetatoKrypton.Columns["espessura"].HeaderText = "Espessura";
            dgvAcetatoKrypton.Columns["espessura"].Width = 200;
            dgvAcetatoKrypton.Columns["espessura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAcetatoKrypton.Columns["espessura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvAcetatoKrypton.Columns["metragemComprimento"].HeaderText = "Comprimento";
            dgvAcetatoKrypton.Columns["metragemComprimento"].Width = 160;
            dgvAcetatoKrypton.Columns["metragemComprimento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAcetatoKrypton.Columns["metragemComprimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAcetatoKrypton.Columns["metragemAltura"].HeaderText = "Altura";
            dgvAcetatoKrypton.Columns["metragemAltura"].Width = 120;
            dgvAcetatoKrypton.Columns["metragemAltura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAcetatoKrypton.Columns["metragemAltura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAcetatoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvAcetatoKrypton.Columns["valor"].Width = 120;
            dgvAcetatoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAcetatoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAcetatoKrypton.Columns["foto"].Width = 70;
            dgvAcetatoKrypton.Columns["foto"].HeaderText = "Foto";
            if (dgvAcetatoKrypton.Columns["foto"] is DataGridViewImageColumn fotoColumn)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            acetato = new AcetatoVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    acetato.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    acetato.Remover();
                    zerarCampos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zerarCampos()
        {
            txtEspessura.Text = string.Empty;
            txtMetragemAltura.Text = string.Empty;
            txtMetragemComprimento.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private object GetValorLinha(String campo)
        {
            return dgvAcetatoKrypton.Rows[dgvAcetatoKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEspessura.Text == string.Empty || txtValor.Text == string.Empty || txtMetragemAltura.Text == string.Empty || txtMetragemComprimento.Text == string.Empty)
                {
                    throw new ArgumentNullException();
                }

                double espessura = Convert.ToDouble(txtEspessura.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                double metragemAltura = Convert.ToDouble(txtMetragemAltura.Text);
                double metragemComprimento = Convert.ToDouble(txtMetragemComprimento.Text);
                byte[] foto = null;

                if (espessura <= 0) { throw new ArgumentException("A espessura não deve ser negativa!"); }

                if (valor <= 0) { throw new ArgumentException("O valor não deve ser negativo"); }

                if (metragemAltura <= 0) { throw new ArgumentException("A altura não deve ser negativa"); }

                if (metragemComprimento <= 0) { throw new ArgumentException("O comprimento não deve ser negativa"); }

                acetato = new AcetatoVO();
                material = new MaterialVO();

                if (!novoClicado)
                {
                    try
                    {
                        acetato.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                        acetato.Espessura = espessura;
                        acetato.MetragemAltura = metragemAltura;
                        acetato.MetragemComprimento = metragemComprimento;
                        acetato.Valor = valor;

                        material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                        material.Nome = nome_material + " " + espessura + " Micra " + metragemAltura + " X " + metragemComprimento;
                        material.Valor = valor;
                        material.Foto = foto;

                        if (!string.IsNullOrEmpty(pbAcetato.ImageLocation))
                        {
                            using (FileStream fstream = new FileStream(this.pbAcetato.ImageLocation, FileMode.Open, FileAccess.Read))
                            using (BinaryReader breader = new BinaryReader(fstream))
                            {
                                try
                                {
                                    foto = breader.ReadBytes((int)fstream.Length);
                                    material.Foto = foto;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());
                                }

                            }
                        }
                        else
                        {
                            foto = null;
                        }

                        material.Atualizar();
                        acetato.Atualizar();

                        MessageBox.Show("Item Atualizado!");

                        Inicializar();
                        pbAcetato.Dispose();
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
                    tipoMaterial = new TipoMaterialVO();

                    try
                    {
                        if (!string.IsNullOrEmpty(pbAcetato.ImageLocation))
                        {
                            using (FileStream fstream = new FileStream(this.pbAcetato.ImageLocation, FileMode.Open, FileAccess.Read))
                            using (BinaryReader breader = new BinaryReader(fstream))
                            {
                                foto = breader.ReadBytes((int)fstream.Length);
                            }
                        }
                        else
                        {
                            foto = null;
                        }

                        long idTipoMaterial;

                        tipoMaterial.Nome = nome_material;
                        tipoMaterial.Inserir();

                        idTipoMaterial = tipoMaterial.getLastId();

                        acetato.Espessura = espessura;
                        acetato.MetragemAltura = metragemAltura;
                        acetato.MetragemComprimento = metragemComprimento;

                        material.Nome = nome_material + " " + espessura + " Micra " + metragemAltura + " X " + metragemComprimento;
                        material.Valor = valor;
                        material.Foto = foto;

                        material.IdTipoMaterial = idTipoMaterial;
                        acetato.itemidTipoMaterial = idTipoMaterial;

                        material.Inserir();

                        acetato.Inserir();

                        novoClicado = false;

                        Inicializar();

                        MessageBox.Show("Item cadastrado!");

                        material.Foto = null;

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
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
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

                dgvAcetatoKrypton.DataSource = dv;

            }
            catch (Exception ex) { }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAcetatoKrypton.Rows.Count == 0)
                {
                    novoClicado = true;
                    zerarCampos();

                    btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                    btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                    btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                    btnLimpar.Enabled = false;
                }
                else
                {
                    novoClicado = true;
                    dgvAcetatoKrypton.CurrentCell.Selected = false;
                    zerarCampos();

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

        private void dgvAcetatoKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbAcetato.Image = null;
            acetato = new AcetatoVO();
            novoClicado = false;

            try
            {

                acetato.MetragemComprimento = Convert.ToDouble(GetValorLinha("metragemComprimento")); ;
                acetato.MetragemAltura = Convert.ToDouble(GetValorLinha("metragemAltura")); ;
                acetato.Espessura = Convert.ToDouble(GetValorLinha("espessura"));

                txtEspessura.Text = acetato.Espessura.ToString();
                txtMetragemAltura.Text = acetato.MetragemAltura.ToString();
                txtMetragemComprimento.Text = acetato.MetragemComprimento.ToString();
                txtValor.Text = GetValorLinha("valor").ToString();

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbAcetato.Image = imagem;
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

        private void pbAcetato_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbAcetato.ImageLocation = localfoto;
            }
        }
    }
}
