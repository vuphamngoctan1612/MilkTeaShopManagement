CREATE DATABASE MilkteaManagement
GO
USE MilkteaManagement
GO
CREATE TABLE Staff
(
	ID CHAR(50) PRIMARY KEY,
	Name NVARCHAR(100),
	BirthDate DATE,
	Position NVARCHAR(100),
	UserName NVARCHAR(100),
	BasicSalary Money,
	WorkingTime SMALLINT,
	Salary Money
)
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(100)
)
ALTER TABLE Staff
ADD FOREIGN KEY (UserName) REFERENCES Account (UserName);
ALTER TABLE Account ADD Type SMALLINT;
SELECT * FROM Account;
CREATE TABLE Drinks
(
	ID CHAR(50) PRIMARY KEY,
	Name NVARCHAR(100),
	Price Money
)
CREATE TABLE Bill
(
	ID CHAR(50) PRIMARY KEY,
	StaffID CHAR(50),
	IssueDate DATE,
	ExportTime TIME,
	Price MONEY
)
SELECT * FROM Staff;
SELECT * FROM Account;
SELECT * FROM Drinks;
SELECT * FROM Bill;
ALTER TABLE Bill
ADD FOREIGN KEY (StaffID) REFERENCES Staff(ID);
insert into Drinks values ('Tea01', N'Trà Sen Vàng', 39000)
insert into Drinks values ('Tea02',N'Trà Th?ch V?i',39000)
insert into Drinks values ('Tea03',N'Trà Thanh ?ào',39000)
insert into Drinks values ('Tea04',N'Trà Th?ch ?ào',39000)
insert into Drinks values ('Tea05',N'Trà Thanh ??u ??',39000)
insert into Drinks values ('PhinDi01',N'PhinDi H?nh Nhân',39000)
insert into Drinks values ('PhinDi02',N'PhinDi Kem S?a',39000)
insert into Drinks values ('PhinDi03',N'PhinDi Choco',39000)
insert into Drinks values ('Traditional Coffee01',N'Phin S?a ?á',29000)
insert into Drinks values ('Traditional Coffee02',N'Phin ?en ?á',29000)
insert into Drinks values ('Traditional Coffee03',N'B?c X?u',29000)
insert into Drinks values ('Traditional Coffee04',N'Phin ?en Nóng',29000)	
insert into Drinks values ('Espresso Coffee01','Latte',55000)
insert into Drinks values ('Espresso Coffee02','Cappuccino',55000)
insert into Drinks values ('Espresso Coffee03','Americano',35000)
insert into Drinks values ('Espresso Coffee04','Mocha',35000)
insert into Drinks values ('Espresso Coffee05','Caramel Macchiato',59000)
insert into Drinks values ('Espresso Coffee06','Espresso',35000)
INSERT INTO Account VALUES ('ADMIN001','7a3e6b16cb75f48fb897eff3ae732f3154f6d203b53f33660f01b4c3b6bc2df9',0);
INSERT INTO Account VALUES ('ADMIN002','7a3e6b16cb75f48fb897eff3ae732f3154f6d203b53f33660f01b4c3b6bc2df9',0);
INSERT INTO Account VALUES ('ADMIN003','7a3e6b16cb75f48fb897eff3ae732f3154f6d203b53f33660f01b4c3b6bc2df9',0);
INSERT INTO Account VALUES ('NV001','7a3e6b16cb75f48fb897eff3ae732f3154f6d203b53f33660f01b4c3b6bc2df9',1);
INSERT INTO Account VALUES ('NV002','7a3e6b16cb75f48fb897eff3ae732f3154f6d203b53f33660f01b4c3b6bc2df9',1);
INSERT INTO Account VALUES ('NV003','7a3e6b16cb75f48fb897eff3ae732f3154f6d203b53f33660f01b4c3b6bc2df9',1);