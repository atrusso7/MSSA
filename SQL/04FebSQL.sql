--Learning Unions and Intersects
Select City
From Customers
Union
Select City
From Suppliers;

Select SupplierID
From Suppliers
Intersect
Select SupplierID
From Products
Where UnitsInStock > 0;