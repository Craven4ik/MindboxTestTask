CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL
);

CREATE TABLE Categories
(
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategories
(
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    PRIMARY KEY (ProductID, CategoryID)
);

INSERT INTO Products (ProductID, ProductName)
VALUES (1, 'Product 1'), (2, 'Product 2'), (3, 'Product 3');

INSERT INTO Categories (CategoryID, CategoryName)
VALUES (1, 'Category 1'), (2, 'Category 2'), (3, 'Category 3');

INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES (1, 1), (1, 2), (2, 2), (3, 3);

SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;