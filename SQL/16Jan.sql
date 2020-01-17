SELECT ProductID, UnitPrice, ProductName
FROM Products
WHERE SupplierID = 6 AND UnitPrice < 100;

SELECT ProductID, UnitPrice, ProductName
FROM Products
WHERE SupplierID = 6 OR SupplierID = 1;

SELECT ProductName, UnitPrice
FROM Products
WHERE SupplierID IN (1, 10)
ORDER BY ProductName;

SELECT ProductName, UnitPrice
FROM Products
WHERE SupplierID IN (SELECT SupplierID FROM Products WHERE SupplierID = 1 AND SupplierID = 10)
ORDER BY ProductName;

SELECT ProductName, UnitPrice, SupplierID
FROM Products
WHERE SupplierID NOT IN (1, 6)
ORDER BY ProductName;

SELECT ProductName
FROM Products
WHERE ProductName LIKE 'G%';

SELECT TerritoryDescription
FROM Territories AS t
WHERE t.RegionID = 4;

SELECT CONCAT(CompanyName, ', ', Country)
FROM Suppliers;
