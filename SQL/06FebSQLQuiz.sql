--Question 1
With Customer1_CTE
As
(Select Products.ProductID, ProductName, Country, ShipCountry
From Products
Join Suppliers On Suppliers.SupplierID = Products.SupplierID
Join [Order Details] On [Order Details].ProductID = Products.ProductID
Join Orders On [Order Details].OrderID = Orders.OrderID
Where Country = 'Germany' AND ShipCountry = 'Germany')
Select * 
From Customer1_CTE
Order By ProductID DESC;
--Question 2
With EmpCustPairs
AS
(SELECT Distinct CONCAT(Firstname, ' ', LastName) As Names, ContactName, ShipName, Employees.EmployeeID, CONCAT(Customers.CustomerID,Employees.EmployeeID) As CustomerEmployeePair
FROM Employees
Join Orders On Orders.EmployeeID = Employees.EmployeeID
Join Customers On Customers.CustomerID = Orders.CustomerID)
Select *
From EmpCustPairs
Order By Names

