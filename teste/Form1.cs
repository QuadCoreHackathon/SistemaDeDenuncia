using System;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mapa1.BringToFront();

            login1.AlterarTextoBotao += MeuUserControl_AlterarTextoBotao;
            login1.AlterarTextoBotaoSair += MeuUserControl_AlterarSair;
        }

        private void MeuUserControl_AlterarTextoBotao(object sender, EventArgs e)
        {
            string nomeUsuario = login1.NomeUsuarioLogado;
            btnLogin.Text = nomeUsuario;
        }
        private void MeuUserControl_AlterarSair(object sender, EventArgs e)
        {
            // Altera o texto do botão no formulário principal
            btnLogin.Text = "Login";
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            mapa1.BringToFront();
            mapa1.Atualizar = "1";
            // Consulta SQL que agora inclui a coluna 'tipo'
             mapa1.MyString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE latitude IS NOT NULL AND longitude IS NOT NULL";
            mapa1.Mapa_Load(sender, e);
        }

        private void btnDenunciar_Click(object sender, EventArgs e)
        {
            denunciar1.BringToFront();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            gerenciarDenuncia1.BringToFront();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            historico1.BringToFront();
            historico1.listaDenuncia();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login1.BringToFront();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            ajuda1.BringToFront();
        }

        private void Incêndios_Click(object sender, EventArgs e)
        {
            mapa1.BringToFront();
            mapa1.Atualizar = "1";
            mapa1.MyString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE tipo = 'Incêndio'";
            mapa1.Mapa_Load(sender, e);
        }


        private void btnDesmatamento_Click(object sender, EventArgs e)
        {
            mapa1.BringToFront();
            mapa1.Atualizar = "1";
            mapa1.MyString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE tipo = 'Desmatamento'";
            mapa1.Mapa_Load(sender, e);
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            mapa1.BringToFront();
            mapa1.Atualizar = "1";
            mapa1.MyString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE tipo = 'Encontro com animais'";
            mapa1.Mapa_Load(sender,e);
        }

        private void btnOutros_Click(object sender, EventArgs e)
        {
            mapa1.BringToFront();
            mapa1.Atualizar = "1";
            mapa1.MyString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE tipo = 'Outros'";
            mapa1.Mapa_Load(sender, e);
        }

        private void btnAjuda_Click_1(object sender, EventArgs e)
        {
            ajuda1.BringToFront();
        }

        private void btnConcientizar_Click(object sender, EventArgs e)
        {
            conscientizar1.BringToFront();
        }
    }
}