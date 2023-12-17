USE DBInventory


CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL,
    Description TEXT
);


INSERT INTO Categories (CategoryID, CategoryName, Description)
VALUES
    (1, 'Electronics', 'Devices and gadgets powered by electricity.'),
    (2, 'Clothing', 'Apparel and wearable items.'),
    (3, 'Furniture', 'Household and office furniture.'),
    (4, 'Books', 'Printed and digital reading materials.'),
    (5, 'Toys', 'Playthings for children.');

-- Retrieve all categories
SELECT * FROM Categories;

-- Retrieve the category with ID 1
SELECT * FROM Categories WHERE CategoryID = 1;

-- Update the description for 'Electronics'
UPDATE Categories SET Description = 'Electronic devices and gadgets powered by electricity.' WHERE CategoryID = 1;

-- Delete the 'Toys' category from the Categories table
DELETE FROM Categories WHERE CategoryName = 'Toys';
