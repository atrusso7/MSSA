SELECT *
FROM Sales.OrderDetails;

SELECT *
FROM Sales.Orders;

SELECT *
FROM HR.Employees;

SELECT orderid, (qty * unitprice) as Total
FROm Sales.OrderDetails
WHERE (qty * unitprice) < 10000
ORDER BY Total;

SELECT freight, qty, city
FROM Sales.Orders
Join Sales.OrderDetails on Sales.OrderDetails.orderid = Sales.Orders.orderid
Join HR.Employees on Hr.Employees.empid = Sales.Orders.empid;


Select *
From Pets;

CREATE VIEW AllMyDog AS
SELECT petid, SpeciesName	
FROM Pets
Join PetSpecies on PetSpecies.PetSpeciesID = pets.PetSpeciesID
WHERE SpeciesName = 'Dog';

Select *
From AllMyDog
Order By PetID;
