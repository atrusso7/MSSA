--SELECT LastName, FirstName
--FROM Owner
--ORDER BY LastName
--OFFSET 2 ROWS
--FETCH NEXT 4 ROWS Only;

--UPDATE Owner
--SET Notes = 'loves his mama'
--WHERE OwnerID = 3;

--Create Table Actors
--(
--ActorID int Not Null,
--LastName VarChar(255), 
--FirstName VarChar(255),
--Salary float, 
--DepartmentID int
--)

--Insert Into Actors (ActorID, LastName, FirstName, Salary, DepartmentID)
--Values
--(12009, 'Mouse' ,'Mickey', 90000, 11),
--(34974, 'White', 'Snow', 65000, 11), 
--(33897, 'Nicholson', 'Jack', 120000, 35), 
--(67543, 'Fuentes', 'Daisy', 93000, 35),
--(32567, 'Fishbourne', 'Lawrence', 125000, 35);

--Select *
--From Actors;

--Select City
--From Customers
--Union -- Won't show duplicates
--Select City
--From Suppliers
--Order By City;

--Select ContactName, City, Country
--From Customers
--Where Country = 'Germany'
--Union All --Will show duplicates
--Select ContactName, City, Country
--From Suppliers
--Where Country = 'Germany';

--Select SupplierID
--From Suppliers
--Where SupplierID > 10
--Intersect
--Select SupplierID
--From Products
--Where UnitsInStock > 0;

--Select Customers.CustomerID, CompanyName, City, Region
--From Customers
--Left Join Orders On Customers.CustomerID = Orders.CustomerID
--Intersect
--Select Customers.CustomerID, CompanyName, City, Region
--From Customers
--Right Join Orders on Customers.CustomerID = Orders.CustomerID;

--1
Select ContactName, Country
From Customers
Union
Select ContactName, Country
From Suppliers

--2
Select ContactName, City, Country
From Customers
Union
Select ContactName, City, Country
From Suppliers

--3
Select ContactName, Country
From Customers
Intersect
Select ContactName, Country
From Suppliers

--4
Select ContactName, City, Country
From Customers
Intersect
Select ContactName, City, Country
From Suppliers

--5
Select ContactName, Country
From Customers
Except
Select ContactName, Country
From Suppliers

 --6
Select ContactName, Country
From Suppliers
Except
Select ContactName, Country
From Customers

Select Count(*) Over (Partition By Month(HireDate), Year(HireDate)) as mumPerMonth,
DATENAME(month,hiredate)+' '+DATENAME(year,hiredate) as TheMonth,
firstname, lastname
From Employees
Order by HireDate;

--Functions
Select
ROW_NUMBER() Over (Order by Year(hiredate), Month(hiredate)) as StartingRank,
Rank() Over (Order by year(hiredate), Month(hiredate)) as EmployeeRank,
Dense_Rank() Over (Order by Year(hiredate), Month(hiredate)) as DenseRank,
DateName(month,hiredate)+ ' ' +datename(year,hiredate)as TheMonth,
firstname, lastname, hiredate
From HR.Employees


--Q1
Select Count(*) Over()ProductName, UnitPrice, UnitsInStock
From Products
Order by ProductID;

--Q2
Select Count(*) Over (Partition By Month(HireDate), Year(HireDate)) as mumPerMonth,
DATENAME(month,hiredate)+' '+DATENAME(year,hiredate) as TheMonth,
firstname, lastname
From Hr.Employees
Order by hiredate;

--Q3
Select
ROW_NUMBER() Over (Order by Year(hiredate), Month(hiredate)) as StartingRank,
Rank() Over (Order by year(hiredate), Month(hiredate)) as EmployeeRank,
Dense_Rank() Over (Order by Year(hiredate), Month(hiredate)) as DenseRank,
DateName(month,hiredate)+ ' ' +datename(year,hiredate)as TheMonth,
firstname, lastname, hiredate
From HR.Employees

--Q4
--Q5
Create Table Students
(
StudentID int Not Null,
Exam1 int,
Exam2 int,
Exam3 int
)
Insert into Students(StudentID, Exam1,Exam2,Exam3)
Values
(1,77,55,90),
(2,98,97,86),
(3,67,54,35),
(4,35,87,77),
(5, 90,35,87)
Select *
From Students;

Select 'Total Score' as totalExam, [1], [2], [3]
From
(Select StudentID, (Exam1 +Exam2+ Exam3) as ExamSums From dbo.Students) as SourceTable
Pivot
(
Sum(ExamSums)
 FOR StudentID IN ([1], [2], [3])
) AS PivotTable;