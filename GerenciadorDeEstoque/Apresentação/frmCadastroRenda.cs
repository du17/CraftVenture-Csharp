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

        public frmCadastroRenda()
        {
            InitializeComponent();
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
            renda = new RendaVO();
            material = new MaterialVO();
            tipoMaterial = new TipoMaterialVO();

            long idTipoMaterial;

            try
            {

                String tamanho = cbxTamanho.Text.ToString() ;
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

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvarTeste_Click(object sender, EventArgs e)
        {
            
        }
    }
}
