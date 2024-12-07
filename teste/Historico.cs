using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Historico : UserControl
    {
        public Historico()
        {
            InitializeComponent();
        }
        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader DadosConsulta;

        public void listaDenuncia()
        {
            string strSQL, tipo, descricao, lon, lat, rua, num, cidade, bairro;

            strSQL = "SELECT * FROM denuncias;";

            Obj_CmdSQL.CommandText = strSQL;

            DadosConsulta = Obj_CmdSQL.ExecuteReader();
            if (DadosConsulta.HasRows)
            {
                while (DadosConsulta.Read())
                {
                    tipo = DadosConsulta["tipo"].ToString();
                    descricao = DadosConsulta["descricao"].ToString();
                    lon = DadosConsulta["longitude"].ToString();
                    lat = DadosConsulta["latitude"].ToString();
                    cidade = DadosConsulta["cidade"].ToString();
                    num = DadosConsulta["num"].ToString();
                    rua = DadosConsulta["rua"].ToString();
                    bairro = DadosConsulta["bairro"].ToString();

                    dgvDenuncias.Rows.Add(tipo, descricao, lon, lat, rua, num, cidade, bairro);
                }
            }
            if (!DadosConsulta.IsClosed)
            {
                DadosConsulta.Close();
            }
        }
        
       
        
       

        private void Historico_Load(object sender, EventArgs e)
        {
            try
            {
                Obj_Conn.ConnectionString = "Server=localhost;Database=controle_denuncias;User=root;Pwd=4002";


                Obj_Conn.Open();
                Obj_CmdSQL.Connection = Obj_Conn;

                dgvDenuncias.Columns.Add("tipo", "Tipo");
                dgvDenuncias.Columns.Add("descricao", "Descrição");
                dgvDenuncias.Columns.Add("longitude", "Longitude");
                dgvDenuncias.Columns.Add("latitude", "Latitude");
                dgvDenuncias.Columns.Add("rua", "Rua");
                dgvDenuncias.Columns.Add("numero", "Número");
                dgvDenuncias.Columns.Add("cidade", "Cidade");
                dgvDenuncias.Columns.Add("bairro", "Bairro");
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Erro de Conexão ADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}