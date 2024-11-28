-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: event
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `signup`
--

DROP TABLE IF EXISTS `signup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `signup` (
  `idsignup` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(60) NOT NULL,
  PRIMARY KEY (`idsignup`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `signup`
--

LOCK TABLES `signup` WRITE;
/*!40000 ALTER TABLE `signup` DISABLE KEYS */;
INSERT INTO `signup` VALUES (1,'kobie calingasan','officialkobiecalingasan@gmail.com','$2a$11$8b7crWpuBQ5ZyuZO1FEw5eX4FX2D0XWtd7dTjN/uQ4YPmPjO6Xne.'),(2,'jhego oyacads','oyacadfam@gmail.com','$2a$11$v.UNoHkYTydcqEfvaNKVL.5nq0R25N96JF6sU2Rf3BDW.vcHTFD5e'),(3,'dadada','russellcalinawan@gmailcom','$2a$11$/TFiaZQIJUVUouqh0AYyt.KfLhi04XOsJ62fglQkKYNCItUg/5SEy'),(4,'russellcali','russellcali','$2a$11$2/JTz43x2G.EmTIVK0Yk7OY3c7EZsps7xPn9oFtfb4CPtQTgEQq.e'),(5,'ediwow','manny','$2a$11$q.CAzDahAMcI4f0d1wl7cuokoCPVwXSYY9.GLfrAqfAmmFhdoWXN.'),(6,'haha','haha','$2a$11$4K29gM238D5uL4dKvfDdO.3GzxbBxLQTWPPbpwDVXLWUP9Y6TGaKi'),(8,'haha11','haha11','$2a$11$uUR/ppsGS8LztpTRJycKlOUeHolLYprALK/GqoZwSL36EIMNwierS'),(9,'ttt','ttt','$2a$11$ORelFqT8RT13q3pLRQqXFeXcorkVmVOqU22kdmANeC6FSX.INV3R.'),(10,'t','t','$2a$11$5G2YkvuQiG6Nvv1qtkZFO.0t4Ag4ET5likCeZlkVSAb07t1aRWwP2'),(11,'t1','t1','$2a$11$RViwu89M/LspAo4.OnFqUeEx.6Ekyoa0u61vo7KtJs5WL4eiu/j6G'),(12,'ha','ha','$2a$11$HgH/M4AkctCqYy8jKYUmGuNzW42.6oRfYTTkuuiGCE2yFcOk054gO'),(13,'g','g','$2a$11$sVBq.4tv0hugEouknfJVouoUWhXRRjnQJ3rc3k9DaO2ME4e3Hl2MW'),(14,'1','1','$2a$11$GyLrzpmxOJjt.2dz77UZlu5IRYcshdbgCJacfcSjvowl97A.9NWC6'),(15,'2','2','$2a$11$wLAmGntfHYVPG1j8gzNSAe.fDoavITFrRsNTLvIg0cCEpX4vSeDiW'),(16,'3','3','$2a$11$neYkSqTkbC1vxUu1IE0q..KgUGDr2Iis4DqyYp15TjsvDFjg0Eawa'),(17,'4','4','$2a$11$4BHNkYNJ6DjpMGTXH2an6OTbMYskE31/UM7cR6.5WoTrqkjBsuEDK'),(18,'5','5','$2a$11$NoV7f1XLuPo9mhMRJui8G.Z7tcV03QLBvqkHSOS0Cvvss0bbdcrjS'),(19,'7','7','$2a$11$scM7os1TgguzsEXF1qgoLeQCmhl35R27koL/N0krskzZXDi78Mh2e'),(20,'8','8','$2a$11$yr7qaALXWnddW6ekPft1FuZ7tOeB4FfRLHdBz2MzPaloRx.q6nise'),(21,'9','9','$2a$11$82OMmV0OyXcp7tA7R71aUOAzKSkHPdeDVFCaZ4CFO1iHZGkNn8L0O'),(22,'10','10','$2a$11$rnaxKx.OGyQqb1.eAopz6e/HSYay0WuHZZ6/A2CBtw6gWmfpUbNIO'),(23,'11','11','$2a$11$FjDAyIMQQHxvzVY9y8rMPOvDesgMAQdaZucyHd2W83xAJRjy3gzTm'),(24,'112','112','$2a$11$w4VrdAcIjjmNCrrhL9bYaONcidajeHUcmxvsHW8j1Z519LyZrbW.2'),(25,'22','22','$2a$11$0QOqK7ZT.cI57xhLfXdMIuiNgfVKuEAsGTsuJWbFENTXgcHNNzHty'),(26,'1123','1123','$2a$11$EuNzfnQMcWR0nd3A674M4OKQF/ZTMK2/Pm37X0EQsnPh4qj3KuuzW'),(27,'1111','1111','$2a$11$iB9gqLKFCITSD4fPrT.6Cuq6ZpMPW6YMEH628GJL5v9SJgwqctLyu'),(28,'56','56','$2a$11$D4PArp1AoBhc25yj/eC9DOJtX/Gq5ghjSZwMchaL6ChafNYZ2lJve'),(29,'y','y','$2a$11$im/Pted/EQca4.jWldbj1efohMPaZDuC9cmbWc1MhMRAQL247S.T6'),(30,'KOB','KOB','$2a$11$faEFX38r7gn0yGLWYx5wTu12lBkVt7hWKKzce7Uppl/EKmeHIr3f.'),(31,'k','k','$2a$11$L2DmOgcnBaZlqTym/fHLyuPM/WkrKjdgSRgfF33SEVQb6l/mEd2mi'),(33,'223','223','$2a$11$LcPY0G0BNiddsm/zxZtZgeU9n40ZtGzatSE896zHfoyvqfrYdFa7u'),(34,'22222','22222','$2a$11$xZk4JPOuAYmoLa/dvSOzIeYNusoBEzwImCTBHcCFljRSgIsEbJM0q'),(35,'kobie','kobie','$2a$11$WosGPSNEkBUKjjFhQpTOse0hzqLYmGOFFvXSgduUoniHTpsBFL3xi'),(36,'2313123123','2313123123','$2a$11$TJ9oWLXOAbicAQKiWv3jtOYqYn1GVo5G6ZLFCHT67veVOgkOM6KwS'),(37,'ww','ww','$2a$11$rd.vnzQheqtvgDM9hdzVv.cX2HT625L4MvhsV8fCvBwZMHuwj2OfK'),(38,'tyt','tyt','$2a$11$cq1WSusNFGTpMySvNT1rXe2MdsntbHDzhOXB8Zrtjot85yvzu3nIe'),(39,'larence','officiallarencepinto@gmail.com','$2a$11$FupBwBDf.b5Ql8rVd2rdveKD6V/a0pYNF/2nik9LRvRcVsS./SPlm'),(40,'russell','russell@gmail.com','gago'),(41,'kobie','kobiecalingasan','gago'),(42,'travis scott','travisscott@gmail.com','$2a$11$l24HSzDVuAcpfGnnhvtf5eToHUANN.qTMyC4Tx1ywFcJmG0g9vSgi'),(43,'russ','russ','$2a$11$AIl9nxyt2vQ6KXu4rQcHC.e7wWUfjOEUP0II6Z4rqDfcYwCc4kn/e');
/*!40000 ALTER TABLE `signup` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-28 15:13:07
