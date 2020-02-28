DROP DATABASE if EXISTS bookStore;
CREATE DATABASE bookStore;
CREATE TABLE bookStore.Product (
			 ProductId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
             ProductName VARCHAR(255) NOT NULL,
             ProductDesc VARCHAR(255) NOT NULL,
             ProductPrice DOUBLE NOT NULL
			 ); 
