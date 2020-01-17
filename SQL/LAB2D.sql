SELECT * 
FROM Customers;

SELECT ContactName, Country
FROM Customers
WHERE Country IN ('Mexico', 'USA', 'Canada')
ORDER BY Country;

SELECT *
FROM Orders
WHERE (OrderDate BETWEEN '19980401' AND '19980430')
ORDER BY OrderID;

SELECT *
FROM Categories;

SELECT ProductName
FROM Products
WHERE ProductName LIKE '%sauce%';

SELECT ProductName 
FROM Products
WHERE ProductName LIKE '%dried%';

SELECT *
FROM Orders
WHERE ShipCountry = 'Germany' AND MONTH(ShippedDate) = 12;

SELECT SUM((Quantity * UnitPrice) - (Quantity * Discount)) AS NetAmountWithDiscount, SUM(Quantity * UnitPrice) AS TotalAmountWithoutDiscount
FROM [Order Details]
WHERE ProductID = 19 AND Discount > 0;