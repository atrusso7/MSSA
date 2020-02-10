--List the number of orders by each customer who lives in the United States using a CTE. Sort from highest to lowest.
With CTE1
As
(Select Orders.CustomerID, Count(Orders.CustomerID) totalNumber from Orders
Join Customers On Customers.CustomerID = Orders.CustomerID
Where Customers.Country = 'USA'
Group By Orders.CustomerID)
Select * 
From CTE1
Order By totalNumber DESC;
--List the product name and the number of each product from a German supplier sold to a customer in Germany using a CTE. Sort from highest to lowest.
With CTE2
As
(Select Products.ProductID, ProductName, Country, ShipCountry
From Products
Join Suppliers On Suppliers.SupplierID = Products.SupplierID
Join [Order Details] On [Order Details].ProductID = Products.ProductID
Join Orders On [Order Details].OrderID = Orders.OrderID
Where Country = 'Germany' AND ShipCountry = 'Germany')
Select ProductName, Count(ProductID) as ProductTotal
From CTE2
Group By ProductName
Order By ProductTotal DESC;
--Prepare an employee report showing the name of each employee, the number of employees they supervise, and the name of their supervisor using a CTE. Sort by the number of employees supervised.
With CTE3
As
(Select FirstName, LastName , EmployeeID, ReportsTo
From Employees)
Select STRING_AGG(LastName,';') as Names, ReportsTo, Count(ReportsTo) as NumSupervised
From CTE3
Group By ReportsTo
Order By NumSupervised;
--Create a query that returns every distinct customer/employee pair.
With EmpCustPairs
AS
(SELECT Distinct CONCAT(Customers.CustomerID,Employees.EmployeeID) As CustomerEmployeePair
FROM Employees
Join Orders On Orders.EmployeeID = Employees.EmployeeID
Join Customers On Customers.CustomerID = Orders.CustomerID)
Select *
From EmpCustPairs;
--Use that query to write another query turning the customerid, customername, and customercontact, and the employeeid, firstname, and lastname.
With EmpCustPairs
AS
(SELECT Distinct CONCAT(Firstname, ' ', LastName) As Names, ContactName, ShipName, Employees.EmployeeID, CONCAT(Customers.CustomerID,Employees.EmployeeID) As CustomerEmployeePair
FROM Employees
Join Orders On Orders.EmployeeID = Employees.EmployeeID
Join Customers On Customers.CustomerID = Orders.CustomerID)
Select *
From EmpCustPairs
Order By Names;
--Create a view based on your query.
Create View [EmpCust Pairs]
AS
(SELECT Distinct CONCAT(Firstname, ' ', LastName) As Names, CompanyName, ContactName, ShipName, Employees.EmployeeID, CONCAT(Customers.CustomerID,Employees.EmployeeID) As CustomerEmployeePair
FROM Employees
Join Orders On Orders.EmployeeID = Employees.EmployeeID
Join Customers On Customers.CustomerID = Orders.CustomerID)
--Write a report listing all customers served by employee 7, Robert King.
Select ContactName, Names
From [EmpCust Pairs]
Where EmployeeID = 7;
--Write a report listing all employees who served customer CHOPS, Chop-suey Chinese.
Select Names, CompanyName
From [EmpCust Pairs]
Where CompanyName Like '%chop%';
--Drop the view.
Drop View [EmpCust Pairs];