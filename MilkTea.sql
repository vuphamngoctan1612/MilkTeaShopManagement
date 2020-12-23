create MilkTea
go

use MilkTea
go

create table Account
(
	USERNAME varchar(100) not null,
	PASSWORD VARCHAR(1000) not null,
	TYPE BIT not null,

	constraint PK_Account primary key (USERNAME)
)
go

create table Drink
(
	ID int not null,
	NAME nvarchar(100) not null,
	CATEGORY nvarchar(100) default '',
	PRICE int default 0,
	IMAGE image,
	STATUS bit default 1,

	constraint PK_Drink primary key (ID),
	constraint FK_Drink_Category foreign key(CATEGORY) references Category(NAME)
)
go
alter table drink
add price bigint default 0
alter table drink
add originprice bigint default 0

create table Category
(
	NAME nvarchar(100) default '',

	constraint PK_Category primary key (NAME)
)
go

create table Staff
(
	ID int not null,
	NAME NVARCHAR(100) not null,
	IMAGE image,
	BIRTHDATE DATE,
	POSITION NVARCHAR(100),
	USERNAME VARCHAR(100),
	OVERTIME SMALLINT DEFAULT 0, -- sửa lại là overtime nha
	SALARY INT DEFAULT 0,

	constraint PK_Staff primary key (ID),
	constraint FK_Staff_UserName foreign key(USERNAME) references Account(USERNAME)
)
go
alter table Staff
add SalaryReceived bigint default 0
alter table Staff
add Fault int default 0
alter table Staff
add PhoneNumber varchar(10)
alter table Staff 
add CMND varchar(9)
alter table Staff
add Address nvarchar(1000)
alter table Staff
add Sex bit
alter table staff
add constraint FK_Staff_Position foreign key (POSITION) references POSITION(NAME)


create table Position
(
	Name NVARCHAR(100) primary key,
	Salary INT default 0,
	OverTimeSalary INT default 0,
	MinusSalary INT default 0
)
alter table position add Salary bigint default 0
alter table position add OverTimeSalary bigint default 0
alter table position add MinusSalary bigint default 0

create table Bill
(
	ID int not null,
	STAFFID int,
	CHECKOUT date,
	STATUS bit default 0,
	TOTAL int default 0,

	constraint PK_Bill primary key(ID),
)
go
alter table bill	
add NOTE nvarchar(1000)
alter table bill
add CheckIn date

alter table BILL
add TableID int
alter table BILL
add constraint FK_Bill_TableID foreign key (TableID) references TableFood(ID)
alter table bill	
add constraint FK_Bill_StaffID foreign key (STAFFID) references Staff(ID)

alter table bill add TOTAL BIGINT DEFAULT 0

create table TableFood
(
	ID int not null,
	Name nvarchar(100),
	status bit,

	constraint PK_Table_ID primary key(ID)
)

create table BillInfo
(
	BILLID int,
	DRINKID int,
	COUNT int,

	constraint PK_BillInfo primary key(BILLID, DRINKID),
	constraint FK_BillInfo_BillID foreign key(BILLID) references Bill(ID),
	constraint FK_BillInfo_DrinkID foreign key(DRINKID) references Drink(ID)
)
go

