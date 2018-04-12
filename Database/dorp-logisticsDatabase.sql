-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 12, 2018 at 09:16 PM
-- Server version: 10.1.29-MariaDB
-- PHP Version: 7.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dorp-logistics`
--

-- --------------------------------------------------------

--
-- Table structure for table `chauffeurs`
--

CREATE TABLE `chauffeurs` (
  `chauffeur_ID` int(11) NOT NULL,
  `voornaam` varchar(100) DEFAULT NULL,
  `tussenvoegsel` varchar(100) DEFAULT NULL,
  `achternaam` varchar(100) DEFAULT NULL,
  `soortrijbewijs` varchar(100) DEFAULT NULL,
  `nationaliteit_rijbewijs` varchar(100) DEFAULT NULL,
  `werkdagen` varchar(100) NOT NULL,
  `inlognaam` varchar(100) DEFAULT NULL,
  `wachtwoord` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chauffeurs`
--

INSERT INTO `chauffeurs` (`chauffeur_ID`, `voornaam`, `tussenvoegsel`, `achternaam`, `soortrijbewijs`, `nationaliteit_rijbewijs`, `werkdagen`, `inlognaam`, `wachtwoord`) VALUES
(1, 'Ricky', 'de', 'Groene', 'C', 'EU', '3', 'r.groene', 'Q81m6565zb'),
(2, 'Kasper', '', 'Opdam', 'C', 'EU', '5', 'k.opdam', '0V69B7YF8i'),
(3, 'Sjoerd', '', 'Hendrix', 'C', 'EU', '2', 'S.hendrix', 'rLzng9S89g'),
(4, 'Luc', 'van', 'Engelen', 'C', 'EU', '5', 'l.engelen', 'R4D4z21pxn'),
(5, 'Youri', '', 'Spa', 'C', 'EU', '3', 'y.spa', '8db75hZh1i'),
(6, 'Jan', 'van de', 'Berg', 'C', 'EU', '2', 'j.berg', 'CFGc69o7Kq'),
(7, 'Joop', 'van', 'Ede', 'C', 'NL', '1', 'j.ede', '5O9rOt5n7P'),
(8, 'Bart', 'de', 'Jong', 'C', 'NL', '2', 'o.jong', 'VN84I3nu2m'),
(9, 'Susan', '', 'Havinga', 'C', 'NL', '5', 's.havinga', 'xU3YGYwe8D'),
(10, 'Laura', 'de', 'Groot', 'C', 'NL', '1', 'l.groot', 'hpDpq85NuZ'),
(11, 'Piet', 'de', 'Klerck', 'C', 'NL', '4', 'p.klerck', '7G6p3sHE7t'),
(12, 'Sjef', '', 'Smits', 'C', 'BENELUX', '5', 's.smits', 'PM5hgO3i5s'),
(13, 'Rosa', '', 'Veenstra', 'C', 'BENELUX', '4', 'r.veenstra', 'RQAdU5Rr34'),
(14, 'Henry', '', 'Burgers', 'C', 'BENELUX', '2', 'h.burgers', 'o1U62Eiv84'),
(15, 'Cor', '', 'Vink', 'C', 'BENELUX', '2', 'c.vink', '6SBS3IY8nP'),
(16, 'Tom', '', 'Schotten', 'C', 'BENELUX', '2', 't.schotten', 'jAWc270F16'),
(17, 'Bas', 'van de', 'Brink', 'C', 'NL + B', '3', 'b.brink', 'GB0rqQG4x2'),
(18, 'Klaas', 'de', 'Boer', 'C', 'NL + D', '5', 'k.boer', '5pF5AC0IhZ'),
(19, 'Sofie', 'de', 'Vos', 'C', 'NL + D', '2', 's.vos', 'kuRH1321me'),
(20, 'Max', 'de', 'Koning', 'C', 'NL + D', '2', 'm.koning', 'c91u7K28ZA'),
(21, 'Piet', 'de', 'Leeuw', 'D', 'EU', '4', 'p.leeuw', 'JF6WO36kEa'),
(22, 'Bart', '', 'Vaessen', 'D', 'EU', '3', 'b.vaessen', 'kuJr8n5r6d'),
(23, 'Jan', '', 'Jansen', 'D', 'NL', '1', 'j.jansen', 'C038472XFi'),
(24, 'Henk', 'de', 'Rechter', 'D', 'NL', '5', 'h.rechter', 'bm699iJScZ'),
(25, 'Rik', '', 'Lamers', 'D', 'NL + D', '4', 'r.lamers', 'i7Pz5NjOe9');

