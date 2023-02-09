USE Gringotts

-- Problem 01

SELECT 
  COUNT(*) 
FROM 
  WizzardDeposits


-- Problem 02

SELECT TOP (1) 
  MagicWandSize AS LongestMagicWand 
FROM 
  WizzardDeposits 
ORDER BY 
  MagicWandSize DESC


-- Problem 03

SELECT 
  DepositGroup,
  MAX(MagicWandSize) AS LongestMagicWand 
FROM 
  WizzardDeposits
GROUP BY 
  DepositGroup


  -- Problem 04

SELECT 
  TOP 2 DepositGroup 
FROM 
  WizzardDeposits 
GROUP BY 
  DepositGroup 
ORDER BY 
  AVG(MagicWandSize)


-- Problem 05

SELECT 
  DepositGroup,
  SUM(DepositAmount) AS TotalSum
FROM 
  WizzardDeposits
GROUP BY DepositGroup


-- Problem 06

SELECT 
  DepositGroup,
  SUM(DepositAmount)
FROM 
  WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup


-- Problem 07

SELECT 
  DepositGroup, 
  SUM(DepositAmount) AS TotalSum 
FROM 
  WizzardDeposits 
WHERE 
  MagicWandCreator = 'Ollivander family' 
GROUP BY 
  DepositGroup 
HAVING 
  SUM(DepositAmount) < 150000 
ORDER BY 
  TotalSum DESC

-- Problem 08

SELECT 
  DepositGroup, 
  MagicWandCreator, 
  MIN(DepositCharge) 
FROM 
  WizzardDeposits 
GROUP BY 
  DepositGroup, 
  MagicWandCreator
ORDER BY 
  MagicWandCreator,
  DepositGroup
  

-- Problem 09

SELECT 
  AgeGroup, 
  COUNT(*) 
FROM 
  (
    SELECT 
      CASE WHEN Age BETWEEN 0 
      AND 10 THEN '[0-10]' WHEN Age BETWEEN 11 
      AND 20 THEN '[11-20]' WHEN Age BETWEEN 21 
      AND 30 THEN '[21-30]' WHEN Age BETWEEN 31 
      AND 40 THEN '[31-40]' WHEN Age BETWEEN 41 
      AND 50 THEN '[41-50]' WHEN Age BETWEEN 51 
      AND 60 THEN '[51-60]' ELSE '[61+]' END AS AgeGroup 
    FROM 
      WizzardDeposits
  ) AS AgeGroupSubquery 
GROUP BY 
  AgeGroup


-- Problem 10

SELECT 
  LEFT(FirstName, 1) FROM WizzardDeposits
WHERE 
  DepositGroup = 'Troll Chest'
GROUP BY 
  LEFT(FirstName, 1)


-- Problem 11

SELECT 
  DepositGroup, 
  IsDepositExpired, 
  AVG(DepositInterest) AS AverageInterest 
FROM 
  WizzardDeposits 
WHERE 
  DepositStartDate > CONVERT(DATETIME, 01 / 01 / 1985, 120) 
GROUP BY 
  DepositGroup, 
  IsDepositExpired 
ORDER BY 
  DepositGroup DESC, 
  IsDepositExpired


--Problem 12

SELECT 
  SUM([Difference]) AS SumDifference 
FROM 
  (
    SELECT 
      wd1.FirstName AS [Host Wizzard], 
      wd1.DepositAmount AS [Host Wizard Deposit], 
      wd2.FirstName AS [Guest Wizard], 
      wd2.DepositAmount AS [Guest Wizzard Deposit], 
      (
        wd1.DepositAmount - wd2.DepositAmount
      ) AS [Difference] 
    FROM 
      WizzardDeposits AS wd1 
      JOIN WizzardDeposits AS wd2 ON wd1.Id + 1 = wd2.Id
  ) AS DepositDifferenceSubquery




