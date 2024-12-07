-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: controle_denuncias
-- ------------------------------------------------------
-- Server version	8.0.40

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `denuncias`
--

DROP TABLE IF EXISTS `denuncias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `denuncias` (
  `id_denuncias` int NOT NULL AUTO_INCREMENT,
  `tipo` varchar(20) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `rua` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) DEFAULT NULL,
  `num` varchar(7) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `latitude` varchar(20) NOT NULL,
  `longitude` varchar(20) NOT NULL,
  `imagem` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_denuncias`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `denuncias`
--

LOCK TABLES `denuncias` WRITE;
/*!40000 ALTER TABLE `denuncias` DISABLE KEYS */;
INSERT INTO `denuncias` VALUES (1,'Incêndio','Incêndio em vegetação urbana próximo a áreas residenciais','Avenida Paulista','Bela Vista','1000','São Paulo','-23.561414','-46.656110',NULL),(2,'Encontro com animais','Cachorro perdido na rua, precisa de resgate','Rua do Ouvidor','Centro','234','Rio de Janeiro','-22.906847','-43.172896',NULL),(3,'Desmatamento','Desmatamento em área de preservação ambiental','Rua das Flores','Jardim Botânico','567','Curitiba','-25.428954','-49.267137',NULL),(4,'Outros','Construção ilegal em área de preservação','Rua 15 de Novembro','Centro','345','Brasília','-15.780148','-47.929219',NULL),(5,'Incêndio','Queimada em área rural, atingindo propriedades vizinhas','Avenida Governador Roberto da Silveira','Zona Norte','678','Manaus','-3.119028','-60.212738',NULL),(6,'Encontro com animais','Gato ferido encontrado em rua movimentada','Rua dos Três Irmãos','Jardim América','12','São Paulo','-23.570819','-46.631542',NULL),(7,'Desmatamento','Árvore derrubada ilegalmente em área pública','Rua da Liberdade','Liberdade','421','São Paulo','-23.550520','-46.633308',NULL),(8,'Outros','Construção irregular no Parque Nacional de Jericoacoara','Rua Afonso Pena','Centro','500','Fortaleza','-3.717222','-38.543319',NULL),(9,'Incêndio','Incêndio em uma floresta de eucalipto','Rua dos Três Pinheiros','Pinheiros','800','São Paulo','-23.567850','-46.681198',NULL),(10,'Encontro com animais','Capivara encontrada em área urbana','Avenida Rio Branco','Centro','310','Rio de Janeiro','-22.907100','-43.179500',NULL),(11,'Desmatamento','Exploração ilegal de madeira em reserva','Rua Ponta Grossa','Cajuru','200','Curitiba','-25.440077','-49.260562',NULL),(12,'Outros','Descarte de lixo em área de proteção ambiental','Rua do Sol','Centro','123','Salvador','-12.971387','-38.501150',NULL),(13,'Incêndio','Fogo em área de preservação em Minas Gerais','Rua de Fátima','Centro','456','Belo Horizonte','-19.920778','-43.938091',NULL),(14,'Encontro com animais','Aves raras encontradas em zona urbana','Avenida Beira Mar','Zona Sul','789','Rio de Janeiro','-22.979457','-43.184576',NULL),(15,'Desmatamento','Corte ilegal de árvores em região de nascentes','Rua dos Oliveiras','Jardim das Flores','678','São Paulo','-23.585150','-46.622965',NULL),(16,'Outros','Ações ilegais em área de proteção no Amazonas','Rua São João','Centro','987','Manaus','-3.119940','-60.222650',NULL),(17,'Incêndio','Incêndio em floresta tropical devido à ação humana','Rua Sete de Setembro','Centro','345','Belém','-1.455356','-48.490895',NULL),(18,'Encontro com animais','Cavalo solto na rua causando perigo','Rua do Campo','Jardim Imperial','101','Campinas','-23.189585','-47.048236',NULL),(19,'Desmatamento','Desmatamento de área agrícola ilegal','Rua Paraná','Jardim Paulista','456','São Paulo','-23.588003','-46.643009',NULL),(20,'Outros','Poluição sonora em área urbana, afetando o meio ambiente','Avenida Rio Branco','Centro','320','Salvador','-12.971432','-38.502220',NULL),(21,'Incêndio','Queimadas criminosas em floresta tropical','Rua dos Tamarindos','Jardim Tropical','654','Manaus','-3.119303','-60.232303',NULL),(22,'Encontro com animais','Filhotes de gato abandonados na rua','Rua dos Pássaros','Jardim Primavera','890','Porto Alegre','-30.034647','-51.217660',NULL),(23,'Desmatamento','Ações ilegais em mata atlântica','Rua das Palmeiras','Vila Progredior','321','São Paulo','-23.566030','-46.653944',NULL),(24,'Outros','Construção irregular afetando o ecossistema local','Avenida Dom Pedro II','Zona Oeste','987','Rio de Janeiro','-22.908333','-43.182500',NULL),(25,'Incêndio','Queimada em área de cerrado','Avenida Brasil','Centro','234','Brasília','-15.780148','-47.929219',NULL),(26,'Encontro com animais','Serpente encontrada em área urbana','Avenida do Estado','Centro','876','São Paulo','-23.562877','-46.634676',NULL),(27,'Desmatamento','Exploração de madeira em área de proteção','Rua do Porto','Vila das Laranjeiras','654','Curitiba','-25.421702','-49.278281',NULL),(28,'Outros','Poluição visual gerada por propaganda excessiva','Rua do Caravaggio','Centro','456','Porto Alegre','-30.034657','-51.230702',NULL);
/*!40000 ALTER TABLE `denuncias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(15) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'teste','teste','teste','teste');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-07 15:16:30
