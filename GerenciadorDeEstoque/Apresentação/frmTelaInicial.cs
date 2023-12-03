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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            
            frmLogin.Show();
            
        }

        private void frmTelaInicial_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
