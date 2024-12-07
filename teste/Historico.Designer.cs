namespace teste
{
    partial class Historico
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDenuncias = new System.Windows.Forms.DataGridView();
            this.lblDenuncia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenuncias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDenuncias
            // 
            this.dgvDenuncias.AllowUserToAddRows = false;
            this.dgvDenuncias.AllowUserToDeleteRows = false;
            this.dgvDenuncias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDenuncias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDenuncias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenuncias.Location = new System.Drawing.Point(39, 66);
            this.dgvDenuncias.MultiSelect = false;
            this.dgvDenuncias.Name = "dgvDenuncias";
            this.dgvDenuncias.ReadOnly = true;
            this.dgvDenuncias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvDenuncias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDenuncias.Size = new System.Drawing.Size(900, 417);
            this.dgvDenuncias.TabIndex = 23;
            // 
            // lblDenuncia
            // 
            this.lblDenuncia.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblDenuncia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.lblDenuncia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDenuncia.Location = new System.Drawing.Point(0, 20);
            this.lblDenuncia.Name = "lblDenuncia";
            this.lblDenuncia.Size = new System.Drawing.Size(980, 43);
            this.lblDenuncia.TabIndex = 21;
            this.lblDenuncia.Text = "Histórico geral de denúncias";
            this.lblDenuncia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDenuncias);
            this.Controls.Add(this.lblDenuncia);
            this.Name = "Historico";
            this.Size = new System.Drawing.Size(980, 560);
            this.Load += new System.EventHandler(this.Historico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenuncias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDenuncias;
        private System.Windows.Forms.Label lblDenuncia;
    }
}
