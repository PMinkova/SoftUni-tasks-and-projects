CREATE DATABASE [Movies]

USE [Movies] 

CREATE TABLE [Directors](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[DirectorName] NVARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(2000)
)

CREATE TABLE [Genres](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[GenreName] NVARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(2000)
)

CREATE TABLE [Categories](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[CategoryName] NVARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(2000) 
)

CREATE TABLE [Movies](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Title] NVARCHAR(100) NOT NULL,
	[Direc1torId] INT FOREIGN KEY REFERENCES [Directors]([Id]) NOT NULL,
	[CopyrightYear] INT NOT NULL,
	[Length] INT NOT NULL,
	[GenreId] INT FOREIGN KEY REFERENCES [Genres]([Id]) NOT NULL,
	[CategoryId] INT FOREIGN KEY REFERENCES [Categories]([Id]),
	[Rating] DECIMAL(2,1) NOT NULL,
	[Notes] NVARCHAR(2000)
)

INSERT INTO [Directors]
	VALUES
		('Chris Columbus', NULL),
		('Alfonso Cuarón', NULL),
		('Mike Newell', NULL),
		('David Yates', NULL),
		('Peter Jackson', NULL)

INSERT INTO [Genres] (GenreName)
	VALUES	
		('Drama'),
		('Action'),
		('Horror'),
		('Western'),
		('Fantasy')

INSERT INTO [Categories](CategoryName)
	VALUES 
		('Film series'),
		('Telenovela'),
		('Sitcom'),
		('Animation'),
		('Documentary')

INSERT INTO [Movies]
	VALUES 
		('Harry Potter and the Philosopher''s Stone', 1, 2001, 152, 5, 1, 8.1, NULL),
		('Harry Potter and the Chamber of Secrets', 1, 2002, 161, 5, 1, 8.2, NULL),
		('Harry Potter and the Prisoner of Azkaban', 1, 2004, 167, 5, 2, 8.3, NULL),
		('Harry Potter and the Goblet of Fire', 1, 2005, 157, 5, 3, 9.8, NULL),
		('Harry Potter and the Order of the Phoenix', 1, 2007, 146, 5, 1, 9.1, NULL)