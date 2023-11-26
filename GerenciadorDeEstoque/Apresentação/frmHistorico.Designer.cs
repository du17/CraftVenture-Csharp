
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
            this.kryptonDataTesteRenda = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataTesteRenda)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataTesteRenda
            // 
            this.kryptonDataTesteRenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataTesteRenda.Location = new System.Drawing.Point(110, 54);
            this.kryptonDataTesteRenda.Name = "kryptonDataTesteRenda";
            this.kryptonDataTesteRenda.Size = new System.Drawing.Size(573, 251);
            this.kryptonDataTesteRenda.TabIndex = 0;
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonDataTesteRenda);
            this.Name = "frmHistorico";
            this.Text = "frmHistorico";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataTesteRenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataTesteRenda;
    }
}