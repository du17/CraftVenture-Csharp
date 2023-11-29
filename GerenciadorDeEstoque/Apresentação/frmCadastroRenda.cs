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
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetFita();
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
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private object GetValorLinha(String campo)
        {
            return dgvRendaKrypton.Rows[dgvRendaKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                renda = new RendaVO();


                try
                {
                    String tamanho = cbxTamanho.Text;
                    double metragem = Convert.ToDouble(txtMetragem.Text);
                    double valor = Convert.ToDouble(txtValor.Text);

                    renda.idTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    renda.Tamanho = tamanho;
                    renda.Metragem = metragem;
                    material.Valor = valor;

                    renda.Atualizar();

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
                renda = new RendaVO();
                material = new MaterialVO();
                tipoMaterial = new TipoMaterialVO();

                long idTipoMaterial;

                try
                {

                    String tamanho = cbxTamanho.Text.ToString();
                    Double metragem = Convert.ToDouble(txtMetragem.Text);
                    Double valor = Convert.ToDouble(txtValor.Text);

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    material.IdMaterial = idTipoMaterial;
                    material.Nome = nome_material;
                    material.Valor = valor;
                    material.Inserir();

                    renda.idTipoMaterial = idTipoMaterial;
                    renda.Tamanho = tamanho;
                    renda.Metragem = metragem;
                    MessageBox.Show("Acontece");
                    renda.Inserir();

                    MessageBox.Show("Item Cadastrado!");

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { novoClicado = false; }
            }
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
                DataTable dt = new DataTable();
                if (e.KeyChar != '\b')
                {
                    palavra += e.KeyChar;

                    dt = DAO.DAO.GetRenda();

                    dgvRendaKrypton.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRendaKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            renda = new RendaVO();

            novoClicado = false;

            try
            {

                renda.Metragem = Convert.ToDouble(GetValorLinha("metragem"));
                renda.Tamanho = GetValorLinha("tamanho").ToString();
                material.Valor = Convert.ToDouble(GetValorLinha("valor"));

                txtMetragem.Text = renda.Metragem.ToString();
                cbxTamanho.SelectedItem = renda.Tamanho.ToString();
                txtValor.Text = material.Valor.ToString();

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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            novoClicado = true;
            dgvRendaKrypton.CurrentCell.Selected = false;
            LimpaTextos();

            btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
            btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
            btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


            btnLimpar.Enabled = false;
        }
    }
}