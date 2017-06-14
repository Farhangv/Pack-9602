USE AdventureWorks
--------------------
SELECT DISTINCT Color 
FROM Production.Product
--------------------
SELECT DISTINCT Name
FROM Production.Product
--------------------
SELECT DISTINCT ProductId
FROM Sales.SalesOrderDetail
--------------------
SELECT DISTINCT Name 
FROM Production.ProductSubcategory
--------------------
SELECT DISTINCT ProductSubcategoryID 
FROM Production.Product
--------------------
SELECT TOP 10 ProductId, ListPrice
FROM Production.Product
--------------------
SELECT TOP 10 WITH TIES ProductId, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT TOP 20 PERCENT WITH TIES ProductId, ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT DISTINCT TOP 10  ListPrice
FROM Production.Product
ORDER BY ListPrice DESC
--------------------
SELECT *
FROM Production.Product
ORDER BY ProductID
OFFSET 10 ROWS FETCH NEXT 15 ROWS ONLY
--------------------
DECLARE @P INT
DECLARE @X INT
SET @P = 5
SET @X = 10
SELECT *
FROM Production.Product
ORDER BY ProductID
OFFSET ((@P - 1)*@X) ROWS FETCH NEXT @X ROWS ONLY
---------------------
SELECT N'رنگ' + N' ' + N'مشکی'
---------------------
SELECT DISTINCT N'رنگ ' + Color
FROM Production.Product
---------------------
SELECT DISTINCT CONCAT(N'رنگ ' , Color)
FROM Production.Product
---------------------
SELECT SUBSTRING('Hello SQL Server', 1,3)
---------------------
SELECT Name, SUBSTRING(Name,1,2) 'FirstCharacters', Color
FROM Production.Product
---------------------
SELECT Name, LEFT(Name, 2) 'FirstCharacters', RIGHT(Name, 2) 'LastCharacters', Color
FROM Production.Product
---------------------
SELECT CHARINDEX('l','Hello SQL Server')
---------------------
SELECT CHARINDEX('a', Name), Name
FROM Production.Product
---------------------
SELECT CHARINDEX(' ', Name), Name
FROM Production.Product
WHERE CHARINDEX(' ', Name) > 0
---------------------
SELECT CHARINDEX(' ', Name) 'CharIndex', Name
FROM Production.Product
WHERE CHARINDEX(' ', Name) > 0
ORDER BY [CharIndex]
---------------------
SELECT DISTINCT CHARINDEX(' ', Name) 'CharIndex'
FROM Production.Product
WHERE CHARINDEX(' ', Name) > 0
ORDER BY [CharIndex]
---------------------
SELECT CHARINDEX(' ', Name) 'CharIndex', Name
FROM Production.Product
WHERE CHARINDEX(' ', Name) != 0
-------------------
SELECT LEN(N'Hello SQL Server')
-------------------
SELECT LEN(Name) 'Length', Name
FROM Production.Product
ORDER BY Length
-------------------
SELECT REPLACE('1396.02.20', '.','/')
-------------------
SELECT REPLACE(Name, ' ' , '-')
FROM Production.Product
-------------------
SELECT REPLICATE('a',5)
-------------------
SELECT UPPER(Name)
FROM Production.Product
-------------------
SELECT LOWER(Name)
FROM Production.Product
-------------------
SELECT RTRIM('Hello SQL Server                                   ') + 'Version 2016'
-------------------
SELECT 'Version 2016' + LTRIM('                        Hello SQL Server')
-------------------
SELECT ISNULL(Color,N'بدون رنگ'), Name
FROM Production.Product
-------------------
SELECT ProductId,Name, Color, 
ISNULL(
CASE Color
WHEN 'Black' THEN N'مشکی'
WHEN 'Blue' THEN N'آبی'
WHEN 'Red' THEN N'قرمز'
--ELSE N'متفرقه'
ELSE Color
END, N'بدون رنگ') 'PersianColor'

FROM Production.Product
ORDER BY PersianColor

-------------------
SELECT ProductId,Name, Color, 
CASE ISNULL(Color, '[NoColor]')
WHEN 'Black' THEN N'مشکی'
WHEN 'Blue' THEN N'آبی'
WHEN 'Red' THEN N'قرمز'
WHEN '[NoColor]' THEN N'بدون رنگ'
ELSE N'متفرقه'
END 'PersianColor'

FROM Production.Product
ORDER BY PersianColor
--------------------
SELECT ProductId, Name, 
CASE 
WHEN ListPrice > 1000 THEN N'گران'
WHEN ListPrice BETWEEN 500 AND 1000 THEN N'متوسط'
ELSE N'ارزان'
END 'PriceRange'
FROM Production.Product
--------------------
SELECT ProductId, Name, (ListPrice - StandardCost) 'Profit', ListPrice, StandardCost,
CASE 
WHEN (ListPrice) > (StandardCost * (1.5))  THEN N'پرسود'
WHEN (ListPrice) BETWEEN (StandardCost * (1.2)) AND (StandardCost * (1.4)) THEN N'سود متوسط'
ELSE N'کم سود'
END 'ProfitRange'
FROM Production.Product
WHERE (ListPrice - StandardCost) != 0
ORDER BY Profit DESC
----------------------
--------------------
SELECT ProductId, Name, (ListPrice - StandardCost) 'Profit', ListPrice, StandardCost,
CASE 
WHEN (ListPrice) > (StandardCost * (1.5))  THEN N'پرسود'
WHEN (ListPrice) BETWEEN (StandardCost * (1.2)) AND (StandardCost * (1.4)) THEN N'سود متوسط'
ELSE N'کم سود'
END 'ProfitRange'
FROM Production.Product
WHERE ProductId IN (SELECT TOP 10 ProductId FROM Production.Product ORDER BY ListPrice DESC)
ORDER BY Profit DESC
----------------------
SELECT STUFF('Hello SQL Server', 7, 3, 'Oracle')
----------------------
SELECT STUFF('Hello SQL Server', 7, LEN('Hello SQL Server') - 6 , 'Oracle')
----------------------
SELECT STUFF('Hello SQL Server', 7, LEN('Hello SQL Server') - 6 , '')
----------------------
SELECT REPLACE('Hello SQL Server', 'SQL Server', 'Oracle')
----------------------
SELECT GETDATE(), SYSDATETIME(),SYSDATETIMEOFFSET()
----------------------
SELECT DATEPART(YEAR, GETDATE())
----------------------
SELECT YEAR(GETDATE())
----------------------
SELECT MONTH(GETDATE())
----------------------
SELECT * FROM HumanResources.Employee
----------------------
SELECT JobTitle,NationalIdNumber,YEAR(GETDATE()) - YEAR(BirthDate) 'Age'
FROM HumanResources.Employee
ORDER BY Age DESC
----------------------
SELECT DATEPART(YEAR, GETDATE())
SELECT DATEPART(MONTH, GETDATE())
SELECT DATEPART(DAY, GETDATE())
SELECT DATEPART(HOUR, GETDATE())
SELECT DATEPART(MINUTE, GETDATE())
SELECT DATEPART(SECOND, GETDATE())
----------------------
SELECT GETDATE(),DATEADD(DAY,7,GETDATE())
----------------------
SELECT GETDATE(),DATEADD(MONTH, 2,DATEADD(DAY,7,GETDATE()))
-----------------------
SELECT GETDATE(),DATEADD(DAY, 7,DATEADD(DAY,-10,GETDATE()))
-----------------------
SELECT '20151010',DATEADD(DAY, 7, '20151010')
-----------------------
