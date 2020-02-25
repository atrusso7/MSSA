SELECT *
FROM Sales.OrderDetails;
--Q17
SELECT TOP 10 (unitprice * qty) as Total
FROM Sales.OrderDetails
WHERE (unitprice * qty) > 10000
ORDER BY Total;

--Q18
SELECT CONCAT(LastName, ', ', FirstName) AS FullName, Quantity, ShipCountry
FROM dbo.Orders AS o
JOIN [Order Details] on [Order Details].OrderID = o.OrderID
JOIN Employees AS e on e.EmployeeID = o.EmployeeID
WHERE ShipCountry = 'Argentina'
ORDER BY Quantity;

--Q19
SELECT TOP 10 CompanyName, Country, COUNT(o.CustomerID) as Orders
FROM Customers AS c
JOIN dbo.Orders AS o ON o.CustomerID = c.CustomerID
GROUP BY o.CustomerID, CompanyName, Country
ORDER BY Orders DESC;

--Q20
DROP VIEW IF EXISTS AllMyDog;
CREATE VIEW AllMyDog AS
SELECT petid, SpeciesName	
FROM Pets
Join PetSpecies on PetSpecies.PetSpeciesID = pets.PetSpeciesID
WHERE SpeciesName = 'Dog';

SET IDENTITY_INSERT Owner ON;
INSERT INTO Owner (OwnerID, FirstName, LastName, Mobile, Email, Notes)
Values
(333, 'John', 'WAYNE', '121-999-0909', 'jw@hotmail.com', 'Famous Actor');

ALTER VIEW AllMyDog
AS
SELECT
LastName, FirstName, email, mobile, notes
FROM Owner
WHERE LastName = 'Wayne';

SELECT *
FROM AllMyDog;