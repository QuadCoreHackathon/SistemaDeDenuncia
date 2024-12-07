using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace teste
{
    public partial class Mapa : UserControl
    {
        private GMapControl gMapControl;
        private GMapOverlay markersOverlay;
        private string myString = "SELECT latitude, longitude, descricao, tipo, cidade FROM denuncias WHERE latitude IS NOT NULL AND longitude IS NOT NULL";
        private string atualizar = "0";

        public Mapa()
        {
            InitializeComponent();

            // Configuração do controle GMap
            gMapControl = new GMapControl
            {
                Dock = DockStyle.Fill,
                MapProvider = GMapProviders.OpenStreetMap,
                CanDragMap = true,
            };

            // Inicializa a sobreposição de marcadores
            markersOverlay = new GMapOverlay("markers");

            // Adiciona o controle ao formulário
            this.Controls.Add(gMapControl);
        }

        public string MyString
        {
            get { return myString; }
            set { myString = value; }
        }

        public string Atualizar
        {
            get { return atualizar; }
            set { atualizar = value; }
        }

        public void Mapa_Load(object sender, EventArgs e)
        {
            // Configurar o modo de acesso aos mapas (Server e Cache)
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // Configurar o provedor de mapas
            gMapControl.MapProvider = OpenStreetMapProvider.Instance;

            gMapControl.Position = new PointLatLng(-14.2350, -51.9253); // Centro aproximado do Brasil
            gMapControl.MinZoom = 4;
            gMapControl.MaxZoom = 20;
            gMapControl.Zoom = 4; // Ajuste para um zoom inicial menor
            gMapControl.ShowCenter = false; // Não mostrar o marcador central

            // Definir os limites de arrasto (bounding box) - Aumentando ainda mais a parte superior
            gMapControl.BoundsOfMap = new RectLatLng(
                10.0, // Latitude superior bem mais ao norte
                -74.0, // Longitude esquerda (oeste)
                50.0, // Largura (diferença de longitudes)
                80.0 // Aumenta ainda mais a altura para mostrar mais da parte norte
            );

            // Limpar e redefinir os marcadores se necessário
            if (atualizar == "1" || atualizar == "0")
            {
                if(atualizar != "0")
                {
                    // Remove a sobreposição do controle para evitar referências antigas
                    gMapControl.Overlays.Remove(markersOverlay);

                }

                // Limpa os marcadores
                markersOverlay.Markers.Clear();

                // Adiciona novamente a sobreposição ao mapa
                gMapControl.Overlays.Add(markersOverlay);

                // Reseta o valor do atualizar
                atualizar = "0";
            }
           
            // Carregar os marcadores do banco de dados
            LoadMarkersFromDatabase();

            
        }


        public void LoadMarkersFromDatabase()
        {
            try
            {
                
                // Configuração da conexão com o banco de dados
                string connectionString = "Server=localhost;Database=controle_denuncias;User=root;Password=4002;";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                   

                    using (var command = new MySqlCommand(myString, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                // Converte os valores de latitude e longitude
                                double latitude = double.Parse(reader["latitude"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                                double longitude = double.Parse(reader["longitude"].ToString(), System.Globalization.CultureInfo.InvariantCulture);

                                // Lê a descrição e tipo da denúncia
                                string descricao = reader["descricao"].ToString();
                                string tipoDenuncia = reader["tipo"].ToString();
                                string cidade = reader["cidade"].ToString();

                                // Adiciona o marcador ao mapa com o tipo de denúncia
                                AddMarker(latitude, longitude, descricao, tipoDenuncia, cidade);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Erro de formatação nos dados: Latitude={reader["latitude"]}, Longitude={reader["longitude"]}");
                                continue; // Ignora o registro com erro
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMarker(double lat, double lng, string title, string tipoDenuncia, string cidade)
        {
            // Cria o marcador com ícone personalizado com base no tipo da denúncia
            GMarkerGoogleType markerType;

            if (tipoDenuncia == "Incêndio")
            {
                // Usando marcador vermelho para "Incêndio"
                markerType = GMarkerGoogleType.red_pushpin;
            }
            else if (tipoDenuncia == "Desmatamento")
            {
                // Usando marcador verde para "Desmatamento"
                markerType = GMarkerGoogleType.green_pushpin;
            }
            else if (tipoDenuncia == "Encontro com animais")
            {
                // Usando marcador amarelo para "Encontro com animais"
                markerType = GMarkerGoogleType.yellow_pushpin;
            }
            else
            {
                // Usando marcador azul para "Outros"
                markerType = GMarkerGoogleType.blue_pushpin;
            }

            // Cria o texto do ToolTip com o título e tipo da denúncia
            string toolTipContent = $"Tipo: {tipoDenuncia}\n{title}\nCidade: {cidade}";

            var marker = new GMarkerGoogle(new PointLatLng(lat, lng), markerType)
            {
                ToolTipText = toolTipContent // Exibe o título e tipo da denúncia no tooltip
            };

            // Adiciona o marcador à sobreposição
            markersOverlay.Markers.Add(marker);
        }

    }
}
