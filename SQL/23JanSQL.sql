--Joins 2 tables
--Explicit Method
SELECT CompanyName, ProductName, UnitPrice
FROM Suppliers
INNER JOIN Products ON Suppliers.SupplierID = Products.SupplierID
ORDER BY CompanyName, ProductName;

SELECT OrderID, OrderDate, CONCAT(FirstName, ' ', LastName) AS FullName
FROM Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER By OrderID;

SELECT TOP 10 City, ShipName, ShipCity
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
WHERE (City = 'Berlin') OR (City = 'México D.F.')
ORDER BY City;

--Joins 3 tables
SELECT ProductName, CompanyName, CategoryName
FROM Products
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID;

SELECT TerritoryDescription, RegionDescription
FROM Territories
INNER JOIN Region ON Region.RegionID = Territories.RegionID;

SELECT ContactName, ProductName, CompanyName
FROM Suppliers
INNER JOIN Products ON Products.SupplierID = Suppliers.SupplierID;

-- Cartesian Product (Cross Join)
SELECT CompanyName, ProductName, UnitPrice
FROM Suppliers
CROSS JOIN Products
Order BY CompanyName;

SELECT City, Freight, Quantity
FROM Orders
INNER JOIN [Order Details] ON [Order Details].OrderID = Orders.OrderID
INNER JOIN Employees ON Employees.EmployeeID = Orders.EmployeeID
ORDER BY Freight DESC;

--When there are two FROM tables they are cross joined
SELECT UnitPrice, Quantity, ProductID, OrderDate
FROM Orders, [Order Details]
WHERE OrderDate = '1998-05-05'
ORDER BY ProductID;

SELECT UnitPrice, Quantity, ProductID, OrderDate
FROM Orders
INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
WHERE OrderDate = '1998-05-05'
ORDER BY ProductID;

SELECT ContactName, ProductName
FROM Suppliers, Products
ORDER BY ContactName;

SELECT ProductName, [Order Details].UnitPrice, Quantity, OrderDate
FROM Products
INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
INNER JOIN Orders ON Orders.OrderID = [Order Details].OrderID
WHERE OrderDate = '1998-05-05';

--Self join
SELECT p1.ProductID, p1.ProductName
FROM Products AS p1, Products AS p2
WHERE p1.SupplierID = p2.SupplierID
AND p1.ProductID = 4;

SELECT CONCAT(FirstName, ' ', LastName) AS FullName, CompanyName, Quantity, ShipCountry
FROM Customers
INNER JOIN Orders ON Orders.CustomerID = Customers.CustomerID
INNER JOIN [Order Details] ON [Order Details].OrderID = Orders.OrderID
INNER JOIN Employees ON Employees.EmployeeID = Orders.EmployeeID
WHERE ShipCountry = 'France'
ORDER BY FullName;

SELECT ProductName, Products.UnitPrice, ShipCountry
FROM Products
INNER JOIN [Order Details] ON [Order Details].ProductID = Products.ProductID
INNER JOIN Orders ON Orders.OrderID = [Order Details].OrderID
WHERE ShipCountry = 'Mexico'
ORDER BY ProductName;

