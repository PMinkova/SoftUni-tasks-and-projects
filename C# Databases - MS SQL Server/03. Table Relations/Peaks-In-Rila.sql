-- Problem 9. *Peaks in Rila

--  Display all peaks for "Rila" mountain. Include:
--•	MountainRange
--•	PeakName
--•	Elevation

USE Geography

SELECT MountainRange, PeakName, Elevation FROM Peaks
	JOIN Mountains ON MountainId = Mountains.Id
	WHERE MountainRange = 'Rila'
	ORDER BY Elevation DESC