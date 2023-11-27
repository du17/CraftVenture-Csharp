namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmCadastroRenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroRenda));
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLimpar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtValor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistórico = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtMetragem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbxTamanho = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRendaKrypton = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTamanho)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendaKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(926, 591);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(320, 75);
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
            this.btnSalvar.StateNormal.Border.Rounding = 5;
            this.btnSalvar.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.SALVAR;
            this.btnSalvar.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StatePressed.Border.Rounding = 5;
            this.btnSalvar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnSalvar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnSalvar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Salvar_Tracking;
            this.btnSalvar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnSalvar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StateTracking.Border.Rounding = 5;
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Values.Text = "";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(595, 590);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(320, 75);
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
            this.btnLimpar.StateNormal.Border.Rounding = 5;
            this.btnLimpar.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar;
            this.btnLimpar.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLimpar.StatePressed.Border.Rounding = 5;
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
            this.btnLimpar.StateTracking.Border.Rounding = 5;
            this.btnLimpar.TabIndex = 69;
            this.btnLimpar.Values.Text = "";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(280, 629);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(182, 49);
            this.txtValor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValor.StateCommon.Border.Rounding = 3;
            this.txtValor.StateCommon.Border.Width = 1;
            this.txtValor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.txtValor.TabIndex = 68;
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
            this.btnSair.Location = new System.Drawing.Point(0, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 88);
            this.btnSair.TabIndex = 67;
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
            this.btnHistórico.Location = new System.Drawing.Point(0, 379);
            this.btnHistórico.Name = "btnHistórico";
            this.btnHistórico.Size = new System.Drawing.Size(250, 88);
            this.btnHistórico.TabIndex = 66;
            this.btnHistórico.UseVisualStyleBackColor = false;
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
            this.btnVenda.Location = new System.Drawing.Point(0, 291);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(250, 88);
            this.btnVenda.TabIndex = 65;
            this.btnVenda.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Estoque;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Location = new System.Drawing.Point(0, 203);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(250, 88);
            this.btnEstoque.TabIndex = 64;
            this.btnEstoque.UseVisualStyleBackColor = false;
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
            this.btnCadastro.Location = new System.Drawing.Point(0, 115);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(250, 88);
            this.btnCadastro.TabIndex = 63;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtMetragem
            // 
            this.txtMetragem.Location = new System.Drawing.Point(235, 545);
            this.txtMetragem.Name = "txtMetragem";
            this.txtMetragem.Size = new System.Drawing.Size(195, 49);
            this.txtMetragem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtMetragem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMetragem.StateCommon.Border.Rounding = 3;
            this.txtMetragem.StateCommon.Border.Width = 1;
            this.txtMetragem.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.txtMetragem.TabIndex = 62;
            // 
            // cbxTamanho
            // 
            this.cbxTamanho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxTamanho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTamanho.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxTamanho.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxTamanho.DropDownWidth = 416;
            this.cbxTamanho.Items.AddRange(new object[] {
            "P",
            "N",
            "G"});
            this.cbxTamanho.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxTamanho.Location = new System.Drawing.Point(235, 467);
            this.cbxTamanho.Name = "cbxTamanho";
            this.cbxTamanho.Size = new System.Drawing.Size(298, 47);
            this.cbxTamanho.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxTamanho.StateCommon.ComboBox.Border.Rounding = 3;
            this.cbxTamanho.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.cbxTamanho.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxTamanho.StateCommon.Item.Border.Rounding = 5;
            this.cbxTamanho.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxTamanho.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxTamanho.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTamanho.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTamanho.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTamanho.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTamanho.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxTamanho.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxTamanho.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxTamanho.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxTamanho.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamanho.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamanho.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamanho.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxTamanho.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxTamanho.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTamanho.TabIndex = 71;
            this.cbxTamanho.Text = "Tamanho";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dgvRendaKrypton);
            this.panel1.Controls.Add(this.cbxTamanho);
            this.panel1.Controls.Add(this.txtMetragem);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(276, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 482);
            this.panel1.TabIndex = 72;
            // 
            // dgvRendaKrypton
            // 
            this.dgvRendaKrypton.AllowUserToAddRows = false;
            this.dgvRendaKrypton.AllowUserToDeleteRows = false;
            this.dgvRendaKrypton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendaKrypton.Location = new System.Drawing.Point(3, 3);
            this.dgvRendaKrypton.MultiSelect = false;
            this.dgvRendaKrypton.Name = "dgvRendaKrypton";
            this.dgvRendaKrypton.ReadOnly = true;
            this.dgvRendaKrypton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRendaKrypton.Size = new System.Drawing.Size(943, 319);
            this.dgvRendaKrypton.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvRendaKrypton.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvRendaKrypton.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvRendaKrypton.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvRendaKrypton.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvRendaKrypton.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvRendaKrypton.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(34, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 484);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
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
            this.txtPesquisar.TabIndex = 74;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(3, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 65);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(265, 590);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(320, 75);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonButton1.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
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
            this.kryptonButton1.StateNormal.Border.Rounding = 5;
            this.kryptonButton1.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo_Tracking;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 5;
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
            this.kryptonButton1.StateTracking.Border.Rounding = 5;
            this.kryptonButton1.TabIndex = 73;
            this.kryptonButton1.Values.Text = "";
            // 
            // frmCadastroRenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Material_Renda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistórico);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCadastro);
            this.DoubleBuffered = true;
            this.Name = "frmCadastroRenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cbxTamanho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendaKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLimpar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHistórico;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCadastro;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMetragem;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxTamanho;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvRendaKrypton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}