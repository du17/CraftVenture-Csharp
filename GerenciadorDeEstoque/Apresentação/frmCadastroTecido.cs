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

        public frmCadastroTecido()
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

                if(rdEstampado.Checked == true){
                    tipoEstampa = "Estampado";

                }
                else if(rdLiso.Checked == true) 
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


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
