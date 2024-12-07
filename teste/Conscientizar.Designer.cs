namespace teste
{
    partial class Conscientizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBiomas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.cmbBiomas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlterar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua localidade para verificar o bioma que você está:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(89, 235);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(301, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl2.Location = new System.Drawing.Point(280, 93);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 13);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "Longitude:";
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(253, 109);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(121, 20);
            this.longitude.TabIndex = 20;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1.Location = new System.Drawing.Point(141, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 13);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Latitude:";
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(109, 109);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(121, 20);
            this.latitude.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Você está no bioma:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBiomas
            // 
            this.lblBiomas.AutoSize = true;
            this.lblBiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiomas.Location = new System.Drawing.Point(164, 190);
            this.lblBiomas.Name = "lblBiomas";
            this.lblBiomas.Size = new System.Drawing.Size(0, 20);
            this.lblBiomas.TabIndex = 23;
            this.lblBiomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.label3.Location = new System.Drawing.Point(16, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Escolha um bioma para explorar suas informações detalhadas:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(89, 425);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(301, 25);
            this.btnExplorar.TabIndex = 25;
            this.btnExplorar.Text = "EXPLORAR";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.lblBiomas);
            this.gbPrincipal.Controls.Add(this.cmbBiomas);
            this.gbPrincipal.Controls.Add(this.btnBuscar);
            this.gbPrincipal.Controls.Add(this.btnExplorar);
            this.gbPrincipal.Controls.Add(this.label1);
            this.gbPrincipal.Controls.Add(this.label3);
            this.gbPrincipal.Controls.Add(this.latitude);
            this.gbPrincipal.Controls.Add(this.lbl1);
            this.gbPrincipal.Controls.Add(this.label2);
            this.gbPrincipal.Controls.Add(this.longitude);
            this.gbPrincipal.Controls.Add(this.lbl2);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 25);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(487, 491);
            this.gbPrincipal.TabIndex = 27;
            this.gbPrincipal.TabStop = false;
            // 
            // cmbBiomas
            // 
            this.cmbBiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBiomas.FormattingEnabled = true;
            this.cmbBiomas.Items.AddRange(new object[] {
            "Amazônia",
            "Cerrado",
            "Mata Atlântica",
            "Caatinga",
            "Pantanal",
            "Pampa"});
            this.cmbBiomas.Location = new System.Drawing.Point(89, 385);
            this.cmbBiomas.Name = "cmbBiomas";
            this.cmbBiomas.Size = new System.Drawing.Size(301, 21);
            this.cmbBiomas.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "label4";
            // 
            // txtAlterar
            // 
            this.txtAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.txtAlterar.Location = new System.Drawing.Point(0, 0);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(880, 1167);
            this.txtAlterar.TabIndex = 25;
            this.txtAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtAlterar);
            this.panel1.Location = new System.Drawing.Point(505, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 483);
            this.panel1.TabIndex = 29;
            // 
            // Conscientizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "Conscientizar";
            this.Size = new System.Drawing.Size(980, 560);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBiomas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.ComboBox cmbBiomas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtAlterar;
        private System.Windows.Forms.Panel panel1;
    }
}
