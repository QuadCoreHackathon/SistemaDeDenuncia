namespace teste
{
    partial class Denunciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Denunciar));
            this.lblDenuncia = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rdbCEP = new System.Windows.Forms.RadioButton();
            this.rdbCoordenadas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.Imagem = new System.Windows.Forms.OpenFileDialog();
            this.imageDenuncia = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDenuncia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenuncia
            // 
            resources.ApplyResources(this.lblDenuncia, "lblDenuncia");
            this.lblDenuncia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.lblDenuncia.Name = "lblDenuncia";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            resources.GetString("cmbTipo.Items"),
            resources.GetString("cmbTipo.Items1"),
            resources.GetString("cmbTipo.Items2"),
            resources.GetString("cmbTipo.Items3")});
            resources.ApplyResources(this.cmbTipo, "cmbTipo");
            this.cmbTipo.Name = "cmbTipo";
            // 
            // lblTipo
            // 
            resources.ApplyResources(this.lblTipo, "lblTipo");
            this.lblTipo.Name = "lblTipo";
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.Name = "lblDescricao";
            // 
            // txtDescricao
            // 
            resources.ApplyResources(this.txtDescricao, "txtDescricao");
            this.txtDescricao.Name = "txtDescricao";
            // 
            // rdbCEP
            // 
            resources.ApplyResources(this.rdbCEP, "rdbCEP");
            this.rdbCEP.Checked = true;
            this.rdbCEP.Name = "rdbCEP";
            this.rdbCEP.TabStop = true;
            this.rdbCEP.UseVisualStyleBackColor = true;
            this.rdbCEP.CheckedChanged += new System.EventHandler(this.rdbCEP_CheckedChanged);
            // 
            // rdbCoordenadas
            // 
            resources.ApplyResources(this.rdbCoordenadas, "rdbCoordenadas");
            this.rdbCoordenadas.Name = "rdbCoordenadas";
            this.rdbCoordenadas.TabStop = true;
            this.rdbCoordenadas.UseVisualStyleBackColor = true;
            this.rdbCoordenadas.CheckedChanged += new System.EventHandler(this.rdbCoordenadas_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imageDenuncia);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnCarregarImagem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.lblDescricao);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Controls.Add(this.cmbTipo);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCarregarImagem
            // 
            resources.ApplyResources(this.btnCarregarImagem, "btnCarregarImagem");
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCidade);
            this.groupBox3.Controls.Add(this.txtCidade);
            this.groupBox3.Controls.Add(this.txtLong);
            this.groupBox3.Controls.Add(this.txtLat);
            this.groupBox3.Controls.Add(this.lblNum);
            this.groupBox3.Controls.Add(this.txtNum);
            this.groupBox3.Controls.Add(this.lbl2);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.lbl1);
            this.groupBox3.Controls.Add(this.txtRua);
            this.groupBox3.Controls.Add(this.rdbCoordenadas);
            this.groupBox3.Controls.Add(this.rdbCEP);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lblCidade
            // 
            resources.ApplyResources(this.lblCidade, "lblCidade");
            this.lblCidade.Name = "lblCidade";
            // 
            // txtCidade
            // 
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.Name = "txtCidade";
            // 
            // txtLong
            // 
            resources.ApplyResources(this.txtLong, "txtLong");
            this.txtLong.Name = "txtLong";
            // 
            // txtLat
            // 
            resources.ApplyResources(this.txtLat, "txtLat");
            this.txtLat.Name = "txtLat";
            // 
            // lblNum
            // 
            resources.ApplyResources(this.lblNum, "lblNum");
            this.lblNum.Name = "lblNum";
            // 
            // txtNum
            // 
            resources.ApplyResources(this.txtNum, "txtNum");
            this.txtNum.Name = "txtNum";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // txtBairro
            // 
            resources.ApplyResources(this.txtBairro, "txtBairro");
            this.txtBairro.Name = "txtBairro";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // txtRua
            // 
            resources.ApplyResources(this.txtRua, "txtRua");
            this.txtRua.Name = "txtRua";
            // 
            // Imagem
            // 
            this.Imagem.FileName = "openFileDialog1";
            // 
            // imageDenuncia
            // 
            this.imageDenuncia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.imageDenuncia, "imageDenuncia");
            this.imageDenuncia.Name = "imageDenuncia";
            this.imageDenuncia.TabStop = false;
            // 
            // Denunciar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDenuncia);
            this.Name = "Denunciar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDenuncia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDenuncia;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdbCEP;
        private System.Windows.Forms.RadioButton rdbCoordenadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox imageDenuncia;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.OpenFileDialog Imagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
    }
}
