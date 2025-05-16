-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2025 at 09:51 AM
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
-- Database: `dbmanajemenfilm`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `id_akun` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `role` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`id_akun`, `username`, `password`, `role`) VALUES
(3, 'pemvis8', 'pemvis', 'Admin'),
(4, 'pemvis8user', 'pemvis', 'Pengguna Biasa'),
(5, 'pemvis82user', 'pemvis', 'Pengguna Biasa'),
(6, 'pemvis81user', 'pemvis', 'Pengguna Biasa'),
(7, 'pemviss8', 'pemvis', 'Pengguna Biasa'),
(8, 'pemvisss8', 'pemvis', 'Pengguna Biasa');

-- --------------------------------------------------------

--
-- Table structure for table `film`
--

CREATE TABLE `film` (
  `id_film` int(11) NOT NULL,
  `judul` text NOT NULL,
  `genre` text NOT NULL,
  `tglrilis` text NOT NULL,
  `rating` text NOT NULL,
  `gambar` text NOT NULL,
  `views` text NOT NULL,
  `id_akun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `film`
--

INSERT INTO `film` (`id_film`, `judul`, `genre`, `tglrilis`, `rating`, `gambar`, `views`, `id_akun`) VALUES
(9, 'Pengabdi Setan', 'Horror, Thriller, Mistery', '24/05/2025 23:00:59', '4', 'C:\\Users\\User\\Downloads\\Pengabdi_Setan_poster.jpg', '8', 3),
(10, 'Instellar Science', 'Adventure, Action, Science Fiction, Mistery', '15/05/2025 23:01:42', '4', 'C:\\Users\\User\\Downloads\\instellar.jpg', '20', 3),
(11, 'Fast X Part 2', 'Adventure, Action, Drama', '29/04/2025 23:02:16', '3', 'C:\\Users\\User\\Downloads\\fast x 2.jpg', '15', 3),
(13, 'The Meg 2', 'Comedy, Thriller, Mistery', '01/06/2023 23:18:34', 'Kosong', 'C:\\Users\\User\\Downloads\\film 2.jpeg', '7', 3),
(14, 'The Last Of Us', 'Adventure, Horror, Action, Thriller, Mistery', '08/02/2024 23:19:12', 'Kosong', 'C:\\Users\\User\\Downloads\\film 3.jpeg', '4', 3),
(15, 'Inception', 'Adventure, Science Fiction', '15/05/2025 23:19:59', 'Kosong', 'C:\\Users\\User\\Downloads\\film 4.jpeg', '2', 3),
(16, 'Suzanna', 'Horror, Thriller', '16/05/2025 23:20:50', 'Kosong', 'C:\\Users\\User\\Downloads\\suzanna.jpg', '1', 3),
(17, 'Gravity', 'Adventure, Horror, Science Fiction, Thriller', '15/05/2025 23:21:30', '5', 'C:\\Users\\User\\Downloads\\gravity.jpg', '2', 3),
(19, 'Film b', 'Adventure, Horror', '16/05/2025 14:20:16', 'Kosong', 'C:\\Users\\User\\Downloads\\film 3.jpeg', '0', 3);

-- --------------------------------------------------------

--
-- Table structure for table `film_antrian`
--

CREATE TABLE `film_antrian` (
  `id_antrian` int(11) NOT NULL,
  `id_film` int(11) NOT NULL,
  `id_akun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `film_antrian`
--

INSERT INTO `film_antrian` (`id_antrian`, `id_film`, `id_akun`) VALUES
(30, 10, 4),
(37, 10, 5),
(39, 10, 7),
(44, 10, 8),
(31, 11, 4),
(38, 11, 6),
(40, 11, 7),
(27, 13, 4),
(45, 14, 8),
(32, 15, 4),
(36, 17, 4),
(41, 17, 7);

-- --------------------------------------------------------

--
-- Table structure for table `film_favorit`
--

CREATE TABLE `film_favorit` (
  `id_favorit` int(11) NOT NULL,
  `id_film` int(11) NOT NULL,
  `id_akun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `film_favorit`
--

INSERT INTO `film_favorit` (`id_favorit`, `id_film`, `id_akun`) VALUES
(38, 9, 4),
(47, 9, 5),
(39, 10, 4),
(46, 10, 5),
(48, 10, 6),
(49, 10, 7),
(54, 10, 8),
(34, 11, 4),
(53, 11, 7),
(55, 11, 8),
(36, 13, 4),
(50, 13, 7),
(57, 13, 8),
(42, 14, 4),
(51, 14, 7),
(45, 15, 5),
(52, 15, 7),
(43, 17, 4);

-- --------------------------------------------------------

--
-- Table structure for table `film_rate_user`
--

CREATE TABLE `film_rate_user` (
  `id_rate_user` int(11) NOT NULL,
  `id_film` int(11) DEFAULT NULL,
  `id_akun` int(11) DEFAULT NULL,
  `rating` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `film_rate_user`
--

INSERT INTO `film_rate_user` (`id_rate_user`, `id_film`, `id_akun`, `rating`) VALUES
(14, 9, 4, '5'),
(15, 11, 4, '5'),
(18, 9, 5, '3'),
(19, 11, 5, '3'),
(22, 11, 7, '2'),
(23, 10, 7, '4'),
(24, 17, 7, '5'),
(25, 11, 8, '5');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id_akun`);

--
-- Indexes for table `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`id_film`),
  ADD KEY `id_akun` (`id_akun`);

--
-- Indexes for table `film_antrian`
--
ALTER TABLE `film_antrian`
  ADD PRIMARY KEY (`id_antrian`),
  ADD KEY `id_film` (`id_film`,`id_akun`),
  ADD KEY `fk_antrian_akun` (`id_akun`);

--
-- Indexes for table `film_favorit`
--
ALTER TABLE `film_favorit`
  ADD PRIMARY KEY (`id_favorit`),
  ADD KEY `id_film` (`id_film`,`id_akun`),
  ADD KEY `fk_favorit_akun` (`id_akun`);

--
-- Indexes for table `film_rate_user`
--
ALTER TABLE `film_rate_user`
  ADD PRIMARY KEY (`id_rate_user`),
  ADD KEY `id_film` (`id_film`,`id_akun`),
  ADD KEY `fk_rate_akun` (`id_akun`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `akun`
--
ALTER TABLE `akun`
  MODIFY `id_akun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `film`
--
ALTER TABLE `film`
  MODIFY `id_film` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `film_antrian`
--
ALTER TABLE `film_antrian`
  MODIFY `id_antrian` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `film_favorit`
--
ALTER TABLE `film_favorit`
  MODIFY `id_favorit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `film_rate_user`
--
ALTER TABLE `film_rate_user`
  MODIFY `id_rate_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `film`
--
ALTER TABLE `film`
  ADD CONSTRAINT `fk_akun_film` FOREIGN KEY (`id_akun`) REFERENCES `akun` (`id_akun`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `film_antrian`
--
ALTER TABLE `film_antrian`
  ADD CONSTRAINT `fk_antrian_akun` FOREIGN KEY (`id_akun`) REFERENCES `akun` (`id_akun`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_antrian_film` FOREIGN KEY (`id_film`) REFERENCES `film` (`id_film`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `film_favorit`
--
ALTER TABLE `film_favorit`
  ADD CONSTRAINT `fk_favorit_akun` FOREIGN KEY (`id_akun`) REFERENCES `akun` (`id_akun`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_favorit_film` FOREIGN KEY (`id_film`) REFERENCES `film` (`id_film`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `film_rate_user`
--
ALTER TABLE `film_rate_user`
  ADD CONSTRAINT `fk_rate_akun` FOREIGN KEY (`id_akun`) REFERENCES `akun` (`id_akun`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_rate_film` FOREIGN KEY (`id_film`) REFERENCES `film` (`id_film`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
