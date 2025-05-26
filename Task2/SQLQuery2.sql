-- Wstaw dane do ProductCategories
INSERT INTO ProductCategories (Category) VALUES
('Electronics'),
('Books'),
('Clothing');

-- Wstaw dane do Products
INSERT INTO Products (ProductName, Price, Category) VALUES
('Laptop', 2999.99, 'Electronics'),
('T-shirt', 49.99, 'Clothing'),
('C# Programming Book', 129.90, 'Books');

-- Wstaw dane do Clients
INSERT INTO Clients (FirstName, LastName) VALUES
('Mateusz', 'Kowalski'),
('Anna', 'Nowak');

-- Wstaw dane do PurchaseEvents
INSERT INTO PurchaseEvents (ClientId, ProductId, EventDate) VALUES
(1, 1, '2024-12-10'),
(2, 2, '2025-01-15');

-- Wstaw dane do ReturnEvents
INSERT INTO ReturnEvents (ClientId, ProductId, EventDate) VALUES
(2, 2, '2025-01-20');
