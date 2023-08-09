CREATE DATABASE MyTestDatabase;

USE MyTestDatabase;

CREATE TABLE Addresses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StreetName VARCHAR(100),
    StreetNumber INT,
    City VARCHAR(50),
);

CREATE TABLE Customers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150),
    Age INT,
    AddressId INT REFERENCES Addresses(Id)
);

CREATE TABLE Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Details VARCHAR(150),
    CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150)
);

CREATE TABLE Orders_Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT REFERENCES Orders(Id),
    ProductId INT REFERENCES Products(Id)
);

INSERT INTO Addresses
VALUES ('Independentei', 10, 'Iasi');
INSERT INTO Addresses
VALUES ('Eroilor', 34, 'Brasov');
INSERT INTO Addresses
VALUES ('Unirii', 53, 'Bucuresti');
INSERT INTO Addresses
VALUES ('Independentei', 23, 'Brasov');
INSERT INTO Addresses
VALUES ('Eroilor', 35, 'Brasov');

SELECT *
FROM Addresses;

INSERT INTO Customers
VALUES ('Nico', 20, 1);
INSERT INTO Customers
VALUES ('Alex', 30, 2);
INSERT INTO Customers
VALUES ('Daniel', 40, 3);

SELECT *
FROM Customers;

INSERT INTO Orders
VALUES ('First Order for Nico', 1);
INSERT INTO Orders
VALUES ('Second Order for Nico', 1);
INSERT INTO Orders
VALUES ('First Order for Alex', 2);
INSERT INTO Orders
VALUES ('something', 1005);
INSERT INTO Orders (Details)
VALUES ('First Order for Unknown');

SELECT *
FROM Orders;

INSERT INTO Products
VALUES ('Book about cats');
INSERT INTO Products
VALUES ('Book about c# development');
INSERT INTO Products
VALUES ('Book about databases');
INSERT INTO Products
VALUES ('Book about neuroscience');

SELECT * 
FROM Products;

INSERT INTO Orders_Products
VALUES (1, 1);
INSERT INTO Orders_Products
VALUES (1, 2);
INSERT INTO Orders_Products
VALUES (2, 4);
INSERT INTO Orders_Products
VALUES (3, 1);

--Ex 1
--Addresses
INSERT INTO Addresses
VALUES('Plopilor', 23, 'Brasov');
INSERT INTO Addresses
VALUES('Victoriei', 243, 'Sibiu');
INSERT INTO Addresses
VALUES('Milea', 20, 'Sibiu');
INSERT INTO Addresses
VALUES('Arhitectilor', 3, 'Iasi');
INSERT INTO Addresses
VALUES('Aurel-Vlaicu', 23, 'Deva');

--Customers
INSERT INTO Customers
VALUES('Andrei', 20, 1);
INSERT INTO Customers
VALUES('Mihai', 35, 3);
INSERT INTO Customers
VALUES('Ionela', 28, 2);
INSERT INTO Customers
VALUES('Cornel', 45, 5);
INSERT INTO Customers
VALUES('Maria', 24, 4);

--Orders
INSERT INTO Orders
VALUES('First Order for Andrei', 1);
INSERT INTO Orders
VALUES('First Order for Ionela', 3);
INSERT INTO Orders
VALUES('Second Order for Maria', 5);
INSERT INTO Orders
VALUES('something', 2);
INSERT INTO Orders
VALUES('something', 4);

--Products
INSERT INTO Products
VALUES ('Book about dogs');
INSERT INTO Products
VALUES ('Book about c++ development');
INSERT INTO Products
VALUES ('Book about JavaScipt');
INSERT INTO Products
VALUES ('Book about people');
INSERT INTO Products
VALUES ('Book about you');

SELECT * 
FROM Orders_Products;

INSERT INTO Orders_Products
VALUES (6, 5);
INSERT INTO Orders_Products
VALUES (7, 8);
INSERT INTO Orders_Products
VALUES (8, 6);
INSERT INTO Orders_Products
VALUES (9, 9);
INSERT INTO Orders_Products
VALUES (11, 7);

--Ex 2
SELECT *
FROM Customers
WHERE Customers.Age<15

--Ex 3
SELECT COUNT(Addresses.Id) AS 'Number of Addresses'
FROM Addresses

--Ex 4
UPDATE Products
SET Name = 'Another name'
WHERE Id = 1;
UPDATE Products
SET Name = 'Another name1'
WHERE Id = 2;
UPDATE Products
SET Name = 'Another name2'
WHERE Id = 3;
UPDATE Products
SET Name = 'Another name3'
WHERE Id = 4;
UPDATE Products
SET Name = 'Another name4'
WHERE Id = 5;
UPDATE Products
SET Name = 'Another name5'
WHERE Id = 6;
UPDATE Products
SET Name = 'Another name6'
WHERE Id = 7;
UPDATE Products
SET Name = 'Another name7'
WHERE Id = 8;
UPDATE Products
SET Name = 'Another name8'
WHERE Id = 9;


SELECT*
FROM Products;

--Ex 5
ALTER TABLE Addresses
ADD PostalCode INT;

SELECT*
FROM Addresses;

--Ex 6
UPDATE Addresses
SET PostalCode = 557140
WHERE Id = 1;
UPDATE Addresses
SET PostalCode = 478923
WHERE Id = 2;
UPDATE Addresses
SET PostalCode = 129475
WHERE Id = 3;
UPDATE Addresses
SET PostalCode = 864264
WHERE Id = 4;
UPDATE Addresses
SET PostalCode = 135868
WHERE Id = 5;
UPDATE Addresses
SET PostalCode = 232346
WHERE Id = 6;
UPDATE Addresses
SET PostalCode = 344357
WHERE Id = 7;
UPDATE Addresses
SET PostalCode = 234587
WHERE Id = 8;
UPDATE Addresses
SET PostalCode = 567894
WHERE Id = 9;
UPDATE Addresses
SET PostalCode = 234567
WHERE Id = 10;

SELECT*
FROM Orders;


--Ex 7
SELECT *
FROM Customers
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId;

--EX 8
SELECT *
FROM Customers
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId
LEFT JOIN Addresses On  Customers.AddressId =Addresses.Id;






