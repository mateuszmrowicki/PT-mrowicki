-- Usuwanie istniejących tabel (jeśli istnieją)
DROP TABLE IF EXISTS PurchaseEvents;
DROP TABLE IF EXISTS ReturnEvents;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS ProductCategories;
DROP TABLE IF EXISTS Clients;

-- Tworzenie tabel
CREATE TABLE Clients (
    Id INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategories (
    Category VARCHAR(30) PRIMARY KEY
);

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    ProductName VARCHAR(50) NOT NULL,
    Price FLOAT NOT NULL,
    Category VARCHAR(30) NOT NULL,
    FOREIGN KEY (Category) REFERENCES ProductCategories(Category)
);

CREATE TABLE PurchaseEvents (
    Id INT PRIMARY KEY IDENTITY,
    ClientId INT NOT NULL,
    ProductId INT NOT NULL,
    EventDate VARCHAR(50) NOT NULL,
    FOREIGN KEY (ClientId) REFERENCES Clients(Id),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);

CREATE TABLE ReturnEvents (
    Id INT PRIMARY KEY IDENTITY,
    ClientId INT NOT NULL,
    ProductId INT NOT NULL,
    EventDate VARCHAR(50) NOT NULL,
    FOREIGN KEY (ClientId) REFERENCES Clients(Id),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
