With Customer1_CTE
As
(Select Orders.CustomerID, Count(Orders.CustomerID) totalNumber from Orders
Join Customers On Customers.CustomerID = Orders.CustomerID
Where Customers.Country = 'USA'
Group By Orders.CustomerID)
Select * 
From Customer1_CTE
Order By totalNumber DESC;

Create View [German Customers] As
Select CompanyName, ContactName, City
From Customers
Where Country = 'Germany';

Select *
From [German Customers];