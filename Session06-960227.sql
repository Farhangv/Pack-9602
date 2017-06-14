USE AdventureWorks
--------------
SELECT p.ProductId, p.Name, FORMAT(SUM(s.LineTotal),'#,###') 'TotalSales'
FROM Production.Product p
JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name
ORDER BY SUM(s.LineTotal) DESC
----------------
SELECT DISTINCT UnitPrice
FROM Sales.SalesOrderDetail
WHERE ProductId = 955
----------------
SELECT UnitPrice
FROM Sales.SalesOrderDetail
WHERE ProductId = 955
----------------
SELECT p.ProductId, p.Name, FORMAT(ISNULL(SUM(s.LineTotal),0),'0,###') 'TotalSales'
FROM Production.Product p 
LEFT OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name
ORDER BY SUM(s.LineTotal) DESC
----------------
SELECT p.ProductId, p.Name, FORMAT(ISNULL(SUM(s.LineTotal),0),'0,###') 'TotalSales'
FROM Sales.SalesOrderDetail s
RIGHT OUTER JOIN Production.Product p 
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name
ORDER BY SUM(s.LineTotal) DESC
-----------------لیست محصولاتی که دارای زیر مجموعه هستند به همراه نام زیر مجموعه آنها
SELECT p.ProductId, p.Name, sc.Name 'SubCategory'
FROM Production.Product p
INNER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
-----------------
SELECT * FROM Production.Product
-----------------
SELECT p.ProductId, p.Name, sc.Name 'SubCategory'
FROM Production.Product p
LEFT OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
-----------------
SELECT p.ProductId, p.Name, sc.Name 'SubCategory'
FROM Production.Product p
RIGHT OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
-----------------
SELECT p.ProductId, p.Name, sc.Name 'SubCategory'
FROM Production.Product p
FULL OUTER JOIN Production.ProductSubcategory sc
ON p.ProductSubcategoryID = sc.ProductSubcategoryID
------------------
SELECT p.ProductId, p.Name, sc.Name 'SubCategory', SUM(s.LineTotal) 'TotalSales'
FROM Production.ProductSubcategory sc
RIGHT OUTER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
LEFT OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name, sc.Name
------------------
SELECT p.ProductId, p.Name, sc.Name 'SubCategory', SUM(s.LineTotal) 'TotalSales'
FROM Production.ProductSubcategory sc
FULL OUTER JOIN Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
LEFT OUTER JOIN Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name, sc.Name
------------------
CREATE DATABASE Session06
------------------
USE Session06
------------------
CREATE TABLE Course
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50)
)
------------------
CREATE TABLE Student
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50)
)
-------------------
SELECT s.FullName 'StudentName', c.Name 'CourseName'
FROM Student s
CROSS JOIN Course c
--------------------
CREATE TABLE Employee
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	ManagerId INT
)
--------------------
SELECT e.Name 'Employee' , m.Name 'Manager'
FROM Employee e
INNER JOIN Employee m
ON e.ManagerId = m.Id
--------------------
SELECT e.Name 'Employee' , m.Name 'Manager'
FROM Employee e
LEFT OUTER JOIN Employee m
ON e.ManagerId = m.Id
--------------------
SELECT e.Name 'Employee' , m.Name 'Manager'
FROM Employee e
RIGHT OUTER JOIN Employee m
ON e.ManagerId = m.Id
--------------------
SELECT e.Name 'Employee' , m.Name 'Manager'
FROM Employee e
FULL OUTER JOIN Employee m
ON e.ManagerId = m.Id
--------------------
--------------------
SELECT e.Name 'Employee' , m.Name 'Manager'
FROM Employee e
CROSS JOIN Employee m
--------------------
INSERT INTO Employee(Name, ManagerId) VALUES(N'علی علیان', 1)
--------------------
INSERT INTO Employee(Name, ManagerId) VALUES(N'جواد جوادی', 1),(N'اصغر اصغری', 2)
--------------------
INSERT INTO Employee VALUES(N'علی علیان', 1)
--------------------
UPDATE Employee SET Name = N'سارا اسمیت' WHERE Id = 1
--------------------
SELECT * FROM Employee
--------------------
UPDATE Employee SET Name = N'پیام پیامکی', ManagerId = 4 WHERE Id = 2
--------------------
DELETE FROM Employee
WHERE Id > 6
--------------------
SELECT ProductId, OrderQty,UnitPrice,UnitPriceDiscount
INTO Sales
FROM AdventureWorks.Sales.SalesOrderDetail
--------------------
SELECT * FROM Sales
--------------------
DELETE FROM Sales
--------------------
DROP TABLE Sales
--------------------
SELECT *
INTO Sales
FROM AdventureWorks.Sales.SalesOrderDetail
--------------------
DELETE FROM Sales
--------------------
TRUNCATE TABLE Sales
--------------------
SELECT * FROM Sales
--------------------
SELECT p.ProductId, p.Name, sc.Name 'SubCategory', SUM(s.LineTotal) 'TotalSales'
INTO ProductDetail
FROM AdventureWorks.Production.ProductSubcategory sc
RIGHT OUTER JOIN AdventureWorks.Production.Product p
ON sc.ProductSubcategoryID = p.ProductSubcategoryID
LEFT OUTER JOIN AdventureWorks.Sales.SalesOrderDetail s
ON p.ProductID = s.ProductID
GROUP BY p.ProductId, p.Name, sc.Name
---------------------
SELECT * FROM ProductDetail
---------------------
CREATE TABLE Product
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50),
	Color NVARCHAR(50),
	ListPrice DECIMAL(10,2)
)
---------------------
INSERT INTO Product(Name, Color, ListPrice)
SELECT Name, Color,ListPrice
FROM AdventureWorks.Production.Product
---------------------
SELECT * FROM Product
