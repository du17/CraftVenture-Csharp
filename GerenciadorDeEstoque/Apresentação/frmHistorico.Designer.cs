namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmHistorico
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
            this.dgvHistoricoKrypton = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnVoltar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbxFiltroMes = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.rdDateEntrega = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdDataVenda = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpDataMinima = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDataMaxima = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFiltroMes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistoricoKrypton
            // 
            this.dgvHistoricoKrypton.AllowUserToAddRows = false;
            this.dgvHistoricoKrypton.AllowUserToDeleteRows = false;
            this.dgvHistoricoKrypton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoKrypton.Location = new System.Drawing.Point(287, 132);
            this.dgvHistoricoKrypton.MultiSelect = false;
            this.dgvHistoricoKrypton.Name = "dgvHistoricoKrypton";
            this.dgvHistoricoKrypton.ReadOnly = true;
            this.dgvHistoricoKrypton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricoKrypton.Size = new System.Drawing.Size(965, 526);
            this.dgvHistoricoKrypton.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvHistoricoKrypton.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvHistoricoKrypton.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvHistoricoKrypton.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvHistoricoKrypton.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvHistoricoKrypton.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvHistoricoKrypton.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.dgvHistoricoKrypton.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.dgvHistoricoKrypton.TabIndex = 57;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(30, 35);
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
            this.btnVoltar.TabIndex = 67;
            this.btnVoltar.Values.Text = "";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbxFiltroMes
            // 
            this.cbxFiltroMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFiltroMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFiltroMes.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxFiltroMes.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFiltroMes.DropDownWidth = 416;
            this.cbxFiltroMes.Items.AddRange(new object[] {
            "Todos",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbxFiltroMes.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFiltroMes.Location = new System.Drawing.Point(286, 89);
            this.cbxFiltroMes.Name = "cbxFiltroMes";
            this.cbxFiltroMes.Size = new System.Drawing.Size(160, 32);
            this.cbxFiltroMes.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFiltroMes.StateCommon.ComboBox.Border.Rounding = 1;
            this.cbxFiltroMes.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 15F, System.Drawing.FontStyle.Bold);
            this.cbxFiltroMes.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFiltroMes.StateCommon.Item.Border.Rounding = 5;
            this.cbxFiltroMes.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFiltroMes.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxFiltroMes.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltroMes.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltroMes.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltroMes.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFiltroMes.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.cbxFiltroMes.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFiltroMes.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFiltroMes.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFiltroMes.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroMes.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroMes.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroMes.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFiltroMes.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltroMes.TabIndex = 68;
            this.cbxFiltroMes.Text = "Filtra Por Mês";
            this.cbxFiltroMes.SelectedIndexChanged += new System.EventHandler(this.cbxNomeCliente_SelectedIndexChanged);
            // 
            // rdDateEntrega
            // 
            this.rdDateEntrega.Checked = true;
            this.rdDateEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdDateEntrega.Images.CheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdDateEntrega.Images.CheckedPressed = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdDateEntrega.Images.CheckedTracking = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdDateEntrega.Images.Common = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdDateEntrega.Images.UncheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdDateEntrega.Location = new System.Drawing.Point(14, 10);
            this.rdDateEntrega.Name = "rdDateEntrega";
            this.rdDateEntrega.Size = new System.Drawing.Size(41, 35);
            this.rdDateEntrega.TabIndex = 69;
            this.rdDateEntrega.Values.Text = "";
            this.rdDateEntrega.CheckedChanged += new System.EventHandler(this.rdDateEntrega_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rdDataVenda);
            this.panel1.Controls.Add(this.rdDateEntrega);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(452, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 48);
            this.panel1.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Texto_Entrega;
            this.pictureBox1.Location = new System.Drawing.Point(54, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 34);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // rdDataVenda
            // 
            this.rdDataVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdDataVenda.Images.CheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdDataVenda.Images.CheckedPressed = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdDataVenda.Images.CheckedTracking = global::GerenciadorDeEstoque.Properties.Resources.Checked;
            this.rdDataVenda.Images.Common = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdDataVenda.Images.UncheckedNormal = global::GerenciadorDeEstoque.Properties.Resources.NotChecked;
            this.rdDataVenda.Location = new System.Drawing.Point(196, 9);
            this.rdDataVenda.Name = "rdDataVenda";
            this.rdDataVenda.Size = new System.Drawing.Size(41, 35);
            this.rdDataVenda.TabIndex = 70;
            this.rdDataVenda.Values.Text = "";
            this.rdDataVenda.CheckedChanged += new System.EventHandler(this.rdDataVenda_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Texto_Venda;
            this.pictureBox2.Location = new System.Drawing.Point(216, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 34);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(1134, 84);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 34);
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
            this.btnNovo.StateCommon.Border.Width = 1;
            this.btnNovo.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnNovo.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnNovo.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar_btn;
            this.btnNovo.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnNovo.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnNovo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateNormal.Border.Rounding = 5;
            this.btnNovo.StateNormal.Border.Width = 1;
            this.btnNovo.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar_btn;
            this.btnNovo.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StatePressed.Border.Rounding = 5;
            this.btnNovo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnNovo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnNovo.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar_Tracking;
            this.btnNovo.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNovo.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnNovo.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateTracking.Border.Rounding = 6;
            this.btnNovo.TabIndex = 71;
            this.btnNovo.Values.Text = "";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtpDataMinima
            // 
            this.dtpDataMinima.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMinima.Location = new System.Drawing.Point(798, 84);
            this.dtpDataMinima.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtpDataMinima.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDataMinima.Name = "dtpDataMinima";
            this.dtpDataMinima.Size = new System.Drawing.Size(153, 37);
            this.dtpDataMinima.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataMinima.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataMinima.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataMinima.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataMinima.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.dtpDataMinima.TabIndex = 72;
            this.dtpDataMinima.ValueNullable = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // dtpDataMaxima
            // 
            this.dtpDataMaxima.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMaxima.Location = new System.Drawing.Point(967, 84);
            this.dtpDataMaxima.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtpDataMaxima.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDataMaxima.Name = "dtpDataMaxima";
            this.dtpDataMaxima.Size = new System.Drawing.Size(153, 37);
            this.dtpDataMaxima.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataMaxima.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataMaxima.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataMaxima.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataMaxima.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.dtpDataMaxima.TabIndex = 73;
            this.dtpDataMaxima.ValueNullable = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
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
            this.btnSair.Location = new System.Drawing.Point(2, 369);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 88);
            this.btnSair.TabIndex = 78;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.btnHistorico.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Historico;
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(216)))), ((int)(((byte)(251)))));
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Location = new System.Drawing.Point(2, 281);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(250, 88);
            this.btnHistorico.TabIndex = 77;
            this.btnHistorico.UseVisualStyleBackColor = false;
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
            this.btnVenda.Location = new System.Drawing.Point(2, 193);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(250, 88);
            this.btnVenda.TabIndex = 76;
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
            this.btnCadastro.Location = new System.Drawing.Point(2, 102);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(250, 88);
            this.btnCadastro.TabIndex = 74;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Tela_Historico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.dtpDataMaxima);
            this.Controls.Add(this.dtpDataMinima);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxFiltroMes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvHistoricoKrypton);
            this.DoubleBuffered = true;
            this.Name = "frmHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFiltroMes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvHistoricoKrypton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoltar;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxFiltroMes;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdDateEntrega;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdDataVenda;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataMinima;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataMaxima;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnCadastro;
    }
}