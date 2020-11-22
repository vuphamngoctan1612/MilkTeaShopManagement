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
	Category nvarchar(100),
	PRICE int default 0,
	IMAGE image,

	constraint PK_Drink primary key (ID),
	constraint FK_Drink_IDCategory foreign key(Category) references Category(NAME)
)
go

create table Category
(
	NAME nvarchar(100) not null

	constraint PK_Category primary key (NAME)
)

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

create table BillInfo
(
	BILLID int,
	DRINKID int,
	COUNT int,

	constraint PK_BillInfo primary key(BILLID, DRINKID),
	constraint FK_BillInfo_BillID foreign key(BILLID) references Bill(ID),
	constraint FK_BillInfo_DrinkID foreign key(DRINKID) references Drink(ID)
)

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
create proc USP_UpdateBill
@CheckOut date, @Status bit, @Total int, @ID int, @StaffID int
as
begin
	update Bill
	set CheckOut = @CheckOut, Status = @Status, Total = @Total, StaffID = @StaffID
	where ID = @ID
end
go

create proc USP_InsertBill
@ID int, @StaffID int
as
begin
	insert into Bill (ID, StaffID) 
	values 
	(
	@ID,
	@StaffID
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

--proc Drink


create proc USP_AddDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image
as
begin
	insert into Drink(ID,NAME,PRICE,IMAGE) values (@ID,@Name,@Price,@Image)

	update Drink
	set Category=@Category
	where ID=@ID
end
go

drop proc USP_AddDrink

create proc USP_EditDrink
@ID int, @Name nvarchar(100), @Price int, @Category nvarchar(100), @Image image
as 
begin
	update Drink
	set Name=@Name, Price=@Price, Category=@Category, IMAGE=@Image
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

--proc Category
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
--proc Staff
create proc USP_AddStaff
@ID int, @Name nvarchar(100), @birthday date, @pos nvarchar(100),@username varchar(100), @salary int, @overtime int
as
begin
	insert into Staff values(@ID, @Name, @birthday, @pos, @username, @salary, @overtime)
end
go
create proc USP_EditStaff
@ID int, @Name nvarchar(100), @birthday date, @pos nvarchar(100), @salary int, @overtime int
as
begin
	update Staff 
	set Name = @Name, BirthDate = @birthday, Position = @pos, Salary = @salary, OverTime = @overtime
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
create proc USP_DelAccount
@user varchar(100)
as
begin
	delete from Account where UserName = @user
end
