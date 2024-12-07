namespace teste
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnDenunciar = new System.Windows.Forms.Button();
            this.btnOutros = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEspecies = new System.Windows.Forms.Button();
            this.btnDesmatamento = new System.Windows.Forms.Button();
            this.Incêndios = new System.Windows.Forms.Button();
            this.btnMapa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConcientizar = new System.Windows.Forms.Button();
            this.conscientizar1 = new teste.Conscientizar();
            this.login1 = new teste.Login();
            this.ajuda1 = new teste.Ajuda();
            this.historico1 = new teste.Historico();
            this.gerenciarDenuncia1 = new teste.GerenciarDenuncia();
            this.denunciar1 = new teste.Denunciar();
            this.mapa1 = new teste.Mapa();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConcientizar);
            this.panel1.Controls.Add(this.btnAjuda);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnGerenciar);
            this.panel1.Controls.Add(this.btnDenunciar);
            this.panel1.Controls.Add(this.btnOutros);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnEspecies);
            this.panel1.Controls.Add(this.btnDesmatamento);
            this.panel1.Controls.Add(this.Incêndios);
            this.panel1.Controls.Add(this.btnMapa);
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 486);
            this.panel1.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.Location = new System.Drawing.Point(0, 400);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(198, 42);
            this.btnAjuda.TabIndex = 13;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click_1);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(0, 251);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(198, 42);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Histórico de Denúncias";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnDenunciar
            // 
            this.btnDenunciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnDenunciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDenunciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDenunciar.ForeColor = System.Drawing.Color.White;
            this.btnDenunciar.Location = new System.Drawing.Point(0, 167);
            this.btnDenunciar.Name = "btnDenunciar";
            this.btnDenunciar.Size = new System.Drawing.Size(198, 42);
            this.btnDenunciar.TabIndex = 10;
            this.btnDenunciar.Text = "Denunciar";
            this.btnDenunciar.UseVisualStyleBackColor = false;
            this.btnDenunciar.Click += new System.EventHandler(this.btnDenunciar_Click);
            // 
            // btnOutros
            // 
            this.btnOutros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(180)))), ((int)(((byte)(195)))));
            this.btnOutros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutros.Location = new System.Drawing.Point(0, 137);
            this.btnOutros.Name = "btnOutros";
            this.btnOutros.Size = new System.Drawing.Size(198, 30);
            this.btnOutros.TabIndex = 9;
            this.btnOutros.Text = "Outros";
            this.btnOutros.UseVisualStyleBackColor = false;
            this.btnOutros.Click += new System.EventHandler(this.btnOutros_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 442);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 42);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEspecies
            // 
            this.btnEspecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(180)))), ((int)(((byte)(195)))));
            this.btnEspecies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecies.Location = new System.Drawing.Point(0, 107);
            this.btnEspecies.Name = "btnEspecies";
            this.btnEspecies.Size = new System.Drawing.Size(198, 30);
            this.btnEspecies.TabIndex = 3;
            this.btnEspecies.Text = "Espécies";
            this.btnEspecies.UseVisualStyleBackColor = false;
            this.btnEspecies.Click += new System.EventHandler(this.btnEspecies_Click);
            // 
            // btnDesmatamento
            // 
            this.btnDesmatamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(180)))), ((int)(((byte)(195)))));
            this.btnDesmatamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesmatamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmatamento.Location = new System.Drawing.Point(0, 77);
            this.btnDesmatamento.Name = "btnDesmatamento";
            this.btnDesmatamento.Size = new System.Drawing.Size(198, 30);
            this.btnDesmatamento.TabIndex = 2;
            this.btnDesmatamento.Text = "Desmatamento";
            this.btnDesmatamento.UseVisualStyleBackColor = false;
            this.btnDesmatamento.Click += new System.EventHandler(this.btnDesmatamento_Click);
            // 
            // Incêndios
            // 
            this.Incêndios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(180)))), ((int)(((byte)(195)))));
            this.Incêndios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Incêndios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Incêndios.ForeColor = System.Drawing.Color.Black;
            this.Incêndios.Location = new System.Drawing.Point(0, 47);
            this.Incêndios.Name = "Incêndios";
            this.Incêndios.Size = new System.Drawing.Size(198, 30);
            this.Incêndios.TabIndex = 1;
            this.Incêndios.Text = "Incêndios";
            this.Incêndios.UseVisualStyleBackColor = false;
            this.Incêndios.Click += new System.EventHandler(this.Incêndios_Click);
            // 
            // btnMapa
            // 
            this.btnMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnMapa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMapa.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMapa.ForeColor = System.Drawing.Color.White;
            this.btnMapa.Location = new System.Drawing.Point(0, 0);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(198, 47);
            this.btnMapa.TabIndex = 0;
            this.btnMapa.Text = "Mapa de Denúncias";
            this.btnMapa.UseVisualStyleBackColor = false;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 75);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(-17, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDA\r\nSISTEMA DE DENÚNICAS AMBIENTAIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConcientizar
            // 
            this.btnConcientizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnConcientizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConcientizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConcientizar.ForeColor = System.Drawing.Color.White;
            this.btnConcientizar.Location = new System.Drawing.Point(0, 358);
            this.btnConcientizar.Name = "btnConcientizar";
            this.btnConcientizar.Size = new System.Drawing.Size(198, 42);
            this.btnConcientizar.TabIndex = 14;
            this.btnConcientizar.Text = "Cosncientização";
            this.btnConcientizar.UseVisualStyleBackColor = false;
            this.btnConcientizar.Click += new System.EventHandler(this.btnConcientizar_Click);
            // 
            // conscientizar1
            // 
            this.conscientizar1.Location = new System.Drawing.Point(200, 0);
            this.conscientizar1.Name = "conscientizar1";
            this.conscientizar1.Size = new System.Drawing.Size(980, 560);
            this.conscientizar1.TabIndex = 8;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(200, 0);
            this.login1.Name = "login1";
            this.login1.NomeUsuarioLogado = null;
            this.login1.Size = new System.Drawing.Size(980, 560);
            this.login1.TabIndex = 7;
            // 
            // ajuda1
            // 
            this.ajuda1.Location = new System.Drawing.Point(200, 0);
            this.ajuda1.Name = "ajuda1";
            this.ajuda1.Size = new System.Drawing.Size(980, 560);
            this.ajuda1.TabIndex = 6;
            // 
            // historico1
            // 
            this.historico1.Location = new System.Drawing.Point(200, 0);
            this.historico1.Name = "historico1";
            this.historico1.Size = new System.Drawing.Size(980, 560);
            this.historico1.TabIndex = 5;
            // 
            // gerenciarDenuncia1
            // 
            this.gerenciarDenuncia1.Location = new System.Drawing.Point(200, 0);
            this.gerenciarDenuncia1.Name = "gerenciarDenuncia1";
            this.gerenciarDenuncia1.Size = new System.Drawing.Size(980, 560);
            this.gerenciarDenuncia1.TabIndex = 4;
            // 
            // denunciar1
            // 
            this.denunciar1.Location = new System.Drawing.Point(200, 0);
            this.denunciar1.Name = "denunciar1";
            this.denunciar1.Size = new System.Drawing.Size(980, 560);
            this.denunciar1.TabIndex = 2;
            // 
            // mapa1
            // 
            this.mapa1.Atualizar = "0";
            this.mapa1.Location = new System.Drawing.Point(200, 0);
            this.mapa1.MyString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE latitude" +
    " IS NOT NULL AND longitude IS NOT NULL";
            this.mapa1.Name = "mapa1";
            this.mapa1.Size = new System.Drawing.Size(980, 559);
            this.mapa1.TabIndex = 1;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.btnGerenciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Location = new System.Drawing.Point(0, 209);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(198, 42);
            this.btnGerenciar.TabIndex = 11;
            this.btnGerenciar.Text = "Gerenciar denúncias";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.conscientizar1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.ajuda1);
            this.Controls.Add(this.historico1);
            this.Controls.Add(this.gerenciarDenuncia1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.denunciar1);
            this.Controls.Add(this.mapa1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDA - SISTEMA DE DENÚNCIAS AMBIENTAIS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.Button btnEspecies;
        private System.Windows.Forms.Button btnDesmatamento;
        private System.Windows.Forms.Button Incêndios;
        private System.Windows.Forms.Button btnLogin;
        private Mapa mapa1;
        private Denunciar denunciar1;
        private System.Windows.Forms.Panel panel2;
        private GerenciarDenuncia gerenciarDenuncia1;
        private Historico historico1;
        private Ajuda ajuda1;
        private Login login1;
        private System.Windows.Forms.Button btnOutros;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnDenunciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnConcientizar;
        private Conscientizar conscientizar1;
        private System.Windows.Forms.Button btnGerenciar;
    }
}

