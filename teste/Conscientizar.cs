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
    public partial class Conscientizar : UserControl
    {
        public Conscientizar()
        {
            InitializeComponent();
            digitaCord(latitude);
            digitaCord(longitude);
            cmbBiomas.SelectedIndex = 0;
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Gera latitude e longitude aleatórias dentro de um intervalo global
            double latitude2 = Convert.ToInt16(latitude.Text);
            double longitude2 = Convert.ToDouble(longitude.Text);

            string bioma = VerificarBioma(latitude2, longitude2);
            lblBiomas.Text = $"Bioma: {bioma}";
        }
        public class Bioma
        {
            public string Nome { get; set; }
            public List<Bloco> Blocos { get; set; } = new List<Bloco>();
        }

        public class Bloco
        {
            public double MinLat { get; set; }
            public double MaxLat { get; set; }
            public double MinLong { get; set; }
            public double MaxLong { get; set; }
        }

        // Lista de biomas e seus blocos
        private List<Bioma> biomas = new List<Bioma>
        {
        new Bioma
        {
            Nome = "Amazônia",
            Blocos = new List<Bloco>
            {
                new Bloco { MinLat = -15, MaxLat = 6, MinLong = -75, MaxLong = -60 },
                new Bloco { MinLat = -12.5, MaxLat = 6, MinLong = -60, MaxLong = -50 },
                new Bloco { MinLat = -6, MaxLat = -5, MinLong = -50, MaxLong = -45 }
            }
        },
        new Bioma
        {
            Nome = "Cerrado",
            Blocos = new List<Bloco>
            {
                new Bloco { MinLat = -15, MaxLat = -12.5, MinLong = -15, MaxLong = -12.5 },
                new Bloco { MinLat = -22.5, MaxLat = -20, MinLong = -60, MaxLong = -52.5 },
                new Bloco { MinLat = -20, MaxLat = -12.5, MinLong = -55, MaxLong = -42.5 },
                new Bloco { MinLat = -12.5, MaxLat = -5, MinLong = -50, MaxLong = -42.5 },
                new Bloco { MinLat = -5, MaxLat = 0, MinLong = -45, MaxLong = -42.5 }
            }
        },
        new Bioma
        {
            Nome = "Caatinga",
            Blocos = new List<Bloco>
            {
                new Bloco { MinLat = -15, MaxLat = 0, MinLong = -42.5, MaxLong = -40 },
                new Bloco { MinLat = 0, MaxLat = -10, MinLong = -40, MaxLong = -36 },
                new Bloco { MinLat = -12.5, MaxLat = -10, MinLong = -40, MaxLong = -37.5 }
            }
        },
        new Bioma
        {
            Nome = "Pantanal",
            Blocos = new List<Bloco>
            {
                new Bloco { MinLat = -20, MaxLat = -15, MinLong = -60, MaxLong = -55 }
            }
        },
        new Bioma
        {
            Nome = "Pampa",
            Blocos = new List<Bloco>
            {
                new Bloco { MinLat = -35, MaxLat = -27.5, MinLong = -60, MaxLong = -45 }
            }
        }
    };
        private string VerificarBioma(double latitude, double longitude)
        {
            foreach (var bioma in biomas)
            {
                foreach (var bloco in bioma.Blocos)
                {
                    if (latitude >= bloco.MinLat && latitude <= bloco.MaxLat &&
                        longitude >= bloco.MinLong && longitude <= bloco.MaxLong)
                    {
                        return bioma.Nome;
                    }
                }
            }
            return "Mata-Atlântica";
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            txtAlterar.Text = "";

            if (cmbBiomas.SelectedIndex == 0)
            {
                txtAlterar.Text = "Nome e Localização do Bioma\r\n\r\nLocalização Geográfica → Abrange os estados do Acre, Amapá, Amazonas, Pará, Rondônia, Roraima e partes do Maranhão, Mato Grosso e Tocantins.\r\n\r\nTerritório Ocupado→ Ocupa cerca de 49% do território brasileiro.\r\n\r\nCaracterísticas Gerais\r\n\r\nÁrea → Aproximadamente 5,5 milhões de km² (a maior floresta tropical do mundo).\r\n\r\nClima → Equatorial, quente e úmido, com temperaturas médias entre 24°C e 26°C.\r\n\r\nFauna e Flora\r\n\r\nFauna → \r\nMamíferos: Onça-pintada, bicho-preguiça, boto-cor-de-rosa.\r\nAves: Arara-azul, tucano.\r\nRépteis: Jacaré-açu, sucuri.\r\nInsetos: Borboletas gigantes, formigas-cortadeiras.\r\n\r\nFlora →\r\nÁrvores: Castanheira-do-pará, andiroba, seringueira.\r\nPlantas: Vitória-régia, cipós, orquídeas.\r\n\r\nCuriosidade → Possui 10% de todas as espécies conhecidas no mundo.\r\n\r\nImportância do Bioma\r\n\r\nServiços Ecossistêmicos → \r\nAbsorve grandes quantidades de CO₂, regulando o clima global.\r\nProduz 20% da água doce lançada nos oceanos.\r\n\r\nEconomia → \r\nProdutos como castanha-do-pará, borracha e açaí.\r\nTurismo ecológico.\r\n\r\nAmeaças ao Bioma\r\n\r\nPrincipais ameaças →\r\nDesmatamento: Expansão agrícola e pecuária.\r\nQueimadas: Muitas vezes provocadas para \"limpar\" áreas.\r\nMineração ilegal: Exploração de ouro e outros minerais.\r\nMudanças Climáticas: Redução da umidade e aumento da temperatura, afetando o ecossistema.\r\n\r\nImpactos ambientais → \r\n\r\nRedução da biodiversidade.\r\nAlteração do ciclo hidrológico, afetando rios e chuvas.\r\n\r\nLinks Externos →\r\nIBAMA: https://www.ibama.gov.br\r\nICMBio: https://www.icmbio.gov.br\r\nIPAM: https://ipam.org.br/pt/\r\nWWF: https://www.wwf.org.br\r\n";
            }
            else if(cmbBiomas.SelectedIndex == 1)
            {
                txtAlterar.Text = "Nome e Localização do Bioma\r\n\r\nLocalização Geográfica → Abrange os estados de Goiás, Tocantins, Mato Grosso, Mato Grosso do Sul, Minas Gerais, Bahia, Maranhão, Piauí, São Paulo e o Distrito Federal.  \r\n\r\nTerritório Ocupado → Ocupa cerca de 22% do território brasileiro.\r\n\r\nCaracterísticas Gerais\r\n\r\nÁrea → Aproximadamente 2 milhões de km² (o segundo maior bioma brasileiro).  \r\nClima → Tropical sazonal, com estações bem definidas: seca no inverno e chuvas no verão.\r\n\r\nFauna e Flora\r\n\r\nFauna →  \r\n  - Mamíferos: Lobo-guará, tamanduá-bandeira, tatu-canastra.  \r\n  - Aves: Seriema, ema, arara-vermelha.  \r\n  - Répteis: Jabuti, cobra-cipó.  \r\n\r\nFlora →  \r\n  - Árvores: Pequi, baru, ipê.  \r\n  - Plantas: Buriti, cagaiteiras, barbatimão.\r\n\r\nCuriosidade → Considerado o \"berço das águas\" por abrigar nascentes das três maiores bacias hidrográficas da América do Sul.\r\n\r\nImportância do Bioma\r\n\r\n- Serviços Ecossistêmicos →  \r\n  - Contribui para a recarga de aquíferos e manutenção do ciclo hidrológico.  \r\n  - Savana mais rica em biodiversidade no mundo.  \r\n\r\n- Economia →  \r\n  - Extrativismo sustentável (pequi, baru e buriti).  \r\n  - Agricultura e pecuária (embora muitas vezes de forma insustentável).\r\n\r\nAmeaças ao Bioma\r\n\r\n- Principais ameaças →  \r\n  - Desmatamento: Expansão agrícola e pecuária.  \r\n  - Queimadas: Intensificadas por ações humanas.  \r\n  - Monoculturas: Reduzem a biodiversidade.  \r\n\r\n- Impactos ambientais →  \r\n  - Redução da biodiversidade.  \r\n  - Diminuição da capacidade de recarga hídrica.\r\n\r\nLinks Externos →  \r\nIBAMA: https://www.ibama.gov.br\r\nWWF: https://www.wwf.org.br\r\nRede Cerrado: https://www.redecerrado.org.br\r\n";
            }
            else if(cmbBiomas.SelectedIndex == 2)
            {
                txtAlterar.Text = "Nome e Localização do Bioma\r\n\r\n- Localização Geográfica → Exclusivo do Brasil, abrange os estados do Nordeste e parte do norte de Minas Gerais.  \r\n- Território Ocupado → Cerca de 10% do território brasileiro.\r\n\r\nCaracterísticas Gerais\r\n\r\n- Área → Aproximadamente 850.000 km².  \r\n- Clima → Semiárido, com longos períodos de estiagem e temperaturas médias entre 27°C e 29°C.\r\n\r\nFauna e Flora\r\n\r\n- Fauna →  \r\n  - Mamíferos: Veado-catingueiro, gato-do-mato.  \r\n  - Aves: Asa-branca, ararinha-azul.  \r\n  - Répteis: Teiú, jiboia.  \r\n\r\n- Flora →  \r\n  - Árvores: Umbuzeiro, mandacaru, xique-xique.  \r\n  - Plantas: Bromélias, macambiras.  \r\n\r\nCuriosidade → Único bioma exclusivamente brasileiro, com espécies adaptadas à seca.\r\n\r\nImportância do Bioma\r\n\r\n- Serviços Ecossistêmicos →  \r\n  - Regula o microclima local.  \r\n  - Protege o solo contra erosão.  \r\n\r\n- Economia →  \r\n  - Extrativismo de frutos como umbu e licuri.  \r\n  - Apicultura e produção de mel.\r\n\r\nAmeaças ao Bioma\r\n\r\n- Principais ameaças →  \r\n  - Desertificação devido ao manejo inadequado do solo.  \r\n  - Desmatamento para uso agrícola e pecuário.  \r\n\r\n- Impactos ambientais →  \r\n  - Perda de biodiversidade.  \r\n  - Aumento da aridez.\r\n\r\nLinks Externos →  \r\nCaatinga: https://www.caatinga.org.br\r\nSOS Caatinga: https://soscaatinga.org\r\n";
            }
            else if(cmbBiomas.SelectedIndex == 3)
            {
                txtAlterar.Text = "Nome e Localização do Bioma\r\n\r\n- Localização Geográfica → Estende-se por grande parte do litoral brasileiro, abrangendo 17 estados, do Rio Grande do Norte ao Rio Grande do Sul.  \r\n- Território Ocupado → Originalmente 15% do território nacional, hoje reduzido a cerca de 12,4% da cobertura original.\r\n\r\nCaracterísticas Gerais\r\n\r\n- Área → Originalmente 1,3 milhão de km², hoje restam cerca de 150.000 km².  \r\n- Clima → Tropical úmido, com alta pluviosidade.\r\n\r\nFauna e Flora\r\n\r\n- Fauna →  \r\n  - Mamíferos: Mico-leão-dourado, anta, jaguatirica.  \r\n  - Aves: Tucano-de-bico-verde, sabiá-laranjeira.  \r\n  - Répteis: Cobra-coral, lagarto-teiú.  \r\n\r\n- Flora →  \r\n  - Árvores: Pau-brasil, jequitibá-rosa, ipê.  \r\n  - Plantas: Bromélias, orquídeas.\r\n\r\nCuriosidade → Declarada Patrimônio da Humanidade pela UNESCO.\r\n\r\nImportância do Bioma\r\n\r\n- Serviços Ecossistêmicos →  \r\n  - Regula o ciclo hídrico e climático.  \r\n  - Lar de várias espécies endêmicas.\r\n\r\n- Economia →  \r\n  - Turismo ecológico e extrativismo sustentável.  \r\n\r\nAmeaças ao Bioma\r\n\r\n- Principais ameaças →  \r\n  - Desmatamento urbano e agrícola.  \r\n  - Poluição e expansão industrial.  \r\n\r\n- Impactos ambientais →  \r\n  - Fragmentação de habitats.  \r\n  - Ameaça a espécies endêmicas.\r\n\r\nLinks Externos →  \r\nSOS Mata Atlântica: https://www.sosma.org.br\r\nWWF: https://www.wwf.org.br\r\n";
            }
            else if(cmbBiomas.SelectedIndex == 4)
            {
                txtAlterar.Text = "Nome e Localização do Bioma\r\n\r\n- Localização Geográfica → Abrange os estados de Mato Grosso e Mato Grosso do Sul, além de se estender por partes da Bolívia e Paraguai.  \r\n- Território Ocupado → Cerca de 1,8% do território brasileiro.\r\n\r\nCaracterísticas Gerais\r\n\r\n- Área → Aproximadamente 150.000 km² (a maior planície alagável do mundo).  \r\n- Clima → Tropical, com duas estações bem definidas: uma seca e outra chuvosa.\r\n\r\nFauna e Flora\r\n\r\n- Fauna →  \r\n  - Mamíferos: Onça-pintada, capivara, ariranha.  \r\n  - Aves: Tuiuiú, jaburu, arara-azul.  \r\n  - Répteis: Jacaré-do-pantanal, sucuri-verde.  \r\n\r\n- Flora →  \r\n  - Árvores: Ipê-amarelo, aroeira, buriti.  \r\n  - Plantas: Vitórias-régias, aguapés.\r\n\r\nCuriosidade → Reconhecido como Patrimônio Natural da Humanidade pela UNESCO.\r\n\r\nImportância do Bioma\r\n\r\n- Serviços Ecossistêmicos →  \r\n  - Regula o fluxo hídrico, prevenindo enchentes.  \r\n  - Habitat para milhares de espécies de aves migratórias.  \r\n\r\n- Economia →  \r\n  - Turismo ecológico, pesca e pecuária extensiva.  \r\n\r\nAmeaças ao Bioma\r\n\r\n- Principais ameaças →  \r\n  - Desmatamento e poluição das águas.  \r\n  - Queimadas, muitas vezes provocadas.  \r\n\r\n- Impactos ambientais →  \r\n  - Desequilíbrio do ecossistema aquático.  \r\n  - Redução da biodiversidade.\r\n\r\nLinks Externos →  \r\nWWF: https://www.wwf.org.br\r\nPantanal.org: https://www.pantanal.org\r\n";
            }
            else if(cmbBiomas.SelectedIndex == 5)
            {
                txtAlterar.Text = "Nome e Localização do Bioma\r\n\r\n- Localização Geográfica → Exclusivo da região sul do Brasil, abrangendo o estado do Rio Grande do Sul.  \r\n- Território Ocupado → Cerca de 2% do território brasileiro.\r\n\r\nCaracterísticas Gerais\r\n\r\n- Área → Aproximadamente 178.000 km².  \r\n- Clima → Subtropical, com temperaturas que variam entre 13°C e 17°C.\r\n\r\nFauna e Flora\r\n\r\n- Fauna →  \r\n  - Mamíferos: Veado-campeiro, graxaim-do-campo.  \r\n  - Aves: Quero-quero, perdiz.  \r\n  - Répteis: Cobra-verde, lagarto-do-pampa.  \r\n\r\n- Flora →  \r\n  - Árvores: Espinilho, figueira-do-pampa.  \r\n  - Plantas: Gramíneas, capim-forquilha.\r\n\r\nCuriosidade → Também chamado de Campos Sulinos, é uma das regiões de pastagem mais antigas do mundo.\r\n\r\nImportância do Bioma\r\n\r\n- Serviços Ecossistêmicos →  \r\n  - Preserva o solo e regula o ciclo hídrico.  \r\n  - Habitat para várias espécies migratórias.  \r\n\r\n- Economia →  \r\n  - Pecuária extensiva de gado e ovinocultura.  \r\n  - Produção agrícola, principalmente soja e arroz.  \r\n\r\nAmeaças ao Bioma\r\n\r\n- Principais ameaças →  \r\n  - Substituição por monoculturas e pastagens exóticas.  \r\n  - Uso inadequado do solo, levando à erosão.  \r\n\r\n- Impactos ambientais →  \r\n  - Perda da vegetação nativa.  \r\n  - Redução de espécies endêmicas.  \r\n\r\nLinks Externos →  \r\nPampas.org: https://www.pampas.org\r\nWWF: https://www.wwf.org.br\r\n\r\n";
            }
        }
    }
}

