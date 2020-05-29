CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate DECIMAL(5, 2),
	WeeklyRate DECIMAL(5, 2),
	MonthlyRate DECIMAL(5, 2),
	WeekendRate DECIMAL(5, 2)
)

INSERT INTO Categories(CategoryName)
		VALUES
				('Category1'),
				('Category2'),
				('Category3')

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	PlateNumber NVARCHAR(10) NOT NULL,
	Manufacturer NVARCHAR(30) NOT NULL,
	Model NVARCHAR(50) NOT NULL,
	CarYear DATETIME2 NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	Doors SMALLINT NOT NULL,
	Picture VARBINARY(MAX),
	Condition NVARCHAR(50) NOT NULL,
	Available NVARCHAR(50) NOT NULL
)

INSERT INTO Cars
		VALUES
				('В 2078 РК', 'Renaut', 'Clio', '2004', 1, 5, null,'used', 'yes'),
				('С 8473 ЕВ', 'Opel', 'Vectra', '1999', 2, 5, null, 'used', 'yes'),
				('С 3839 ЕT', 'Ford', 'Focus', '2007', 1, 3, null, 'used', 'yes')

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees(FirstName, LastName, Title)
		VALUES
				('Ivan', 'Georgiev', 'Mechanic'),
				('Atanas', 'Hristov', 'Mechanic'),
				('Vladislav', 'Dimitrov', 'Menager')

CREATE TABLE Customers(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	DriverLicenceNumber NVARCHAR(50) NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	City NVARCHAR(50) NOT NULL,
	ZIPCode INT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Customers
		VALUES	
				('2837981372','Petya Minkova', 'Knyaz Boris 1 160', 'Sofia', 1000, Null),
				('4646474930', 'Nayden Naydenov', 'Shiroka Lyka 5', 'Sofia', 1030, Null),
				('1928376459', 'Kiril Kirilov', 'Stara planina 8', 'Klisura', 4147, Null)

CREATE TABLE RentalOrders(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
	CarId  INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
	TankLevel DECIMAL(5,2) NOT NULL,
	KilometrageStart FLOAT(20) NOT NULL,
	KilometrageEnd FLOAT(20) NOT NULL,
	TotalKilometrage FLOAT(20) NOT NULL,
	StartDate DATETIME2 NOT NULL,
	EndDate DATETIME2 NOT NULL,
	TotalDays BIGINT NOT NULL,
	RateApplied DECIMAL(5,2) NOT NULL,
	TaxRate  DECIMAL(5,2) NOT NULL,
	OrderStatus BIT NOT NULL, 
	Notes NVARCHAR(500) NOT NULL
)

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
		VALUES
				(1, 1, 1, 50, 1200, 1500, 300, '02.02.2020', '03.02.2020', 30, 7.2, 2.3, 1, 'Good car!'),
				(2, 2, 2, 50, 1200, 1500, 300, '02.02.2020', '03.02.2020', 30, 7.2, 2.3, 1, 'Good car!'),
				(3, 3, 3, 50, 1200, 1500, 300, '02.02.2020', '03.02.2020', 30, 7.2, 2.3, 1, 'Good car!')