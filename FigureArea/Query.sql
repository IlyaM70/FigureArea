CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name VARCHAR(10)
);

INSERT INTO Products
VALUES
	(1, 'Tomato'),
	(2, 'Apple'),
	(3, 'Milk');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name VARCHAR(10)
);

INSERT INTO Categories
VALUES
	(1, 'Vegetables'),
	(2, 'Fruit'),
	(3, 'Dairy');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 2);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;