-- Create new database
CREATE DATABASE OnlineShopDB;
GO
USE OnlineShopDB;
GO
 
-- Customers Table
CREATE TABLE Customers (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    phone VARCHAR(20),
    address VARCHAR(255)
);
GO
 
-- Categories Table
CREATE TABLE Categories (
    category_id INT PRIMARY KEY IDENTITY(1,1),
    category_name VARCHAR(100) NOT NULL
);
GO
 
-- Products Table
CREATE TABLE Products (
    product_id INT PRIMARY KEY IDENTITY(1,1),
    product_name VARCHAR(100) NOT NULL,
    category_id INT,
    price DECIMAL(10,2),
    stock_quantity INT,
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);
GO
 
-- Orders Table
CREATE TABLE Orders (
    order_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT,
    order_date DATE DEFAULT GETDATE(),
    total_amount DECIMAL(10,2),
    status VARCHAR(50) CHECK (status IN ('Pending', 'Shipped', 'Delivered', 'Cancelled')),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);
GO
 
-- OrderDetails Table (many-to-many between Orders and Products)
CREATE TABLE OrderDetails (
    order_detail_id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT,
    product_id INT,
    quantity INT CHECK (quantity > 0),
    subtotal DECIMAL(10,2),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);
GO
-- Insert Data into Customers
INSERT INTO Customers (first_name, last_name, email, phone, address) VALUES
('Alice', 'Johnson', 'alice@example.com', '555-1234', '123 Main St'),
('Bob', 'Williams', 'bob@example.com', '555-5678', '456 Oak St'),
('Charlie', 'Brown', 'charlie@example.com', '555-9876', '789 Pine St'),
('Diana', 'Adams', 'diana@example.com', '555-5432', '321 Birch St'),
('Eve', 'Miller', 'eve@example.com', '555-2222', '555 Cedar St');
GO
 
-- Insert Data into Categories
INSERT INTO Categories (category_name) VALUES
('Electronics'),
('Clothing'),
('Books'),
('Home & Kitchen'),
('Toys');
GO

SELECT *FROM Categories
 
-- Insert Data into Products
INSERT INTO Products (product_name, category_id, price, stock_quantity) VALUES
('Smartphone', 1, 699.99, 50),
('Laptop', 1, 1299.99, 30),
('Jeans', 2, 49.99, 100),
('T-shirt', 2, 19.99, 200),
('Novel - The Great Gatsby', 3, 10.99, 75),
('Cookware Set', 4, 99.99, 40),
('Vacuum Cleaner', 4, 199.99, 25),
('Lego Set', 5, 49.99, 60),
('Dollhouse', 5, 89.99, 35),
('Gaming Console', 1, 499.99, 20);
GO

SELECT *FROM Products
 
-- Insert Data into Orders
INSERT INTO Orders (customer_id, order_date, total_amount, status) VALUES
(1, '2024-01-10', 749.98, 'Shipped'),
(2, '2024-01-12', 699.99, 'Pending'),
(3, '2024-01-15', 50.98, 'Delivered'),
(4, '2024-01-18', 89.99, 'Cancelled'),
(5, '2024-01-20', 999.99, 'Shipped'),
(1, '2024-01-22', 1299.99, 'Pending'),
(2, '2024-01-25', 19.99, 'Delivered'),
(3, '2024-01-28', 199.99, 'Shipped');
GO
 
-- Insert Data into OrderDetails
INSERT INTO OrderDetails (order_id, product_id, quantity, subtotal) VALUES
(1, 1, 1, 699.99),
(1, 3, 1, 49.99),
(2, 1, 1, 699.99),
(3, 4, 1, 19.99),
(3, 5, 1, 10.99),
(4, 9, 1, 89.99),
(5, 2, 1, 1299.99),
(5, 7, 1, 199.99),
(6, 2, 1, 1299.99),
(7, 4, 1, 19.99),
(8, 7, 1, 199.99);
GO

SELECT *FROM Categories
SELECT *FROM Products
SELECT *FROM OrderDetails

 SELECT p.product_name, p.price, c.category_name  FROM Products AS P
Join Categories AS C ON P.category_id = C.category_id
WHERE C.category_id = 1

SELECT *FROM OrderDetails
SELECT *FROM Orders

SELECT C.first_name, C.last_name, O.order_id FROM Orders AS O
Join Customers AS C ON O.customer_id = C.customer_id

SELECT *FROM Customers AS C
Left Join Orders AS O ON O.customer_id = C.customer_id

SELECT *FROM Orders AS O
Right Join Customers AS C ON C



