CREATE DATABASE LibrariesManagement;

USE LibrariesManagement;

CREATE TABLE Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    StreetName VARCHAR(50),
    City VARCHAR(50)
);

CREATE TABLE Librarians
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(30),
    HireDate Date,
    IsOnHoliday VARCHAR(3),
    LibraryId INT REFERENCES Libraries(Id)
);

CREATE TABLE Books
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Title VARCHAR(50),
    AuthorFirstName VARCHAR(30),
    AuthorLastName VARCHAR(30),
    Type VARCHAR(10), -- crime, fantasy, horror, adventure
);

CREATE TABLE Books_Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    LibraryId INT REFERENCES Libraries(Id)
);

CREATE TABLE Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    NumberOfCopies INT,
    LibraryId INT REFERENCES Libraries(Id),
    LibrarianId INT REFERENCES Librarians(Id)
);

CREATE TABLE Books_Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    SalesId INT REFERENCES Sales(Id)
);

-- Libraries
INSERT INTO Libraries
VALUES  ('Carturesti','Teilor', 'Brasov')
INSERT INTO Libraries
VALUES  ('Diverta Plaza','Victoriei', 'Sibiu')
INSERT INTO Libraries
VALUES  ('Carturesti Carusel','Gladiolelor', 'Iasi')

SELECT *
FROM Libraries;

-- Librarians
INSERT INTO Librarians
VALUES  ('Liviu','2008-11-11 ', 'no',1)
INSERT INTO Librarians
VALUES  ('Andreea','2018-03-20', 'yes',2)
INSERT INTO Librarians
VALUES  ('Mihai','2015-10-10', 'yes',1)
INSERT INTO Librarians
VALUES  ('Cristina','2019-05-10', 'no',3)

SELECT *
FROM Librarians;

-- Books
INSERT INTO Books
VALUES  ('Străinul','Albert ', 'Camus','mister')
INSERT INTO Books
VALUES  ('Mândrie și prejudecată ','Jane ', 'Austen','de viata')
INSERT INTO Books
VALUES  ('Razboi si pace',' Lev ', 'Tolstoi','razboi')


SELECT *
FROM Books;

--Books_Libraries
INSERT INTO Books_Libraries
VALUES  (1,2)
INSERT INTO Books_Libraries
VALUES  (2,1)
INSERT INTO Books_Libraries
VALUES  (3,3)
INSERT INTO Books_Libraries
VALUES  (1,3)

SELECT *
FROM Books_Libraries;

-- Sales
INSERT INTO Sales
VALUES  (100,1,2)
INSERT INTO Sales
VALUES  (200,2,4)
INSERT INTO Sales
VALUES  (156,3,1)

SELECT *
FROM Sales;


--Books_Sales
INSERT INTO Books_Sales
VALUES  (1,1)
INSERT INTO Books_Sales
VALUES  (2,3)
INSERT INTO Books_Sales
VALUES  (3,2)

SELECT*
FROM Books_Sales

-- Ex 1
CREATE TABLE Author (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    FirstName varchar(255),
    LastName varchar(255),
    EmailAddress varchar(255),
);
SELECT * FROM Author

ALTER TABLE Books 
DROP COLUMN AuthorFirstName, AuthorLastName;

SELECT * FROM Books;

ALTER TABLE Books
ADD AuthorId INT REFERENCES Author(Id);

INSERT INTO Author
VALUES  ('Albert ', 'Camus','albert@yahoo.com')
INSERT INTO Author
VALUES  ('Jane ', 'Austen','jane@yahoo.com')
INSERT INTO Author
VALUES  (' Lev ', 'Tolstoi','lev@yahoo.com')

UPDATE Books
SET AuthorId = 1
WHERE id =1

UPDATE Books
SET AuthorId = 2
WHERE id =2

UPDATE Books
SET AuthorId = 3
WHERE id =3

UPDATE Books
SET AuthorId = 3
WHERE id =4

UPDATE Books
SET AuthorId = 3
WHERE id =5


