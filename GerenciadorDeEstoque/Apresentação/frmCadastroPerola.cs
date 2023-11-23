using System;
using GerenciadorDeEstoque.DAO;
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
    public partial class frmCadastroPerola : Form
    {
        static String nome_material = "Perola";
        PerolaVO perola;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;

        public frmCadastroPerola()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroOpcoes menuOpcoes = new frmCadastroOpcoes();
            menuOpcoes.Show();
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

            //pq essa porra não funciona???????
            /*perola = new PerolaVO();
            material = new MaterialVO();
            tipoMaterial = new TipoMaterialVO();

            try
            {
                string cor = txtCor.Text;
                double tamanho = Convert.ToDouble(txtTamanho.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                long idTipoMaterial;

                perola.Cor = cor;
                perola.Tamanho = tamanho;

                material.Valor = valor;
                material.Nome = nome_material;

                tipoMaterial.Nome = nome_material;
                tipoMaterial.Inserir();
                
                idTipoMaterial = tipoMaterial.getLastId();

                perola.itemidTipoMaterial = idTipoMaterial;
                material.IdMaterial = idTipoMaterial;

                material.Inserir();

                perola.Inserir();

                MessageBox.Show("Item cadastrado!");

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = string.Empty;
            txtTamanho.Text = string.Empty;
            txtCor.Text = string.Empty;
        }
    }
}
