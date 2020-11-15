create database MilkTeaManagement
go

use MilkTeaManagement
go

create table Account
(
	UserName varchar(100) not null,
	PassWord VARCHAR(1000) not null,
	Type BIT not null,

	constraint PK_Account primary key (username)
)
go

create table Drink
(
	ID int not null,
	Name nvarchar(100) not null,
	Price int not null,

	constraint PK_Drink primary key (ID)
)
go

create table Staff
(
	ID int not null,
	Name NVARCHAR(100) not null,
	BirthDate DATE not null,
	Position NVARCHAR(100) not null,
	UserName VARCHAR(100) not null,
	WorkingTime SMALLINT not null,
	Salary INT not null,

	constraint PK_Staff primary key (ID)
)
go
alter table staff
add constraint FK_Staff_UserName foreign key (UserName) references Account(username)
go

create table Bill
(
	ID int not null,
	--StaffID int not null,
	--CheckIn DATE not null default getdate(),
	CheckOut date,
	--Price INT not null
	Status bit not null default 0,

	constraint PK_Bill primary key(ID),
	--constraint FK_Bill foreign key(StaffID) references Staff(ID)
)
go
alter table Bill
add Total int

create table BillInfo
(
	ID int not null,
	BillID int not null,
	DrinkID int not null,
	Count int not null,

	constraint PK_BillInfo primary key(ID),
	constraint FK_BillInfo_BillID foreign key(BillID) references Bill(ID),
	constraint FK_BillInfo_DrinkID foreign key(DrinkID) references Drink(ID)
)

insert into Drink (ID, Name, Price) values (1,N'Trà Sen Vàng', 39000)
insert into Drink (ID, Name, Price) values (2,N'Trà Thạch Vải',39000)
insert into Drink (ID, Name, Price) values (3,N'Hạnh Nhân',39000)
insert into Drink (ID, Name, Price) values (4,N'Kem Sữa',39000)
insert into Drink (ID, Name, Price) values (5,'Latte',55000)
insert into Drink (ID, Name, Price) values (6,'Cappuccino',55000)

create proc USP_UpdateBillInfo
@Count int, @ID int, @BillID int
as
begin
	update BillInfo 
	set Count = @Count
	where Id = @ID and BillID = @BillID
end
go

create proc USP_InsertBillInfo
@id int, @idBill int, @idDrink int, @count int	
as
begin
	declare @isExistBillInfo int
	declare @drinkCount int = 1

	select @isExistBillInfo = Id, @drinkCount = Count
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
			insert into BillInfo(id, BillID, DrinkID, Count)
			values
			(
				@id,
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

alter proc USP_UpdateBill
@CheckOut date, @Status bit, @Total int, @ID int
as
begin
	update Bill
	set CheckOut = @CheckOut, Status = @Status, Total = @Total
	where ID = @ID
end
go

alter proc USP_InsertBill
@ID int
as
begin
	insert into Bill (ID) 
	values 
	(
	@ID
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


insert into Account values ('admin', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 0)

insert into Bill (ID, CheckIn) values (1,GETDATE())
insert into Bill (ID, CheckIn) values (2,GETDATE())
insert into Bill (ID, CheckIn) values (3,GETDATE())

insert into Staff (ID, Name, BirthDate, Salary, WorkingTime) values (1, N'Trần Thế Anh', '2001-11-22', 3000000, 200)
insert into Staff (ID, Name, BirthDate, Salary, WorkingTime) values (2, N'Quang', '2001-4-15', 4000000, 200)

select b.ID as BillID, bf.ID as IDBillInfo, d.ID as IDDrink, d.Name, d.Price, bf.Count 
from ((BillInfo as bf 
		inner join Drink as d
		on bf.DrinkID = d.ID)
		inner join Bill as b
		on b.ID = bf.BillID)
where b.ID = 1