-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2025 at 01:14 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aquapalace`
--

-- --------------------------------------------------------

--
-- Table structure for table `abonnementen`
--

CREATE TABLE `abonnementen` (
  `id` int(11) NOT NULL,
  `klant_id` int(11) NOT NULL,
  `abonnement_type_id` int(11) NOT NULL,
  `aankoop_datum` timestamp NOT NULL DEFAULT current_timestamp(),
  `verval_datum` date DEFAULT NULL,
  `aantal_overige_ritten` int(11) DEFAULT NULL,
  `actief` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `abonnementtypes`
--

CREATE TABLE `abonnementtypes` (
  `id` int(11) NOT NULL,
  `naam` enum('dagkaart','rittenkaart','maandabonnement','jaarabonnement') NOT NULL,
  `beschrijving` text DEFAULT NULL,
  `prijs` decimal(10,2) NOT NULL,
  `geldigheid_dagen` int(11) DEFAULT NULL,
  `aantal_ritten` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `customer_firstname` varchar(20) NOT NULL,
  `customer_lastname` varchar(20) NOT NULL,
  `customer_address` varchar(25) NOT NULL,
  `customer_zipcode` varchar(7) NOT NULL,
  `customer_city` varchar(25) NOT NULL,
  `customer_email` varchar(25) NOT NULL,
  `customer_phone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `customer_firstname`, `customer_lastname`, `customer_address`, `customer_zipcode`, `customer_city`, `customer_email`, `customer_phone`) VALUES
(101, 'Jona', 'Albema', 'Hoofdstraat 55', '1025 KN', 'Amsterdam', 'J.Albema@Ziggo.', ''),
(102, 'Kahim', 'Balema', 'Lindengracht 33', '1082 KL', 'Amsterdam', 'KBaal@hotmail.com', ''),
(103, 'Bart', 'de Vries', 'Kasteel 5', '3872 LM', 'Alkmaar', 'PdeVries@hotmail.com', ''),
(104, 'Pieter', 'Haarlem', 'Amsterdamse weg 107', '3038 DF', 'Haarlem', 'PHaarlem@gmail.com', ''),
(105, 'Lieven', 'Halsema', 'Boerenlaan 77', '3974 PK', 'Groningen', 'Superman@hotmail.com', ''),
(106, 'Veronique', 'Groothoofd', 'Jan de Bouvierstraat 21', '8564 LP', 'Amstelveen', 'Grootkop@gmail.com', ''),
(107, 'Leo', 'Bartels', 'Veenwegen 974', '2963 KL', 'Hoofddorp', 'Bartel@gmail.com', ''),
(108, 'Petra', 'de Jong', 'Amstelkade 64', '1957 ED', 'Rotterdam', 'P.deJong@hotmail.com', ''),
(109, 'Karel', 'Vrolijk', 'Parkstraat 54', '4045 MN', 'Rotterdam', 'Vrolijkjoch@gmail.com', ''),
(110, 'Lucas', 'Vroom', 'Kerkstraat 9', '2046 LK', 'Haarlem ', 'VroomL@gmail.com', ''),
(111, 'Karin', 'Klein', 'Gartmanplantsoen 4', '1087 AQ', 'Amsterdam', 'Klein@kpn.com', ''),
(112, 'Lisa', 'Ravenstein', 'Keienstraat 9', '4837 LM', 'Rotterdam', 'Ravenstein@dat.com', ''),
(113, 'Merijn', 'Rood', 'Kleurenplantsoen 2', '5463 FS', 'Nieuw-Vennep', 'Rood@hotmail.com', ''),
(114, 'Willem', 'van Oranje', 'Paleisstraat 52', '8372 UJ', 'Soestdijk', 'Prinsgemaal@hotmail.com', ''),
(115, 'Mark', 'de Boer', 'Landweg 43', '8877 AA', 'St. Oedenrode', 'Mark@deboer', '');

-- --------------------------------------------------------

--
-- Table structure for table `incheckgeschiedenis`
--

CREATE TABLE `incheckgeschiedenis` (
  `id` int(11) NOT NULL,
  `abonnement_id` int(11) NOT NULL,
  `incheck_tijdstip` timestamp NOT NULL DEFAULT current_timestamp(),
  `uitcheck_tijdstip` timestamp NULL DEFAULT NULL,
  `medewerker_id` int(11) DEFAULT NULL,
  `zuil_id` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `rapportages`
--

CREATE TABLE `rapportages` (
  `id` int(11) NOT NULL,
  `beheerder_id` int(11) NOT NULL,
  `rapportage_type` varchar(100) NOT NULL,
  `periode` varchar(50) NOT NULL,
  `aangemaakt_op` timestamp NOT NULL DEFAULT current_timestamp(),
  `data` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`data`))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `transacties`
--

