CREATE DATABASE MusicHubs;
GO

USE MusicHubs;
GO

CREATE TABLE Writers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    WriterName VARCHAR(30) NOT NULL,
    Pseudonym VARCHAR(40)
);

CREATE TABLE Performers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(30) NOT NULL,
    LastName VARCHAR(30) NOT NULL,
    Age INT CHECK (Age > 0),
    NetWorth DECIMAL(15,2) DEFAULT 0
);

CREATE TABLE Producers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ProducerName VARCHAR(30) NOT NULL,
    Pseudonym VARCHAR(40),
    PhoneNumber VARCHAR(15) -- Changed from INT to VARCHAR to store full phone numbers
);

CREATE TABLE Albums (
    Id INT PRIMARY KEY IDENTITY(1,1),
    AlbumName VARCHAR(40) NOT NULL,
    ReleaseDate DATE,
    ProducerId INT,
    CONSTRAINT FK_Albums_Producers FOREIGN KEY (ProducerId) REFERENCES Producers(Id) ON DELETE SET NULL
);

CREATE TABLE Songs (
    Id INT PRIMARY KEY IDENTITY(1,1),
    SongName VARCHAR(40) NOT NULL,
    Duration INT CHECK (Duration > 0),
    CreatedOn DATE,
    Genre VARCHAR(30),
    AlbumId INT NOT NULL, 
    WriterId INT NOT NULL, 
    Price DECIMAL(10,2) CHECK (Price >= 0),
    CONSTRAINT FK_Songs_Albums FOREIGN KEY (AlbumId) REFERENCES Albums(Id) ON DELETE CASCADE,
    CONSTRAINT FK_Songs_Writers FOREIGN KEY (WriterId) REFERENCES Writers(Id) ON DELETE CASCADE
);

CREATE TABLE SongsPerformers (
    SongId INT NOT NULL,
    PerformerId INT NOT NULL,
    PRIMARY KEY (SongId, PerformerId), -- Composite Primary Key
    CONSTRAINT FK_SongsPerformers_Songs FOREIGN KEY (SongId) REFERENCES Songs(Id) ON DELETE CASCADE,
    CONSTRAINT FK_SongsPerformers_Performers FOREIGN KEY (PerformerId) REFERENCES Performers(Id) ON DELETE CASCADE
);
