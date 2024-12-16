-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 16, 2024 at 05:18 PM
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
-- Database: `finalcsproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `data`
--

CREATE TABLE `data` (
  `ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `age` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `Gender` enum('Male','Female','Other') NOT NULL,
  `DOB` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `data`
--

INSERT INTO `data` (`ID`, `name`, `surname`, `age`, `username`, `password`, `Gender`, `DOB`) VALUES
(1, 'Allen', 'Banana', 21, 'zyte', 'password123', 'Male', '2002-12-09'),
(2, 'chian', 'arara', 23, '', '', 'Male', '0000-00-00'),
(3, 'len', 'leneee', 19, '', '', 'Male', '0000-00-00'),
(4, 'zel', 'befd', 20, '', '', 'Female', '0000-00-00'),
(5, 'yaaaa', 'hehe', 34, '', '', 'Male', '2003-08-29'),
(6, 'Maria', 'Lopez', 27, 'mlopez', 'securepass01', 'Female', '1997-05-14'),
(7, 'John', 'Doe', 30, 'johndoe', 'mypassword', 'Male', '1994-09-22'),
(8, 'Ella', 'Smith', 22, 'esmith22', 'password2023', 'Female', '2002-11-01'),
(9, 'Liam', 'Brown', 25, 'liam_b', 'liamsecure', 'Male', '1999-03-15'),
(10, 'Sofia', 'Garcia', 21, 'sofia21', 'garciapass', 'Female', '2003-07-08'),
(11, 'Ethan', 'Davis', 18, 'ethanD', 'davispw', 'Male', '2005-01-12'),
(12, 'Olivia', 'Martinez', 24, 'oliviam', 'passMartinez', 'Female', '1999-12-30'),
(13, 'Mason', 'Taylor', 20, 'masont', 'taylor2023', 'Male', '2004-06-18'),
(14, 'Isabella', 'Wilson', 28, 'bella_w', 'wilson123', 'Female', '1996-10-05'),
(15, 'Aiden', 'Moore', 23, 'aiden23', 'moorepass', 'Male', '2001-04-07'),
(16, 'default_name', 'default_surname', 0, 'John', 'Smith', 'Other', '2000-01-01'),
(17, 'default_name', 'default_surname', 0, 'allen09', 'password', 'Other', '2000-01-01'),
(18, 'default_name', 'default_surname', 0, 'zyte', 'password', 'Other', '2000-01-01'),
(19, 'default_name', 'default_surname', 0, 'banana', 'banana', 'Other', '2000-01-01'),
(20, 'default_name', 'default_surname', 0, 'potato', 'password', 'Other', '2000-01-01'),
(21, 'default_name', 'default_surname', 0, '', '', 'Other', '2000-01-01'),
(22, 'default_name', 'default_surname', 0, 'fries', 'potato', 'Other', '2000-01-01'),
(23, 'default_name', 'default_surname', 0, 'allen', 'password', 'Other', '2000-01-01'),
(24, 'default_name', 'default_surname', 0, 'fries', 'password', 'Other', '2000-01-01'),
(25, 'John', 'Smith', 67, '', '', 'Male', '1995-06-23'),
(26, 'default_name', 'default_surname', 0, 'make', '123', 'Other', '2000-01-01'),
(27, 'Fries', 'Banana', 28, '', '', 'Female', '2008-08-13'),
(28, 'default_name', 'default_surname', 0, 'random', 'password', 'Other', '2000-01-01'),
(29, 'Random', 'Smith', 54, '', '', 'Male', '2003-06-10'),
(30, 'default_name', 'default_surname', 0, 'wando', 'password', 'Other', '2000-01-01'),
(31, 'default_name', 'default_surname', 0, 'wando', 'password', 'Other', '2000-01-01'),
(32, 'default_name', 'default_surname', 0, 'john09', 'password', 'Other', '2000-01-01'),
(33, 'Wando', 'Heck', 29, '', '', 'Male', '2005-05-02'),
(34, 'default_name', 'default_surname', 0, 'paul', 'password', 'Other', '2000-01-01'),
(35, 'Paul', 'Smith', 35, '', '', 'Male', '1995-11-29'),
(36, 'default_name', 'default_surname', 0, 'allen123', 'password', 'Other', '2000-01-01'),
(37, 'default_name', 'default_surname', 0, 'allen009', 'password', 'Other', '2000-01-01'),
(38, 'default_name', 'default_surname', 0, 'allen23', 'password', 'Other', '2000-01-01'),
(39, 'Allen', 'Christian', 21, '', '', 'Male', '2002-12-09'),
(40, 'default_name', 'default_surname', 0, 'acallen123', 'password', 'Other', '2000-01-01'),
(41, 'default_name', 'default_surname', 0, 'acallen09', 'password', 'Other', '2000-01-01'),
(42, 'Chian', 'Len', 56, '', '', 'Male', '1999-02-09'),
(43, 'Allen', 'Smith', 67, '', '', 'Male', '1999-08-12'),
(44, 'default_name', 'default_surname', 0, 'yan', 'password', 'Other', '2000-01-01'),
(45, 'Yan', 'Smith', 23, '', '', 'Female', '2005-06-17');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data`
--
ALTER TABLE `data`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data`
--
ALTER TABLE `data`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
