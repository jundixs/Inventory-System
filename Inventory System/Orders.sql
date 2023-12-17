USE DBInventory


CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Assuming the Customers table has the data you provided

-- Insert orders for existing customers
INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount)
VALUES
    (101, 1, '2023-01-15', 150.99),
    (102, 2, '2023-02-20', 275.50),
    (103, 3, '2023-03-10', 99.95),
    (104, 4, '2023-04-05', 450.75),
    (105, 5, '2023-05-12', 200.00);

-- Retrieve all orders
SELECT * FROM Orders;

-- Retrieve orders with a total amount greater than 200
SELECT * FROM Orders WHERE TotalAmount > 200;

-- Retrieve orders for a specific customer (e.g., customer with ID 3)
SELECT * FROM Orders WHERE CustomerID = 3;

-- Update the total amount for order with ID 1
UPDATE Orders SET TotalAmount = 175.99 WHERE OrderID = 1;

-- Delete the order with ID 4 from the Orders table
DELETE FROM Orders WHERE OrderID = 4;
