USE SoftUni

-- Problem 01

SELECT 
  TOP (5) e.EmployeeID, 
  e.JobTitle, 
  e.AddressId, 
  a.AddressText 
FROM 
  Employees as e 
  LEFT JOIN Addresses as a ON e.AddressId = a.AddressId 
Order By 
  e.AddressId


-- Problem 02

SELECT 
  TOP 50 e.FirstName, 
  e.LastName, 
  t.[Name] as Town, 
  a.AddressText 
FROM 
  Employees as e 
  LEFT JOIN Addresses as a ON e.AddressID = a.AddressID 
  LEFT JOIN Towns as t ON t.TownID = a.TownID 
ORDER BY 
  FirstName, 
  LastName


-- Problem 03

SELECT 
  e.EmployeeID, 
  e.FirstName, 
  e.LastName, 
  d.[Name] as DepartmentName 
FROM 
  Employees as e 
  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID 
WHERE 
  d.[Name] = 'Sales'


-- Problem 04

SELECT 
  TOP (5) e.EmployeeID, 
  e.FirstName, 
  e.Salary, 
  d.[Name] as DepartmentName 
FROM 
  Employees as e 
  JOIN Departments as D ON e.DepartmentID = d.DepartmentID 
WHERE 
  e.Salary > 15000 
ORDER BY 
  e.DepartmentID


-- Problem 05

SELECT 
  TOP 3 e.EmployeeId, 
  e.FirstName 
FROM 
  Employees as e 
  LEFT JOIN EmployeesProjects as ep ON ep.EmployeeID = e.EmployeeID 
WHERE 
  ep.ProjectID IS NULL


-- Problem 06

SELECT 
  e.FirstName, 
  e.LastName, 
  e.HireDate, 
  d.[Name] as DeptName 
FROM 
  Employees as e 
  JOIN Departments as d ON d.DepartmentID = e.DepartmentID 
WHERE 
  d.[Name] IN ('Sales', 'Finance') 
ORDER BY 
  e.HireDate


-- Problem 07 

SELECT 
  TOP 5 e.EmployeeId, 
  e.FirstName, 
  p.[Name] as ProjectName 
FROM 
  Employees as e 
  JOIN EmployeesProjects as ep ON e.EmployeeID = ep.EmployeeID 
  LEFT JOIN Projects as p ON ep.ProjectID = p.ProjectID 
WHERE 
  p.StartDate > 13 / 08 / 2002 
  AND p.EndDate IS NULL


-- Problem 08

SELECT 
  e.EmployeeID, 
  e.FirstName, 
  CASE WHEN p.StartDate >= '2005-01-01' THEN NULL ELSE p.[Name] END AS ProjectName
FROM 
  Employees AS e
  JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
  JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE 
  e.EmployeeID = 24


-- Problem 09

SELECT 
  e.EmployeeID, 
  e.FirstName, 
  e.ManagerID, 
  m.FirstName AS ManagerName
FROM 
  Employees AS e 
  JOIN Employees AS m ON e.ManagerID = m.EmployeeID 
WHERE 
  e.ManagerID IN (3, 7)


 -- Problem 10

SELECT 
  TOP 50 e.EmployeeID, 
  CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName, 
  CONCAT(m.FirstName, ' ', m.LastName) AS ManagerName, 
  d.[Name] AS DepartmentName 
FROM 
  Employees as e 
  JOIN Employees as m ON e.ManagerID = m.EmployeeID 
  JOIN Departments as d ON d.DepartmentID = e.DepartmentID


-- Problem 11

SELECT 
  MIN(AvgSalary) AS MinAverageSalary 
FROM 
  (
    SELECT 
      AVG(Salary) AS AvgSalary 
    FROM 
      Employees 
    GROUP BY 
      DepartmentID
  ) AS DepartmentsSalary;