USE TSQLV4;
DROP VIEW IF EXISTS Sales.VEmpOrders;
GO
CREATE VIEW  Sales.VEmpOrders
AS

SELECT
  empid,
  YEAR(orderdate) AS orderyear,
  count(DISTINCT productid) AS UniqProdCount
FROM Sales.Orders AS O
  INNER JOIN Sales.OrderDetails AS OD
    ON O.orderid = OD.orderid
GROUP BY
  empid,
  YEAR(orderdate);
GO

SELECT empid, orderyear, UniqProdCount
FROM  Sales.VEmpOrders AS V1
ORDER BY empid, orderyear;
-------------------------------
USE TSQLV4;
DROP VIEW IF EXISTS Sales.VEmpOrders;
GO
CREATE VIEW  Sales.VEmpOrders
AS

SELECT
  empid,
  YEAR(orderdate) AS orderyear,
  count(DISTINCT productid) AS UniqProdCount,
  shipcountry
FROM Sales.Orders AS O
  INNER JOIN Sales.OrderDetails AS OD
    ON O.orderid = OD.orderid
GROUP BY
  empid,
  YEAR(orderdate), shipcountry;
GO

SELECT empid, shipcountry, orderyear, UniqProdCount
FROM  Sales.VEmpOrders AS V1
ORDER BY empid, orderyear;
---------------------------------------------------
USE TSQLV4;
DROP VIEW IF EXISTS Sales.VEmpOrders;
GO
CREATE VIEW  Sales.VEmpOrders
AS

SELECT
  SUM(unitprice * qty) AS totalSpent,
  shipcountry
FROM Sales.Orders AS O
  INNER JOIN Sales.OrderDetails AS OD
    ON O.orderid = OD.orderid
GROUP BY
  shipcountry;
GO

SELECT totalSpent, shipcountry
FROM  Sales.VEmpOrders AS V1
ORDER BY totalSpent;
--------------------------------------------------
USE TSQLV4;
DROP FUNCTION IF EXISTS Production.TopProducts;
GO
CREATE FUNCTION Production.TopProducts
  (@supid AS INT, @n AS INT)
  RETURNS TABLE
AS
RETURN
  SELECT TOP (@n) productid, productname, unitprice
  FROM Production.Products
  WHERE supplierid = @supid
  ORDER BY unitprice DESC;
  GO
  ----------------------------------------------------
  SELECT S.supplierid, S.companyname, P.productid, P.productname, P.unitprice
FROM Production.Suppliers AS S
  CROSS APPLY Production.TopProducts(S.supplierid, 2) AS P;
