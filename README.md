# README

## Projeto: Sistema de Denúncia com Geolocalização e Mapa

Este projeto é uma aplicação Windows Forms para registro de denúncias com suporte à geolocalização. O sistema permite buscar coordenadas geográficas (latitude e longitude) utilizando a API do **OpenStreetMap Nominatim** e exibir um mapa integrado com o controle **GMap.NET**.

---

## Funcionalidades
- Registro de denúncias com informações como rua, bairro, número e cidade.
- Busca de coordenadas geográficas a partir de endereço (rua e cidade).
- Integração com mapas usando **OpenStreetMap**.
- Validação de entrada em campos de texto para números e letras.
- Exibição de coordenadas no mapa.
- Identificação de bioma por coordenada.
- Informação sobre biomas

---

## Dependências Externas
### APIs e Serviços
- **OpenStreetMap Nominatim API**: Utilizada para buscar coordenadas geográficas com base no endereço.
  - Documentação: [https://nominatim.org/](https://nominatim.org/)
  - URL utilizada: `https://nominatim.openstreetmap.org/search`

### Bibliotecas NuGet
1. **Newtonsoft.Json** (≥13.0.1)
   - Para manipulação de dados JSON retornados pela API Nominatim.
   - Instalação:
     ```bash
     Install-Package Newtonsoft.Json
     ```

2. **RestSharp** (≥108.0.0)
   - Para realizar requisições HTTP na API Nominatim.
   - Instalação:
     ```bash
     Install-Package RestSharp
     ```

3. **GMap.NET.WindowsForms** (≥1.9.6)
   - Para integração com mapas do OpenStreetMap no Windows Forms.
   - Instalação:
     ```bash
     Install-Package GMap.NET.WindowsForms
     ```

---

## Configuração e Uso
### Requisitos
- **.NET Framework** ou **.NET Core** (dependendo da configuração do projeto).
- Conexão com a internet para acessar a API e os mapas.

### Passos para Executar
1. **Clone o Repositório**
   ```bash
   git clone https://github.com/QuadCoreHackathon/SistemaDeDenuncia.git
   ```
2. **Instale as Dependências**
   - Use o **NuGet Package Manager** ou os comandos listados acima para instalar as bibliotecas necessárias.
3. **Compile e Execute**
   - Abra o projeto no **Visual Studio**, compile e execute.

---

## Execução
  - Para executar o código siga o caminho a seguir até o executável teste.exe
  teste/bin/Debug/teste.exe

---

## Observações
- O controle GMap.NET suporta diferentes provedores de mapa; neste projeto, o **OpenStreetMap** foi utilizado por ser gratuito.

---

## Autores
- Desenvolvido por João Vitor Leite Novoletti, 
Lucas Campos Regonha, Lucas Novello Schiavuzzo e 
Matheus Henrique Lopes Manoel.
