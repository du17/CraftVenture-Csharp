using GerenciadorDeEstoque.DAO;
using MetroFramework;
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
    public partial class frmCadastroCanudo : Form
    {
        static String nome_material = "Canudo";
        CanudoVO canudo;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        DataTable dt = new DataTable();

        public frmCadastroCanudo()
        {
            InitializeComponent();
            //Inicializar();
        }

        /*private void Inicializar()
        {
            dt = DAO.DAO.GetCanudo();
            dgvPapelKrypton.DataSource = dt;
            ConfigurarGradeLivros();
        }*/

        private void ConfigurarGradeLivros()
        {
            dgvCanudoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvCanudoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvCanudoKrypton.RowHeadersWidth = 20;
            dgvCanudoKrypton.RowTemplate.Height = 40;

            dgvCanudoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvCanudoKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvCanudoKrypton.Columns["quantidade"].HeaderText = "Tipo";
            dgvCanudoKrypton.Columns[""].Width = 200;
            dgvCanudoKrypton.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCanudoKrypton.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCanudoKrypton.Columns["gramatura"].HeaderText = "Gramatura";
            dgvCanudoKrypton.Columns["gramatura"].Width = 130;
            dgvCanudoKrypton.Columns["gramatura"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvCanudoKrypton.Columns["cor"].HeaderText = "Cor";
            dgvCanudoKrypton.Columns["cor"].Width = 200;
            dgvCanudoKrypton.Columns["cor"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvCanudoKrypton.Columns["tamanho"].HeaderText = "Tamanho";
            dgvCanudoKrypton.Columns["tamanho"].Width = 120;
            dgvCanudoKrypton.Columns["tamanho"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCanudoKrypton.Columns["tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCanudoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvCanudoKrypton.Columns["valor"].Width = 100;
            dgvCanudoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCanudoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            txtValor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtCor.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            canudo = new CanudoVO();
            material = new MaterialVO();   
            tipoMaterial = new TipoMaterialVO();

            try
            {
                string cor = txtCor.Text;
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                long idTipoMaterial;

                canudo.Cor = cor;
                canudo.Quantidade = quantidade;

                material.Valor = valor;
                material.Nome = nome_material;

                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();

                idTipoMaterial = tipoMaterial.getLastId();

                canudo.itemidproduto = idTipoMaterial;
                material.IdMaterial = idTipoMaterial;

                material.Inserir();

                canudo.Inserir();

                MessageBox.Show("Item cadastrado!");

            }
            catch(ArgumentNullException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
