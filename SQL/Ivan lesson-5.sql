CREATE DATABASE TINDER

USE TINDER

CREATE TABLE City(
	CityId int IDENTITY(1,1) primary key,
	CityName varchar (20),
	)

CREATE TABLE USERS(
	UserId int IDENTITY(1,1) primary key,
	UserName varchar(50),
	Age int,
	Gender char,
	CityId int,
	FOREIGN KEY(CityId) REFERENCES City(CityId),
	UserDate Date,
	)

CREATE TABLE Prefernces(
	PreferenceId int IDENTITY(1,1) primary key,
	UserId int,
	FOREIGN KEY(UserId) REFERENCES USERS(UserId),
	PreferredGender varchar(30),
	Age int,
	CityId int,
	FOREIGN KEY(CityId) REFERENCES City(CityId),
	)

SELECT MIN(Age)
FROM Prefernces;

SELECT MAX(Age)
FROM Prefernces;

CREATE TABLE Matches(
	MatchId int IDENTITY(1,1) Primary key,
	UserId1 int,
	FOREIGN KEY(UserId1) REFERENCES USERS(UserId),
	UserId2 int,
	FOREIGN KEY(UserId2) REFERENCES USERS(UserId),
	MatchDate Date,
	MatchStatus varchar(20),
	)
CREATE TABLE UserMessages(
	MessageId int IDENTITY(1,1) Primary key,
	MatchId int,
	FOREIGN KEY(MatchId) REFERENCES Matches(MatchId),
	SenderId int,
	FOREIGN KEY(SenderId) REFERENCES USERS(UserId),
	ReceiverId int,
	FOREIGN KEY(ReceiverId) REFERENCES USERS(UserId),
	MessageContent varchar(50),
	SentDate TIMESTAMP,
	)

INSERT INTO City
VALUES(1, 'Kardzhali');
INSERT INTO City VALUES(2, 'Plovdiv');
INSERT INTO City VALUES(3, 'Sofia');
INSERT INTO City VALUES(4, 'Varna');
INSERT INTO City VALUES(5, 'Burgas');
INSERT INTO City VALUES(6, 'Ruse');
INSERT INTO City VALUES(7, 'Stara Zagora');
INSERT INTO City VALUES(8, 'Pleven');
INSERT INTO City VALUES(9, 'Sliven');
INSERT INTO City VALUES(10, 'Dobrich');
INSERT INTO City VALUES(11, 'Shumen');
INSERT INTO City VALUES(12, 'Pernik');
INSERT INTO City VALUES(13, 'Haskovo');
INSERT INTO City VALUES(14, 'Blagoevgrad');
INSERT INTO City VALUES(15, 'Yambol');
INSERT INTO City VALUES(16, 'Asenovgrad');
INSERT INTO City VALUES(17, 'Vidin');
INSERT INTO City VALUES(18, 'Vratsa');
INSERT INTO City VALUES(19, 'Gabrovo');
INSERT INTO City VALUES(20, 'Razgrad');
INSERT INTO City VALUES(21, 'Montana');

INSERT INTO USERS
VALUES (1, 'Alper', 21, 'male', 'Kardzhali', 2025-01-24);
INSERT INTO USERS VALUES (2, 'Emre', 25, 'male', 'Plovdiv', '2025-01-24');
INSERT INTO USERS VALUES (3, 'Selin', 22, 'female', 'Sofia', '2025-01-24');
INSERT INTO USERS VALUES (4, 'Ece', 30, 'female', 'Varna', '2025-01-24');
INSERT INTO USERS VALUES (5, 'Ahmet', 28, 'male', 'Burgas', '2025-01-24');
INSERT INTO USERS VALUES (6, 'Murat', 27, 'male', 'Ruse', '2025-01-24');
INSERT INTO USERS VALUES (7, 'Zeynep', 23, 'female', 'Stara Zagora', '2025-01-24');
INSERT INTO USERS VALUES (8, 'Burak', 29, 'male', 'Pleven', '2025-01-24');
INSERT INTO USERS VALUES (9, 'Ayşe', 26, 'female', 'Sliven', '2025-01-24');
INSERT INTO USERS VALUES (10, 'Kerem', 24, 'male', 'Dobrich', '2025-01-24');
INSERT INTO USERS VALUES (11, 'Can', 22, 'male', 'Shumen', '2025-01-24');
INSERT INTO USERS VALUES (12, 'Melis', 31, 'female', 'Pernik', '2025-01-24');
INSERT INTO USERS VALUES (13, 'Yusuf', 34, 'male', 'Haskovo', '2025-01-24');
INSERT INTO USERS VALUES (14, 'Ezgi', 21, 'female', 'Blagoevgrad', '2025-01-24');
INSERT INTO USERS VALUES (15, 'Tugce', 33, 'female', 'Yambol', '2025-01-24');
INSERT INTO USERS VALUES (16, 'Berk', 28, 'male', 'Asenovgrad', '2025-01-24');
INSERT INTO USERS VALUES (17, 'Ceyda', 29, 'female', 'Vidin', '2025-01-24');
INSERT INTO USERS VALUES (18, 'Okan', 25, 'male', 'Vratsa', '2025-01-24');
INSERT INTO USERS VALUES (19, 'Hande', 32, 'female', 'Gabrovo', '2025-01-24');
INSERT INTO USERS VALUES (20, 'Kaan', 26, 'male', 'Razgrad', '2025-01-24');
INSERT INTO USERS VALUES (21, 'Deniz', 27, 'male', 'Montana', '2025-01-24');

