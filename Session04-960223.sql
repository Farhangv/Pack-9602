USE AdventureWorks
-----------------
SELECT DATEDIFF(DAY, GETDATE(), DATEADD(DAY, 25,GETDATE()))
-----------------
SELECT DATEDIFF(MINUTE, GETDATE(), DATEADD(DAY, 25,GETDATE()))
-----------------
SELECT SYSDATETIMEOFFSET(),SWITCHOFFSET(SYSDATETIMEOFFSET(), '-02:30')
-----------------
SELECT TODATETIMEOFFSET(GETDATE() , '+04:30')
----------------
SELECT SWITCHOFFSET(SYSDATETIME(), '-02:30')
----------------
SELECT COUNT(Color) 
FROM Production.Product
----------------
SELECT COUNT(DISTINCT Color) 
FROM Production.Product
----------------
SELECT COUNT(DISTINCT ISNULL(Color, 'NoColor')) 
FROM Production.Product
----------------
SELECT COUNT(ISNULL(Color, 'NoColor')) 
FROM Production.Product
-------------------
SELECT ISNULL(Color,'NoColor')
FROM Production.Product
-------------------
SELECT COUNT(*)
FROM Production.Product
-------------------
SELECT COUNT(ProductId)
FROM Production.Product
-------------------
SELECT SUM(UnitPrice)
FROM Sales.SalesOrderDetail
-------------------
SELECT FORMAT(SUM((1 - UnitPriceDiscount) * UnitPrice * OrderQty), '#,###')
FROM Sales.SalesOrderDetail
-------------------
SELECT *
FROM Sales.SalesOrderDetail
------------------
SELECT SUM((UnitPriceDiscount) * UnitPrice * OrderQty) 'مجموع مبلغ تخفیفات داده شده'
FROM Sales.SalesOrderDetail
------------------
SELECT FORMAT(SUM((UnitPriceDiscount) * UnitPrice * OrderQty),'#,###') 'مجموع مبلغ تخفیفات داده شده'
FROM Sales.SalesOrderDetail
------------------
SELECT AVG(UnitPrice)
FROM Sales.SalesOrderDetail
------------------
SELECT AVG(ListPrice)
FROM Production.Product
------------------
SELECT AVG((1 - UnitPriceDiscount) * UnitPrice * OrderQty)
FROM Sales.SalesOrderDetail
-------------------
SELECT AVG(UnitPrice), VAR(UnitPrice)
FROM Sales.SalesOrderDetail
-------------------
SELECT MAX(UnitPrice) 'Max' , MIN(UnitPrice) 'Min'
FROM Sales.SalesOrderDetail
-------------------
SELECT MAX(UnitPrice) , ProductId
FROM Sales.SalesOrderDetail
-------------------
SELECT SUM((1 - UnitPriceDiscount) * UnitPrice * OrderQty) 'OrderTotal', SalesOrderID
FROM Sales.SalesOrderDetail
GROUP BY SalesOrderID
ORDER BY OrderTotal DESC
-------------------
SELECT SUM((1 - UnitPriceDiscount) * UnitPrice * OrderQty) 'ProductTotal', ProductID
FROM Sales.SalesOrderDetail
GROUP BY ProductID
ORDER BY ProductTotal DESC
-------------------
SELECT SUM(OrderQty) 'ProductTotalQuantity', ProductID
FROM Sales.SalesOrderDetail
GROUP BY ProductID
ORDER BY ProductTotalQuantity DESC
-------------------
SELECT SUM(OrderQty) 'ProductTotalQuantity', ProductID
FROM Sales.SalesOrderDetail
--WHERE SUM(OrderQty) > 2000
GROUP BY ProductID
HAVING SUM(OrderQty) > 2000
ORDER BY ProductTotalQuantity DESC
-------------------
SELECT COUNT(*) 'TotalSalesCount', ProductID
FROM Sales.SalesOrderDetail
GROUP BY ProductID
HAVING COUNT(*) > 3000 
ORDER BY TotalSalesCount DESC
-------------------
SELECT COUNT(*) 'TotalSalesCount', ProductID
FROM Sales.SalesOrderDetail
WHERE ProductId > 800
GROUP BY ProductID
HAVING COUNT(*) > 3000
--HAVING COUNT(*) > 3000 AND ProductID > 800
ORDER BY TotalSalesCount DESC
-------------------
SELECT COUNT(*) 'TotalSalesCount', ProductID
FROM Sales.SalesOrderDetail
--WHERE ProductId > 800
GROUP BY ProductID
--HAVING COUNT(*) > 3000
HAVING COUNT(*) > 3000 AND ProductID > 800
ORDER BY TotalSalesCount DESC
--------------------
SELECT ROW_NUMBER() OVER (ORDER BY Name) 'Row', ProductId, Name, Color
FROM Production.Product
ORDER BY [Row]
--ORDER BY ProductID
---------------------
SELECT ROW_NUMBER() OVER (ORDER BY Name) 'Row', ProductId, Name, Color, ROW_NUMBER() OVER (ORDER BY ListPrice)
FROM Production.Product
ORDER BY [Row]
--ORDER BY ProductID
---------------------
SELECT RANK() OVER(ORDER BY ListPrice DESC) 'Rank', ProductId, Name, ListPrice
FROM Production.Product
---------------------
SELECT ROW_NUMBER() OVER(ORDER BY ListPrice DESC) 'Rank', ProductId, Name, ListPrice
FROM Production.Product
---------------------
SELECT DENSE_RANK() OVER(ORDER BY ListPrice DESC) 'Rank', ProductId, Name, ListPrice
FROM Production.Product
---------------------
SELECT TOP 6 WITH TIES
DENSE_RANK() OVER(ORDER BY ListPrice DESC) 'Rank', ProductId, Name, ListPrice
FROM Production.Product
ORDER BY [Rank]
-----------------------