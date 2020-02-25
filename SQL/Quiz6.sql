--1
CREATE PROCEDURE dbo.GetOrders @ShipCountry nvarchar(30)
AS
SELECT * FROM dbo.orders Where ShipCountry = @ShipCountry;

EXEC dbo.GetOrders @ShipCountry = 'Germany';

--2
SELECT *
INTO dbo.OrdersClone
From dbo.Orders;

--3
DELETE FROM dbo.OrdersClone WHERE ShipCountry = 'Brazil';

--4
SELECT *
INTO dbo.T2
FROM Employees
WHERE Country = 'USA';