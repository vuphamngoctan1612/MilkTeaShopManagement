create database MilkTeaManagement
go

use MilkTeaManagement
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
add COUNT int default 0
alter table drink
add OriginPrice int default 0

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
add SalaryReceived int default 0
alter table Staff
add Fault int default 0
alter table Staff
add PhoneNumber varchar(10)
alter table Staff
add foreign key (position) references Position(name)
alter table staff
drop column MinusSalary
select *from staff
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
add NOTE text

alter table bill
add TableID int

alter table bill
add constraint FK_Bill_TableId foreign key(TableID) references TableFood(ID)


create table TableFood
(
	ID int not null,
	Name nvarchar(100),
	status bit default 0,

	constraint PK_Table_ID primary key(ID)
)
go

alter table tableFood
add NameGroup nvarchar(100) default ''

alter table TableFood
add constraint FK_TableFood_GroupTable foreign key(NameGroup) references GroupTable(Name)

create table GroupTable
(
	NAME nvarchar(100) default '',

	constraint PK_GroupTable primary key (NAME)
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
create table Position
(
	Name NVARCHAR(100) primary key,
	Salary INT default 0,
	OverTimeSalary INT default 0,
	MinusSalary INT default 0
)

-- proc BillInfo

--edit 
create proc USP_InsertBillInfo
@idBill int, @idDrink int, @count int	
as
begin
	declare @isExistBillInfo int
	declare @drinkCount int = 1

	select @isExistBillInfo = BillID, @drinkCount = Count
	from BillInfo
	where BillID = @idBill and DrinkID = @idDrink

	if (@isExistBillInfo > 0)
		begin
			declare @newCount int = @drinkCount + @count
			if (@newCount > 0)
				update BillInfo 
				set Count = @drinkCount + @Count
				where DrinkID = @idDrink and BILLID = @idBill
			else 
				delete BillInfo
				where BillID = @idBill and DrinkID = @idDrink
		end
	else 
		begin
			insert into BillInfo(BillID, DrinkID, Count)
			values
			(
				@idBill,
				@idDrink,
				@Count
			)
		end
end
go



create proc USP_DeleteBillInfo
@BillID int
as
begin
	delete from BillInfo
	where BillID = @BillID
end
go

-- proc Bill
create proc USP_UpdateBill
@ID int, @StaffID int, @CheckOut date, @Status bit, @Total int, 
as
begin
	update Bill
	set StaffID = @StaffID, CheckOut = @CheckOut, Status = @Status, Total = @Total 
	where ID = @ID
end
go

create proc USP_InsertBill
@ID int, @StaffID int, @note text
as
begin
	insert into Bill (ID, StaffID, NOTE) 
	values 
	(
	@ID,
	@StaffID,
	@note
	)
end
go

create proc USP_DeleteBill
@ID int
as
begin
	delete from Bill
	where ID = @ID
end
go

-- proc drink
create proc USP_AddDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image, @Origin int, @Count int
as
begin
	insert into Drink (ID, NAME, CATEGORY, PRICE, IMAGE, OriginPrice, Count) values (@ID, @Name, @Category, @Price, @Image, @Origin, @Count)
end
go

drop proc USP_EditDrink

create proc USP_EditDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image, @Origin int, @Count int
as 
begin
	update Drink
	set Name=@Name, Price=@Price, category=@Category, Image=@Image, OriginPrice=@Origin, Count=@Count
	where ID=@ID
end
go

create proc USP_SetnullDrinkIDinBillInfo
@drinkID int
as
begin
	update BillInfo
	set DrinkID=null
	where DrinkID=@drinkID
end
go

-- PROC MENU
create proc USP_GetListMenuByBillID
@billID int
as
begin
	select b.ID as BillID, d.ID as IDDrink, d.Name, d.Price, bf.Count 
	from ((BillInfo as bf 
		inner join Drink as d
		on bf.DrinkID = d.ID)
		inner join Bill as b
		on b.ID = bf.BillID)
	where b.ID = @billID
end
go

-- proc category
create proc USP_DeleteCategory
@Category nvarchar(100)
as 
begin
	delete from Drink
	where Category=@Category

	delete from Category
	where NAME=@Category
end
go

-- proc staff
create proc USP_AddStaff
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @username varchar(100), @phonenumber varchar(10)
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, USERNAME, PhoneNumber) values(@ID, @Name, @image, @birthday, @pos, @username, @phonenumber)
end
go

create proc USP_AddStaffnoUsername
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @phonenumber varchar(10)
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, PhoneNumber) values(@ID, @Name, @image, @birthday, @pos, @phonenumber)
end
go

create proc USP_EditStaff
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100),@phonenumber varchar(10)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, PhoneNumber = @phonenumber
	where ID = @ID
end
go

create proc USP_EditStaffnoUsername
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @phonenumber varchar(10)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, PhoneNumber = @phonenumber
	where ID = @ID
end
go

create proc USP_DelStaff
@ID int
as
begin
	delete from Staff where ID = @ID
end
go

create proc USP_UpdateOverTime
@ID int, @OverTime int
as
begin
	update Staff
	set OverTime = @OverTime
	where ID = @ID
end
go

create proc USP_UpdateFault
@ID int, @fault int
as
begin
	update Staff
	set Fault = @fault
	where ID = @ID
end
go

create proc USP_UpdateSalary
@name nvarchar(100), @salary int,@overtimesalary int, @minussalary int
as
begin
	update Position
	set SALARY = @salary, OverTimeSalary = @overtimesalary, MinusSalary = @minussalary
	where Name = @name
end
go

create proc USP_UpdateSalaryReceived
@id int, @salaryreceived int
as
begin
	update Staff
	set SalaryReceived = @salaryreceived
	where ID = @id
end
go

-- proc account
create proc USP_DelAccount
@user varchar(100)
as
begin
	delete from Account where UserName = @user
end

create proc USP_GetListInvoicebyBillID
@billID int
as
begin
select d.Name as N'Tên món', bf.Count as N'Số lượng', d.Price as N'Đơn giá', d.PRICE * bf.COUNT as N'Thành tiền'
from ((BillInfo as bf 
		inner join Drink as d
		on bf.DrinkID = d.ID)
		inner join Bill as b
		on b.ID = bf.BillID)
	where b.ID = @billID
end

select * from GroupTable
delete from 

select * from TableFood
select * from Bill
select * from BillInfo

                SELECT SUM(bf.COUNT) 
				FROM BillInfo bf 
                    JOIN Drink d ON d.ID = bf.DRINKID 
                    WHERE BILLID = 64
      