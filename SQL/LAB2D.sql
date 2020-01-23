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

SELECT CONCAT(FirstName, ' ', LastName, CHAR(13), Title, CHAR(13), '___________________') AS FullNameAndTitle
FROM Employees;
                      
SELECT CompanyName, ContactName = LEFT(ContactName, CHARINDEX(' ', ContactName) - 1)
FROM Customers
WHERE CHARINDEX(' ', ContactName) > 0;

SELECT CompanyName, ContactName = RIGHT(ContactName, LEN(ContactName) - CHARINDEX(' ', ContactName))
FROM Customers
WHERE CHARINDEX(' ', ContactName) > 0
ORDER BY ContactName;

SELECT DATEDIFF(DAY, '1991/12/11', '2020/01/22') AS AgeInDays;
