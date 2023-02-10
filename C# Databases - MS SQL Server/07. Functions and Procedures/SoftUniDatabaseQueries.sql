USE SoftUni


-- Problem 01

CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000 
AS 
  SELECT 
    FirstName, 
    LastName 
  FROM 
    Employees 
  WHERE 
    SALARY > 35000 


EXEC usp_GetEmployeesSalaryAbove35000

GO

-- Problem 02

CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber @number DECIMAL(18,4)
AS
  SELECT 
    FirstName,
	LastName
  FROM 
    Employees
  WHERE Salary >= @number

EXEC usp_GetEmployeesSalaryAboveNumber 48100

GO


-- Problem 03

CREATE PROCEDURE usp_GetTownsStartingWith @word VARCHAR(100)
AS
  SELECT 
    [Name] AS Town
  FROM 
    Towns
  WHERE 
    SUBSTRING([Name], 1, LEN(@word)) = @word

EXEC usp_GetTownsStartingWith 'b'

GO


-- Problem 04 

CREATE PROCEDURE usp_GetEmployeesFromTown @town VARCHAR(100)
AS
  SELECT 
    FirstName,
	LastName
  FROM 
    Employees AS e
  JOIN Addresses AS a ON e.AddressID = a.AddressID
  JOIN Towns AS t ON t.TownID = a.TownID
  WHERE t.[Name] = @town

EXEC usp_GetEmployeesFromTown 'Sofia'
  

GO


-- Problem 05

CREATE FUNCTION udf_GetSalaryLevel (@salary DECIMAL(18,4))
RETURNS VARCHAR(10)
AS
BEGIN
  RETURN CASE
      WHEN @salary < 30000 THEN 'Low'
      WHEN @salary >= 30000 AND @salary <= 50000 THEN 'Average'
      ELSE 'High'
    END
END

GO

-- Problem 06

CREATE PROCEDURE usp_EmployeesBySalaryLevel @salaryLevel VARCHAR(10)
AS
BEGIN
  SELECT 
    FirstName,
	LastName
  FROM 
    Employees 
  WHERE dbo.udf_GetSalaryLevel(Salary) = @salaryLevel
END

EXEC dbo.usp_EmployeesBySalaryLevel 'High'

GO

 -- Problem 07

 CREATE FUNCTION udf_IsWordComprised
 @setOfLetters VARCHAR(50), @word VARCHAR(50)
 RETURNS BIT
 AS
 BEGIN
   DECLARE @wordIndex INT = 1
   WHILE(@wordIndex <= LEN(@wordIndex))
		BEGIN
		 DECLARE @currentCharacter CHAR = SUBSTRING(@word, @wordIndex, 1)
		 IF CHARINDEX(@currentCharacter, @setOfLetters) = 0
		 BEGIN
		 RETURN 0
		 END
		 SET @wordIndex += 1
		END
		RETURN 1
 END
 GO

SELECT dbo.udf_IsWordComprised 'oistmiahf', 'sofia'


-- Problem 08 

CREATE PROC usp_DeleteEmployeesFromDepartment 
@departmentId INT
AS
BEGIN
	ALTER TABLE Departments
	ALTER COLUMN ManagerID INT NULL
	
	DELETE FROM EmployeesProjects	
	WHERE EmployeeID IN
	(
		SELECT EmployeeID FROM Employees
		WHERE DepartmentID = @departmentId
	)

	UPDATE Employees
	SET ManagerID = NULL
	WHERE ManagerID IN
	(
		SELECT EmployeeID FROM Employees
		WHERE DepartmentID = @departmentId
	)
	
	UPDATE Departments
	SET ManagerID = NULL
	WHERE DepartmentID = @departmentId
	
 	DELETE FROM Employees
	WHERE DepartmentID = @departmentId

	DELETE FROM Departments
	WHERE DepartmentID = @departmentId

	SELECT COUNT(*) FROM Employees
	WHERE DepartmentID = @departmentId
END
