-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2020 at 04:50 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csharp_roombooking_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `EmployeeID` int(11) NOT NULL,
  `EmployeeFname` varchar(72) COLLATE utf8_bin NOT NULL,
  `EmployeeLname` varchar(72) COLLATE utf8_bin NOT NULL,
  `EmployeeEmail` varchar(100) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`EmployeeID`, `EmployeeFname`, `EmployeeLname`, `EmployeeEmail`) VALUES
(1, 'Shawn', 'Lee', 'ShawnL@TayMark.com'),
(2, 'Marki', 'West', 'MarkiW@TayMark.com'),
(3, 'Suliman ', 'Lin', 'SulimanL@TayMark.com'),
(4, 'Letti', 'Mccarthy', 'LettiM@TayMark.com'),
(5, 'Tony', 'Harris', 'TonyH@TayMark.com'),
(6, 'Hannah', 'Parson', 'HannahP@TayMark.com'),
(7, 'Sarah', 'Campos', 'SarahC@TayMark.com'),
(8, 'Sophi', 'Hatter', 'SophiH@TayMark.com'),
(9, 'Jack', 'Hammond', 'JackH@TayMark.com'),
(10, 'Calcifer', 'Garza', 'CalciferG@TayMark.com'),
(11, 'Nunnally', 'Lynch', 'NunnallyL@TayMark.com'),
(12, 'Lelouch', 'Lynch', 'LelouchL@TayMark.com'),
(13, 'Harry', 'Macinnes', 'HarryM@Example.com');

-- --------------------------------------------------------

--
-- Table structure for table `meetingemployees`
--

CREATE TABLE `meetingemployees` (
  `MeetingEmployeeID` int(11) NOT NULL,
  `employees.EmployeeID` int(11) NOT NULL,
  `meetings.MeetingID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `meetings`
--

CREATE TABLE `meetings` (
  `MeetingID` int(11) NOT NULL,
  `Rooms.RoomID` int(11) NOT NULL,
  `MeetingStart` varchar(72) COLLATE utf8_bin DEFAULT NULL,
  `MeetingEnd` varchar(72) COLLATE utf8_bin DEFAULT NULL,
  `MeetingDesc` varchar(200) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `RoomID` int(11) NOT NULL,
  `RoomName` varchar(72) COLLATE utf8_bin NOT NULL,
  `RoomCapacity` varchar(72) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`RoomID`, `RoomName`, `RoomCapacity`) VALUES
(1, 'SemiCircle', '2'),
(2, 'Triangle', '3'),
(3, 'Square', '4'),
(4, 'Pentagon', '5'),
(5, 'Hexagon', '6'),
(6, 'Octagon', '8');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(50) NOT NULL,
  `username` varchar(50) COLLATE utf8_bin NOT NULL,
  `password` varchar(50) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`EmployeeID`);

--
-- Indexes for table `meetingemployees`
--
ALTER TABLE `meetingemployees`
  ADD PRIMARY KEY (`MeetingEmployeeID`),
  ADD KEY `meetingemployees_ibfk_1` (`meetings.MeetingID`),
  ADD KEY `meetingemployees_ibfk_2` (`employees.EmployeeID`);

--
-- Indexes for table `meetings`
--
ALTER TABLE `meetings`
  ADD PRIMARY KEY (`MeetingID`),
  ADD KEY `meetings_ibfk_1` (`Rooms.RoomID`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`RoomID`),
  ADD UNIQUE KEY `RoomName` (`RoomName`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `EmployeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `meetingemployees`
--
ALTER TABLE `meetingemployees`
  MODIFY `MeetingEmployeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=155;

--
-- AUTO_INCREMENT for table `meetings`
--
ALTER TABLE `meetings`
  MODIFY `MeetingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=60;

--
-- AUTO_INCREMENT for table `rooms`
--
ALTER TABLE `rooms`
  MODIFY `RoomID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `meetingemployees`
--
ALTER TABLE `meetingemployees`
  ADD CONSTRAINT `meetingemployees_ibfk_1` FOREIGN KEY (`meetings.MeetingID`) REFERENCES `meetings` (`MeetingID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `meetingemployees_ibfk_2` FOREIGN KEY (`employees.EmployeeID`) REFERENCES `employees` (`EmployeeID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `meetings`
--
ALTER TABLE `meetings`
  ADD CONSTRAINT `meetings_ibfk_1` FOREIGN KEY (`Rooms.RoomID`) REFERENCES `rooms` (`RoomID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
