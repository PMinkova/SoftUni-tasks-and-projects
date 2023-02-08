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