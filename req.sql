-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2024 at 11:39 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `req`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `course_code` varchar(20) NOT NULL,
  `course_desc` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`course_code`, `course_desc`) VALUES
('BSCE', 'Bachelor of Science in Civil Engineering'),
('BSIT', 'Bachelor of Science in Information Technology'),
('BSPs', 'Bachelor of Science in Psychology');

-- --------------------------------------------------------

--
-- Table structure for table `scholars`
--

CREATE TABLE `scholars` (
  `student_id` varchar(30) NOT NULL,
  `studentName` varchar(50) NOT NULL,
  `sex` varchar(30) NOT NULL,
  `course_code` varchar(20) NOT NULL,
  `mobile_number` varchar(30) NOT NULL,
  `date_birth` date NOT NULL,
  `address` varchar(30) NOT NULL,
  `gwa` varchar(50) DEFAULT NULL,
  `income` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `scholars`
--

INSERT INTO `scholars` (`student_id`, `studentName`, `sex`, `course_code`, `mobile_number`, `date_birth`, `address`, `gwa`, `income`) VALUES
('21090', 'Jean Alvaro', 'Male', 'BSIT', '091222212', '2024-01-18', '113123dsds ', '2.0', 0),
('34', 'Lightning, Neon', 'Male', 'BSIT', '091111', '2023-11-04', 'VALORANT', '1.9', 0);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `student_id` varchar(11) NOT NULL,
  `studentName` varchar(50) DEFAULT NULL,
  `sex` varchar(6) DEFAULT NULL,
  `course_code` varchar(20) NOT NULL,
  `mobile_number` varchar(11) DEFAULT NULL,
  `date_birth` varchar(15) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(30) NOT NULL,
  `gwa` varchar(50) DEFAULT NULL,
  `income` int(11) NOT NULL,
  `status` varchar(15) NOT NULL DEFAULT 'On Review'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`student_id`, `studentName`, `sex`, `course_code`, `mobile_number`, `date_birth`, `address`, `username`, `password`, `gwa`, `income`, `status`) VALUES
('10023', 'Alice Cababat', 'Female', 'BSME', '09292212333', '2024-04-22', 'Tarlac', 'alice', '', '2.1', 5000, 'On Review'),
('0892', 'Colets Vergara', 'Female', 'BSCE', '8', '2024-06-05', 'kyusi', 'colets', '', '1', 1500, 'Accepted'),
('0028', 'Donn Quinto', 'Male', 'BSIT', '0945736487', '2024-01-06', 'Bayambang', 'donn', '', '1', 9999, 'On Review'),
('0025', 'Jaide Lampa', 'Female', 'BSIT', '097894512', '2024-01-02', 'San Nicolas', 'jaide', '', '2.3', 15000, 'On Review'),
('123', 'Lara Jean Alvaro', 'Female', 'BSCE', '12312', '2024-01-22', '123', 'lara', 'lara', '1.2', 1233, 'Accepted'),
('1002365', ' Ma. Loi', 'Male', 'BSIT', '21220200', '2024-04-22', 'Batangas', 'maloi', '', '2.5', 7000, 'On Review'),
('002\r\n', 'Melanie Nozuelo', 'Female', 'BSME', '0919354865', '2024-01-22', 'Villasis', 'mel', '', '2.8', 8999, 'On Review'),
('653', 'Yara', 'Female', 'BSCE', '123', '2024-01-22', '1223', 'yara', '', '3', 4466, 'On Review');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `role` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `role`) VALUES
('1', '1', 'Admin'),
('admin', 'admin', 'Admin'),
('alice', 'alice', 'Student'),
('colets', 'colets', 'Student'),
('donn', 'donn', 'Student'),
('gab', 'gab', 'Student'),
('jaide', 'jaide', 'Student'),
('lara', 'lara', 'Student'),
('maloi', 'amloi', 'Student'),
('mel', 'mel', 'Student'),
('yara', 'yara', 'Student');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`course_code`);

--
-- Indexes for table `scholars`
--
ALTER TABLE `scholars`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`username`),
  ADD KEY `course_fk` (`course_code`),
  ADD KEY `student_id` (`student_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`username`) REFERENCES `user` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
