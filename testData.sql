-- Q2. Create a simple web-based database that stores the data between the main player and their IPD within the experience.
-- IPD means Interpupillary Distance
-- Headset IPD means to the distance between the lenses
-- we are going to make a database that store the player information
-- it will have name or username, headset number, and IPD
-- IPD value is in mm (millimeter)

-- Database name: dataTest
CREATE DATABASE IF NOT EXISTS `dataTest` DEFAULT CHARACTER SET utf8
 COLLATE utf8_general_ci;
Use `dataTest`;

-- Table structure for the table `Users`
DROP TABLE IF EXISTS `Users`;
CREATE TABLE `Users` (
`#` int(11) NOT NULL,
`UserId` INT(11) NOT NULL,
`Username` varchar(255) DEFAULT NULL,
`HeadsetNo.` int(11) NOT NULL,
`IPD_mm` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8; 

-- Dumping data for table `Users`

INSERT INTO `Users` (`#`, `UserId`, `Username`,`HeadsetNo.`, `IPD_mm`) VALUES
(1, 1,'DummyTest1', 1, '48'),
(2, 20,'AdminOne', 2, '60'),
(3, 10,'BrendaK', 3, '50'),
(4, 2,'AllenJ', 4, '72'),
(5, 35,'JWBrodt', 5, '63'),
(6, 42,'WallyZ', 6, '55');

-- Making index for dumped table

-- Index for table `Users`

ALTER TABLE `Users`
	ADD PRIMARY KEY(`#`);