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

ALTER proc [dbo].[USP_AddDrink]
@ID int, @Name nvarchar(100), @Price bigint, @Category nvarchar(100), @Image image, @Origin bigint
as
begin
	insert into Drink (ID, NAME, CATEGORY, PRICE, IMAGE, originprice) values (@ID, @Name, @Category, @Price, @Image, @Origin)
end

ALTER proc [dbo].[USP_AddStaff]
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @username varchar(100), @salaryreceived bigint , @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	insert into Staff  (ID, NAME, IMAGE,BIRTHDATE, POSITION, USERNAME, OVERTIME, SalaryReceived, Fault, PhoneNumber, CMND, Sex, Address)
	values(@ID, @Name, @image, @birthday, @pos, @username,0,@salaryreceived,0, @phonenumber, @cmnd, @sex, @address)
end

ALTER proc [dbo].[USP_AddStaffnoUsername]
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @salaryreceived bigint , @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, SalaryReceived,PhoneNumber, CMND, Sex, Address) values(@ID, @Name, @image, @birthday, @pos, @salaryreceived,@phonenumber, @cmnd, @sex, @address)
end

ALTER proc [dbo].[USP_DelAccount]
@user varchar(100)
as
begin
	delete from Account where UserName = @user
end

ALTER proc [dbo].[USP_DeleteBill]
@ID int
as
begin
	delete from Bill
	where ID = @ID
end

ALTER proc [dbo].[USP_DeleteBillInfo]
@BillID int
as
begin
	delete from BillInfo
	where BillID = @BillID
end

ALTER proc [dbo].[USP_DeleteCategory]
@Category nvarchar(100)
as 
begin
	delete from Drink
	where Category=@Category

	delete from Category
	where NAME=@Category
end

ALTER proc [dbo].[USP_DelStaff]
@ID int
as
begin
	delete from Staff where ID = @ID
end

ALTER proc [dbo].[USP_EditDrink]
@ID int, @Name nvarchar(100), @Price bigint, @Category nvarchar(100), @Image image, @Origin bigint
as 
begin
	update Drink
	set Name=@Name, Price=@Price, category=@Category, Image=@Image, OriginPrice = @Origin
	where ID=@ID
end

ALTER proc [dbo].[USP_EditStaff]
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @username varchar(100),@salaryreceived bigint, @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, USERNAME = @username, SalaryReceived = @salaryreceived,PhoneNumber = @phonenumber, CMND = @cmnd, Sex = @sex, Address = @address
	where ID = @ID
end

ALTER proc [dbo].[USP_EditStaffnoUsername]
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @salaryreceived bigint, @phonenumber varchar(10),  @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, SalaryReceived = @salaryreceived, PhoneNumber = @phonenumber, CMND = @cmnd, Sex = @sex, Address = @address
	where ID = @ID
end

ALTER proc [dbo].[USP_GetListInvoice]
as
begin
	select d.Name as N'Tên món', d.Price as N'Đơn giá', bd.Count as N'Số lượng', d.PRICE * bd.COUNT as N'Thành tiền' from BillInfo as bd 
	inner join Drink as d
	on bd.DrinkID = d.ID 
end

ALTER proc [dbo].[USP_GetListInvoicebyBillID]
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

ALTER proc [dbo].[USP_GetListMenuByBillID]
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

ALTER proc [dbo].[USP_InsertBill]
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

ALTER proc [dbo].[USP_InsertBillInfo]
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

ALTER proc [dbo].[USP_SetnullDrinkIDinBillInfo]
@drinkID int
as
begin
	update BillInfo
	set DrinkID=null
	where DrinkID=@drinkID
end

ALTER proc [dbo].[USP_UpdateBill]
@ID int, @StaffID int, @CheckOut date, @Status bit, @Total bigint
as
begin
	update Bill
	set StaffID = @StaffID, CheckOut = @CheckOut, Status = @Status, Total = @Total 
	where ID = @ID
end

ALTER proc [dbo].[USP_UpdateFault]
@ID int, @fault int
as
begin
	update Staff
	set Fault = @fault
	where ID = @ID
end

ALTER proc [dbo].[USP_SetnullDrinkIDinBillInfo]
@drinkID int
as
begin
	update BillInfo
	set DrinkID=null
	where DrinkID=@drinkID
end

ALTER proc [dbo].[USP_UpdateSalary]
@position nvarchar(100), @salary bigint,@overtimesalary bigint, @minussalary bigint
as
begin
	update Position
	set SALARY = @salary, OverTimeSalary = @overtimesalary, MinusSalary = @minussalary
	where Name = @position
end

ALTER proc [dbo].[USP_UpdateSalaryReceived]
@id int, @salaryreceived bigint
as
begin
	update Staff
	set SalaryReceived = @salaryreceived
	where ID = @id
end

