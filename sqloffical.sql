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
go

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
create proc USP_AddStaff
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @username varchar(100), @salary int
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, USERNAME, SALARY) values(@ID, @Name, @image, @birthday, @pos, @username, @salary)
end
go

create proc USP_AddStaffnoUsername
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @salary int
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, SALARY) values(@ID, @Name, @image, @birthday, @pos, @salary)
end
go

create proc USP_EditStaff
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100),@overtime int, @salary int
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, OverTime = @overtime, SALARY = @salary
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

-- proc account
create proc USP_DelAccount
@user varchar(100)
as
begin
	delete from Account where UserName = @user
end

INSERT INTO Account VALUES ('admin', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 0)
INSERT INTO Account VALUES ('nv', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1)

insert into Staff(ID, Name, BirthDate, Position, UserName, Salary, overtime) values(1, 'Anhdz', '2001-11-22', 'Quan Ly', 'admin', '3000000', 0)
insert into Staff(ID, Name, BirthDate, Position, UserName, Salary, overtime) values(2, 'Quang', '2001-11-22', 'Quan Ly', 'nv', '3000000', 0)

INSERT INTO Staff(ID, NAME, BIRTHDATE, POSITION, SALARY,) 
VALUES (4, 'TAN', '2001-11-22', 'Quan Ly', 3000000, 0)
SELECT * FROM Staff
delete FROM Staff
select * from Drink
select * from billinfo
select * from Bill

delete from BillInfo
delete from Bill
delete from Drink
select * from Category

exec USP_GetListMenuByBillID 1
select * from bill

SELECT SUM(bf.COUNT) FROM BillInfo bf
JOIN Drink d ON d.ID = bf.DRINKID
WHERE BILLID = 2

update Category
set NAME = ''


SELECT * FROM STAFF WHERE USERNAME = 'admin'