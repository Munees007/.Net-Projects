
-- Drop tables safely (for re-run purpose)
IF OBJECT_ID('Bills', 'U') IS NOT NULL DROP TABLE Bills;
IF OBJECT_ID('Vehicles', 'U') IS NOT NULL DROP TABLE Vehicles;
IF OBJECT_ID('Customers', 'U') IS NOT NULL DROP TABLE Customers;

-------------------------------------------------
--  CREATE TABLE - Customers
-------------------------------------------------
CREATE TABLE Customers (
    CustomerID VARCHAR(12) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Contact VARCHAR(15),
    City VARCHAR(100),
    GSTIN VARCHAR(20),
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-------------------------------------------------
-- CREATE TABLE - Vehicles
-------------------------------------------------
CREATE TABLE Vehicles (
    VehicleNo VARCHAR(20) PRIMARY KEY,
    CustomerID VARCHAR(12) NOT NULL,

    CONSTRAINT FK_Vehicle_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customers(CustomerID)
    ON DELETE CASCADE
);

-------------------------------------------------
-- CREATE TABLE - Bills
-------------------------------------------------
CREATE TABLE Bills (
    BillID INT IDENTITY(1,1) PRIMARY KEY,
    BillNo INT NOT NULL,
    BillingYear INT NOT NULL,
    CustomerID VARCHAR(12) NOT NULL,
    VehicleNo VARCHAR(20) NULL,
    BillDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL,
    Discount DECIMAL(10,2) DEFAULT 0,
    GrandTotal AS (TotalAmount - Discount) PERSISTED,

    CONSTRAINT FK_Bill_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customers(CustomerID),

    CONSTRAINT FK_Bill_Vehicle
    FOREIGN KEY (VehicleNo)
    REFERENCES Vehicles(VehicleNo)
);

-------------------------------------------------
-- INSERT CUSTOMERS (15)
-------------------------------------------------
INSERT INTO Customers (CustomerID, Name, Contact, City, GSTIN) VALUES
('C001','Dean Winchester','9876543210','Chennai','33ABCDE1234F1Z5'),
('C002','Sam Winchester','9123456780','Madurai','33ABCDE2234F1Z5'),
('C003','Elena Gilbert','9789012345','Coimbatore',NULL),
('C004','Damon Salvatore','9000011111','Salem',NULL),
('C005','Stefan Salvatore','9888877777','Trichy',NULL),
('C006','Klaus Mikaelson','9012345678','Erode',NULL),
('C007','Elijah Mikaelson','9345678901','Chennai',NULL),
('C008','Tanjiro Kamado','9445566778','Madurai',NULL),
('C009','Nezuko Kamado','9556677889','Tirunelveli',NULL),
('C010','Zenitsu Agatsuma','9667788990','Vellore',NULL),
('C011','Asta','9778899001','Chennai',NULL),
('C012','Yuno','9889900112','Salem',NULL),
('C013','Yami Sukehiro','9990011223','Erode',NULL),
('C014','Yuji Itadori','9112233445','Trichy',NULL),
('C015','Satoru Gojo','9223344556','Madurai',NULL);


-------------------------------------------------
-- INSERT VEHICLES (15)
-------------------------------------------------
INSERT INTO Vehicles (VehicleNo, CustomerID) VALUES
('TN01AB1234','C001'),
('TN02CD2345','C002'),
('TN03EF3456','C003'),
('TN04GH4567','C004'),
('TN05IJ5678','C005'),
('TN06KL6789','C006'),
('TN07MN7890','C007'),
('TN08OP8901','C008'),
('TN09QR9012','C009'),
('TN10ST0123','C010'),
('TN11UV1234','C011'),
('TN12WX2345','C012'),
('TN13YZ3456','C013'),
('TN14AA4567','C014'),
('TN15BB5678','C015');

-------------------------------------------------
-- INSERT BILLS (20)
-------------------------------------------------
INSERT INTO Bills (BillNo, BillingYear, CustomerID, VehicleNo, TotalAmount, Discount) VALUES
(101,2025,'C001','TN01AB1234',20000,1000),
(102,2025,'C002','TN02CD2345',15000,500),
(103,2025,'C003','TN03EF3456',18000,800),
(104,2025,'C004','TN04GH4567',22000,1200),
(105,2025,'C005','TN05IJ5678',14000,400),
(106,2025,'C006','TN06KL6789',25000,1500),
(107,2025,'C007','TN07MN7890',16000,600),
(108,2025,'C008','TN08OP8901',17000,700),
(109,2025,'C009','TN09QR9012',21000,1000),
(110,2025,'C010','TN10ST0123',19000,900),
(111,2025,'C011','TN11UV1234',13000,300),
(112,2025,'C012','TN12WX2345',26000,2000),
(113,2025,'C013','TN13YZ3456',24000,1200),
(114,2025,'C014','TN14AA4567',15500,500),
(115,2025,'C015','TN15BB5678',17500,800),
(116,2025,'C001','TN01AB1234',21000,1000),
(117,2025,'C002','TN02CD2345',14500,300),
(118,2025,'C003','TN03EF3456',23000,1500),
(119,2025,'C004','TN04GH4567',19500,700),
(120,2025,'C005','TN05IJ5678',16500,600);

