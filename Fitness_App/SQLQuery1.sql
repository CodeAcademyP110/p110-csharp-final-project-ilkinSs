--create database Oybeden

use Oybeden

--create table Services(
--id int  primary key identity,
--Name nvarchar(50) not null unique,
--"Price (per hour)" decimal(18,2) not null,
--"Price (per month)" decimal(18,2) not null
--)

--create table Times(
-- id int primary key identity,
-- Name nvarchar(20) not null,
-- Hours nvarchar(100) not null
-- )

--create table Packages(
--id int primary key identity,
--Name nvarchar(100) not null,
--FitnessId int references Services(id),
--PoolId int references Services(id),
--MassageId int references Services(id),
--SaunaId int references Services(id),
--TimeId int references Times(id),
--"Price (per month)" decimal(18,2) not null
--)

--create table Customers(
--id int primary key identity,
--Name nvarchar(100) not null,
--Surname nvarchar(100),
--CardCode  nvarchar(13) not null unique,
--)

--create table Positions(
--id int primary key identity,
--Name nvarchar(100) not null unique
--)

--create table Employees(
--id int primary key identity,
--Name nvarchar(100) not null,
--Surname nvarchar(100),
--Username nvarchar(50) not null unique,
--Password nvarchar(50) not null,
--PositionId int references Positions(id)
--)

--create table Orders(
--id int primary key identity,
--EmployeeId int references Employees(id),
--CustomerId int references Customers(id),
--Date datetime not null,
--Price decimal(18,2) not null
--)

--create table OrderDetails(
--id int primary key identity,
--PackageId int references Packages(id),
--OrderId int references Orders(id)
--)

--create table Incomes(
--id int primary key identity,
--Date datetime not null,
--Income decimal(18,2) not null
--)

--create table Outcomes(
--id int primary key identity,
--Date datetime not null,
--Outcome decimal(18,2) not null
--)
