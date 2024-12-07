namespace teste
{
    partial class GerenciarDenuncia
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
            this.lblDenuncia = new System.Windows.Forms.Label();
            this.btnAlt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenuncia
            // 
            this.lblDenuncia.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblDenuncia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.lblDenuncia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDenuncia.Location = new System.Drawing.Point(0, 20);
            this.lblDenuncia.Name = "lblDenuncia";
            this.lblDenuncia.Size = new System.Drawing.Size(980, 43);
            this.lblDenuncia.TabIndex = 1;
            this.lblDenuncia.Text = "Gerencie suas denúncias";
            this.lblDenuncia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.DarkGray;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlt.Location = new System.Drawing.Point(39, 495);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(127, 37);
            this.btnAlt.TabIndex = 18;
            this.btnAlt.Text = "Alterar Dados";
            this.btnAlt.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 400);
            this.dataGridView1.TabIndex = 20;
            // 
            // GerenciarDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.lblDenuncia);
            this.Name = "GerenciarDenuncia";
            this.Size = new System.Drawing.Size(980, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDenuncia;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
