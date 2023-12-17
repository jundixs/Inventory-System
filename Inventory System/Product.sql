Use DBInventory 

CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
    Category VARCHAR(50),
    Price DECIMAL(10, 2) NOT NULL,
    StockQuantity INT NOT NULL
);

INSERT INTO Product (ProductID, ProductName, Category, Price, StockQuantity)
VALUES
    (1, 'Laptop', 'Electronics', 999.99, 50),
    (2, 'Smartphone', 'Electronics', 499.99, 100),
    (3, 'Desk Chair', 'Furniture', 79.99, 30),
    (4, 'Headphones', 'Electronics', 49.99, 75),
    (5, 'Coffee Table', 'Furniture', 129.99, 20);

SELECT * FROM Product;


SELECT * FROM Product WHERE Category = 'Electronics';


SELECT * FROM Product WHERE Price < 100;


UPDATE Product SET Price = 1099.99 WHERE ProductName = 'Laptop';


DELETE FROM Product WHERE ProductName = 'Headphones';