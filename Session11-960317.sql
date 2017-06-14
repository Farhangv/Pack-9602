CREATE DATABASE Session11
GO
USE Session11
GO
SELECT * 
INTO Product
FROM AdventureWorks.Production.Product
GO
CREATE VIEW ProductBrief
AS
SELECT ProductId, Name, Color,(ListPrice - StandardCost)  'Benefit'
FROM Product
GO
INSERT INTO ProductBrief VALUES(1020,'NewProduct', 'red', 1000)
GO
CREATE VIEW ProductBrief2
AS
SELECT ProductId, Name, Color
FROM Product
GO
INSERT INTO ProductBrief2(Name, Color) VALUES('NewProduct', 'red')
GO
CREATE TABLE Employee
(
	ID INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50),
	Department NVARCHAR(50)
)
GO
CREATE VIEW DevelopmentEmployees
AS
SELECT * FROM Employee WHERE Department = 'Development'
GO
CREATE VIEW UXEmployees
AS
SELECT * FROM Employee WHERE Department = 'UX Design'
GO
SELECT * FROM DevelopmentEmployees
GO
SELECT * FROM UXEmployees
GO
ALTER VIEW DevelopmentEmployees
AS
SELECT * FROM Employee WHERE Department = 'Development' WITH CHECK OPTION
GO
ALTER VIEW UXEmployees
AS
SELECT * FROM Employee WHERE Department = 'UX Design' WITH CHECK OPTION


