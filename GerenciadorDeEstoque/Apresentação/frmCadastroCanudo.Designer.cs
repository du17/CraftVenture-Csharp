﻿namespace GerenciadorDeEstoque.Apresentação
{
    partial class frmCadastroCanudo
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
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLimpar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtValor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistórico = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txtQuantidade = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(776, 592);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.OverrideFocus.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.OverrideFocus.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSalvar.Size = new System.Drawing.Size(463, 66);
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
            this.btnSalvar.StateTracking.Border.Rounding = 7;
            this.btnSalvar.TabIndex = 60;
            this.btnSalvar.Values.Text = "";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(293, 593);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(463, 66);
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
            this.btnLimpar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnLimpar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(189)))), ((int)(((byte)(243)))));
            this.btnLimpar.StateTracking.Back.Image = global::GerenciadorDeEstoque.Properties.Resources.LIMPAR;
            this.btnLimpar.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnLimpar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpar.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnLimpar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLimpar.StateTracking.Border.Rounding = 7;
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Values.Text = "";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(565, 256);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(182, 54);
            this.txtValor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtValor.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtValor.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtValor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValor.StateCommon.Border.Rounding = 5;
            this.txtValor.StateCommon.Border.Width = 1;
            this.txtValor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.txtValor.TabIndex = 58;
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
            this.btnSair.TabIndex = 57;
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
            this.btnHistórico.TabIndex = 56;
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
            this.btnVenda.TabIndex = 55;
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
            this.btnEstoque.TabIndex = 54;
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
            this.btnCadastro.TabIndex = 53;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(518, 176);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(200, 54);
            this.txtQuantidade.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtQuantidade.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtQuantidade.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtQuantidade.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQuantidade.StateCommon.Border.Rounding = 5;
            this.txtQuantidade.StateCommon.Border.Width = 1;
            this.txtQuantidade.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.TabIndex = 52;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(519, 102);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(302, 54);
            this.txtCor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.txtCor.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtCor.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtCor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCor.StateCommon.Border.Rounding = 5;
            this.txtCor.StateCommon.Border.Width = 1;
            this.txtCor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.txtCor.TabIndex = 51;
            // 
            // frmCadastroCanudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciadorDeEstoque.Properties.Resources.CadastroCanudo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistórico);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtCor);
            this.DoubleBuffered = true;
            this.Name = "frmCadastroCanudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuantidade;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCor;
    }
}