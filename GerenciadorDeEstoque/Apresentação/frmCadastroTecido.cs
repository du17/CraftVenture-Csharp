using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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

                    tecido.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    tecido.Tipo = tipo;
                    tecido.MetragemComprimento = metragemComprimento;
                    tecido.MetragemAltura = metragemAltura;
                    tecido.TipoEstampa = tipoEstampa;

                    material.Nome = nome_material + " " + tipo + " " + tipoEstampa + " " + (metragemAltura * metragemComprimento).ToString() + " cm";
                    material.Valor = valor;
                    material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    material.Atualizar();
                    tecido.Atualizar();

                    MessageBox.Show("Item Atualizado!");

                    Inicializar();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Algum dos campos está vazio!");
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

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    material.IdTipoMaterial = idTipoMaterial;
                    material.Nome = nome_material + " " + tipo + " " + tipoEstampa + " " + (metragemAltura * metragemComprimento).ToString() + " cm";
                    material.Valor = valor;
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
                    MessageBox.Show("Algum dos campos está vazio!");
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
    }
}
