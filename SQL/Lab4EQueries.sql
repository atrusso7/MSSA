--Create a report that shows the product name and supplier id for all products supplied by Exotic Liquids, Grandma Kelly’s Homestead, and Tokyo Traders.
Select ProductName, Products.SupplierID, CompanyName
From Products
Join Suppliers On Suppliers.SupplierID = Products.SupplierID
Where CompanyName In (Select CompanyName From Suppliers Where CompanyName Like '%xot%' OR CompanyName Like '%elly%' OR CompanyName Like '%oky%');
--Create a report that shows all products by name that are in the Seafood category.
Select ProductName, CategoryName
From Products
Join Categories On Categories.CategoryID = Products.CategoryID
Where CategoryName In (Select CategoryName From Categories Where CategoryName = 'Seafood');
--Create a report that shows all companies by name that sell products in CategoryID 8.
Select CompanyName, CategoryID
From Products
Join Suppliers On Suppliers.SupplierID = Products.SupplierID
Where CategoryID In (Select CategoryID From Products Where CategoryID = 8);
--Create a report that shows all companies by name that sell products in the Seafood category.
Select CompanyName, CategoryName
From Products
Join Categories On Categories.CategoryID = Products.CategoryID
Join Suppliers On Suppliers.SupplierID = Products.SupplierID
Where CategoryName In (Select CategoryName From Categories Where CategoryName = 'Seafood');
--Create a report that lists the ten most expensive products.
Select Top 10 ProductName, UnitPrice
From Products
Order By UnitPrice DESC
--Create a report that shows the date of the last order by all employees.
Select OrderDate, o.EmployeeID
From Orders As o
Join (
    Select EmployeeID, max(OrderDate) as MaxDate
    From Orders
    Group by EmployeeID
) tm On o.EmployeeID = tm.EmployeeID and o.OrderDate = tm.MaxDate