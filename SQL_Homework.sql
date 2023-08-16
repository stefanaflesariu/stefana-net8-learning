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
SELECT * FROM Author
SELECT * FROM Books;

SELECT Author.EmailAddress, COUNT(Books.AuthorId) AS 'Books published'
FROM Author
INNER JOIN Books ON Author.Id = AuthorId
GROUP BY EmailAddress 
HAVING COUNT(Books.AuthorId) >= 3;

-- Ex 5
SELECT * FROM Sales
SELECT * FROM Books_Libraries
SELECT * FROM Books

SELECT Libraries.Name , Books.Title
FROM Books_Libraries
INNER JOIN Libraries ON LibraryId=Libraries.Id
INNER JOIN Books ON BookId=Books.Id

SELECT MAX(Sales.NumberOfCopies)
FROM Sales
JOIN Libraries ON LibraryId=Libraries.Id

--EX 6
SELeCT * FRoM Librarians

SELECT Librarians.Name
FROM Librarians
WHERE IsOnHoliday = 'no' AND DATEDIFF(YEAR,HireDate, GETDATE()) > 5  

--Ex 7
SELECT * FROM Books_Libraries
GO
CREATE PROCEDURE ShowLibraries(@title VARCHAR)
AS
BEGIN
    SELECT Books.Title As 'Title of Book' ,COUNT(Libraries.Id) AS 'Number of Libraries'
    FROM Books
    JOIN  Books_Libraries ON BookId=Books.Id
    JOIN Libraries ON LibraryId = Libraries.Id
    GROUP BY Books.Title 
    HAVING Title = @title
END
DROP procedure ShowLibraries
-- call the procedure
GO
exec ShowLibraries @title='Strainul';
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
select dbo.HelloWorldFunction();