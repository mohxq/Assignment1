-- Create database and tables for SedapMakan
CREATE DATABASE SedapMakanDB;
GO
USE SedapMakanDB;
GO

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
    Balance DECIMAL(10,2) NOT NULL
);

CREATE TABLE Foods (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Chef NVARCHAR(100) NOT NULL
);

CREATE TABLE EWalletTransactions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT REFERENCES Users(Id),
    Amount DECIMAL(10,2) NOT NULL,
    Date DATETIME NOT NULL,
    Type NVARCHAR(20) NOT NULL
);

INSERT INTO Users (Email, Password, Role, Balance) VALUES
('admin@sedap.com','admin123','Admin',0),
('manager@sedap.com','manager123','Manager',0),
('chef@sedap.com','chef123','Chef',0),
('customer1@sedap.com','cust123','Customer',50),
('customer2@sedap.com','cust123','Customer',20);

INSERT INTO Foods (Name, Category, Price, Chef) VALUES
('Veggie Delight','Vegetarian',10.0,'chef@sedap.com'),
('Pasta Carbonara','Italian',15.0,'chef@sedap.com'),
('Tacos','Mexican',12.0,'chef@sedap.com'),
('Tom Yum Soup','Vegetarian',11.5,'chef@sedap.com'),
('Pizza Margherita','Italian',14.0,'chef@sedap.com');
