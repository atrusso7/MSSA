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
INNER JOIN Region ON Region.RegionID = Territories.RegionID

SELECT ContactName, ProductName, CompanyName
FROM Suppliers
INNER JOIN Products ON Products.SupplierID = Suppliers.SupplierID;
