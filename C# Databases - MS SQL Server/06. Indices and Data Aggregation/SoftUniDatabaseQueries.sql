USE SoftUni

-- Problem 13

SELECT 
  DepartmentID,
  SUM(Salary) AS TotalSalary
FROM
  Employees
GROUP BY 
  DepartmentID


-- Problem 14

SELECT 
  DepartmentID,
  MIN(Salary) AS MinimumSalary
FROM
  Employees
WHERE HireDate > '2000-01-01'
GROUP BY 
  DepartmentID
HAVING DepartmentID IN (2, 5, 7)


-- Problem 15

SELECT 
  * INTO NewTable 
FROM 
  Employees 
WHERE 
  Salary > 30000 

DELETE FROM 
  NewTable 
WHERE 
  ManagerID = 42 
UPDATE 
  NewTable 
SET 
  Salary += 5000 
WHERE 
  DepartmentID = 1 

SELECT 
  DepartmentId, 
  AVG(Salary) AS AverageSalary
FROM 
  NewTable 
GROUP BY 
  DepartmentID


-- Problem 16

SELECT 
  DepartmentID,
  MAX(Salary) AS MaxSalary
FROM 
  Employees
GROUP BY 
  DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000


--Problem 17

SELECT 
  COUNT(Salary) AS [Count] 
FROM 
  Employees 
WHERE 
  ManagerID IS NULL


-- Problem 18

SELECT 
  DepartmentID, 
  MAX(Salary) AS ThirdHighestSalary 
FROM 
  (
    SELECT 
      DepartmentID, 
      Salary, 
      DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC)
      AS [Rank]
    FROM 
      Employees
  ) AS t 
WHERE 
  Rank = 3 
GROUP BY 
  DepartmentID


-- Problem 19

SELECT 
  TOP 10 e.FirstName, 
  e.LastName, 
  e.DepartmentID 
FROM 
  Employees AS e
  JOIN (
    SELECT 
      e.DepartmentID, 
      AVG(e.Salary) AS AverageSalary
    FROM 
      Employees AS e
    GROUP BY 
      e.DepartmentID
  ) AS AvgTable ON e.DepartmentID = AvgTable.DepartmentID
WHERE 
  e.Salary > AvgTable.AverageSalary