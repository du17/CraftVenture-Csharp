using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace GerenciadorDeEstoque.Apresentação.Menu
{
    public partial class frmMenuCadastro : KryptonForm
    {
        public frmMenuCadastro()
        {
            InitializeComponent();
        }

        private void frmMenuCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmCadastroOpcoes frmOpcoesmaterial = new frmCadastroOpcoes();
            frmOpcoesmaterial.ShowDialog();
            this.Close();
        }
    }
}
