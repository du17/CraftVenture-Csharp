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
            dgvTecidoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvTecidoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvTecidoKrypton.RowHeadersWidth = 20;
            dgvTecidoKrypton.RowTemplate.Height = 40;

            dgvTecidoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvTecidoKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvTecidoKrypton.Columns["tipo"].HeaderText = "Tipo";
            dgvTecidoKrypton.Columns["tipo"].Width = 200;
            dgvTecidoKrypton.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTecidoKrypton.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTecidoKrypton.Columns["tipoEstampa"].HeaderText = "TipoEstampa";
            dgvTecidoKrypton.Columns["tipoEstampa"].Width = 130;
            dgvTecidoKrypton.Columns["tipoEstampa"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvTecidoKrypton.Columns["metragem"].HeaderText = "Metragem";
            dgvTecidoKrypton.Columns["metragem"].Width = 100;
            dgvTecidoKrypton.Columns["metragem"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvTecidoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvTecidoKrypton.Columns["valor"].Width = 100;
            dgvTecidoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTecidoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                tecido = new TecidoVO();


                try
                {
                    String tipo = cbxTipo.Text;
                    double metragem = Convert.ToDouble(txtMetragemAltura.Text) * Convert.ToDouble(txtMetragemComprimento.Text);
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
                    tecido.Metragem = metragem;
                    tecido.TipoEstampa = tipoEstampa;
                    material.Valor = valor;

                    tecido.Atualizar();

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
                tecido = new TecidoVO();
                material = new MaterialVO();
                tipoMaterial = new TipoMaterialVO();

                long idTipoMaterial;

                try
                {
                    String tipo = cbxTipo.Text;
                    double metragem = Convert.ToDouble(txtMetragemAltura.Text) * Convert.ToDouble(txtMetragemComprimento.Text);
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

                    material.IdMaterial = idTipoMaterial;
                    material.Nome = nome_material;
                    material.Valor = valor;
                    material.Inserir();

                    tecido.itemidTipoMaterial = idTipoMaterial;
                    tecido.Tipo = tipo;
                    tecido.Metragem = metragem;
                    tecido.TipoEstampa = tipoEstampa;
                    tecido.Inserir();

                    MessageBox.Show("Item Cadastrado!");
                    LimpaTextos();
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
                finally { novoClicado = false; }
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
                tecido.Metragem = Convert.ToDouble(GetValorLinha("metragem"));
                tecido.TipoEstampa = GetValorLinha("tipoEstampa").ToString();
                material.Valor = Convert.ToDouble(GetValorLinha("valor"));
                /*String tipoEstampa;


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
                }*/

                txtMetragemAltura.Text = tecido.Metragem.ToString();
                txtMetragemComprimento.Text = tecido.Metragem.ToString();
                cbxTipo.SelectedItem = tecido.Tipo.ToString();
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
            dgvTecidoKrypton.CurrentCell.Selected = false;
            LimpaTextos();

            btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
            btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
            btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


            btnLimpar.Enabled = false;
        }
    }
}
