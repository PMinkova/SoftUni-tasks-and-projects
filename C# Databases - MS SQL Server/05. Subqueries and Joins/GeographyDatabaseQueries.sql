USE Geography

-- Problem 12

SELECT 
  mc.CountryCode,
  m.MountainRange,
  p.PeakName,
  p.Elevation
FROM 
  MountainsCountries as mc
  JOIN Mountains as m ON mc.MountainId = m.Id
  JOIN Peaks as p ON p.MountainId = m.Id
WHERE 
  p.Elevation > 2835 AND mc.CountryCode = 'BG'
ORDER BY
  p.Elevation DESC


-- Problem 13

SELECT  
  CountryCode,
  COUNT(MountainId) AS MountainRanges
FROM 
  MountainsCountries
WHERE 
  CountryCode IN ('BG', 'RU', 'US')
GROUP BY CountryCode


-- Problem 14

SELECT 
  TOP 5 c.CountryName, 
  r.RiverName 
FROM 
  Countries AS c 
  LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode 
  LEFT JOIN Rivers AS r ON r.Id = cr.RiverId 
  LEFT JOIN Continents as cn ON c.ContinentCode = cn.ContinentCode 
WHERE 
  cn.ContinentName = 'Africa' 
ORDER BY 
  c.CountryName


  -- Problem 15


SELECT 
  [r].ContinentCode, 
  [r].CurrencyCode, 
  [r].CurrencyUsage 
FROM 
  (
    SELECT 
      c.[ContinentCode], 
      c.[CurrencyCode], 
      COUNT(c.[CurrencyCode]) AS [CurrencyUsage], 
      DENSE_RANK() OVER (
        PARTITION BY c.[ContinentCode] 
        ORDER BY 
          COUNT(c.[CurrencyCode]) DESC
      ) AS [CurrencyRank] 
    FROM 
      [Countries] AS [c] 
    GROUP BY 
      c.[ContinentCode], 
      c.[CurrencyCode] 
    HAVING 
      COUNT(c.[CurrencyCode]) > 1
  ) AS [r] 
WHERE 
  [r].CurrencyRank = 1 
ORDER BY 
  [r].ContinentCode


-- Problem 16 

SELECT 
  COUNT(*) AS [Count] 
FROM 
  Countries AS c 
  LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode 
WHERE 
  MountainId IS NULL


-- Problem 17

SELECT TOP (5) 
  c.CountryName,
  MAX(p.Elevation) AS HighestPeakElevation,
  MAX(r.Length) AS LongestRiverLength
FROM 
  Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY 
  CountryName
ORDER BY
  HighestPeakElevation DESC,
  LongestRiverLength DESC


-- Problem 18

SELECT 
  TOP (5) CountryName AS Country, 
  CASE WHEN PeakName IS NULL THEN '(no highest peak)' ELSE PeakName END AS [Highest Peak Name], 
  CASE WHEN Elevation IS NULL THEN 0 ELSE Elevation END AS [Highest Peak Elevation], 
  CASE WHEN MountainRange IS NULL THEN '(no mountain)' ELSE MountainRange END AS Mountain 
FROM 
  (
    SELECT 
      c.CountryName, 
      p.PeakName, 
      p.Elevation, 
      m.MountainRange, 
      DENSE_RANK() OVER(
        PARTITION BY c.CountryName 
        ORDER BY 
          p.Elevation DESC
      ) AS [PeakRank] 
    FROM 
      Countries AS c 
      LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode 
      LEFT JOIN Mountains AS m ON m.Id = mc.MountainId 
      LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId 
      LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode 
      LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
  ) AS PeakRankingSubquery 
WHERE 
  PeakRank = 1 
ORDER BY 
  Country, 
  [Highest Peak Name]

