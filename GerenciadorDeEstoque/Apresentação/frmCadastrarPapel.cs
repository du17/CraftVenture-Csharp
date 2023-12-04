using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastrarPapel : Form
    {
        static String nome_material = "Papel";
        PapelVO papel;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastrarPapel()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetPapel();
            dgvPapelKrypton.DataSource = dt;
            ConfigurarGradePapel();
        }

        private void ConfigurarGradePapel()
        {        
            dgvPapelKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvPapelKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvPapelKrypton.RowHeadersWidth = 20;
            dgvPapelKrypton.RowTemplate.Height = 40;
                    
            dgvPapelKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvPapelKrypton.Columns["idTipoMaterial"].Visible = true;
                    
            dgvPapelKrypton.Columns["tipo"].HeaderText = "Tipo";
            dgvPapelKrypton.Columns["tipo"].Width = 200;
            dgvPapelKrypton.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPapelKrypton.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    
            dgvPapelKrypton.Columns["gramatura"].HeaderText = "Gramatura";
            dgvPapelKrypton.Columns["gramatura"].Width = 130;
            dgvPapelKrypton.Columns["gramatura"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
                    
            dgvPapelKrypton.Columns["cor"].HeaderText = "Cor";
            dgvPapelKrypton.Columns["cor"].Width = 200;
            dgvPapelKrypton.Columns["cor"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
                    
            dgvPapelKrypton.Columns["tamanho"].HeaderText = "Tamanho";
            dgvPapelKrypton.Columns["tamanho"].Width = 120;
            dgvPapelKrypton.Columns["tamanho"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPapelKrypton.Columns["tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPapelKrypton.Columns["valor"].HeaderText = "Valor";
            dgvPapelKrypton.Columns["valor"].Width = 100;
            dgvPapelKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPapelKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrindo Menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            papel = new PapelVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: " + cbxTipo.SelectedItem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(dialog == DialogResult.Yes)
                {
                    papel.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    papel.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaTextos()
        {
            txtValor.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtGramatura.Text = string.Empty;
            cbxTamanho.Text = "Tamanho";
            cbxTipo.Text = "Inserir Tipo";
            pbPapel.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxTipo.Text == string.Empty || txtCor.Text == string.Empty || cbxTamanho.Text == "Tamanho" || txtGramatura.Text == string.Empty || txtValor.Text == string.Empty)
                {
                    throw new ArgumentNullException("Um ou mais campos estão vazios!");
                }
                String tipo = cbxTipo.Text;
                String cor = txtCor.Text;
                String tamanho = cbxTamanho.Text;
                int gramatura = Convert.ToInt32(txtGramatura.Text);
                double valor = Convert.ToDouble(txtValor.Text);

                if (!(tipo.Equals("Fotográfico") || tipo.Equals("Offset") || tipo.Equals("Colorplus") || tipo.Equals("Fosco") || tipo.Equals("Pólen"))) { throw new ArgumentException("O tipo não foi encontrado, utilize a lista!"); }

                if (!(tamanho.Equals("A0") || tamanho.Equals("A1") || tamanho.Equals("A2") || tamanho.Equals("A3") || tamanho.Equals("A4") || tamanho.Equals("A5") || tamanho.Equals("A6") || tamanho.Equals("A7") || tamanho.Equals("A8") || tamanho.Equals("A9") || tamanho.Equals("A10"))) { throw new ArgumentException("O tamanho não foi encontrado, utilize as lista!"); }

                if (gramatura <= 0) { throw new ArgumentException("A gramatura não pode ser menor que zero!"); }

                if (valor <= 0) { throw new ArgumentException("O valor não pode ser negativo!"); }

                papel = new PapelVO();
                material = new MaterialVO();

                if (!novoClicado)
                {
                    try
                    {
                        papel.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                        papel.Tipo = tipo;
                        papel.Gramatura = gramatura;
                        papel.Cor = cor;
                        papel.Tamanho = tamanho;
                        papel.Valor = valor;

                        material.Nome = nome_material + " " + tipo + " " + cor + " " + tamanho + " " + gramatura.ToString();
                        material.Valor = valor;
                        material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                        papel.Atualizar();
                        material.Atualizar();

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
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Este material já existe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {                    
                    tipoMaterial = new TipoMaterialVO();

                    long idTipoMaterial;

                    try
                    {

                        papel.Tipo = tipo;
                        papel.Cor = cor;
                        papel.Tamanho = tamanho;
                        papel.Gramatura = gramatura;

                        tipoMaterial.Nome = nome_material;
                        tipoMaterial.Inserir();

                        idTipoMaterial = tipoMaterial.getLastId();

                        material.Nome = nome_material + " " + tipo + " " + cor + " " + tamanho + " " + gramatura.ToString();
                        material.Valor = valor;
                        material.IdTipoMaterial = idTipoMaterial;
                        material.Inserir();

                        papel.itemidTipoMaterial = idTipoMaterial;

                        papel.Inserir();

                        MessageBox.Show("Item Cadastrado!");

                        LimpaTextos();
                        Inicializar();

                        novoClicado = false;

                    }
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show("Algum dos campos está vazio!");
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Este material já existe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ");
                    }
                }
            }
            catch(ArgumentException ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPapelFoto_Click(object sender, EventArgs e)
        {
            
        }

        private void pbPapel_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbPapel.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private object GetValorLinha(String campo)
        {
            return dgvPapelKrypton.Rows[dgvPapelKrypton.CurrentCell.RowIndex].Cells[campo].Value;
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

                dv.RowFilter = String.Format("tipo LIKE '%{0}%' OR cor LIKE '%{0}%'", palavra);

                dgvPapelKrypton.DataSource = dv;

            }
            catch (Exception ex) { }

        }

        private void dgvPapelKrypton_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPapelKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            papel = new PapelVO();

            novoClicado = false;

            try
            {

                papel.Tipo = GetValorLinha("tipo").ToString();
                papel.Gramatura = Convert.ToInt32(GetValorLinha("gramatura"));
                papel.Cor = GetValorLinha("cor").ToString();
                papel.Tamanho = GetValorLinha("tamanho").ToString();


                cbxTipo.SelectedItem = papel.Tipo;
                txtGramatura.Text = papel.Gramatura.ToString();
                txtCor.Text = papel.Cor;
                cbxTamanho.SelectedItem = papel.Tamanho;
                txtValor.Text = GetValorLinha("valor").ToString();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnApagar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvPapelKrypton.Rows.Count != 0)
                {
                    dgvPapelKrypton.CurrentCell.Selected = false;
                }

                novoClicado = true;
                LimpaTextos();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


                btnApagar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Voltando", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmCadastroOpcoes menuOpcoes = new frmCadastroOpcoes();
                menuOpcoes.Show();
                this.Close();
            }
        }
    }
}
