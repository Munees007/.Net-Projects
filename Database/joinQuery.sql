/* ===========================================
   TYRE SHOP MANAGEMENT
   JOINS PRACTICE FILE (SQL SERVER)
   =========================================== */

-------------------------------------------------
-- INNER JOIN
-- Get all Bills with Customer Name
-- Shows only matching records
-------------------------------------------------

SELECT 
    b.BillID,
    b.BillNo,
    c.Name AS CustomerName,
    b.TotalAmount,
    b.Discount,
    b.GrandTotal
FROM Bills b
INNER JOIN Customers c
    ON b.CustomerID = c.CustomerID;

-------------------------------------------------
-- INNER JOIN (3 Tables)
-- Bill + Customer + Vehicle
-- Used for Invoice Screen
-------------------------------------------------

SELECT 
    b.BillNo,
    c.Name AS CustomerName,
    v.VehicleNo,
    b.BillDate,
    b.GrandTotal
FROM Bills b
INNER JOIN Customers c 
    ON b.CustomerID = c.CustomerID
INNER JOIN Vehicles v 
    ON b.VehicleNo = v.VehicleNo;

-------------------------------------------------
-- LEFT JOIN
-- Show ALL Customers (even if no Bills)
-- Very important interview question
-------------------------------------------------

SELECT 
    c.CustomerID,
    c.Name,
    b.BillNo,
    b.GrandTotal
FROM Customers c
LEFT JOIN Bills b
    ON c.CustomerID = b.CustomerID
ORDER BY c.CustomerID;

-------------------------------------------------
-- RIGHT JOIN
-- Show ALL Bills even if Customer missing
-- (Rare but good for understanding)
-------------------------------------------------

SELECT 
    c.Name,
    b.BillNo,
    b.GrandTotal
FROM Customers c
RIGHT JOIN Bills b
    ON c.CustomerID = b.CustomerID;

-------------------------------------------------
-- GROUP BY + JOIN
-- Total Spending Per Customer
-- Dashboard Query
-------------------------------------------------

SELECT 
    c.Name,
    SUM(b.GrandTotal) AS TotalSpent
FROM Customers c
INNER JOIN Bills b
    ON c.CustomerID = b.CustomerID
GROUP BY c.Name
ORDER BY TotalSpent DESC;

-------------------------------------------------
-- COUNT + JOIN
-- Number of Bills per Customer
-------------------------------------------------

SELECT 
    c.Name,
    COUNT(b.BillID) AS NumberOfBills
FROM Customers c
LEFT JOIN Bills b
    ON c.CustomerID = b.CustomerID
GROUP BY c.Name
ORDER BY NumberOfBills DESC;

-------------------------------------------------
-- HAVING Clause with JOIN
-- Customers who spent more than 30,000
-------------------------------------------------

SELECT 
    c.Name,
    SUM(b.GrandTotal) AS TotalSpent
FROM Customers c
INNER JOIN Bills b
    ON c.CustomerID = b.CustomerID
GROUP BY c.Name
HAVING SUM(b.GrandTotal) > 30000;

-------------------------------------------------
-- TOP Customers (Most Valuable Customer)
-------------------------------------------------

SELECT TOP 5
    c.Name,
    SUM(b.GrandTotal) AS TotalSpent
FROM Customers c
INNER JOIN Bills b
    ON c.CustomerID = b.CustomerID
GROUP BY c.Name
ORDER BY TotalSpent DESC;

-------------------------------------------------
-- Bills This Year
-------------------------------------------------

SELECT 
    c.Name,
    b.BillNo,
    b.GrandTotal
FROM Bills b
INNER JOIN Customers c
    ON b.CustomerID = c.CustomerID
WHERE b.BillingYear = 2025;

-------------------------------------------------
-- Full Detailed Report (Best Practice Query)
-- Used in Billing System / Reports
-------------------------------------------------

SELECT 
    b.BillID,
    b.BillNo,
    b.BillingYear,
    c.CustomerID,
    c.Name AS CustomerName,
    c.City,
    v.VehicleNo,
    b.TotalAmount,
    b.Discount,
    b.GrandTotal,
    b.BillDate
FROM Bills b
INNER JOIN Customers c
    ON b.CustomerID = c.CustomerID
LEFT JOIN Vehicles v
    ON b.VehicleNo = v.VehicleNo
ORDER BY b.BillDate DESC;

