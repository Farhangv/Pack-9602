USE AdventureWorks
----------------------
SELECT * 
FROM Production.Product
----------------------
SELECT * 
FROM Production.ProductCategory
----------------------
SELECT *
FROM Production.ProductSubcategory
----------------------
SELECT ProductId,
Name,
Color,
StandardCost,      ListPrice,ProductSubCategoryId
FROM Production.Product
----------------------
SELECT ProductId,Name
FROM Production.Product
ORDER BY Name 
----------------------
SELECT ProductId,Name
FROM Production.Product
ORDER BY Name DESC
----------------------
SELECT ProductId,Name,Color
FROM Production.Product
ORDER BY Color DESC
----------------------
SELECT ProductId,Name,Color,ListPrice
FROM Production.Product
ORDER BY Color DESC,ListPrice
----------------------
SELECT ProductId,Name,Color
FROM Production.Product
ORDER BY ListPrice
----------------------
SELECT ProductId AS Code, Name AS 'نام محصول', ListPrice 'قیمت فروش', StandardCost, (ListPrice - StandardCost) سود
FROM Production.Product
----------------------
SELECT [ProductId] AS Code, [Name] AS 'نام محصول', ListPrice 'قیمت فروش', StandardCost, (ListPrice - StandardCost) سود
FROM [Production].[Product]
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE 1 = 2
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId = 777
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId != 1
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId <> 1
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId < 200
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId > 400
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId >= 400
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId >= 400 AND ProductID <= 410
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId >= 500 AND ProductID <= 800 AND Color = 'Black'
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId BETWEEN 400 AND 410
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name BETWEEN 'a' AND 'b'
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name >= 'a' AND Name <= 'b'
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL
----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE 'a%'
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '%Bike%'
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '_b%'
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '%e_'
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name LIKE '%|%%' ESCAPE '|'
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId = 1 OR ProductId = 777 OR ProductId = 400
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId IN (1,400,777,2)
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE Name IN ('Bearing Ball','Blade','Decal 1')
-----------------------
SELECT * FROM Sales.SalesOrderDetail
-----------------------
SELECT ProductId FROM Sales.SalesOrderDetail
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId IN (SELECT ProductId FROM Sales.SalesOrderDetail)
-----------------------
SELECT ProductId, Name, Color, ListPrice
FROM Production.Product
WHERE ProductId NOT IN (SELECT ProductId FROM Sales.SalesOrderDetail)
