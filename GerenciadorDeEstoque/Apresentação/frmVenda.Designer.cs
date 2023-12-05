namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmVenda
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
            this.cbxFormaEntrega = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbxFormaPagamento = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtAnotacao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtpDataVenda = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDateEntrega = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtGramatura = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbxNomeCliente = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtCor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtValor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvVendaKrypton = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnApagar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdicionarProduto = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistórico = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFormaEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNomeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.cbxFormaEntrega);
            this.panel1.Controls.Add(this.cbxFormaPagamento);
            this.panel1.Controls.Add(this.txtAnotacao);
            this.panel1.Controls.Add(this.dtpDataVenda);
            this.panel1.Controls.Add(this.dtpDateEntrega);
            this.panel1.Controls.Add(this.txtGramatura);
            this.panel1.Controls.Add(this.cbxNomeCliente);
            this.panel1.Controls.Add(this.txtCor);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.dgvVendaKrypton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(260, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 429);
            this.panel1.TabIndex = 0;
            // 
            // cbxFormaEntrega
            // 
            this.cbxFormaEntrega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFormaEntrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFormaEntrega.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxFormaEntrega.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFormaEntrega.DropDownWidth = 416;
            this.cbxFormaEntrega.Items.AddRange(new object[] {
            "Motoboy",
            "Correio",
            "Melhor Envio"});
            this.cbxFormaEntrega.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFormaEntrega.Location = new System.Drawing.Point(773, 536);
            this.cbxFormaEntrega.Name = "cbxFormaEntrega";
            this.cbxFormaEntrega.Size = new System.Drawing.Size(182, 37);
            this.cbxFormaEntrega.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFormaEntrega.StateCommon.ComboBox.Border.Rounding = 1;
            this.cbxFormaEntrega.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.cbxFormaEntrega.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFormaEntrega.StateCommon.Item.Border.Rounding = 5;
            this.cbxFormaEntrega.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFormaEntrega.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxFormaEntrega.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaEntrega.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaEntrega.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaEntrega.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaEntrega.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaEntrega.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaEntrega.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFormaEntrega.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFormaEntrega.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaEntrega.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaEntrega.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaEntrega.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaEntrega.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaEntrega.TabIndex = 69;
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFormaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFormaPagamento.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxFormaPagamento.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFormaPagamento.DropDownWidth = 416;
            this.cbxFormaPagamento.Items.AddRange(new object[] {
            "Pix",
            "Cartão",
            "Depósito"});
            this.cbxFormaPagamento.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(324, 540);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(177, 37);
            this.cbxFormaPagamento.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFormaPagamento.StateCommon.ComboBox.Border.Rounding = 1;
            this.cbxFormaPagamento.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.cbxFormaPagamento.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFormaPagamento.StateCommon.Item.Border.Rounding = 5;
            this.cbxFormaPagamento.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFormaPagamento.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxFormaPagamento.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaPagamento.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaPagamento.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaPagamento.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaPagamento.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxFormaPagamento.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxFormaPagamento.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxFormaPagamento.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxFormaPagamento.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPagamento.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPagamento.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPagamento.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxFormaPagamento.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPagamento.TabIndex = 68;
            // 
            // txtAnotacao
            // 
            this.txtAnotacao.Location = new System.Drawing.Point(326, 660);
            this.txtAnotacao.Multiline = true;
            this.txtAnotacao.Name = "txtAnotacao";
            this.txtAnotacao.Size = new System.Drawing.Size(508, 85);
            this.txtAnotacao.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtAnotacao.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtAnotacao.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtAnotacao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAnotacao.StateCommon.Border.Rounding = 2;
            this.txtAnotacao.StateCommon.Border.Width = 1;
            this.txtAnotacao.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.txtAnotacao.TabIndex = 67;
            this.txtAnotacao.WordWrap = false;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(326, 479);
            this.dtpDataVenda.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtpDataVenda.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(175, 37);
            this.dtpDataVenda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataVenda.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataVenda.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDataVenda.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataVenda.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.dtpDataVenda.TabIndex = 66;
            this.dtpDataVenda.ValueNullable = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // dtpDateEntrega
            // 
            this.dtpDateEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEntrega.Location = new System.Drawing.Point(763, 478);
            this.dtpDateEntrega.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtpDateEntrega.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDateEntrega.Name = "dtpDateEntrega";
            this.dtpDateEntrega.Size = new System.Drawing.Size(175, 37);
            this.dtpDateEntrega.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDateEntrega.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDateEntrega.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.dtpDateEntrega.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDateEntrega.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.dtpDateEntrega.TabIndex = 64;
            this.dtpDateEntrega.ValueNullable = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // txtGramatura
            // 
            this.txtGramatura.Location = new System.Drawing.Point(324, 660);
            this.txtGramatura.Multiline = true;
            this.txtGramatura.Name = "txtGramatura";
            this.txtGramatura.Size = new System.Drawing.Size(510, 0);
            this.txtGramatura.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtGramatura.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtGramatura.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtGramatura.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGramatura.StateCommon.Border.Rounding = 1;
            this.txtGramatura.StateCommon.Border.Width = 1;
            this.txtGramatura.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGramatura.TabIndex = 61;
            // 
            // cbxNomeCliente
            // 
            this.cbxNomeCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNomeCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNomeCliente.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonGallery;
            this.cbxNomeCliente.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxNomeCliente.DropDownWidth = 416;
            this.cbxNomeCliente.Items.AddRange(new object[] {
            ""});
            this.cbxNomeCliente.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.cbxNomeCliente.Location = new System.Drawing.Point(325, 419);
            this.cbxNomeCliente.Name = "cbxNomeCliente";
            this.cbxNomeCliente.Size = new System.Drawing.Size(401, 37);
            this.cbxNomeCliente.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxNomeCliente.StateCommon.ComboBox.Border.Rounding = 1;
            this.cbxNomeCliente.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.cbxNomeCliente.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateCommon.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxNomeCliente.StateCommon.Item.Border.Rounding = 5;
            this.cbxNomeCliente.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxNomeCliente.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.cbxNomeCliente.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxNomeCliente.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxNomeCliente.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxNomeCliente.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxNomeCliente.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.cbxNomeCliente.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.cbxNomeCliente.StateNormal.Item.Border.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.Item.Border.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxNomeCliente.StateNormal.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.cbxNomeCliente.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomeCliente.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomeCliente.StateTracking.Item.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateTracking.Item.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomeCliente.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cbxNomeCliente.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomeCliente.TabIndex = 63;
            this.cbxNomeCliente.Text = "Escolher Cliente";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(321, 719);
            this.txtCor.Multiline = true;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(510, 0);
            this.txtCor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtCor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtCor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtCor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCor.StateCommon.Border.Rounding = 1;
            this.txtCor.StateCommon.Border.Width = 1;
            this.txtCor.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtCor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold);
            this.txtCor.TabIndex = 60;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(361, 601);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 39);
            this.txtValor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValor.StateCommon.Border.Rounding = 1;
            this.txtValor.StateCommon.Border.Width = 1;
            this.txtValor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.TabIndex = 62;
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
            this.txtPesquisar.TabIndex = 57;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // dgvVendaKrypton
            // 
            this.dgvVendaKrypton.AllowUserToAddRows = false;
            this.dgvVendaKrypton.AllowUserToDeleteRows = false;
            this.dgvVendaKrypton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendaKrypton.Location = new System.Drawing.Point(3, 3);
            this.dgvVendaKrypton.MultiSelect = false;
            this.dgvVendaKrypton.Name = "dgvVendaKrypton";
            this.dgvVendaKrypton.ReadOnly = true;
            this.dgvVendaKrypton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendaKrypton.Size = new System.Drawing.Size(953, 319);
            this.dgvVendaKrypton.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvVendaKrypton.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvVendaKrypton.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvVendaKrypton.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvVendaKrypton.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvVendaKrypton.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvVendaKrypton.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.dgvVendaKrypton.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.dgvVendaKrypton.TabIndex = 56;
            this.dgvVendaKrypton.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendaKrypton_CellEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(3, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 65);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Textos_Venda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 359);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(265, 586);
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
            this.btnSalvar.Location = new System.Drawing.Point(928, 586);
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
            this.btnApagar.Location = new System.Drawing.Point(597, 586);
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
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(319, 521);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(894, 45);
            this.btnAdicionarProduto.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAdicionarProduto.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
            this.btnAdicionarProduto.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnAdicionarProduto.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAdicionarProduto.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarProduto.StateCommon.Border.Rounding = 7;
            this.btnAdicionarProduto.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnAdicionarProduto.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Produtos;
            this.btnAdicionarProduto.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnAdicionarProduto.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnAdicionarProduto.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarProduto.StateNormal.Border.Rounding = 5;
            this.btnAdicionarProduto.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Produtos;
            this.btnAdicionarProduto.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarProduto.StatePressed.Border.Rounding = 5;
            this.btnAdicionarProduto.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnAdicionarProduto.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnAdicionarProduto.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Produtos_Tracking;
            this.btnAdicionarProduto.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAdicionarProduto.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnAdicionarProduto.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarProduto.StateTracking.Border.Rounding = 6;
            this.btnAdicionarProduto.TabIndex = 55;
            this.btnAdicionarProduto.Values.Text = "";
            this.btnAdicionarProduto.Click += new System.EventHandler(this.kryptonButton1_Click);
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
            this.btnSair.Location = new System.Drawing.Point(-3, 368);
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
            this.btnHistórico.Location = new System.Drawing.Point(-3, 280);
            this.btnHistórico.Name = "btnHistórico";
            this.btnHistórico.Size = new System.Drawing.Size(250, 88);
            this.btnHistórico.TabIndex = 59;
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
            this.btnVenda.Location = new System.Drawing.Point(-3, 192);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(250, 88);
            this.btnVenda.TabIndex = 58;
            this.btnVenda.UseVisualStyleBackColor = false;
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
            this.btnCadastro.Location = new System.Drawing.Point(-3, 101);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(250, 88);
            this.btnCadastro.TabIndex = 56;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(26, 33);
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
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Tela_Venda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistórico);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFormaEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNomeCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvVendaKrypton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGramatura;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxNomeCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValor;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDateEntrega;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVenda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxFormaEntrega;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxFormaPagamento;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAnotacao;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnApagar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdicionarProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHistórico;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnCadastro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVoltar;
    }
}