namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmCadastroTecido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTecido));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistórico = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtMetragemAltura = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMetragemComprimento = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdLiso = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdEstampado = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.txtValor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLimpar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbxTipo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbTecido = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvTecidoKrypton = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVoltar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTecido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecidoKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(0, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 88);
            this.btnSair.TabIndex = 45;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnHistórico
            // 
            this.btnHistórico.BackColor = System.Drawing.Color.Transparent;
            this.btnHistórico.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Historico;
            this.btnHistórico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHistórico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistórico.FlatAppearance.BorderSize = 0;
            this.btnHistórico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.btnHistórico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistórico.Location = new System.Drawing.Point(0, 289);
            this.btnHistórico.Name = "btnHistórico";
            this.btnHistórico.Size = new System.Drawing.Size(250, 88);
            this.btnHistórico.TabIndex = 44;
            this.btnHistórico.UseVisualStyleBackColor = false;
            this.btnHistórico.Click += new System.EventHandler(this.btnHistórico_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnVenda.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Venda;
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Location = new System.Drawing.Point(0, 201);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(250, 88);
            this.btnVenda.TabIndex = 43;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Cadastrar__1_;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Location = new System.Drawing.Point(0, 107);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(250, 88);
            this.btnCadastro.TabIndex = 41;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtMetragemAltura
            // 
            this.txtMetragemAltura.Location = new System.Drawing.Point(221, 501);
            this.txtMetragemAltura.Name = "txtMetragemAltura";
            this.txtMetragemAltura.Size = new System.Drawing.Size(195, 49);
            this.txtMetragemAltura.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragemAltura.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragemAltura.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragemAltura.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMetragemAltura.StateCommon.Border.Rounding = 2;
            this.txtMetragemAltura.StateCommon.Border.Width = 1;
            this.txtMetragemAltura.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.txtMetragemAltura.TabIndex = 39;
            // 
            // txtMetragemComprimento
            // 
            this.txtMetragemComprimento.Location = new System.Drawing.Point(477, 501);
            this.txtMetragemComprimento.Name = "txtMetragemComprimento";
            this.txtMetragemComprimento.Size = new System.Drawing.Size(195, 49);
            this.txtMetragemComprimento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragemComprimento.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragemComprimento.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragemComprimento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMetragemComprimento.StateCommon.Border.Rounding = 2;
            this.txtMetragemComprimento.StateCommon.Border.Width = 1;
            this.txtMetragemComprimento.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.txtMetragemComprimento.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Tipo_Tecido;
            this.panel1.Controls.Add(this.rdLiso);
            this.panel1.Controls.Add(this.rdEstampado);
            this.panel1.Location = new System.Drawing.Point(496, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 166);
            this.panel1.TabIndex = 47;
            // 
            // rdLiso
            // 
            this.rdLiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdLiso.Images.CheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdLiso.Images.CheckedPressed = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdLiso.Images.CheckedTracking = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdLiso.Images.Common = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdLiso.Images.UncheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdLiso.Location = new System.Drawing.Point(44, 95);
            this.rdLiso.Name = "rdLiso";
            this.rdLiso.Size = new System.Drawing.Size(41, 35);
            this.rdLiso.TabIndex = 1;
            this.rdLiso.Values.Text = "";
            // 
            // rdEstampado
            // 
            this.rdEstampado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdEstampado.Images.CheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdEstampado.Images.CheckedPressed = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdEstampado.Images.CheckedTracking = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdEstampado.Images.Common = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdEstampado.Images.UncheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdEstampado.Location = new System.Drawing.Point(44, 25);
            this.rdEstampado.Name = "rdEstampado";
            this.rdEstampado.Size = new System.Drawing.Size(41, 35);
            this.rdEstampado.TabIndex = 0;
            this.rdEstampado.Values.Text = "";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(265, 587);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(182, 49);
            this.txtValor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValor.StateCommon.Border.Rounding = 2;
            this.txtValor.StateCommon.Border.Width = 1;
            this.txtValor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.txtValor.TabIndex = 48;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(926, 591);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(319, 70);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSalvar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.SALVAR;
            this.btnSalvar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnSalvar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSalvar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StateCommon.Border.Rounding = 7;
            this.btnSalvar.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnSalvar.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnSalvar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSalvar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.SALVAR;
            this.btnSalvar.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StateNormal.Border.Rounding = 4;
            this.btnSalvar.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StatePressed.Border.Rounding = 4;
            this.btnSalvar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnSalvar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnSalvar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.SALVAR;
            this.btnSalvar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSalvar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StateTracking.Border.Rounding = 4;
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Values.Text = "";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(595, 591);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(319, 70);
            this.btnLimpar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnLimpar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
            this.btnLimpar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnLimpar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnLimpar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLimpar.StateCommon.Border.Rounding = 7;
            this.btnLimpar.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnLimpar.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnLimpar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLimpar.StateDisabled.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar_Disabled;
            this.btnLimpar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar;
            this.btnLimpar.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLimpar.StateNormal.Border.Rounding = 4;
            this.btnLimpar.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar;
            this.btnLimpar.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLimpar.StatePressed.Border.Rounding = 4;
            this.btnLimpar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnLimpar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnLimpar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar_Tracking;
            this.btnLimpar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnLimpar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnLimpar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLimpar.StateTracking.Border.Rounding = 4;
            this.btnLimpar.TabIndex = 49;
            this.btnLimpar.Values.Text = "";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipo.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxTipo.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxTipo.DropDownWidth = 416;
            this.cbxTipo.Items.AddRange(new object[] {
            "Atoalhado",
            "Fralda",
            "Tricoline",
            "Tule",
            "Feltro"});
            this.cbxTipo.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxTipo.Location = new System.Drawing.Point(222, 422);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(469, 47);
            this.cbxTipo.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxTipo.StateCommon.ComboBox.Border.Rounding = 2;
            this.cbxTipo.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.cbxTipo.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxTipo.StateCommon.Item.Border.Rounding = 5;
            this.cbxTipo.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxTipo.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxTipo.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTipo.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTipo.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTipo.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTipo.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTipo.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTipo.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxTipo.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxTipo.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTipo.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTipo.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.TabIndex = 51;
            this.cbxTipo.Text = "Inserir Tipo";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.pbTecido);
            this.panel2.Controls.Add(this.txtPesquisar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dgvTecidoKrypton);
            this.panel2.Controls.Add(this.txtMetragemComprimento);
            this.panel2.Controls.Add(this.cbxTipo);
            this.panel2.Controls.Add(this.txtMetragemAltura);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(276, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 482);
            this.panel2.TabIndex = 52;
            // 
            // pbTecido
            // 
            this.pbTecido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTecido.Location = new System.Drawing.Point(222, 674);
            this.pbTecido.Name = "pbTecido";
            this.pbTecido.Size = new System.Drawing.Size(201, 195);
            this.pbTecido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTecido.TabIndex = 79;
            this.pbTecido.TabStop = false;
            this.pbTecido.Click += new System.EventHandler(this.pbTecido_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(3, 328);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(551, 56);
            this.txtPesquisar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtPesquisar.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtPesquisar.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.txtPesquisar.StateCommon.Border.Rounding = 10;
            this.txtPesquisar.StateCommon.Border.Width = 1;
            this.txtPesquisar.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtPesquisar.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.TabIndex = 56;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(3, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 65);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // dgvTecidoKrypton
            // 
            this.dgvTecidoKrypton.AllowUserToAddRows = false;
            this.dgvTecidoKrypton.AllowUserToDeleteRows = false;
            this.dgvTecidoKrypton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecidoKrypton.Location = new System.Drawing.Point(3, 3);
            this.dgvTecidoKrypton.MultiSelect = false;
            this.dgvTecidoKrypton.Name = "dgvTecidoKrypton";
            this.dgvTecidoKrypton.ReadOnly = true;
            this.dgvTecidoKrypton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecidoKrypton.Size = new System.Drawing.Size(943, 319);
            this.dgvTecidoKrypton.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvTecidoKrypton.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvTecidoKrypton.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvTecidoKrypton.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvTecidoKrypton.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvTecidoKrypton.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvTecidoKrypton.TabIndex = 53;
            this.dgvTecidoKrypton.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTecidoKrypton_CellEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(22, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 499);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(265, 591);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(319, 70);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton1.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.SALVAR;
            this.kryptonButton1.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 7;
            this.kryptonButton1.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 4;
            this.kryptonButton1.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 4;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.kryptonButton1.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo_Tracking;
            this.kryptonButton1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 4;
            this.kryptonButton1.TabIndex = 53;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(30, 34);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(35, 46);
            this.btnVoltar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnVoltar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.SALVAR;
            this.btnVoltar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnVoltar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnVoltar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StateCommon.Border.Rounding = 7;
            this.btnVoltar.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnVoltar.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnVoltar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnVoltar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Voltar;
            this.btnVoltar.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.BottomMiddle;
            this.btnVoltar.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StateNormal.Border.Rounding = 14;
            this.btnVoltar.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Voltar;
            this.btnVoltar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StatePressed.Border.Rounding = 2;
            this.btnVoltar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnVoltar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnVoltar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Voltar;
            this.btnVoltar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnVoltar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnVoltar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnVoltar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVoltar.StateTracking.Border.Rounding = 0;
            this.btnVoltar.TabIndex = 66;
            this.btnVoltar.Values.Text = "";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadastroTecido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Material_Tecido;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistórico);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnCadastro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroTecido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTecido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecidoKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHistórico;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnCadastro;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMetragemAltura;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMetragemComprimento;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdEstampado;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdLiso;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLimpar;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvTecidoKrypton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoltar;
        private System.Windows.Forms.PictureBox pbTecido;
    }
}