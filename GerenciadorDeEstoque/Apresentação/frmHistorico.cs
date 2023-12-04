using GerenciadorDeEstoque.Apresentação.Menu;
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
    public partial class frmHistorico : Form
    {
        DataTable dt = new DataTable();

        public frmHistorico()
        {
            InitializeComponent();
            Inicializar();

            btnHistorico.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetVenda();
            dgvHistoricoKrypton.DataSource = dt;

            ConfigurarGradeClientes();
        }

        private void ConfigurarGradeClientes()
        {
            dgvHistoricoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12, FontStyle.Bold);
            dgvHistoricoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 10, FontStyle.Bold);
            dgvHistoricoKrypton.RowHeadersWidth = 20;
            dgvHistoricoKrypton.RowTemplate.Height = 40;

            dgvHistoricoKrypton.Columns["id"].HeaderText = "ID";
            dgvHistoricoKrypton.Columns["id"].Visible = true;
            dgvHistoricoKrypton.Columns["id"].Width = 50;
            dgvHistoricoKrypton.Columns["id"].DisplayIndex = 0;

            dgvHistoricoKrypton.Columns["nome"].HeaderText = "Nome do cliente";
            dgvHistoricoKrypton.Columns["nome"].Width = 200;
            dgvHistoricoKrypton.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistoricoKrypton.Columns["nome"].DisplayIndex = 1;

            dgvHistoricoKrypton.Columns["dataVenda"].HeaderText = "Data de Venda";
            dgvHistoricoKrypton.Columns["dataVenda"].Width = 120;
            dgvHistoricoKrypton.Columns["dataVenda"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["dataVenda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["dataVenda"].DisplayIndex = 2;

            dgvHistoricoKrypton.Columns["dataEntrega"].HeaderText = "Data de Entrega";
            dgvHistoricoKrypton.Columns["dataEntrega"].Width = 120;
            dgvHistoricoKrypton.Columns["dataEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["dataEntrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["dataEntrega"].DisplayIndex = 3;

            dgvHistoricoKrypton.Columns["formaPagamento"].HeaderText = "Forma de Pagamento";
            dgvHistoricoKrypton.Columns["formaPagamento"].Width = 120;
            dgvHistoricoKrypton.Columns["formaPagamento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistoricoKrypton.Columns["formaPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHistoricoKrypton.Columns["formaPagamento"].DisplayIndex = 4;

            dgvHistoricoKrypton.Columns["formaEntrega"].HeaderText = "Forma de Entrega";
            dgvHistoricoKrypton.Columns["formaEntrega"].Width = 120;
            dgvHistoricoKrypton.Columns["formaEntrega"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["formaEntrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["formaEntrega"].DisplayIndex = 5;

            dgvHistoricoKrypton.Columns["valorTotal"].HeaderText = "Valor Total";
            dgvHistoricoKrypton.Columns["valorTotal"].Width = 90;
            dgvHistoricoKrypton.Columns["valorTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["valorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHistoricoKrypton.Columns["valorTotal"].DisplayIndex = 6;

            dgvHistoricoKrypton.Columns["anotacao"].HeaderText = "Anotação";
            dgvHistoricoKrypton.Columns["anotacao"].Visible = true;
            dgvHistoricoKrypton.Columns["anotacao"].DisplayIndex = 7;

            dgvHistoricoKrypton.Columns["idUsuario"].HeaderText = "idUsuario";
            dgvHistoricoKrypton.Columns["idUsuario"].Visible = false;

            dgvHistoricoKrypton.Columns["codigoCliente"].HeaderText = "codigoCliente";
            dgvHistoricoKrypton.Columns["codigoCliente"].Visible = false;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuCadastro menuCadastro = new frmMenuCadastro();
            menuCadastro.Show();
            this.Close();
        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltroPorMes();
        }

        private void FiltroPorMes()
        {
            String tipoData;

            if (rdDataVenda.Checked == true) { tipoData = "DataVenda"; }
            else { tipoData = "dataEntrega"; }

            String mes = "01";

            switch (cbxFiltroMes.SelectedIndex)
            {
                case 0:
                    mes = "00";
                    break;
                case 1:
                    mes = "01";
                    break;
                case 2:
                    mes = "02";
                    break;
                case 3:
                    mes = "03";
                    break;
                case 4:
                    mes = "04";
                    break;
                case 5:
                    mes = "05";
                    break;
                case 6:
                    mes = "06";
                    break;
                case 7:
                    mes = "07";
                    break;
                case 8:
                    mes = "08";
                    break;
                case 9:
                    mes = "09";
                    break;
                case 10:
                    mes = "10";
                    break;

                case 11:
                    mes = "11";
                    break;
                case 12:
                    mes = "12";
                    break;
            }
            if (mes == "00" || cbxFiltroMes.Text == "Filtra Por Mês")
            {
                dt = DAO.DAO.GetVenda();
            }
            else { dt = DAO.DAO.GetHistoricoMes(mes, tipoData); }
            

            dgvHistoricoKrypton.DataSource = dt;
        }

        private void rdDateEntrega_CheckedChanged(object sender, EventArgs e)
        {
            FiltroPorMes();
        }

        private void rdDataVenda_CheckedChanged(object sender, EventArgs e)
        {
            FiltroPorMes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            String tipoData;

            if (rdDataVenda.Checked == true) { tipoData = "DataVenda"; }
            else { tipoData = "dataEntrega"; }

            String dataMinima = dtpDataMinima.Value.ToString("yyyy-MM-dd");
            String dataMaxima = dtpDataMaxima.Value.ToString("yyyy-MM-dd");

            dt = DAO.DAO.GetHistoricoMes(dataMinima, tipoData, false, dataMaxima);

            dgvHistoricoKrypton.DataSource = dt;

            Inicializar();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmMenuCadastro menuCadastro = new frmMenuCadastro();
            menuCadastro.Show();
            this.Close();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda();
            frmVenda.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair?", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