INSERT INTO Prefernces
VALUES(1, 1, 'male', 18, 30, 'Kardzhali') 
INSERT INTO Prefernces VALUES(2, 2, 'female', 20, 35, 'Plovdiv');
INSERT INTO Prefernces VALUES(3, 3, 'male', 22, 28, 'Sofia');
INSERT INTO Prefernces VALUES(4, 4, 'female', 25, 30, 'Varna');
INSERT INTO Prefernces VALUES(5, 5, 'male', 20, 35, 'Burgas');
INSERT INTO Prefernces VALUES(6, 6, 'female', 18, 40, 'Ruse');
INSERT INTO Prefernces VALUES(7, 7, 'male', 23, 33, 'Stara Zagora');
INSERT INTO Prefernces VALUES(8, 8, 'female', 21, 31, 'Pleven');
INSERT INTO Prefernces VALUES(9, 9, 'male', 19, 29, 'Sliven');
INSERT INTO Prefernces VALUES(10, 10, 'female', 24, 34, 'Dobrich');
INSERT INTO Prefernces VALUES(11, 11, 'male', 18, 32, 'Shumen');
INSERT INTO Prefernces VALUES(12, 12, 'female', 20, 40, 'Pernik');
INSERT INTO Prefernces VALUES(13, 13, 'male', 22, 38, 'Haskovo');
INSERT INTO Prefernces VALUES(14, 14, 'female', 19, 28, 'Blagoevgrad');
INSERT INTO Prefernces VALUES(15, 15, 'male', 26, 36, 'Yambol');
INSERT INTO Prefernces VALUES(16, 16, 'female', 23, 33, 'Asenovgrad');
INSERT INTO Prefernces VALUES(17, 17, 'male', 25, 35, 'Vidin');
INSERT INTO Prefernces VALUES(18, 18, 'female', 22, 32, 'Vratsa');
INSERT INTO Prefernces VALUES(19, 19, 'male', 18, 25, 'Gabrovo');
INSERT INTO Prefernces VALUES(20, 20, 'female', 21, 30, 'Razgrad');
INSERT INTO Prefernces VALUES(21, 21, 'male', 20, 30, 'Montana');

SELECT MIN(Age) AS MinimumAge
FROM Prefernces

SELECT MAX(Age) AS MaximumAge
FROM Prefernces


INSERT INTO Matches
VALUES(1, 1, 2, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(2, 2, 3, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(3, 3, 4, '2025-01-24', 'Rejected');
INSERT INTO Matches VALUES(4, 4, 5, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(5, 5, 6, '2025-01-24', 'Rejected');
INSERT INTO Matches VALUES(6, 6, 7, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(7, 7, 8, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(8, 8, 9, '2025-01-24', 'Rejected');
INSERT INTO Matches VALUES(9, 9, 10, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(10, 10, 11, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(11, 11, 12, '2025-01-24', 'Rejected');
INSERT INTO Matches VALUES(12, 12, 13, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(13, 13, 14, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(14, 14, 15, '2025-01-24', 'Rejected');
INSERT INTO Matches VALUES(15, 15, 16, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(16, 16, 17, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(17, 17, 18, '2025-01-24', 'Rejected');
INSERT INTO Matches VALUES(18, 18, 19, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(19, 19, 20, '2025-01-24', 'Accepted');
INSERT INTO Matches VALUES(20, 20, 21, '2025-01-24', 'Rejected');










