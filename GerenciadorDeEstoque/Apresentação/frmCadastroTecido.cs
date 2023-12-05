using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastroTecido : Form
    {
        static String nome_material = "Tecido";

        TecidoVO tecido;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        String palavra;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroTecido()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetTecido();
            dgvTecidoKrypton.DataSource = dt;
            ConfigurarGradeTecido();
        }

        private void ConfigurarGradeTecido()
        {
            dgvTecidoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 18, FontStyle.Bold);
            dgvTecidoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvTecidoKrypton.RowHeadersWidth = 20;
            dgvTecidoKrypton.RowTemplate.Height = 40;

            dgvTecidoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvTecidoKrypton.Columns["idTipoMaterial"].Visible = true;
            dgvTecidoKrypton.Columns["idTipoMaterial"].Width = 100;

            dgvTecidoKrypton.Columns["tipo"].HeaderText = "Tipo";
            dgvTecidoKrypton.Columns["tipo"].Width = 200;
            dgvTecidoKrypton.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTecidoKrypton.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTecidoKrypton.Columns["tipoEstampa"].HeaderText = "TipoEstampa";
            dgvTecidoKrypton.Columns["tipoEstampa"].Width = 150;
            dgvTecidoKrypton.Columns["tipoEstampa"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
           
            dgvTecidoKrypton.Columns["metragemComprimento"].HeaderText = "Comprimento";
            dgvTecidoKrypton.Columns["metragemComprimento"].Width = 160;
            dgvTecidoKrypton.Columns["metragemComprimento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTecidoKrypton.Columns["metragemComprimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvTecidoKrypton.Columns["metragemAltura"].HeaderText = "Altura";
            dgvTecidoKrypton.Columns["metragemAltura"].Width = 80;
            dgvTecidoKrypton.Columns["metragemAltura"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTecidoKrypton.Columns["metragemAltura"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTecidoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvTecidoKrypton.Columns["valor"].Width = 200;
            dgvTecidoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTecidoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvTecidoKrypton.Columns["foto"].Width = 70;
            dgvTecidoKrypton.Columns["foto"].HeaderText = "Foto";
            if (dgvTecidoKrypton.Columns["foto"] is DataGridViewImageColumn fotoColumn)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                tecido = new TecidoVO();
                material = new MaterialVO();

                try
                {
                    if (cbxTipo.Text == "Inserir Tipo" || txtMetragemAltura.Text == string.Empty || txtMetragemComprimento.Text == string.Empty || txtValor.Text == string.Empty)
                    {
                        throw new ArgumentNullException();
                    }

                    String tipo = cbxTipo.Text;
                    double metragemAltura = Convert.ToDouble(txtMetragemAltura.Text);
                    double metragemComprimento = Convert.ToDouble(txtMetragemComprimento.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    String tipoEstampa;
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbTecido.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbTecido.ImageLocation, FileMode.Open, FileAccess.Read))
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

                    if (rdEstampado.Checked == true)
                    {
                        tipoEstampa = "Estampado";

                    }
                    else if (rdLiso.Checked == true)
                    {
                        tipoEstampa = "Liso";
                    }
                    else
                    {
                        tipoEstampa = "Sem Tipo";
                    }

                    if (!(tipo.Equals("Atoalhado") || tipo.Equals("Tule") || tipo.Equals("Fralda") || tipo.Equals("Tricoline") || tipo.Equals("Feltro"))) { throw new ArgumentException("O tipo de tecido não foi encontrado, utilize a lista"); }

                    if (metragemAltura <= 0) { throw new ArgumentException("A altura não deve ser negativa"); }

                    if (metragemComprimento <= 0) { throw new ArgumentException("O comprimento não deve ser negativa"); }

                    if (valor <= 0) { throw new ArgumentException("O valor não deve ser negativo!"); }

                    tecido.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    tecido.Tipo = tipo;
                    tecido.MetragemComprimento = metragemComprimento;
                    tecido.MetragemAltura = metragemAltura;
                    tecido.TipoEstampa = tipoEstampa;

                    material.Nome = nome_material + " " + tipo + " " + tipoEstampa + " " + (metragemAltura * metragemComprimento).ToString() + " cm";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    material.Atualizar();
                    tecido.Atualizar();

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
                tecido = new TecidoVO();
                material = new MaterialVO();
                tipoMaterial = new TipoMaterialVO();

                long idTipoMaterial;

                try
                {

                    if (cbxTipo.Text == "Inserir Tipo" || txtMetragemAltura.Text == string.Empty || txtMetragemComprimento.Text == string.Empty || txtValor.Text == string.Empty)
                    {
                        throw new ArgumentNullException();
                    }
                    String tipo = cbxTipo.Text;
                    double metragemAltura = Convert.ToDouble(txtMetragemAltura.Text);
                    double metragemComprimento = Convert.ToDouble(txtMetragemComprimento.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    String tipoEstampa;
                    byte[] foto = null;

                    if (!string.IsNullOrEmpty(pbTecido.ImageLocation))
                    {
                        using (FileStream fstream = new FileStream(this.pbTecido.ImageLocation, FileMode.Open, FileAccess.Read))
                        using (BinaryReader breader = new BinaryReader(fstream))
                        {
                            foto = breader.ReadBytes((int)fstream.Length);
                        }
                    }
                    else
                    {
                        foto = null;
                    }

                    if (rdEstampado.Checked == true)
                    {
                        tipoEstampa = "Estampado";

                    }
                    else if (rdLiso.Checked == true)
                    {
                        tipoEstampa = "Liso";
                    }
                    else
                    {
                        tipoEstampa = "Sem Tipo";
                    }

                    if(!(tipo.Equals("Atoalhado") || tipo.Equals("Tule") || tipo.Equals("Fralda") || tipo.Equals("Tricoline") || tipo.Equals("Feltro"))) { throw new ArgumentException("O tipo de tecido não foi encontrado, utilize a lista"); }

                    if (metragemAltura <= 0) { throw new ArgumentException("A altura não deve ser negativa"); }

                    if (metragemComprimento <= 0) { throw new ArgumentException("O comprimento não deve ser negativa"); }
    
                    if(valor <= 0) { throw new ArgumentException("O valor não deve ser negativo!"); }

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    material.IdTipoMaterial = idTipoMaterial;
                    material.Nome = nome_material + " " + tipo + " " + tipoEstampa + " " + (metragemAltura * metragemComprimento).ToString() + " cm";
                    material.Valor = valor;
                    material.Foto = foto;
                    material.Inserir();

                    tecido.itemidTipoMaterial = idTipoMaterial;
                    tecido.Tipo = tipo;
                    tecido.TipoEstampa = tipoEstampa;
                    tecido.MetragemAltura = metragemAltura;
                    tecido.MetragemComprimento = metragemComprimento;


                    tecido.Inserir();

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

        private object GetValorLinha(String campo)
        {
            return dgvTecidoKrypton.Rows[dgvTecidoKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void LimpaTextos()
        {
            txtMetragemAltura.Text = string.Empty;
            txtMetragemComprimento.Text = string.Empty;
            cbxTipo.Text = "Inserir Tipo";
            txtValor.Text = string.Empty;
            pbTecido.Image = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tecido = new TecidoVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: " + cbxTipo.SelectedItem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    tecido.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    tecido.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTecidoKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbTecido.Image = null;
            tecido = new TecidoVO();
            novoClicado = false;

            try
            {
                tecido.Tipo = GetValorLinha("tipo").ToString();
                String tipoEstampa;

                if (GetValorLinha("tipoEstampa").ToString() == "Estampado")
                {
                    tipoEstampa = "Estampado";
                    rdEstampado.Checked = true;

                }
                else if (GetValorLinha("tipoEstampa").ToString() == "Liso")
                {
                    tipoEstampa = "Liso";
                    rdLiso.Checked = true;
                }
                else
                {
                    tipoEstampa = "Sem Tipo";
                }

                tecido.TipoEstampa = tipoEstampa;
                tecido.MetragemComprimento = Convert.ToDouble(GetValorLinha("metragemComprimento")); ;
                tecido.MetragemAltura = Convert.ToDouble(GetValorLinha("metragemAltura")); 

                cbxTipo.SelectedItem = tecido.Tipo;
                txtMetragemAltura.Text = tecido.MetragemAltura.ToString();
                txtMetragemComprimento.Text = tecido.MetragemComprimento.ToString();
                txtValor.Text = GetValorLinha("valor").ToString();

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbTecido.Image = imagem;
                }

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnLimpar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (dgvTecidoKrypton.Rows.Count != 0)
                {
                    dgvTecidoKrypton.CurrentCell.Selected = false;
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
                frmVenda frmVenda = new frmVenda();
                frmVenda.Show();
                this.Close();
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

                dv.RowFilter = String.Format("tipo LIKE '%{0}%' OR tipoEstampa LIKE '%{0}%'", palavra);

                dgvTecidoKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
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

        private void pbTecido_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbTecido.ImageLocation = localfoto;
            }
        }
    }
}