CREATE TABLE `transacties` (
  `id` int(11) NOT NULL,
  `klant_id` int(11) NOT NULL,
  `abonnement_type_id` int(11) NOT NULL,
  `transactie_datum` timestamp NOT NULL DEFAULT current_timestamp(),
  `bedrag` decimal(10,2) NOT NULL,
  `betaalmethode` enum('pin','creditcard','ideal','contant') NOT NULL,
  `status` enum('voltooid','in_afwachting','geannuleerd') DEFAULT 'voltooid'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `user_firstname` varchar(20) NOT NULL,
  `user_lastname` varchar(30) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(60) NOT NULL,
  `user_admin` int(11) NOT NULL,
  `user_role` varchar(20) DEFAULT 'standaard'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_firstname`, `user_lastname`, `user_email`, `user_username`, `user_password`, `user_admin`, `user_role`) VALUES
(1, 'Eva', 'Johnson', 'eva.johnson@email.com', 'eva_j', '$2a$10$8E33/hnAAApeysB0gRE8Qu7k4js2XLMzhps3h7L/bNfSWCs9YS8Ki', 0, 'standaard'),
(2, 'Liam', 'Miller', 'liam.miller@email.com', 'liam_m', 'Liam#456', 0, 'standaard'),
(3, 'Sophia', 'Smith', 'sophia.smith@email.com', 'sophia_s', 'Sophia@789', 0, 'standaard'),
(4, 'Noah', 'Brown', 'noah.brown@email.com', 'noah_b', 'Noah_123', 0, 'standaard'),
(5, 'Ava', 'Davis', 'ava.davis@email.com', 'ava_d', 'Ava#456', 0, 'standaard'),
(6, 'Jackson', 'Martinez', 'jackson.martinez@email.co', 'jackson_m', 'Jackson@789', 0, 'standaard'),
(7, 'Olivia', 'Garcia', 'olivia.g@email.com', 'olivia_g', 'Olivia_123', 0, 'standaard'),
(8, 'Lucas', 'Williams', 'lucas.w@email.com', 'lucas_w', 'Lucas#456', 0, 'standaard'),
(9, 'Isabella', 'Jones', 'isabella.j@email.com', 'isabella_j', 'Isabella@789', 0, 'standaard'),
(10, 'Mia', 'Rodriguez', 'mia.rodriguez@email.com', 'mia_r', 'Mia_123', 0, 'standaard');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `abonnementen`
--
ALTER TABLE `abonnementen`
  ADD PRIMARY KEY (`id`),
  ADD KEY `abonnement_type_id` (`abonnement_type_id`),
  ADD KEY `idx_abonnementen_klant` (`klant_id`),
  ADD KEY `idx_abonnementen_verval` (`verval_datum`),
  ADD KEY `idx_abonnementen_actief` (`actief`);

--
-- Indexes for table `abonnementtypes`
--
ALTER TABLE `abonnementtypes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `unique_abonnement_naam` (`naam`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `incheckgeschiedenis`
--
ALTER TABLE `incheckgeschiedenis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `medewerker_id` (`medewerker_id`),
  ADD KEY `idx_incheck_abonnement` (`abonnement_id`),
  ADD KEY `idx_incheck_tijdstip` (`incheck_tijdstip`);

--
-- Indexes for table `rapportages`
--
ALTER TABLE `rapportages`
  ADD PRIMARY KEY (`id`),
  ADD KEY `beheerder_id` (`beheerder_id`);

--
-- Indexes for table `transacties`
--
ALTER TABLE `transacties`
  ADD PRIMARY KEY (`id`),
  ADD KEY `klant_id` (`klant_id`),
  ADD KEY `abonnement_type_id` (`abonnement_type_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `abonnementen`
--
ALTER TABLE `abonnementen`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `abonnementtypes`
--
ALTER TABLE `abonnementtypes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=116;

--
-- AUTO_INCREMENT for table `incheckgeschiedenis`
--
ALTER TABLE `incheckgeschiedenis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `rapportages`
--
ALTER TABLE `rapportages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `transacties`
--
ALTER TABLE `transacties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `abonnementen`
--
ALTER TABLE `abonnementen`
  ADD CONSTRAINT `abonnementen_ibfk_1` FOREIGN KEY (`klant_id`) REFERENCES `klanten` (`id`),
  ADD CONSTRAINT `abonnementen_ibfk_2` FOREIGN KEY (`abonnement_type_id`) REFERENCES `abonnementtypes` (`id`);

--
-- Constraints for table `incheckgeschiedenis`
--
ALTER TABLE `incheckgeschiedenis`
  ADD CONSTRAINT `incheckgeschiedenis_ibfk_1` FOREIGN KEY (`abonnement_id`) REFERENCES `abonnementen` (`id`),
  ADD CONSTRAINT `incheckgeschiedenis_ibfk_2` FOREIGN KEY (`medewerker_id`) REFERENCES `gebruikers` (`id`);

--
-- Constraints for table `rapportages`
--
ALTER TABLE `rapportages`
  ADD CONSTRAINT `rapportages_ibfk_1` FOREIGN KEY (`beheerder_id`) REFERENCES `gebruikers` (`id`);

--
-- Constraints for table `transacties`
--
ALTER TABLE `transacties`
  ADD CONSTRAINT `transacties_ibfk_1` FOREIGN KEY (`klant_id`) REFERENCES `klanten` (`id`),
  ADD CONSTRAINT `transacties_ibfk_2` FOREIGN KEY (`abonnement_type_id`) REFERENCES `abonnementtypes` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
