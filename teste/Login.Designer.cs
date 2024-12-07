namespace teste
{
    partial class Login
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadastrarSenha = new System.Windows.Forms.TextBox();
            this.txtCadastrarUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.btn_deslogar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.gbPerfil.SuspendLayout();
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
            this.lblDenuncia.TabIndex = 23;
            this.lblDenuncia.Text = "Faça seu login";
            this.lblDenuncia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblCadastro);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.btnEntrar);
            this.gbLogin.Controls.Add(this.txtSenha);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.lblSenha);
            this.gbLogin.Controls.Add(this.lblUsuario);
            this.gbLogin.Location = new System.Drawing.Point(222, 119);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(536, 264);
            this.gbLogin.TabIndex = 24;
            this.gbLogin.TabStop = false;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.ForeColor = System.Drawing.Color.Navy;
            this.lblCadastro.Location = new System.Drawing.Point(317, 139);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(73, 13);
            this.lblCadastro.TabIndex = 7;
            this.lblCadastro.Text = "CADASTRAR";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ainda não possui cadastro?";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(207, 197);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(102, 30);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(173, 106);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(223, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(173, 61);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(107, 106);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(100, 59);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.txtCPF);
            this.gbCadastro.Controls.Add(this.btnCadastrar);
            this.gbCadastro.Controls.Add(this.label6);
            this.gbCadastro.Controls.Add(this.btnVoltar);
            this.gbCadastro.Controls.Add(this.txtNomeCompleto);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.txtConfirmarSenha);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.txtCadastrarSenha);
            this.gbCadastro.Controls.Add(this.txtCadastrarUser);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.label5);
            this.gbCadastro.Location = new System.Drawing.Point(216, 86);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(536, 322);
            this.gbCadastro.TabIndex = 25;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(174, 209);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(223, 20);
            this.txtCPF.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(294, 266);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 30);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "CPF:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(174, 266);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 30);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(174, 172);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(223, 20);
            this.txtNomeCompleto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome completo:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(174, 134);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(223, 20);
            this.txtConfirmarSenha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirme sua senha:";
            // 
            // txtCadastrarSenha
            // 
            this.txtCadastrarSenha.Location = new System.Drawing.Point(173, 98);
            this.txtCadastrarSenha.Name = "txtCadastrarSenha";
            this.txtCadastrarSenha.Size = new System.Drawing.Size(223, 20);
            this.txtCadastrarSenha.TabIndex = 3;
            // 
            // txtCadastrarUser
            // 
            this.txtCadastrarUser.Location = new System.Drawing.Point(173, 61);
            this.txtCadastrarUser.Name = "txtCadastrarUser";
            this.txtCadastrarUser.Size = new System.Drawing.Size(223, 20);
            this.txtCadastrarUser.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuário:";
            // 
            // gbPerfil
            // 
            this.gbPerfil.Controls.Add(this.btn_deslogar);
            this.gbPerfil.Controls.Add(this.label11);
            this.gbPerfil.Location = new System.Drawing.Point(169, 75);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(616, 350);
            this.gbPerfil.TabIndex = 26;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Visible = false;
            // 
            // btn_deslogar
            // 
            this.btn_deslogar.Location = new System.Drawing.Point(260, 179);
            this.btn_deslogar.Name = "btn_deslogar";
            this.btn_deslogar.Size = new System.Drawing.Size(102, 30);
            this.btn_deslogar.TabIndex = 25;
            this.btn_deslogar.Text = "Sair";
            this.btn_deslogar.UseVisualStyleBackColor = true;
            this.btn_deslogar.Click += new System.EventHandler(this.btn_deslogar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "USUÁRIO LOGADO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.lblDenuncia);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(980, 560);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDenuncia;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtCadastrarSenha;
        private System.Windows.Forms.TextBox txtCadastrarUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.Button btn_deslogar;
        private System.Windows.Forms.Label label11;
    }
}
