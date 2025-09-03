-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2025 at 12:03 PM
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
-- Table structure for table `gebruikers`
--

CREATE TABLE `gebruikers` (
  `id` int(11) NOT NULL,
  `rol` enum('gast','medewerker','beheerder') NOT NULL,
  `email` varchar(255) NOT NULL,
  `wachtwoord` varchar(255) NOT NULL,
  `voornaam` varchar(100) NOT NULL,
  `achternaam` varchar(100) NOT NULL,
  `telefoon` varchar(20) DEFAULT NULL,
  `geboortedatum` date DEFAULT NULL,
  `aanmaak_datum` timestamp NOT NULL DEFAULT current_timestamp(),
  `laatste_login` timestamp NULL DEFAULT NULL,
  `actief` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
-- Table structure for table `klanten`
--

CREATE TABLE `klanten` (
  `id` int(11) NOT NULL,
  `gebruiker_id` int(11) NOT NULL,
  `postcode` varchar(10) DEFAULT NULL,
  `huisnummer` varchar(10) DEFAULT NULL,
  `stad` varchar(100) DEFAULT NULL,
  `land` varchar(100) DEFAULT 'Nederland'
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
-- Indexes for table `gebruikers`
--
ALTER TABLE `gebruikers`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `idx_gebruikers_rol` (`rol`),
  ADD KEY `idx_gebruikers_email` (`email`);

--
-- Indexes for table `incheckgeschiedenis`
--
ALTER TABLE `incheckgeschiedenis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `medewerker_id` (`medewerker_id`),
  ADD KEY `idx_incheck_abonnement` (`abonnement_id`),
  ADD KEY `idx_incheck_tijdstip` (`incheck_tijdstip`);

--
-- Indexes for table `klanten`
--
ALTER TABLE `klanten`
  ADD PRIMARY KEY (`id`),
  ADD KEY `gebruiker_id` (`gebruiker_id`);

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
-- AUTO_INCREMENT for table `gebruikers`
--
ALTER TABLE `gebruikers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `incheckgeschiedenis`
--
ALTER TABLE `incheckgeschiedenis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `klanten`
--
ALTER TABLE `klanten`
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
-- Constraints for table `klanten`
--
ALTER TABLE `klanten`
  ADD CONSTRAINT `klanten_ibfk_1` FOREIGN KEY (`gebruiker_id`) REFERENCES `gebruikers` (`id`) ON DELETE CASCADE;

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
