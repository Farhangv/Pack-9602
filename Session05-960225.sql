USE AdventureWorks
----------------
SELECT NTILE(5) OVER (ORDER BY ProductId) 'Tile', ProductId, Name,Color
FROM Production.Product
----------------
SELECT
Name,ProductId
FROM Production.Product
---------------
SELECT * FROM Sales.SalesOrderDetail
---------------
SELECT * FROM Person.Person
---------------
SELECT * FROM HumanResources.Employee
---------------
SELECT * FROM Production.ProductSubcategory
---------------
SELECT * FROM Production.ProductCategory
---------------
SELECT * FROM Production.Product
---------------
SELECT * FROM Production.ProductPhoto
---------------
SELECT * FROM Production.ProductProductPhoto
---------------
SELECT *
FROM Production.Product
INNER JOIN Sales.SalesOrderDetail
ON Production.Product.ProductId = Sales.SalesOrderDetail.ProductId
---------------
SELECT Production.Product.ProductId, Name, SalesOrderId, SalesOrderDetailId,OrderQty,UnitPrice
FROM Production.Product
INNER JOIN Sales.SalesOrderDetail
ON Production.Product.ProductId = Sales.SalesOrderDetail.ProductId
---------------
SELECT p.ProductId,Name, SalesOrderId, SalesOrderDetailId,OrderQty,UnitPrice
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductId = s.ProductId
---------------
SELECT Name, SalesOrderId, SalesOrderDetailId,OrderQty,UnitPrice
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductId = s.ProductId
----------------
---------------
SELECT ROW_NUMBER() OVER(ORDER BY Name) 'Row',SalesOrderId,p.ProductId,Name,OrderQty,UnitPrice
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductId = s.ProductId
WHERE SalesOrderID = 43663
-----------------
SELECT ROW_NUMBER() OVER(ORDER BY Name) 'Row',SalesOrderId,p.ProductId,Name,OrderQty,UnitPrice
FROM Production.Product p
INNER JOIN Sales.SalesOrderDetail s
ON p.ProductId = s.ProductId
WHERE SalesOrderID IN (
	--شماره فاکتور سنگین ترین فاکتور
	SELECT TOP 1 
	SalesOrderID
	FROM Sales.SalesOrderDetail
	GROUP BY SalesOrderID
	ORDER BY SUM((1 - UnitPriceDiscount) * OrderQty * UnitPrice) DESC
)
-----------------لیست محصولات به همراه اسم زیر دسته
SELECT p.ProductId, p.Name, p.Color, psc.Name 'SubCategory'
FROM Production.Product p
JOIN Production.ProductSubCategory psc
ON p.ProductSubcategoryID = psc.ProductSubcategoryID
-----------------لیست محصولات به همراه اسم زیر مجموعه و مجموعه
SELECT p.ProductId, p.Name, p.Color, psc.Name 'SubCategory', pc.Name 'Category'
FROM Production.Product p
JOIN Production.ProductSubCategory psc
ON p.ProductSubcategoryID = psc.ProductSubcategoryID
JOIN Production.ProductCategory pc
ON psc.ProductCategoryID = pc.ProductCategoryID






