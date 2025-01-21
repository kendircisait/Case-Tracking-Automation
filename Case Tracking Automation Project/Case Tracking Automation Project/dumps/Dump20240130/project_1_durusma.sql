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
-- Table structure for table `durusma`
--

DROP TABLE IF EXISTS `durusma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `durusma` (
  `DurusmaID` int NOT NULL AUTO_INCREMENT,
  `DavaID` int DEFAULT NULL,
  `MahkemeID` int DEFAULT NULL,
  `HakimID` int DEFAULT NULL,
  `DurusmaTarihi` date DEFAULT NULL,
  PRIMARY KEY (`DurusmaID`),
  KEY `DavaID` (`DavaID`),
  KEY `MahkemeID` (`MahkemeID`),
  KEY `HakimID` (`HakimID`),
  CONSTRAINT `durusma_ibfk_1` FOREIGN KEY (`DavaID`) REFERENCES `dava` (`DavaID`),
  CONSTRAINT `durusma_ibfk_2` FOREIGN KEY (`MahkemeID`) REFERENCES `mahkeme` (`MahkemeID`),
  CONSTRAINT `durusma_ibfk_3` FOREIGN KEY (`HakimID`) REFERENCES `hakim` (`HakimID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `durusma`
--

LOCK TABLES `durusma` WRITE;
/*!40000 ALTER TABLE `durusma` DISABLE KEYS */;
INSERT INTO `durusma` VALUES (4,3,1,1,'2024-01-30'),(5,2,1,1,'2024-01-30'),(6,2,3,2,'2024-01-24');
/*!40000 ALTER TABLE `durusma` ENABLE KEYS */;
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