-- --------------------------------------------------------

--
-- Table structure for table `klanten`
--

CREATE TABLE `klanten` (
  `klant_id` int(11) NOT NULL,
  `voornaam` varchar(100) DEFAULT NULL,
  `tussenvoegsel` varchar(100) DEFAULT NULL,
  `achternaam` varchar(100) DEFAULT NULL,
  ` geboortedatum` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  ` telefoonNr` int(11) DEFAULT NULL,
  ` postcode` varchar(23) DEFAULT NULL,
  ` straatnaam` varchar(100) DEFAULT NULL,
  ` huisNr` int(2) DEFAULT NULL,
  ` plaats` varchar(100) DEFAULT NULL,
  ` land` varchar(100) DEFAULT NULL,
  `bedrijf_particulier` tinyint(1) DEFAULT NULL,
  ` iban_nr` int(50) DEFAULT NULL,
  `wachtwoord` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `klanten`
--

INSERT INTO `klanten` (`klant_id`, `voornaam`, `tussenvoegsel`, `achternaam`, ` geboortedatum`, `email`, ` telefoonNr`, ` postcode`, ` straatnaam`, ` huisNr`, ` plaats`, ` land`, `bedrijf_particulier`, ` iban_nr`, `wachtwoord`) VALUES
(1, 'jeremie', 'de', 'vos', '17-10-1999', 'mail.com', 681701360, '6852', 'Schoren', 11, 'huissen', 'nederland', 1, 1289721213, 'ww'),
(10, '21', '21', '21', '05 March 2018', '21', 21, '6852 BW', 'molensteen', 21, 'Huissen', 'Netherlands', 1, 12, '21'),
(11, 'Jan', 'der', 'Derksen', '05 March 2018', 'derksen.mail', 682637237, '6852 BW', 'molensteen', 1, 'Huissen', 'Netherlands', 1, 2147483647, 'ww'),
(12, 'Luuk', '', 'Burgers', '22 June 1994', 'l.@hoi.nl', 612521412, '6601VD', 'Heilige stoel', 5304, 'Wijchen', 'Nederland', 0, 2147483647, 'burgers');

-- --------------------------------------------------------

--
-- Table structure for table `managers`
--

CREATE TABLE `managers` (
  `manager_ID` int(11) NOT NULL,
  `voornaam` varchar(100) DEFAULT NULL,
  `tussenvoegsel` varchar(100) DEFAULT NULL,
  `achternaam` varchar(100) DEFAULT NULL,
  `inlognaam` varchar(100) DEFAULT NULL,
  `wachtwoord` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `managers`
--

INSERT INTO `managers` (`manager_ID`, `voornaam`, `tussenvoegsel`, `achternaam`, `inlognaam`, `wachtwoord`) VALUES
(1, 'Jacqueline', 'op den', 'Dorb', 'j.dorb', 'Arnhem1974'),
(2, 'Gerbert', 'op den', 'Dorb', 'g.dorb', 'Welkom01');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_ID` int(11) NOT NULL,
  `klant_ID` int(11) DEFAULT NULL,
  `rit_ID` int(11) DEFAULT NULL,
  `postcode` varchar(50) DEFAULT NULL,
  `straatnaam` varchar(100) DEFAULT NULL,
  `huis_nr` int(2) DEFAULT NULL,
  `plaats` varchar(100) DEFAULT NULL,
  `land` varchar(100) DEFAULT NULL,
  `ontvanger` varchar(100) DEFAULT NULL,
  `datum` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_ID`, `klant_ID`, `rit_ID`, `postcode`, `straatnaam`, `huis_nr`, `plaats`, `land`, `ontvanger`, `datum`) VALUES
(9, 1, 0, '6852 BZ', 'Schoren', 11, 'Huissen', 'Netherlands', 'Jeremie de vos', '16 March 2018'),
(10, 1, 0, '6852 BZ', 'schoren ', 11, 'Huissen', 'Netherlands', 'de vos', '16 March 2018'),
(11, 12, 0, '1566 AB', 'dorpsstraat', 41, 'Assendelft', 'Netherlands', 'ah', '28 March 2018');

-- --------------------------------------------------------

--
-- Table structure for table `pallets`
--

CREATE TABLE `pallets` (
  `pallet_ID` int(11) NOT NULL,
  `order_ID` int(11) DEFAULT NULL,
  `gewicht` int(4) DEFAULT NULL,
  `inhoud` varchar(100) DEFAULT NULL,
  `notitie` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pallets`
--

INSERT INTO `pallets` (`pallet_ID`, `order_ID`, `gewicht`, `inhoud`, `notitie`) VALUES
(1, 9, 12, 'veren', 'erg zwaar voor veren weet ik :P'),
(2, 9, 1233, 'Grind', 'Zakken zijn zwaar.'),
(3, 10, 1, 'pannenkoeken', 'lekkah heb trek!'),
(4, 10, 4, 'Chocolademelk', 'Voor bij de pannekoeken :P'),
(5, 11, 71, 'fanta', ''),
(6, 11, 71, 'fanta', ''),
(7, 11, 71, 'fanta', '');

-- --------------------------------------------------------

--
-- Table structure for table `planners`
--

CREATE TABLE `planners` (
  `planner_ID` int(11) NOT NULL,
  `voornaam` varchar(100) DEFAULT NULL,
  `tussenvoegsel` varchar(100) DEFAULT NULL,
  `achternaam` varchar(100) DEFAULT NULL,
  `inlognaam` varchar(100) DEFAULT NULL,
  `wachtwoord` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `planners`
--

INSERT INTO `planners` (`planner_ID`, `voornaam`, `tussenvoegsel`, `achternaam`, `inlognaam`, `wachtwoord`) VALUES
(1, 'Trudy', '', 'Linssen', 't.linssen', '60v35MiX5'),
(2, 'Corine', 'ter', 'Dal', 'c.dal', 'e6TN07mCH'),
(3, 'Jaap', '', 'Gerritsen', 'j.gerritsen', 'uJ522Rmqo2'),
(4, 'Susan', '', 'Vlierma', 's.vlierma', 'JZ6uG13atj'),
(5, 'Jop', '', 'Spanjers', 'j.spanjers', 'I9Y9H9sU0'),
(6, 'jeremie planner', '', 'Spanjers', 'planner', 'ww');

-- --------------------------------------------------------

--
-- Table structure for table `ritten`
--

CREATE TABLE `ritten` (
  `rit_ID` int(11) NOT NULL,
  `chauffeur_ID` int(11) DEFAULT NULL,
  `vrachtwagen_ID` int(11) DEFAULT NULL,
  `rijDatum` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `vrachtwagens`
--

CREATE TABLE `vrachtwagens` (
  `vrachtwagen_ID` int(11) NOT NULL,
  `soort` varchar(100) DEFAULT NULL,
  `kenteken` varchar(100) DEFAULT NULL,
  `apk_tot` varchar(100) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vrachtwagens`
--

INSERT INTO `vrachtwagens` (`vrachtwagen_ID`, `soort`, `kenteken`, `apk_tot`, `status`) VALUES
(1, 'CF 300 FA', 'BV-45-KS', '25/02/2018', 'Beschikbaar'),
(2, 'CF 300 FA', 'BX-85-JL', '21/01/2018', 'Beschikbaar'),
(3, 'CF 300 FA', 'BW-84-KL', '01/12/2017', 'Beschikbaar'),
(4, 'CF 300 FA', 'BA-14-GF', '14/09/2018', 'Beschikbaar'),
(5, 'CF 300 FA', 'BP-77-TX', '04/08/2018', 'Beschikbaar'),
(6, 'CF 300 FA', 'BZ-84-DR', '08/06/2018', 'Beschikbaar'),
(7, 'CF 300 FA', 'BHT-87-L', '08/06/2018', 'Onderhoud'),
(8, 'CF 300 FA', 'BVT-96-R', '08/06/2018', 'Onderhoud'),
(9, 'CF 300 FA', 'BPH-44-X', '14/09/2018', 'Beschikbaar'),
(10, 'CF 300 FA', 'BY-749-B', '14/09/2018', 'Beschikbaar'),
(11, 'CF 300 FA', 'BF-659-V', '14/09/2018', 'Beschikbaar'),
(12, 'CF 410 FTN', 'BT-83-BP', '14/09/2018', 'Beschikbaar'),
(13, 'CF 410 FTN', 'BT-86-GH', '14/09/2018', 'Beschikbaar'),
(14, 'CF 410 FTN', 'BTT-58-J', '23/10/2018', 'Beschikbaar'),
(15, 'CF 410 FTN', 'BYK-71-S', '23/10/2018', 'Beschikbaar'),
(16, 'CF 410 FTN', 'BGP-56-Z', '23/10/2018', 'Beschikbaar'),
(17, 'CF 410 FTN', 'BBD-10-D', '23/10/2018', 'Beschikbaar'),
(18, 'XF 430 FTM', 'BZ-89-LW', '23/10/2018', 'Beschikbaar'),
(19, 'XF 430 FTM', 'B-845-KH', '11/12/2018', 'Beschikbaar'),
(20, 'XF 430 FTM', 'BWP-32-S', '11/12/2018', 'Beschikbaar');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chauffeurs`
--
ALTER TABLE `chauffeurs`
  ADD PRIMARY KEY (`chauffeur_ID`);

--
-- Indexes for table `klanten`
--
ALTER TABLE `klanten`
  ADD PRIMARY KEY (`klant_id`);

--
-- Indexes for table `managers`
--
ALTER TABLE `managers`
  ADD PRIMARY KEY (`manager_ID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_ID`),
  ADD KEY `FK` (`klant_ID`,`rit_ID`);

--
-- Indexes for table `pallets`
--
ALTER TABLE `pallets`
  ADD PRIMARY KEY (`pallet_ID`),
  ADD KEY `FK` (`order_ID`);

--
-- Indexes for table `planners`
--
ALTER TABLE `planners`
  ADD PRIMARY KEY (`planner_ID`);

--
-- Indexes for table `ritten`
--
ALTER TABLE `ritten`
  ADD PRIMARY KEY (`rit_ID`),
  ADD KEY `FK` (`chauffeur_ID`,`vrachtwagen_ID`);

--
-- Indexes for table `vrachtwagens`
--
ALTER TABLE `vrachtwagens`
  ADD PRIMARY KEY (`vrachtwagen_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chauffeurs`
--
ALTER TABLE `chauffeurs`
  MODIFY `chauffeur_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `klanten`
--
ALTER TABLE `klanten`
  MODIFY `klant_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `managers`
--
ALTER TABLE `managers`
  MODIFY `manager_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `pallets`
--
ALTER TABLE `pallets`
  MODIFY `pallet_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `planners`
--
ALTER TABLE `planners`
  MODIFY `planner_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `ritten`
--
ALTER TABLE `ritten`
  MODIFY `rit_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `vrachtwagens`
--
ALTER TABLE `vrachtwagens`
  MODIFY `vrachtwagen_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
