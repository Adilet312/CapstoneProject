DROP DATABASE if EXISTS bookStore;
CREATE DATABASE bookStore;
CREATE TABLE bookStore.Product (
			ProductId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
							ProductName VARCHAR(255) NOT NULL,
							ProductDesc VARCHAR(255) NOT NULL,
							ProductPrice DOUBLE NOT NULL
 );
 CREATE TABLE bookStore.OrderDetail (
			 OrderDetailId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
							ProductId INT  NOT NULL,
							OrderId INT NOT NULL,
							Quantity INT NOT NULL,
							CONSTRAINT fk_OrderDetail_ProductId FOREIGN KEY (ProductId)
				REFERENCES Product (ProductId)
								 ON DELETE CASCADE
 );
 /*Order Table*/
 CREATE TABLE bookStore.`Order` (
			 OrderId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
							OrderDate DATE NOT NULL,
							TotalAmount DOUBLE NOT NULL,
							IsCheckOut enum ('yes','no') DEFAULT NULL


 );
