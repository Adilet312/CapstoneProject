DROP DATABASE if EXISTS bookStore;
CREATE DATABASE bookStore;
/*Product Table*/
CREATE TABLE bookStore.Product (
			 ProductId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
             ProductName VARCHAR(255) NOT NULL,
             ProductDesc VARCHAR(255) NOT NULL,
             ProductPrice FLOAT NOT NULL
);
/*Customer Table*/
CREATE TABLE bookStore.Customer (
			 CustomerId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
             FirstName VARCHAR(255) NOT NULL,
             LastName VARCHAR(255) NOT NULL,
             Email VARCHAR(255) NOT NULL,
             Address VARCHAR(255) NOT NULL,
             City VARCHAR(255),
             State VARCHAR(255),
             Zip VARCHAR(255),
             Country VARCHAR(255)
);
/*Order Table*/
CREATE TABLE bookStore.`Order` (
			 OrderId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
             CustomerId INT NOT NULL,
             OrderDate DATE NOT NULL,
             TotalAmount FLOAT NOT NULL,
             IsCheckOut ENUM ('yes','no') DEFAULT NULL,
             CONSTRAINT fk_Order_CustomerId FOREIGN KEY (CustomerId)
			       REFERENCES Customer (CustomerId)
			       ON DELETE CASCADE


);
/*OrderDetail is linking table*/
CREATE TABLE bookStore.OrderDetail (
			 OrderDetailId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
             ProductId INT  NOT NULL,
             OrderId INT NOT NULL,
             Quantity INT NOT NULL,
             CONSTRAINT fk_OrderDetail_ProductId FOREIGN KEY (ProductId)
			       REFERENCES Product (ProductId)
			       ON DELETE CASCADE,
			       CONSTRAINT fk_OrderDetail_OrderId FOREIGN KEY (OrderId)
			       REFERENCES `Order` (OrderId)
			       ON DELETE CASCADE
);
