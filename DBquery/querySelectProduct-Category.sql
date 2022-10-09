CREATE TABLE Products(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL
)

CREATE TABLE Categories(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL
)

CREATE TABLE ProductOfCategory(
	idProduct int NOT NULL,
	idCategory int NOT NULL,
	FOREIGN KEY (idProduct) REFERENCES Products(id),
	FOREIGN KEY (idCategory) REFERENCES Categories(id),
	PRIMARY KEY(idProduct, idCategory)
)

GO

USE master

INSERT INTO Products 
VALUES
	('Sausage'),
	('Milk'),
	('Tea'),
	('Coffee'),
	('Sugar');

INSERT INTO Categories 
VALUES
	('Grocery group'),
	('Gastronomy');

INSERT INTO ProductOfCategory
VALUES
	(1, 2),
	(2, 2),
	(3, 1),
	(4, 1),
	(5, 1);

GO

SELECT Products.Name, Categories.Name 
FROM Products INNER JOIN ProductOfCategory
	ON Products.id = ProductOfCategory.idProduct
INNER JOIN Categories
	ON ProductOfCategory.idCategory = Categories.id
