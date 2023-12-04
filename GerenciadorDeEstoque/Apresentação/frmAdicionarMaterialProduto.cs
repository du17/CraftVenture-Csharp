using GerenciadorDeEstoque.DAO;
using Org.BouncyCastle.Tls.Crypto;
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
    public partial class frmAdicionarMaterialProduto : Form
    {
        MaterialProdutoVO materialProduto;
        DataTable dt = new DataTable();

        long idTipoMaterial;

        bool novaVenda = true;

        public frmAdicionarMaterialProduto(MaterialProdutoVO materialProduto)
        {
            InitializeComponent();
            Inicializar();

            this.materialProduto = materialProduto;
        }

        public frmAdicionarMaterialProduto(long idTipoMaterial, MaterialProdutoVO materialProduto)
        {
            InitializeComponent();
            
            this.materialProduto = materialProduto;

            this.idTipoMaterial = idTipoMaterial;

            novaVenda = false;

            InicializarChecked(this.idTipoMaterial);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetMaterial();
            dgvAdicionarProdutoKrypton.DataSource = dt;
            ConfigurarGradeMaterialProduto();

        }

        private void InicializarChecked(long idProduto)
        {
            dt = DAO.DAO.GetMaterial();
            Dictionary<String, List<long>> idProduto_Quantidade;
            List<long> idTipoMaterial;
            List<long> quantidade;

            idProduto_Quantidade = DAO.DAO.GetMaterialProdutoId(idProduto);

            if (idProduto_Quantidade != null)
            {


                idTipoMaterial = idProduto_Quantidade["idProduto"];
                quantidade = idProduto_Quantidade["quantidade"];

                int i = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (idTipoMaterial.Contains(Convert.ToInt64(row["idTipoMaterial"])))
                    {
                        row["escolha"] = true;
                        row["quantidade"] = quantidade[i];

                        i++;
                    }
                } 
            }
            dgvAdicionarProdutoKrypton.DataSource = dt;
            ConfigurarGradeMaterialProduto();
        }

        private void ConfigurarGradeMaterialProduto()
        {
            dgvAdicionarProdutoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvAdicionarProdutoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 12, FontStyle.Bold);
            dgvAdicionarProdutoKrypton.RowHeadersWidth = 20;
            dgvAdicionarProdutoKrypton.RowTemplate.Height = 40;
            
            dgvAdicionarProdutoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvAdicionarProdutoKrypton.Columns["idTipoMaterial"].Visible = true;
            dgvAdicionarProdutoKrypton.Columns["idTipoMaterial"].ReadOnly = true;

            dgvAdicionarProdutoKrypton.Columns["escolha"].HeaderText = "";
            dgvAdicionarProdutoKrypton.Columns["escolha"].Width = 50;
            dgvAdicionarProdutoKrypton.Columns["escolha"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["escolha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["escolha"].ReadOnly = false;
           
            dgvAdicionarProdutoKrypton.Columns["nome"].HeaderText = "Nome";
            dgvAdicionarProdutoKrypton.Columns["nome"].Width = 500;
            dgvAdicionarProdutoKrypton.Columns["nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["nome"].ReadOnly = true;

            dgvAdicionarProdutoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvAdicionarProdutoKrypton.Columns["valor"].Width = 100;
            dgvAdicionarProdutoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["valor"].ReadOnly = true;

            dgvAdicionarProdutoKrypton.Columns["quantidade"].HeaderText = "Quant.";
            dgvAdicionarProdutoKrypton.Columns["quantidade"].Width = 90;
            dgvAdicionarProdutoKrypton.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["quantidade"].ReadOnly = false;

            dgvAdicionarProdutoKrypton.Columns["foto"].HeaderText = "Foto";
            dgvAdicionarProdutoKrypton.Columns["foto"].Width = 100;
            dgvAdicionarProdutoKrypton.Columns["foto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["foto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAdicionarProdutoKrypton.Columns["foto"].ReadOnly = true;

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            List<Int64> idMaterial = new List<Int64>();
            List<Int32> quantidade = new List<Int32>();

            try
            {

                foreach (DataGridViewRow row in dgvAdicionarProdutoKrypton.Rows)
                {
                    if (row.Cells["escolha"].Value.ToString() == "True")
                    {
                        if (row.Cells["quantidade"].Value != DBNull.Value && Convert.ToInt32(row.Cells["quantidade"].Value) > 0)
                        {
                            idMaterial.Add(Convert.ToInt64(row.Cells["idTipoMaterial"].Value));
                            quantidade.Add(Convert.ToInt32(row.Cells["quantidade"].Value));
                        }
                        else
                        {
                            throw new ArgumentException("O produto " + row.Cells["nome"].Value + " está sem quantidade ou com uma quantidade negativo");
                        }
                    }
                }

                if (idMaterial.Count <= 0)
                {
                    throw new ArgumentNullException("Ao menos um item precisa compor um produto!");
                }
                materialProduto.IdMaterialLista = idMaterial;
                materialProduto.QuantidadeLista = quantidade;

                MessageBox.Show("Materiais adicionados ao produto com Sucesso");

                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Você não escolheu nenhum material que faz parte do produto");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "erro");
            }


        }

        private void dgvLivrosKrypton_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        String palavra;

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
                dv.RowFilter = String.Format("nome LIKE '%{0}%'", palavra);

                dgvAdicionarProdutoKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria de Voltar? (todas as informações não salvas serão perdidas)", "Voltar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (novaVenda) { this.Close(); }
                else
                {
                    List<Int64> idMaterial = new List<Int64>();
                    List<Int64> quantidadeErrado = new List<Int64>();
                    List<Int32> quantidade = new List<Int32>();

                    try
                    {

                        Dictionary<String, List<long>> idMaterial_Quantidade;

                        idMaterial_Quantidade = DAO.DAO.GetMaterialProdutoId(idTipoMaterial);

                        idMaterial = idMaterial_Quantidade["idProduto"];
                        quantidadeErrado = idMaterial_Quantidade["quantidade"];

                        foreach (Int64 l in quantidadeErrado)
                        {
                            quantidade.Add(Convert.ToInt32(l));
                        }

                        if (idMaterial.Count <= 0)
                        {
                            throw new ArgumentNullException("Ao menos um item precisa compor uma venda!");
                        }

                        materialProduto.IdMaterialLista = idMaterial;
                        materialProduto.QuantidadeLista = quantidade;


                        this.Close();
                    }
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show("Você não escolheu nenhum produto para vender!");
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "erro");
                    }
                }
            }
        }

        private void frmAdicionarMaterialProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (novaVenda) { this.Close(); }
            else
            {
                List<Int64> idMaterial = new List<Int64>();
                List<Int64> quantidadeErrado = new List<Int64>();
                List<Int32> quantidade = new List<Int32>();

                try
                {

                    Dictionary<String, List<long>> idMaterial_Quantidade;

                    idMaterial_Quantidade = DAO.DAO.GetMaterialProdutoId(idTipoMaterial);

                    idMaterial = idMaterial_Quantidade["idProduto"];
                    quantidadeErrado = idMaterial_Quantidade["quantidade"];

                    foreach (Int64 l in quantidadeErrado)
                    {
                        quantidade.Add(Convert.ToInt32(l));
                    }

                    if (idMaterial.Count <= 0)
                    {
                        throw new ArgumentNullException("Ao menos um item precisa compor uma venda!");
                    }

                    materialProduto.IdMaterialLista = idMaterial;
                    materialProduto.QuantidadeLista = quantidade;


                    this.Close();
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Você não escolheu nenhum produto para vender!");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "erro");
                }
            }
        }
    }
}
