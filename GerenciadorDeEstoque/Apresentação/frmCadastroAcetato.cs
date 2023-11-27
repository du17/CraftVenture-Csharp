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

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroAcetato()
        {
            InitializeComponent();
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetPapel();
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
            
            dgvAcetatoKrypton.Columns["tamanho"].HeaderText = "Tamanho";
            dgvAcetatoKrypton.Columns["tamanho"].Width = 120;
            dgvAcetatoKrypton.Columns["tamanho"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAcetatoKrypton.Columns["tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvAcetatoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvAcetatoKrypton.Columns["valor"].Width = 100;
            dgvAcetatoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAcetatoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            zerarCampos();
        }

        private void zerarCampos()
        {
            txtEspessura.Text = string.Empty;
            txtMetragemAltura.Text = string.Empty;
            txtMetragemComprimento.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*

            if (!novoClicado)
            {
                acetato = new AcetatoVO();


                try
                {
                    String tipo = cbxTipo.Text;
                    String cor = txtCor.Text;
                    String tamanho = cbxTamanho.Text;
                    int gramatura = Convert.ToInt32(txtGramatura.Text);
                    double valor = Convert.ToDouble(txtValor.Text);

                    papel.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    papel.Tipo = tipo;
                    papel.Gramatura = gramatura;
                    papel.Cor = cor;
                    papel.Tamanho = tamanho;
                    papel.Valor = valor;

                    papel.Atualizar();

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
                acetato = new AcetatoVO();
                tipoMaterial = new TipoMaterialVO();
                material = new MaterialVO();

                try
                {
                    double espessura = Convert.ToDouble(txtEspessura.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    double metragemAltura = Convert.ToDouble(txtMetragemAltura.Text);
                    double metragemComprimento = Convert.ToDouble(txtMetragemComprimento.Text);
                    
                    long idTipoMaterial;

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();
                    idTipoMaterial = tipoMaterial.getLastId();

                    acetato.Espessura = espessura;
                    acetato.Tamanho = metragemAltura;

                    material.Nome = nome_material;
                    material.Valor = valor;

                    material.IdMaterial = idTipoMaterial;
                    acetato.itemidTipoMaterial = idTipoMaterial;

                    material.Inserir();

                    acetato.Inserir();

                    MessageBox.Show("Item cadastrado!");

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
            
            }*/
        }
    }
}
