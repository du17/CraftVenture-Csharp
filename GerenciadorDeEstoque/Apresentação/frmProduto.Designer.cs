namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxFiltro = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgvProduto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTipo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtQuantidade = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.txtNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtValor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProdutoKrypton = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnApagar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAcidionarMaterial = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistórico = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.cbxFiltro);
            this.panel1.Controls.Add(this.dgvProduto);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtTipo);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.pbProduto);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dgvProdutoKrypton);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(276, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 410);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFiltro.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxFiltro.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFiltro.DropDownWidth = 416;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Nome",
            "Tipo",
            "Quantidade"});
            this.cbxFiltro.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFiltro.Location = new System.Drawing.Point(179, 444);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(378, 47);
            this.cbxFiltro.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFiltro.StateCommon.ComboBox.Border.Rounding = 2;
            this.cbxFiltro.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 22F, System.Drawing.FontStyle.Bold);
            this.cbxFiltro.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFiltro.StateCommon.Item.Border.Rounding = 5;
            this.cbxFiltro.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFiltro.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxFiltro.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltro.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltro.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltro.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltro.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltro.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltro.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFiltro.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFiltro.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltro.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltro.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltro.TabIndex = 61;
            this.cbxFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(3, 3);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(844, 348);
            this.dgvProduto.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvProduto.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvProduto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvProduto.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvProduto.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvProduto.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvProduto.TabIndex = 65;
            this.dgvProduto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellEnter);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(16, 357);
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
            this.txtPesquisar.TabIndex = 60;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(16, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 65);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(232, 595);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(374, 50);
            this.txtTipo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtTipo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtTipo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtTipo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTipo.StateCommon.Border.Rounding = 5;
            this.txtTipo.StateCommon.Border.Width = 1;
            this.txtTipo.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtTipo.TabIndex = 59;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(233, 665);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(231, 50);
            this.txtQuantidade.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtQuantidade.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtQuantidade.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtQuantidade.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQuantidade.StateCommon.Border.Rounding = 5;
            this.txtQuantidade.StateCommon.Border.Width = 1;
            this.txtQuantidade.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.TabIndex = 58;
            // 
            // pbProduto
            // 
            this.pbProduto.BackColor = System.Drawing.Color.Transparent;
            this.pbProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProduto.Location = new System.Drawing.Point(492, 737);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(201, 195);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProduto.TabIndex = 57;
            this.pbProduto.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(232, 514);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(470, 50);
            this.txtNome.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtNome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtNome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNome.StateCommon.Border.Rounding = 5;
            this.txtNome.StateCommon.Border.Width = 1;
            this.txtNome.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtNome.TabIndex = 55;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(281, 743);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(177, 50);
            this.txtValor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValor.StateCommon.Border.Rounding = 5;
            this.txtValor.StateCommon.Border.Width = 1;
            this.txtValor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold);
            this.txtValor.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Textos_Produto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 457);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // dgvProdutoKrypton
            // 
            this.dgvProdutoKrypton.AllowUserToAddRows = false;
            this.dgvProdutoKrypton.AllowUserToDeleteRows = false;
            this.dgvProdutoKrypton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoKrypton.Location = new System.Drawing.Point(3, -330);
            this.dgvProdutoKrypton.MultiSelect = false;
            this.dgvProdutoKrypton.Name = "dgvProdutoKrypton";
            this.dgvProdutoKrypton.ReadOnly = true;
            this.dgvProdutoKrypton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoKrypton.Size = new System.Drawing.Size(943, 319);
            this.dgvProdutoKrypton.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvProdutoKrypton.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvProdutoKrypton.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvProdutoKrypton.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvProdutoKrypton.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvProdutoKrypton.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvProdutoKrypton.TabIndex = 53;
            this.dgvProdutoKrypton.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPapelKrypton_CellEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Filtrar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(16, 445);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(561, 46);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(263, 590);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(319, 70);
            this.btnNovo.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnNovo.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
            this.btnNovo.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnNovo.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNovo.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateCommon.Border.Rounding = 7;
            this.btnNovo.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnNovo.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo;
            this.btnNovo.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnNovo.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnNovo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateNormal.Border.Rounding = 5;
            this.btnNovo.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo;
            this.btnNovo.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StatePressed.Border.Rounding = 5;
            this.btnNovo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnNovo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnNovo.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Novo_Tracking;
            this.btnNovo.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNovo.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnNovo.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateTracking.Border.Rounding = 6;
            this.btnNovo.TabIndex = 54;
            this.btnNovo.Values.Text = "";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(920, 592);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(320, 70);
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
            this.btnSalvar.StateTracking.Border.Rounding = 6;
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Values.Text = "";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.Location = new System.Drawing.Point(591, 590);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(320, 70);
            this.btnApagar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnApagar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
            this.btnApagar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnApagar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnApagar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApagar.StateCommon.Border.Rounding = 7;
            this.btnApagar.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnApagar.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnApagar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnApagar.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StateDisabled.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar_Disabled;
            this.btnApagar.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApagar.StateDisabled.Border.Rounding = 3;
            this.btnApagar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar;
            this.btnApagar.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnApagar.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnApagar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApagar.StateNormal.Border.Rounding = 5;
            this.btnApagar.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar;
            this.btnApagar.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApagar.StatePressed.Border.Rounding = 5;
            this.btnApagar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnApagar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnApagar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Apagar_Tracking;
            this.btnApagar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnApagar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnApagar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnApagar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnApagar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnApagar.StateTracking.Border.Rounding = 6;
            this.btnApagar.TabIndex = 52;
            this.btnApagar.Values.Text = "";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAcidionarMaterial
            // 
            this.btnAcidionarMaterial.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAcidionarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcidionarMaterial.Location = new System.Drawing.Point(292, 513);
            this.btnAcidionarMaterial.Name = "btnAcidionarMaterial";
            this.btnAcidionarMaterial.Size = new System.Drawing.Size(940, 49);
            this.btnAcidionarMaterial.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAcidionarMaterial.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Material_btn;
            this.btnAcidionarMaterial.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnAcidionarMaterial.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAcidionarMaterial.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcidionarMaterial.StateCommon.Border.Rounding = 7;
            this.btnAcidionarMaterial.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnAcidionarMaterial.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Material_btn;
            this.btnAcidionarMaterial.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnAcidionarMaterial.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnAcidionarMaterial.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcidionarMaterial.StateNormal.Border.Rounding = 5;
            this.btnAcidionarMaterial.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Material_btn;
            this.btnAcidionarMaterial.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcidionarMaterial.StatePressed.Border.Rounding = 5;
            this.btnAcidionarMaterial.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnAcidionarMaterial.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnAcidionarMaterial.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Material_Tracking;
            this.btnAcidionarMaterial.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAcidionarMaterial.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAcidionarMaterial.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAcidionarMaterial.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcidionarMaterial.StateTracking.Border.Rounding = 6;
            this.btnAcidionarMaterial.TabIndex = 55;
            this.btnAcidionarMaterial.Values.Text = "";
            this.btnAcidionarMaterial.Click += new System.EventHandler(this.btnAcidionarMaterial_Click);
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
            this.btnSair.Location = new System.Drawing.Point(-4, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 88);
            this.btnSair.TabIndex = 60;
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
            this.btnHistórico.Location = new System.Drawing.Point(-4, 353);
            this.btnHistórico.Name = "btnHistórico";
            this.btnHistórico.Size = new System.Drawing.Size(250, 88);
            this.btnHistórico.TabIndex = 59;
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
            this.btnVenda.Location = new System.Drawing.Point(-4, 265);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(250, 88);
            this.btnVenda.TabIndex = 58;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
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
            this.btnEstoque.Location = new System.Drawing.Point(-4, 177);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(250, 88);
            this.btnEstoque.TabIndex = 57;
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
            this.btnCadastro.Location = new System.Drawing.Point(-4, 89);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(250, 88);
            this.btnCadastro.TabIndex = 56;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Cadastro_Produto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistórico);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnAcidionarMaterial);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProdutoKrypton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnApagar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValor;
        private System.Windows.Forms.PictureBox pbProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAcidionarMaterial;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuantidade;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTipo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHistórico;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxFiltro;
    }
}