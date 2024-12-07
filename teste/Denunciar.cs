using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using System.Threading.Tasks;

namespace teste
{
    public partial class Denunciar : UserControl
    {
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        public Denunciar()
        {
            InitializeComponent();
            digitaNum(txtNum);
        }


        private void RegistrarBanco()
        {
            if(Login.login == 1)
            {
                try
                {
                    string strSQL;
                    string relativePath = "";

                    if (imageDenuncia.Image != null)
                    {
                        // Caminho completo da imagem selecionada
                        string sourcePath = Imagem.FileName;

                        // Nome do arquivo
                        string fileName = Path.GetFileName(sourcePath);

                        // Caminho do diretório de destino (dentro da aplicação)
                        string destinationPath = Path.Combine(Application.StartupPath, "images", fileName);

                        // Verificar se a pasta existe; criar se não existir
                        string folderPath = Path.Combine(Application.StartupPath, "images");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        // Copiar a imagem para o diretório
                        File.Copy(sourcePath, destinationPath, true);

                        // Salvar o caminho relativo no banco de dados
                        relativePath = $"{fileName}";
                    }

                    Obj_Conn.ConnectionString = "Server=localhost;Database=controle_denuncias;user=root;Pwd=4002;";
                    if (Obj_Conn.State != ConnectionState.Open)
                    {
                        Obj_Conn.Open();
                    }

                    // Definir o comando SQL
                    strSQL = "INSERT INTO denuncias (tipo, descricao, rua, bairro, num, cidade, latitude, longitude, imagem) " +
                             "VALUES(@Tipo, @Descricao, @Rua, @Bairro, @Num, @Cidade, @Latitude, @Longitude, @Imagem)";
                    Obj_CmdSQL.Connection = Obj_Conn;
                    Obj_CmdSQL.CommandText = strSQL;

                    // Limpar parâmetros antes de adicionar novos
                    Obj_CmdSQL.Parameters.Clear();

                    // Adicionar parâmetros
                    Obj_CmdSQL.Parameters.AddWithValue("@Tipo", cmbTipo.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Rua", txtRua.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Num", txtNum.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Latitude", txtLat.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Longitude", txtLong.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Imagem", relativePath);

                    // Executar o comando
                    Obj_CmdSQL.ExecuteNonQuery();
                    MessageBox.Show("Denúncia cadastrada!");
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
                return;
            }
            else { MessageBox.Show("Realize o login para realizar sua denúncia."); }
            
        }

        private async Task listarLoc(object sender, EventArgs e)
        {
            try
            {
                var rua = txtRua.Text;
                var cidade = txtCidade.Text;

                // Criando o cliente
                var client = new RestClient("https://nominatim.openstreetmap.org/search");

                // Criando a requisição e configurando o método GET
                var request = new RestRequest();
                request.AddParameter("street", rua);
                request.AddParameter("city", cidade);
                request.AddParameter("format", "json");

                // Enviando a requisição
                var response = await client.ExecuteAsync(request, Method.Get);

                if (response.IsSuccessful)
                {
                    var result = JArray.Parse(response.Content);
                    if (result.Count > 0)
                    {
                        var primeiroResultado = result[0];
                        txtLat.Text = $"{primeiroResultado["lat"]}";
                        txtLong.Text = $"{primeiroResultado["lon"]}";
                    }
                    else
                    {
                        txtDescricao.Text = "Nenhum local encontrado.";
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao buscar localidade.", "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro");
            }
        }

        private void digitaCord(System.Windows.Forms.TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                System.Windows.Forms.TextBox currentTextBox = sender as System.Windows.Forms.TextBox;

                // Permite dígitos, backspace e ponto decimal
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != '-')
                {
                    e.Handled = true; // Bloqueia o caractere
                }

                // Permite o sinal negativo apenas no início
                if (e.KeyChar == '-' && currentTextBox.Text.Length > 0)
                {
                    e.Handled = true;
                }

                // Impede múltiplos pontos decimais
                if (e.KeyChar == '.' && currentTextBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            };
        }

        private void digitaNum(System.Windows.Forms.TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                System.Windows.Forms.TextBox currentTextBox = sender as System.Windows.Forms.TextBox;

                // Permite dígitos, backspace e ponto decimal
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back )
                {
                    e.Handled = true; // Bloqueia o caractere
                }

            };
        }

        private void rdbCEP_CheckedChanged(object sender, EventArgs e)
        {
            lblNum.Visible = true;
            txtNum.Visible = true;
            lblCidade.Visible = true;
            txtCidade.Visible = true;
            txtLat.Visible = false;
            txtLong.Visible = false;
            txtRua.Visible = true;
            txtBairro.Visible = true;
            lbl1.Text = "Rua / Av.:";
            lbl2.Text = "Bairro:";
            txtLat.Clear();
            txtLong.Clear();
            digitaNum(txtNum);
        }

        private void rdbCoordenadas_CheckedChanged(object sender, EventArgs e)
        {
            lblNum.Visible = false;
            txtNum.Visible = false;
            lblCidade.Visible=false;
            txtCidade.Visible = false;
            txtLat.Visible = true;
            txtLong.Visible = true;
            txtRua.Visible = false;
            txtBairro.Visible = false;
            lbl1.Text = "Latitude:";
            lbl2.Text = "Longitude:";
            txtRua.Clear();
            txtBairro.Clear();
            txtNum.Clear();
            txtCidade.Clear();
            digitaCord(txtLat);
            digitaCord(txtLong);
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            if (Imagem.ShowDialog() == DialogResult.OK)
            {
                imageDenuncia.Load(Imagem.FileName);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            imageDenuncia.Image = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = -1;
            txtRua.Clear();
            txtBairro.Clear();
            txtLong.Clear();
            txtLat.Clear();
            txtNum.Clear();
            txtCidade.Clear();
            txtDescricao.Clear();
            btnExcluir.PerformClick();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex != -1 && txtDescricao.Text != "")
            {
                if (txtRua.Text != "" && txtBairro.Text != "" && txtNum.Text != "" && txtCidade.Text != "")
                {
                    await listarLoc(sender, e); // Aguarda a latitude e longitude serem preenchidas
                }
                else if(txtLat.Text == "" && txtLong.Text == "")
                {
                    MessageBox.Show("Complete todos os campos para denunciar.");
                    return; // Interrompe a execução se os campos estiverem incompletos
                }

                RegistrarBanco(); // Somente executado após os campos necessários estarem preenchidos
                btnLimpar.PerformClick();
               
            }
            else
            {
                MessageBox.Show("Complete todos os campos antes de salvar.");
            }
        }
    }
}
