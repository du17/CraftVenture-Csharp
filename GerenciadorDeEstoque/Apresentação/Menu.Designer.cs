
namespace GerenciadorDeEstoque.Apresentação
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuOpcoes = new System.Windows.Forms.Panel();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.buttonEstoque = new System.Windows.Forms.Button();
            this.buttonVenda = new System.Windows.Forms.Button();
            this.buttonHistorico = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.menuOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuOpcoes.Controls.Add(this.buttonSair);
            this.menuOpcoes.Controls.Add(this.buttonHistorico);
            this.menuOpcoes.Controls.Add(this.buttonVenda);
            this.menuOpcoes.Controls.Add(this.buttonEstoque);
            this.menuOpcoes.Controls.Add(this.buttonCadastro);
            this.menuOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuOpcoes.Location = new System.Drawing.Point(0, 0);
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(205, 537);
            this.menuOpcoes.TabIndex = 0;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastro.Location = new System.Drawing.Point(28, 124);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(146, 45);
            this.buttonCadastro.TabIndex = 1;
            this.buttonCadastro.Text = "Cadastro";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            // 
            // buttonEstoque
            // 
            this.buttonEstoque.Location = new System.Drawing.Point(28, 195);
            this.buttonEstoque.Name = "buttonEstoque";
            this.buttonEstoque.Size = new System.Drawing.Size(146, 45);
            this.buttonEstoque.TabIndex = 2;
            this.buttonEstoque.Text = "Estoque";
            this.buttonEstoque.UseVisualStyleBackColor = true;
            // 
            // buttonVenda
            // 
            this.buttonVenda.Location = new System.Drawing.Point(28, 262);
            this.buttonVenda.Name = "buttonVenda";
            this.buttonVenda.Size = new System.Drawing.Size(146, 45);
            this.buttonVenda.TabIndex = 3;
            this.buttonVenda.Text = "Venda";
            this.buttonVenda.UseVisualStyleBackColor = true;
            // 
            // buttonHistorico
            // 
            this.buttonHistorico.Location = new System.Drawing.Point(28, 330);
            this.buttonHistorico.Name = "buttonHistorico";
            this.buttonHistorico.Size = new System.Drawing.Size(146, 45);
            this.buttonHistorico.TabIndex = 4;
            this.buttonHistorico.Text = "Historico";
            this.buttonHistorico.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(28, 398);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(146, 45);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(1136, 537);
            this.Controls.Add(this.menuOpcoes);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Menu";
            this.Text = " ";
            this.menuOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_AddProd;
        private System.Windows.Forms.Label label_AddProd;
        private System.Windows.Forms.PictureBox picture_Edit;
        private System.Windows.Forms.Label label_EditEstoq;
        private System.Windows.Forms.GroupBox gpb_Estoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnImg_Cliente;
        private System.Windows.Forms.GroupBox gpb_Cliente;
        private System.Windows.Forms.PictureBox btn_NovoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btn_pedido;
        private System.Windows.Forms.PictureBox btn_criarPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureAlterarEstadoPedido;
        private System.Windows.Forms.CheckBox checkBoxCancelados;
        private System.Windows.Forms.CheckBox checkBoxPago;
        private System.Windows.Forms.CheckBox checkBoxPendentes;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox groupBox_pedidos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picBoxUsuarios;
        private System.Windows.Forms.PictureBox pictureBoxEditarCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSuporte;
        private System.Windows.Forms.PictureBox imgSuporte;
        private System.Windows.Forms.GroupBox gpBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBoxSuporte;
        private System.Windows.Forms.ListView listViewAnaliseVendas;
        private System.Windows.Forms.Button btn2021;
        private System.Windows.Forms.Button btn2020;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDezembro;
        private System.Windows.Forms.Button btnNovembro;
        private System.Windows.Forms.Button btnOutubro;
        private System.Windows.Forms.Button btnSetembro;
        private System.Windows.Forms.Button btnAgosto;
        private System.Windows.Forms.Button btnJulho;
        private System.Windows.Forms.Button btnJunho;
        private System.Windows.Forms.Button btnMaio;
        private System.Windows.Forms.Button btnAbril;
        private System.Windows.Forms.Button btnMarco;
        private System.Windows.Forms.Button btnFevereiro;
        private System.Windows.Forms.Button btnJaneiro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.ListView listView_Cliente;
        public System.Windows.Forms.ListView listView_Clientes;
        public System.Windows.Forms.ListView listView_Pedido;
        public System.Windows.Forms.ListView listViewUsuario;
        public System.Windows.Forms.GroupBox gpBoxAnalise;
        public System.Windows.Forms.GroupBox gpBoxSuporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVendas;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel menuOpcoes;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonHistorico;
        private System.Windows.Forms.Button buttonVenda;
        private System.Windows.Forms.Button buttonEstoque;
        private System.Windows.Forms.Button buttonCadastro;
    }
}