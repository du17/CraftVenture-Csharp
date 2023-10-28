namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmCadastro
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
            this.btnEntrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCadastrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbSenha = new System.Windows.Forms.PictureBox();
            this.pbRepetirSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepetirSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(573, 642);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(133, 25);
            this.btnEntrar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnEntrar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnEntrar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.ENTRAR;
            this.btnEntrar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnEntrar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnEntrar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnEntrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEntrar.StateCommon.Border.Rounding = 4;
            this.btnEntrar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.StateNormal.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.TabIndex = 19;
            this.btnEntrar.Values.Image = global::GerenciadorDeEstoque.Properties.Resources.ENTRAR;
            this.btnEntrar.Values.Text = "";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.BackColor = System.Drawing.Color.White;
            this.lblRepetirSenha.Enabled = false;
            this.lblRepetirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRepetirSenha.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirSenha.Location = new System.Drawing.Point(427, 435);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(229, 37);
            this.lblRepetirSenha.TabIndex = 18;
            this.lblRepetirSenha.Text = "REPETIR SENHA";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Location = new System.Drawing.Point(412, 431);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = '●';
            this.txtRepetirSenha.Size = new System.Drawing.Size(453, 45);
            this.txtRepetirSenha.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtRepetirSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRepetirSenha.StateCommon.Border.Rounding = 25;
            this.txtRepetirSenha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirSenha.TabIndex = 17;
            this.txtRepetirSenha.UseSystemPasswordChar = true;
            this.txtRepetirSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepetirSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Enabled = false;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(427, 360);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(111, 37);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(412, 356);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(453, 45);
            this.txtSenha.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSenha.StateCommon.Border.Rounding = 25;
            this.txtSenha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.WordWrap = false;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Enabled = false;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(427, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 37);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(412, 280);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(453, 45);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 25;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.TabIndex = 13;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Enabled = false;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(427, 211);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(102, 37);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(412, 207);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(453, 45);
            this.txtNome.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNome.StateCommon.Border.Rounding = 25;
            this.txtNome.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.TabIndex = 11;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(500, 511);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(257, 49);
            this.btnCadastrar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Cadastrar;
            this.btnCadastrar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCadastrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCadastrar.StateCommon.Border.Rounding = 4;
            this.btnCadastrar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.StateNormal.Content.LongText.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Values.Image = global::GerenciadorDeEstoque.Properties.Resources.Cadastrar;
            this.btnCadastrar.Values.Text = "";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pbSenha
            // 
            this.pbSenha.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.olho__1_;
            this.pbSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSenha.Image = global::GerenciadorDeEstoque.Properties.Resources.olho;
            this.pbSenha.Location = new System.Drawing.Point(815, 364);
            this.pbSenha.Name = "pbSenha";
            this.pbSenha.Size = new System.Drawing.Size(36, 31);
            this.pbSenha.TabIndex = 20;
            this.pbSenha.TabStop = false;
            this.pbSenha.Click += new System.EventHandler(this.pbSenha_Click);
            // 
            // pbRepetirSenha
            // 
            this.pbRepetirSenha.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.olho__1_;
            this.pbRepetirSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRepetirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRepetirSenha.Image = global::GerenciadorDeEstoque.Properties.Resources.olho;
            this.pbRepetirSenha.Location = new System.Drawing.Point(815, 439);
            this.pbRepetirSenha.Name = "pbRepetirSenha";
            this.pbRepetirSenha.Size = new System.Drawing.Size(36, 31);
            this.pbRepetirSenha.TabIndex = 21;
            this.pbRepetirSenha.TabStop = false;
            this.pbRepetirSenha.Click += new System.EventHandler(this.pbRepetirSenha_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Frame_20frameCadastro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pbRepetirSenha);
            this.Controls.Add(this.pbSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblRepetirSenha);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepetirSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEntrar;
        private System.Windows.Forms.Label lblRepetirSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtRepetirSenha;
        private System.Windows.Forms.Label lblSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSenha;
        private System.Windows.Forms.Label lblEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCadastrar;
        private System.Windows.Forms.PictureBox pbSenha;
        private System.Windows.Forms.PictureBox pbRepetirSenha;
    }
}