USE AdventureWorks
----------------
SELECT ProductID,Name,Color
FROM Production.Product
ORDER BY Color
----------------
SELECT SUM(OrderQty), p.Color
FROM Sales.SalesOrderDetail s
INNER JOIN Production.Product p
ON p.ProductID = s.ProductID
GROUP BY p.Color
----------------
SELECT psc.Name, p.Color,SUM(OrderQty) 'Total'
FROM Sales.SalesOrderDetail s
INNER JOIN Production.Product p
ON p.ProductID = s.ProductID
INNER JOIN Production.ProductSubcategory psc
ON p.ProductSubcategoryID = psc.ProductSubcategoryID
GROUP BY psc.Name, p.Color
ORDER BY psc.Name,p.Color
-----------------
CREATE DATABASE Session07
-----------------
DROP DATABASE Session07
GO
CREATE DATABASE Session07
GO
SELECT 'Hello'
GO
EXEC sp_detach_db 'Session07'
GO
EXEC sp_attach_db 'Session07', 'c:\Session07\session07.mdf', 'c:\session07\session07_log.ldf'
GO
EXEC sp_detach_db 'Session07'
GO
CREATE DATABASE Session07
ON
(FILENAME = 'c:\Session07\session07.mdf'),
(FILENAME = 'c:\session07\session07_log.ldf') 
FOR ATTACH
GO
EXEC sp_detach_db 'Session07'
GO
CREATE DATABASE Session07
ON
(FILENAME = 'c:\Session07\session07.mdf')
FOR ATTACH_REBUILD_LOG
GO
DROP DATABASE Session07
GO
CREATE DATABASE Session07
GO
CREATE DATABASE Session07
ON
(
	NAME = 'Session07_Data',
	FILENAME = 'C:\Session07\Session07.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'Session07_Log',
	FILENAME = 'C:\Session07\Session07_log.ldf',
	SIZE = 15MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
GO
USE Session07
GO
CREATE TABLE Person
(
	Id INT,
	Name NVARCHAR(50),
	Family NVARCHAR(50),
	Age TINYINT,
	Height DECIMAL(5,2),
	BirthDate DATETIME,
	NationalCode CHAR(10)
)
