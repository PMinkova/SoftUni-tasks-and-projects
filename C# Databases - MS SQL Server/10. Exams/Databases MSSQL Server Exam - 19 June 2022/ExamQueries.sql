CREATE DATABASE Zoo

USE Zoo

-- Problem 01

CREATE TABLE Owners
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL,
	[Address] VARCHAR(50) 
)


CREATE TABLE AnimalTypes
(
  Id INT PRIMARY KEY IDENTITY,
  AnimalType VARCHAR(30) NOT NULL
)

CREATE TABLE Cages
( 
  Id INT PRIMARY KEY IDENTITY,
  AnimalTypeId INT NOT NULL FOREIGN KEY REFERENCES AnimalTypes(Id) 
 )

CREATE TABLE Animals
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR (30) NOT NULL,
	BirthDate DATE NOT NULL,
	OwnerId INT FOREIGN KEY REFERENCES Owners(Id),
	AnimalTypeId INT NOT NULL FOREIGN KEY REFERENCES AnimalTypes(Id)
)

CREATE TABLE AnimalsCages
( 
	CageId INT NOT NULL FOREIGN KEY REFERENCES Cages(Id),
	AnimalId INT NOT NULL FOREIGN KEY REFERENCES Animals(Id)
	PRIMARY KEY(CageId, AnimalId)
)

CREATE TABLE VolunteersDepartments
(
	Id INT PRIMARY KEY IDENTITY,
	DepartmentName VARCHAR(30) NOT NULL
)

CREATE TABLE Volunteers
( 
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL, 
	PhoneNumber VARCHAR(15) NOT NULL,
	[Address] VARCHAR(50),
	AnimalId INT FOREIGN KEY REFERENCES Animals(Id),
	DepartmentId INT NOT NULL FOREIGN KEY REFERENCES VolunteersDepartments(Id)
) 


-- Problem 02

INSERT INTO Volunteers 
	VALUES	
		('Anita Kostova', '0896365412', 'Sofia, 5 Rosa str.', 15, 1),
		('Dimitur Stoev', '0877564223', NULL, 42, 4),
		('Kalina Evtimova', '0896321112', 'Silistra, 21 Breza str.', 9, 7),
		('Stoyan Tomov', '0898564100', 'Montana, 1 Bor str.', 18, 8),
		('Boryana Mileva', '0888112233', NULL, 31, 5)

INSERT INTO Animals 
	VALUES
        ('Giraffe', '2018-09-21',	21,	1),
        ('Harpy Eagle', '2015-04-17', 15,	3),
        ('Hamadryas Baboon', '2017-11-02', NULL, 1),
        ('Tuatara', '2021-06-30',	2, 4)

			
-- Problem 03


UPDATE 
  Animals 
SET 
  OwnerId = (
    SELECT 
      Id 
    FROM 
      Owners 
    WHERE 
      [Name] = 'Kaloqn Stoqnov'
  ) 
WHERE 
  OwnerId IS NULL



-- Problem 04

SELECT 
  * 
FROM 
  VolunteersDepartments 
WHERE 
  DepartmentName = 'Education program assistant' 

SELECT 
  * 
FROM 
  Volunteers 
WHERE 
  DepartmentId = 2;

DELETE FROM 
  Volunteers 
WHERE 
  DepartmentId = (
    SELECT 
      Id 
    FROM 
      VolunteersDepartments 
    WHERE 
      DepartmentName = 'Education program assistant'
  ) 

DELETE FROM 
  VolunteersDepartments 
WHERE 
  DepartmentName = 'Education program assistant'


 -- Problem 05

SELECT 
  [Name], 
  PhoneNumber, 
  [Address], 
  AnimalId, 
  DepartmentId 
FROM 
  Volunteers 
ORDER BY 
  [Name], 
  AnimalId, 
  DepartmentId

 
-- Problem 06

SELECT 
  a.Name, 
  at.AnimalType, 
  FORMAT(a.BirthDate, 'dd.MM.yyyy') AS BirthDate
FROM 
  Animals AS a 
  JOIN AnimalTypes AS at ON a.AnimalTypeId = at.Id 
ORDER BY 
  a.[Name]

-- Problem 07

SELECT 
  TOP 5 o.Name, 
  COUNT(a.Id) AS CountOfAnimals
FROM 
  Animals AS a 
  JOIN Owners AS o ON o.Id = a.OwnerId 
GROUP BY 
  o.Name  
ORDER BY 
  COUNT(a.Id) DESC


-- Problem 08

SELECT 
  CONCAT(o.[Name], '-', a.[Name]) AS OwnersAnimals, 
  o.PhoneNumber, 
  ac.CageId 
FROM 
  Animals as a 
  JOIN Owners as o ON a.OwnerId = o.Id 
  Join AnimalsCages as ac ON ac.AnimalId = a.Id 
  JOIN AnimalTypes as at ON at.Id = a.AnimalTypeId 
WHERE 
  at.AnimalType = 'Mammals' 
ORDER BY 
  o.[Name], 
  a.[Name] DESC


-- Problem 09 

 SELECT 
  v.[Name], 
  v.PhoneNumber, 
  SUBSTRING(v.Address, CHARINDEX(',', v.Address) + 2, LEN(v.Address) - CHARINDEX(',', v.Address))   
FROM 
  Volunteers AS v 
  JOIN VolunteersDepartments AS vd ON v.DepartmentId = vd.Id 
WHERE 
  v.[Address] LIKE '%Sofia%' AND 
  vd.DepartmentName = 'Education program assistant' 
ORDER BY 
  v.[Name]

  
  -- Problem 10

SELECT 
  a.[Name], 
  YEAR(a.BirthDate) AS BirthYear, 
  at.AnimalType 
FROM 
  Animals AS a 
  JOIN AnimalTypes AS at ON at.Id = a.AnimalTypeId 
WHERE 
  a.OwnerId IS NULL 
  AND DATEDIFF(YEAR, a.BirthDate, '01/01/2022') < 5 
  AND at.AnimalType != 'Birds' 
ORDER BY 
  a.Name


-- Problem 11

CREATE FUNCTION udf_GetVolunteersCountFromADepartment 
(@departmentent VARCHAR(30)) 
RETURNS INT 
AS 
BEGIN 
DECLARE @departmentId INT = 
(SELECT 
    Id 
  FROM 
    VolunteersDepartments 
  WHERE 
    DepartmentName = @departmentent)
  RETURN 
  (SELECT 
    COUNT(*) 
  FROM 
    Volunteers 
  WHERE 
    DepartmentId = @departmentId) 
END


-- Problem 12

CREATE PROCEDURE usp_AnimalsWithOwnersOrNot(
  @AnimalName VARCHAR(30)
) AS BEGIN 
SELECT 
  a.[Name], 
  ISNULL(o.[Name], 'For adoption') 
FROM 
  Animals AS a 
  LEFT JOIN Owners AS o ON a.OwnerId = o.Id 
WHERE 
  a.[Name] = @AnimalName END


EXEC usp_AnimalsWithOwnersOrNot 'Pumpkinseed Sunfish'
