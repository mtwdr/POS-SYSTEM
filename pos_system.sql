-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 12, 2022 at 10:54 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `LastName` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `Company` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Telephone` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`LastName`, `FirstName`, `Company`, `Address`, `Telephone`, `Email`) VALUES
('Ramnarine', 'Matthew', 'Vanier College ', '821 Sainte Croix Ave, Saint-Laurent, Quebec H4L 3X9', '5146515167', 'matthewramnarine@hotmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `Sku` varchar(255) NOT NULL,
  `Barcode` varchar(255) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Price` decimal(65,2) NOT NULL,
  `Quantity` varchar(255) NOT NULL,
  `Location` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`Sku`, `Barcode`, `ProductName`, `Price`, `Quantity`, `Location`) VALUES
('123123', '10000000001', 'Pen', '1.00', '25', 'A1'),
('123124', '10000000002', 'Computer', '1.99', '1', 'A1');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderNumber` varchar(255) NOT NULL,
  `OrderType` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `Company` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Telephone` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Products` varchar(255) NOT NULL,
  `Quantities` varchar(255) NOT NULL,
  `Prices` varchar(255) NOT NULL,
  `Total` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderNumber`, `OrderType`, `LastName`, `FirstName`, `Company`, `Address`, `Telephone`, `Email`, `Products`, `Quantities`, `Prices`, `Total`) VALUES
('9154401', 'Deliveries', 'Ramnarine', 'Matthew', 'Vanier College ', '821 Sainte Croix Ave, Saint-Laurent, Quebec H4L 3X9', '5146515167', 'matthewramnarine@hotmail.com', '123124;123123;123123;', '99;12;123;', '1.99;1.00;1.00;', '395.27');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `UserType` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `LastName`, `FirstName`, `Password`, `UserType`) VALUES
('500', 'Manager', 'Manager', 'admin', 'Manager'),
('400', 'Customer Service', 'Customer Service', 'admin', 'Customer Service'),
('300', 'Cashier', 'Cashier', 'admin', 'Cashier'),
('200', 'Clerk', 'Clerk', 'admin', 'Clerk');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
