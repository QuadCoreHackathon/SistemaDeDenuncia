using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    
    public partial class Login : UserControl
    {
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        public event EventHandler AlterarTextoBotao;
        public event EventHandler AlterarTextoBotaoSair;
        public string NomeUsuarioLogado { get; set; } // Propriedade para armazenar o nome do usuário

        public static int login { get; set; } = 0; // Variável estática


        public void verificaLogin()
        {
            if (login == 0)
            {
                gbLogin.Visible = true;
                gbPerfil.Visible = false;
            }
            else
            {
                try
                {
                    if (Obj_Conn.State == ConnectionState.Open)
                    {
                        Obj_Conn.Close();
                    }

                    Obj_Conn.ConnectionString = "Server=localhost;Database=controle_denuncias;user=root;Pwd=4002;";
                    Obj_Conn.Open();

                    // Consultar os dados do usuário logado
                    string strSQL = "SELECT usuario, nome, cpf FROM usuarios WHERE usuario = @Usuario";
                    Obj_CmdSQL.Connection = Obj_Conn;
                    Obj_CmdSQL.CommandText = strSQL;
                    Obj_CmdSQL.Parameters.Clear();
                    Obj_CmdSQL.Parameters.AddWithValue("@Usuario", NomeUsuarioLogado);

                    using (MySqlDataReader reader = Obj_CmdSQL.ExecuteReader())
                    {
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados do usuário: " + ex.Message, "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Obj_Conn.State == ConnectionState.Open)
                    {
                        Obj_Conn.Close();
                    }
                }

                lblDenuncia.Text = "Dados do Usuário";
                gbPerfil.Visible = true;
                gbCadastro.Visible = false;
                gbLogin.Visible = false;
            }
        }



        public Login()
        {
            InitializeComponent();
            login = 0;
            txtSenha.PasswordChar = '*';
            txtCadastrarSenha.PasswordChar = '*';
            txtConfirmarSenha.PasswordChar = '*';
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            lblDenuncia.Text = "Faça seu login";
            gbCadastro.Visible=false;
            gbLogin.Visible=true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text != txtCadastrarSenha.Text)
            {
                MessageBox.Show("Os campos senha e confirme sua senha devem ser iguais.");
            }
            else if (txtCadastrarUser.Text != "" && txtCadastrarSenha.Text != "" && txtConfirmarSenha.Text != "" && txtNomeCompleto.Text != "" && txtCPF.Text != "")
            {
                try
                {
                    string strSQL;

                    Obj_Conn.ConnectionString = "Server=localhost;Database=controle_denuncias;user=root;Pwd=4002;";
                    if (Obj_Conn.State != ConnectionState.Open)
                    {
                        Obj_Conn.Open();
                    }

                    // Verificar se o usuário já existe
                    strSQL = "SELECT COUNT(*) FROM usuarios WHERE usuario = @Usuario";
                    Obj_CmdSQL.Connection = Obj_Conn;
                    Obj_CmdSQL.CommandText = strSQL;
                    Obj_CmdSQL.Parameters.Clear();
                    Obj_CmdSQL.Parameters.AddWithValue("@Usuario", txtCadastrarUser.Text);

                    int userExists = Convert.ToInt32(Obj_CmdSQL.ExecuteScalar());

                    if (userExists > 0)
                    {
                        MessageBox.Show("Já existe um usuário com este nome. Escolha outro nome de usuário.");
                        return;
                    }

                    // Caso o usuário não exista, prosseguir com o cadastro
                    strSQL = "INSERT INTO usuarios (usuario, senha, nome, cpf) " +
                             "VALUES(@Usuario, @Senha, @Nome, @Cpf)";
                    Obj_CmdSQL.CommandText = strSQL;
                    Obj_CmdSQL.Parameters.Clear();
                    Obj_CmdSQL.Parameters.AddWithValue("@Usuario", txtCadastrarUser.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Senha", txtCadastrarSenha.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Nome", txtNomeCompleto.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@CPF", txtCPF.Text);

                    Obj_CmdSQL.ExecuteNonQuery();

                    MessageBox.Show("Usuário cadastrado com sucesso.");
                    NomeUsuarioLogado = txtCadastrarUser.Text;
                    AlterarTextoBotao?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Erro de Inclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Obj_Conn.State == ConnectionState.Open)
                    {
                        Obj_Conn.Close();
                    }
                }

                login = 1;
                verificaLogin();

                return;
            }
            else
            {
                MessageBox.Show("Complete todos os campos para realizar seu cadastro.");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                try
                {
                    string strSQL;

                    Obj_Conn.ConnectionString = "Server=localhost;Database=controle_denuncias;user=root;Pwd=4002;";
                    if (Obj_Conn.State != ConnectionState.Open)
                    {
                        Obj_Conn.Open();
                    }

                    // Definir o comando SQL para verificar o login
                    strSQL = "SELECT COUNT(*) FROM usuarios WHERE usuario = @Usuario AND senha = @Senha";
                    Obj_CmdSQL.Connection = Obj_Conn;
                    Obj_CmdSQL.CommandText = strSQL;

                    // Limpar parâmetros antes de adicionar novos
                    Obj_CmdSQL.Parameters.Clear();

                    // Adicionar parâmetros
                    Obj_CmdSQL.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Senha", txtSenha.Text);

                    // Executar o comando e obter o resultado
                    int resultado = Convert.ToInt32(Obj_CmdSQL.ExecuteScalar());

                    if (resultado > 0)
                    {
                        // Login bem-sucedido
                        login = 1;
                        verificaLogin();
                    }
                    else
                    {
                        // Login ou senha inválidos
                        MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    NomeUsuarioLogado = txtUsuario.Text;
                    txtUsuario.Text = "";
                    txtSenha.Text = "";

                    AlterarTextoBotao?.Invoke(this, EventArgs.Empty);
                    



                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro: " + Erro.Message, "Erro de Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Obj_Conn.State == ConnectionState.Open)
                    {
                        Obj_Conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos de usuário e senha.", "Campos Obrigatórios",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            lblDenuncia.Text = "Faça seu cadastro";
            gbLogin.Visible = false;
            gbCadastro.Visible = true;

        }

        private void btn_deslogar_Click(object sender, EventArgs e)
        {
            login = 0;
            gbLogin.Visible = true;
            gbPerfil.Visible = false;
            NomeUsuarioLogado = null;
            AlterarTextoBotaoSair?.Invoke(this, EventArgs.Empty);
        }
    }
}