SET IDENTITY_INSERT Books OFF
INSERT INTO Books
VALUES  ('Vina',' mister', 3)
INSERT INTO Books
VALUES  ('Cei 3 muschetari',' aventura',3)


-- EX 2
SELECT Librarians.Name,Libraries.Name
FROM Librarians
JOIN Libraries ON Librarians.Id = Libraries.Id
ORDER BY Librarians.Name DESC 

SELECT Librarians.Name,Libraries.Name
FROM Librarians
JOIN Libraries ON Librarians.Id = Libraries.Id
ORDER BY Libraries.Name DESC 


-- EX 3
UPDATE Libraries
SET StreetName = 'Str.'+ StreetName

SELECT * FROM Libraries;


--Ex 4
SELECT * FROM Author;
SELECT * FROM Books;

SELECT Author.EmailAddress
FROM Author
INNER JOIN Books ON Author.Id = AuthorId
GROUP BY EmailAddress 
HAVING COUNT(Books.AuthorId) >= 3;

-- Ex 5

SELECT * FROM Sales
SELECT * FROM Libraries
SELECT * FROM Books_Sales
SELECT * FROM  Books_Libraries

SELECT TOP 1 Libraries.Name, Books.Title FROM Libraries 
JOIN Books_Libraries ON LibraryId =Libraries.Id
JOIN  Books ON Libraries.Id=Books.Id
JOIN Books_Sales ON Books.Id=Books_Sales.BookId
JOIN Sales ON SalesId=Sales.Id
ORDER BY Sales.NumberOfCopies ASC


--EX 6
SELECT * FROM Librarians

SELECT Librarians.Name
FROM Librarians
WHERE IsOnHoliday = 'no' AND DATEDIFF(YEAR,HireDate, GETDATE()) > 5  

--Ex 7
SELECT * FROM Books
SELECT * FROM Libraries
SELECT * FROM Books_Libraries

GO
CREATE PROCEDURE ShowLibraries(@title VARCHAR(23))
AS
BEGIN
    SELECT Books.Title, COUNT(LibraryId) FROM Books_Libraries
    JOIN Libraries ON Libraries.Id = Libraries.Id
    JOIN Books ON BookId= Books.Id
    WHERE Books.Title=@title
    GROUP BY Books.Title
    ORDER BY COUNT(LibraryId) DESC;
END
DROP procedure ShowLibraries
-- call the procedure
GO
exec ShowLibraries @title='Strainul';
exec ShowLibraries @title='Razboi si pace';
exec ShowLibraries @title='Vina';

--Ex 8

GO
CREATE FUNCTION dbo.HelloWorldFunction(
@email VARCHAR
)
RETURNS varchar(20)
AS
BEGIN
RETURN 'Hello world'
END;
-- call the function

GO
select dbo.HelloWorldFunction('lev@yahoo.com');

--Ex 9
GO
CREATE TRIGGER AssignedLibraryWhenNewLibrarianIsAdded
ON Librarians
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @name CHAR(128);
    DECLARE @HireDate Date;
    DECLARE @IsOnHoliday  CHAR(3);
    DECLARE @LibraryId INT;
    SELECT @name = Name, @HireDate = HireDate, @IsOnHoliday = IsOnHoliday, @LibraryId = LibraryId FROM INSERTED;
    IF  @LibraryId IS NULL SET @LibraryId = 2;
    INSERT INTO Librarians
    VALUES(@name , @HireDate, @IsOnHoliday, @LibraryId)
END
GO
DROP TRIGGER AssignedLibraryWhenNewLibrarianIsAdded

INSERT INTO Librarians(Name,HireDate,IsOnHoliday)
VALUES('Iulian','2023-05-15','no');

SELECT * FROM Librarians


--Ex 10
BEGIN TRANSACTION 
INSERT INTO Librarians 
VALUES('Corina','2023-05-15' ,'yes',1)
SAVE TRANSACTION InsertStatement
DELETE Librarians WHERE Id=1004
SELECT * FROM Librarians 
ROLLBACK TRANSACTION InsertStatement
COMMIT

SELECT * FROM Librarians 