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
            if (!novoClicado)
            {
                acetato = new AcetatoVO();


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



                    acetato.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    acetato.Espessura = espessura;
                    acetato.MetragemAltura = metragemAltura;
                    acetato.MetragemComprimento = metragemComprimento;
                    acetato.Valor = valor;

                    acetato.Atualizar();
                    
                    MessageBox.Show("Item Atualizado!");

                    Inicializar();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Algum campo está vazio!");
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
                acetato = new AcetatoVO();
                tipoMaterial = new TipoMaterialVO();
                material = new MaterialVO();

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
                    
                    long idTipoMaterial;

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    acetato.Espessura = espessura;
                    acetato.MetragemAltura = metragemAltura;
                    acetato.MetragemComprimento = metragemComprimento;

                    material.Nome = nome_material + " " + espessura + " Micra " + metragemAltura + " X " + metragemComprimento;
                    material.Valor = valor;

                    material.IdTipoMaterial = idTipoMaterial;
                    acetato.itemidTipoMaterial = idTipoMaterial;

                    material.Inserir();

                    acetato.Inserir();

                    novoClicado = false;

                    Inicializar();

                    MessageBox.Show("Item cadastrado!");

                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Algum campo está vazio!");
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

        private void dgvAcetatoKrypton_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            

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
    }
}
