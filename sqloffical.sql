create MilkTea
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

select * from Account
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
alter table Staff 
add CMND varchar(9)
alter table Staff
add Address nvarchar(1000)
alter table Staff
add Sex bit
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
select * from Position
Insert into Position
Values (N'Thu Ngân',3000000,0,0);
Insert into Position
Values (N'Pha Chế',3000000,0,0);
Insert into Position
Values (N'Phục Vụ',3000000,0,0);
Insert into Position
Values (N'Bảo Vệ',3000000,0,0);
create table Admin
(	
	ID int primary key,
	Name nvarchar(100)
)
insert into Admin
values (1,N'Thành Quang');


-- proc BillInfo
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
				where DrinkID = @idDrink
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
alter proc USP_UpdateBill
@ID int, @StaffID int, @CheckOut date, @Status bit, @Total int
as
begin
	update Bill
	set StaffID = @StaffID, CheckOut = @CheckOut, Status = @Status, Total = @Total 
	where ID = @ID
end
go

alter proc USP_InsertBill
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
alter proc USP_AddDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image
as
begin
	--insert into Drink(ID,NAME,PRICE,IMAGE) values (@ID,@Name,@Price,@Image)

	--update Drink
	--set category = @Category
	--where ID = @ID

	insert into Drink (ID, NAME, CATEGORY, PRICE, IMAGE) values (@ID, @Name, @Category, @Price, @Image)
end
go

create proc USP_EditDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image
as 
begin
	update Drink
	set Name=@Name, Price=@Price, category=@Category, Image=@Image
	where ID=@ID
end
go

alter proc USP_SetnullDrinkIDinBillInfo
@drinkID int
as
begin
	update BillInfo
	set DrinkID=null
	where DrinkID=@drinkID
end
go

UPDATE Drink
SET STATUS =1
WHERE ID = 1

select * from Drink
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
alter proc USP_AddStaff
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @username varchar(100), @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	insert into Staff  
	values(@ID, @Name, @image, @birthday, @pos, @username,0,0,0, @phonenumber, @cmnd, @sex, @address)
end
go

alter proc USP_AddStaffnoUsername
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, PhoneNumber, CMND, Sex, Address) values(@ID, @Name, @image, @birthday, @pos, @phonenumber, @cmnd, @sex, @address)
end
go

alter proc USP_EditStaff
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100),@phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, PhoneNumber = @phonenumber, CMND = @cmnd, Sex = @sex, Address = @address
	where ID = @ID
end
go
alter proc USP_EditStaffnoUsername
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @phonenumber varchar(10),  @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, PhoneNumber = @phonenumber, CMND = @cmnd, Sex = @sex, Address = @address
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

alter proc USP_UpdateSalary
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

alter proc USP_GetListInvoicebyBillID
@billID int
as
begin
select d.Name as N'Tên món', bf.Count as N'Số lượng', d.Price as N'Đơn giá', d.PRICE * bf.COUNT as N'Thành tiền'
from ((BillInfo as bf 
		inner join Drink as d
		on bf.DrinkID = d.ID)
		inner join Bill as b
		on b.ID = bf.BillID)
	where b.ID = 6
end
INSERT INTO BILL VALUES({0}, {1}, '{2}', 1, {3}, N'Kết toán lương tháng {4}'), 
                id, idStaff, time, totalSalary, month)
select * from bill
select *from Staff
select *from Account
select * from Position
insert into Position
values (N'Quản Lý', 0,0,0);
insert into Staff
values (1, N'Thế ANh',null,'10-01-2020',N'Quản Lý','admin',0,0,0,'0');
