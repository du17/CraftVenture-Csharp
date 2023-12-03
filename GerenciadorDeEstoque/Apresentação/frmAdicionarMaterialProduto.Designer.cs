namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmAdicionarMaterialProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarMaterialProduto));
            this.dgvAdicionarProdutoKrypton = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarProdutoKrypton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdicionarProdutoKrypton
            // 
            this.dgvAdicionarProdutoKrypton.AllowUserToAddRows = false;
            this.dgvAdicionarProdutoKrypton.AllowUserToDeleteRows = false;
            this.dgvAdicionarProdutoKrypton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionarProdutoKrypton.Location = new System.Drawing.Point(47, 12);
            this.dgvAdicionarProdutoKrypton.MultiSelect = false;
            this.dgvAdicionarProdutoKrypton.Name = "dgvAdicionarProdutoKrypton";
            this.dgvAdicionarProdutoKrypton.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAdicionarProdutoKrypton.Size = new System.Drawing.Size(844, 348);
            this.dgvAdicionarProdutoKrypton.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvAdicionarProdutoKrypton.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvAdicionarProdutoKrypton.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvAdicionarProdutoKrypton.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvAdicionarProdutoKrypton.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dgvAdicionarProdutoKrypton.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.dgvAdicionarProdutoKrypton.TabIndex = 54;
            // 
            // btnNovo
            // 
            this.btnNovo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(556, 476);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(280, 48);
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
            this.btnNovo.StateNormal.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.CONFIRMAR;
            this.btnNovo.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnNovo.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnNovo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateNormal.Border.Rounding = 5;
            this.btnNovo.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.CONFIRMAR;
            this.btnNovo.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StatePressed.Border.Rounding = 5;
            this.btnNovo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnNovo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnNovo.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.CONFIRMAR_Tracking;
            this.btnNovo.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNovo.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnNovo.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnNovo.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateTracking.Border.Rounding = 6;
            this.btnNovo.TabIndex = 55;
            this.btnNovo.Values.Text = "";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(139, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(280, 48);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnCancelar.StateCommon.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
            this.btnCancelar.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btnCancelar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnCancelar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateCommon.Border.Rounding = 7;
            this.btnCancelar.StateCommon.Content.Image.ImageColorMap = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Content.Image.ImageColorTo = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnCancelar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.StateNormal.Back.Image")));
            this.btnCancelar.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btnCancelar.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btnCancelar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateNormal.Border.Rounding = 5;
            this.btnCancelar.StatePressed.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Cancelar_Menor;
            this.btnCancelar.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StatePressed.Border.Rounding = 5;
            this.btnCancelar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnCancelar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnCancelar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.Cancelar_Tracking;
            this.btnCancelar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnCancelar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateTracking.Border.Rounding = 6;
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Values.Text = "";
            this.btnCancelar.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Back;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(19, 28);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(22, 31);
            this.btnVoltar.TabIndex = 57;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(20, 366);
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
            this.txtPesquisar.TabIndex = 62;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Pesquisar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(20, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 65);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // frmAdicionarMaterialProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.Adicionar_Material;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvAdicionarProdutoKrypton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarMaterialProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdicionarMaterialProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionarProdutoKrypton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvAdicionarProdutoKrypton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.Button btnVoltar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}