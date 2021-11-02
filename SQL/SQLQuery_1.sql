--Practice 1
--SELECT *
--FROM Orders
--WHERE CustomerID = (
--    SELECT CustomerID
--    FROM Customers
--    WHERE CompanyName = 'Que Delícia'
--)
--Practice 5
--SELECT SUM(UnitPrice*UnitsInStock) AS 'Value in $'
--From Products

--Practice 6
SELECT SUM((UnitPrice * (1 - Discount)) * Quantity) AS 'TofuValue'
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74

SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'Value in $'
FROM [Order Details]
WHERE ProductID IN (
    SELECT ProductID
    FROM Products
    WHERE ProductName LIKE '%Tofu%' 
)

