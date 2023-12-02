namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCadastrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbSenha = new System.Windows.Forms.PictureBox();
            this.btnFechar_Krypton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Enabled = false;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(421, 387);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(111, 37);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(406, 383);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(453, 45);
            this.txtSenha.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSenha.StateCommon.Border.Rounding = 25;
            this.txtSenha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.TabIndex = 19;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WordWrap = false;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Enabled = false;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(421, 299);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(102, 37);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(406, 295);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(453, 45);
            this.txtNome.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNome.StateCommon.Border.Rounding = 25;
            this.txtNome.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.TabIndex = 17;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress_1);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(513, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 49);
            this.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.btnLogin;
            this.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateCommon.Border.Rounding = 4;
            this.btnLogin.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLogin.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLogin.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Login_btn;
            this.btnLogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateNormal.Border.Rounding = 3;
            this.btnLogin.StateNormal.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Login_btn;
            this.btnLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StatePressed.Border.Rounding = 3;
            this.btnLogin.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Login_Tracking_btn;
            this.btnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogin.StateTracking.Border.Rounding = 3;
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Values.Image = global::GerenciadorDeEstoque.Properties.Resources.Cadastrar;
            this.btnLogin.Values.Text = "";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(517, 626);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(233, 36);
            this.btnCadastrar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.CADASTRE_SE;
            this.btnCadastrar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnCadastrar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCadastrar.StateCommon.Border.Rounding = 4;
            this.btnCadastrar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateNormal.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Values.Text = "";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pbSenha
            // 
            this.pbSenha.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.olho__1_;
            this.pbSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSenha.Image = global::GerenciadorDeEstoque.Properties.Resources.olho;
            this.pbSenha.Location = new System.Drawing.Point(810, 393);
            this.pbSenha.Name = "pbSenha";
            this.pbSenha.Size = new System.Drawing.Size(36, 31);
            this.pbSenha.TabIndex = 23;
            this.pbSenha.TabStop = false;
            this.pbSenha.Click += new System.EventHandler(this.pbSenha_Click);
            // 
            // btnFechar_Krypton
            // 
            this.btnFechar_Krypton.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnFechar_Krypton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar_Krypton.Location = new System.Drawing.Point(1211, 8);
            this.btnFechar_Krypton.Name = "btnFechar_Krypton";
            this.btnFechar_Krypton.Size = new System.Drawing.Size(44, 41);
            this.btnFechar_Krypton.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.btn_Fechar;
            this.btnFechar_Krypton.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnFechar_Krypton.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFechar_Krypton.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StatePressed.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnFechar_Krypton.StatePressed.Back.ColorAngle = 0F;
            this.btnFechar_Krypton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnFechar_Krypton.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.btn_Fechar;
            this.btnFechar_Krypton.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnFechar_Krypton.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnFechar_Krypton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnFechar_Krypton.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateTracking.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnFechar_Krypton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btnFechar_Krypton.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.btn_Fechar;
            this.btnFechar_Krypton.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnFechar_Krypton.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnFechar_Krypton.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnFechar_Krypton.TabIndex = 25;
            this.btnFechar_Krypton.Values.Image = global::GerenciadorDeEstoque.Properties.Resources.btn_Fechar;
            this.btnFechar_Krypton.Values.Text = "";
            this.btnFechar_Krypton.Click += new System.EventHandler(this.btnFechar_Krypton_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnFechar_Krypton);
            this.Controls.Add(this.pbSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label lblSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSenha;
        private System.Windows.Forms.Label lblNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCadastrar;
        private System.Windows.Forms.PictureBox pbSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFechar_Krypton;
    }
}