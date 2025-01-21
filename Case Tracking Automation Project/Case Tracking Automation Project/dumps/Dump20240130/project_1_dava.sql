-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: project_1
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `dava`
--

DROP TABLE IF EXISTS `dava`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dava` (
  `DavaID` int NOT NULL AUTO_INCREMENT,
  `DavaAdi` varchar(100) NOT NULL,
  `DavaciID` int DEFAULT NULL,
  `DavaliID` int DEFAULT NULL,
  `MahkemeID` int DEFAULT NULL,
  `DavaTuruID` int DEFAULT NULL,
  `AvukatID` int DEFAULT NULL,
  `SaatID` int DEFAULT NULL,
  `AcilmaTarihi` date DEFAULT NULL,
  `DurusmaTarihi` date DEFAULT NULL,
  `Sonuc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`DavaID`),
  KEY `MahkemeID` (`MahkemeID`),
  KEY `DavaTuruID` (`DavaTuruID`),
  KEY `AvukatID` (`AvukatID`),
  KEY `SaatID` (`SaatID`),
  KEY `DavaciID` (`DavaciID`),
  KEY `DavaliID` (`DavaliID`),
  CONSTRAINT `dava_ibfk_1` FOREIGN KEY (`MahkemeID`) REFERENCES `mahkeme` (`MahkemeID`),
  CONSTRAINT `dava_ibfk_2` FOREIGN KEY (`DavaTuruID`) REFERENCES `davaturu` (`DavaTuruID`),
  CONSTRAINT `dava_ibfk_3` FOREIGN KEY (`AvukatID`) REFERENCES `avukat` (`AvukatID`),
  CONSTRAINT `dava_ibfk_4` FOREIGN KEY (`SaatID`) REFERENCES `saat` (`SaatID`),
  CONSTRAINT `dava_ibfk_5` FOREIGN KEY (`DavaciID`) REFERENCES `davaci` (`DavaciID`),
  CONSTRAINT `dava_ibfk_6` FOREIGN KEY (`DavaliID`) REFERENCES `davali` (`DavaliID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dava`
--

LOCK TABLES `dava` WRITE;
/*!40000 ALTER TABLE `dava` DISABLE KEYS */;
INSERT INTO `dava` VALUES (2,'Boşanma',1,1,1,1,2,2,'2024-01-31','2024-01-31','YeniDurum'),(3,'boşanma',1,1,2,1,2,1,'2024-01-31','2024-01-31','sonuçlandırılmadı'),(4,'boşanma',1,1,2,1,2,3,'2024-01-24','2024-01-24','sonuçlandırılmadı'),(5,'boşanma',1,1,1,1,2,2,'2024-01-24','2024-01-24','sonuçlandırılmadı');
/*!40000 ALTER TABLE `dava` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-30  0:37:20
