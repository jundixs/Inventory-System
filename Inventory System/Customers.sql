USE DBInventory
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber VARCHAR(20),
    Address VARCHAR(255)
);


INSERT INTO Customers (CustomerID, FirstName, LastName, Email, PhoneNumber, Address)
VALUES
    (1, 'John', 'Doe', 'john.doe@email.com', '555-1234', '123 Main St'),
    (2, 'Jane', 'Smith', 'jane.smith@email.com', '555-5678', '456 Oak St'),
    (3, 'Bob', 'Johnson', 'bob.johnson@email.com', '555-9876', '789 Pine St'),
    (4, 'Alice', 'Williams', 'alice.williams@email.com', NULL, '101 Elm St'),
    (5, 'Charlie', 'Brown', 'charlie.brown@email.com', '555-4321', '234 Cedar St');

-- Retrieve all customers
SELECT * FROM Customers;

-- Retrieve customers with the last name 'Smith'
SELECT * FROM Customers WHERE LastName = 'Smith';

-- Retrieve customers with a phone number
SELECT * FROM Customers WHERE PhoneNumber IS NOT NULL;

-- Update the address for customer with ID 1
UPDATE Customers SET Address = '321 Oak St' WHERE CustomerID = 1;

-- Delete the customer with ID 4 from the Customers table
DELETE FROM Customers WHERE CustomerID = 4;
