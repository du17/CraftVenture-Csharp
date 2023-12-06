
﻿using GerenciadorDeEstoque.Apresentação.Menu;
using GerenciadorDeEstoque.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastrarFita : Form
    {

        private static String nome_material = "Fita";
        FitaVO fita;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastrarFita()
        {
            InitializeComponent();
            Inicializar();

            btnCadastro.BackColor = Color.FromArgb(115, 217, 250);
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetFita();
            dgvFitaKrypton.DataSource = dt;
            ConfigurarGradeFitas();
        }

        private void ConfigurarGradeFitas()
        {
            dgvFitaKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvFitaKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvFitaKrypton.RowHeadersWidth = 20;
            dgvFitaKrypton.RowTemplate.Height = 40;
            
            dgvFitaKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvFitaKrypton.Columns["idTipoMaterial"].Visible = true;
            dgvFitaKrypton.Columns["idTipoMaterial"].Width = 100;
            
            dgvFitaKrypton.Columns["tipo"].HeaderText = "Tipo";
            dgvFitaKrypton.Columns["tipo"].Width = 200;
            dgvFitaKrypton.Columns["tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFitaKrypton.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvFitaKrypton.Columns["numero"].HeaderText = "Número";
            dgvFitaKrypton.Columns["numero"].Width = 130;
            dgvFitaKrypton.Columns["numero"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            
            dgvFitaKrypton.Columns["metragem"].HeaderText = "Metragem";
            dgvFitaKrypton.Columns["metragem"].Width = 100;
            dgvFitaKrypton.Columns["metragem"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            
            dgvFitaKrypton.Columns["marca"].HeaderText = "Marca";
            dgvFitaKrypton.Columns["marca"].Width = 120;
            dgvFitaKrypton.Columns["marca"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFitaKrypton.Columns["marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvFitaKrypton.Columns["numeroCor"].HeaderText = "Nº Cor";
            dgvFitaKrypton.Columns["numeroCor"].Width = 120;
            dgvFitaKrypton.Columns["numeroCor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFitaKrypton.Columns["numeroCor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFitaKrypton.Columns["valor"].HeaderText = "Valor";
            dgvFitaKrypton.Columns["valor"].Width = 100;
            dgvFitaKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFitaKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFitaKrypton.Columns["foto"].Width = 70;
            dgvFitaKrypton.Columns["foto"].HeaderText = "Foto";
            if (dgvFitaKrypton.Columns["foto"] is DataGridViewImageColumn fotoColumn)
            {
                fotoColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão perdidas)", "Abrindo Cadastro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmMenuCadastro menuCadastro = new frmMenuCadastro();
                menuCadastro.Show();
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            fita = new FitaVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: " + cbxTipo.SelectedItem, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    fita.itemidTpoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    fita.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaTextos()
        {
            txtMarca.Text = string.Empty;
            txtMetragem.Text = string.Empty;
            txtNumCor.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cbxTipo.Text = "Inserir Tipo";
            txtValor.Text = string.Empty;
            pbFita.Image = null;
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
            material = new MaterialVO();

            try
            {
                if (ChecarCampos(cbxTipo.Text, txtNumero.Text, txtMetragem.Text, txtMarca.Text, txtNumCor.Text, txtValor.Text))
                {
                    throw new ArgumentNullException("Um ou mais campos estão vazios");
                }

                String tipo = cbxTipo.Text;
                int numero = Convert.ToInt32(txtNumero.Text);
                double metragem = Convert.ToDouble(txtMetragem.Text);
                String marca = txtMarca.Text;
                String numeroCor = txtNumCor.Text;
                double valor = Convert.ToDouble(txtValor.Text);
                byte[] foto = null;

                if (!(tipo.Equals("Cetim") || tipo.Equals("Gorgurão") || tipo.Equals("Voil"))) { throw new ArgumentException("O tipo não foi encontrado, utilize a lista!"); }

                if (numero <= 0) { throw new ArgumentException("O Nº não pode ser negativo"); }

                if (Convert.ToInt32(numeroCor) <= 0) { throw new ArgumentException("O Nº de Número da cor não pode ser negativo"); }
                else if (Convert.ToInt32(numeroCor) > 999) { throw new ArgumentException("O Nº é maior do que 3 digitos"); }

                if (valor <= 0) { throw new ArgumentException("O valor não pode ser negativo!"); }

                if (metragem <= 0) { throw new ArgumentException("A metragem não deve ser negativa!"); }

                fita = new FitaVO();

                if (!novoClicado)
                {
                    try
                    {
                        fita.itemidTpoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                        fita.Tipo = tipo;
                        fita.Numero = numero;
                        fita.Metragem = metragem;
                        fita.Marca = marca;
                        fita.NumeroCor = numeroCor;
                        fita.Valor = valor;

                        if (!string.IsNullOrEmpty(pbFita.ImageLocation))
                        {
                            using (FileStream fstream = new FileStream(this.pbFita.ImageLocation, FileMode.Open, FileAccess.Read))
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

                        material.Nome = nome_material + " " + tipo + " Nº " + numero.ToString() + " Nº Cor " + numeroCor + " " + marca;
                        material.Valor = valor;
                        material.IdTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                        material.Atualizar();
                        fita.Atualizar();

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
                        MessageBox.Show("Este material já existe" + ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    material = new MaterialVO();
                    tipoMaterial = new TipoMaterialVO();

                    long idTipoMaterial;

                    try
                    {
                        if (!string.IsNullOrEmpty(pbFita.ImageLocation))
                        {
                            using (FileStream fstream = new FileStream(this.pbFita.ImageLocation, FileMode.Open, FileAccess.Read))
                            using (BinaryReader breader = new BinaryReader(fstream))
                            {
                                foto = breader.ReadBytes((int)fstream.Length);
                            }
                        }
                        else
                        {
                            foto = null;
                        }

                        tipoMaterial.Nome = nome_material;
                        tipoMaterial.Inserir();

                        idTipoMaterial = tipoMaterial.getLastId();

                        material.IdTipoMaterial = idTipoMaterial;
                        material.Nome = nome_material + " "+ tipo +" Nº " + numero.ToString() + " Nº Cor " + numeroCor + " " + marca;
                        material.Valor = valor;

                        material.Inserir();

                        fita.itemidTpoMaterial = idTipoMaterial;
                        fita.Tipo = tipo;
                        fita.Numero = numero;
                        fita.Metragem = metragem;
                        fita.Marca = marca;
                        fita.NumeroCor = numeroCor;
                        fita.Inserir();

                        MessageBox.Show("Item Cadastrado!");

                        LimpaTextos();
                        Inicializar();

                        novoClicado = false;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "erro");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "" + Environment.NewLine + "" + ex.StackTrace + "" + ex.GetType());

                    }
                }
            }catch(ArgumentException ex) {  MessageBox.Show(ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private static bool ChecarCampos(string tipo, string numero, string metragem, string marca, string numeroCor, string valor)
        {
            return tipo == "Inserir Tipo" || numero == String.Empty || metragem == String.Empty || valor == String.Empty || marca == string.Empty || numeroCor == string.Empty;
        }

        private object GetValorLinha(String campo)
        {
            return dgvFitaKrypton.Rows[dgvFitaKrypton.CurrentCell.RowIndex].Cells[campo].Value;
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

                dv.RowFilter = String.Format("tipo LIKE '%{0}%'", palavra);

                dgvFitaKrypton.DataSource = dv;

            }
            catch (Exception ex) { }
        }

        private void dgvFitaKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pbFita.Image = null;
            fita = new FitaVO();

            novoClicado = false;

            try
            {

                fita.Tipo = GetValorLinha("tipo").ToString();
                fita.Numero = Convert.ToInt32(GetValorLinha("numero"));
                fita.Metragem = Convert.ToInt32(GetValorLinha("metragem"));
                fita.Marca = GetValorLinha("marca").ToString() ;
                fita.NumeroCor = GetValorLinha("numeroCor").ToString();
                fita.Valor = Convert.ToDouble(GetValorLinha("valor"));


                txtNumero.Text = fita.Numero.ToString();
                txtNumCor.Text = fita.NumeroCor.ToString();
                txtMetragem.Text = fita.Metragem.ToString();
                txtMarca.Text = fita.Marca.ToString();
                cbxTipo.SelectedItem = fita.Tipo.ToString();
                txtValor.Text = fita.Valor.ToString();

                byte[] bytes = GetValorLinha("foto") as byte[];
                if (bytes != null)
                {
                    Image imagem = ByteArrayParaImagem(bytes);
                    pbFita.Image = imagem;
                }

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
            try
            {
                novoClicado = true;

                if (dgvFitaKrypton.Rows.Count != 0)
                {
                    dgvFitaKrypton.CurrentCell.Selected = false;
                }

                LimpaTextos();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;

                btnApagar.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex) {MessageBox.Show(ex.Message);}
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

        private void pbFita_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;png;)|*.jpg;*.jpeg;.*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string localfoto = opnfd.FileName.ToString();
                pbFita.ImageLocation = localfoto;
            }
        }
    }
}
