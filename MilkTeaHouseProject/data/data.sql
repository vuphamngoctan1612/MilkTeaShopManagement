USE [master]
GO
/****** Object:  Database [data]    Script Date: 12/25/2020 9:03:59 AM ******/
CREATE DATABASE [MILKTEA]

ALTER DATABASE [MILKTEA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MILKTEA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MILKTEA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MILKTEA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MILKTEA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MILKTEA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MILKTEA] SET ARITHABORT OFF 
GO
ALTER DATABASE [MILKTEA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MILKTEA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MILKTEA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MILKTEA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MILKTEA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MILKTEA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MILKTEA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MILKTEA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MILKTEA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MILKTEA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MILKTEA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MILKTEA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MILKTEA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MILKTEA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MILKTEA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MILKTEA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MILKTEA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MILKTEA] SET RECOVERY FULL 
GO
ALTER DATABASE [MILKTEA] SET  MULTI_USER 
GO
ALTER DATABASE [MILKTEA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MILKTEA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MILKTEA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MILKTEA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MILKTEA] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MILKTEA', N'ON'
GO
ALTER DATABASE [MILKTEA] SET QUERY_STORE = OFF
GO
USE [MILKTEA]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[USERNAME] [varchar](100) NOT NULL,
	[PASSWORD] [varchar](1000) NOT NULL,
	[TYPE] [bit] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] NOT NULL,
	[STAFFID] [int] NULL,
	[CHECKOUT] [date] NULL,
	[STATUS] [bit] NULL,
	[NOTE] [nvarchar](1000) NULL,
	[TABLEID] [int] NULL,
	[CHECKIN] [date] NULL,
	[TOTAL] [bigint] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[BILLID] [int] NOT NULL,
	[DRINKID] [int] NOT NULL,
	[COUNT] [int] NULL,
 CONSTRAINT [PK_BillInfo] PRIMARY KEY CLUSTERED 
(
	[BILLID] ASC,
	[DRINKID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[NAME] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[ID] [int] NOT NULL,
	[NAME] [nvarchar](100) NOT NULL,
	[CATEGORY] [nvarchar](100) NULL,
	[IMAGE] [image] NULL,
	[STATUS] [bit] NULL,
	[COUNT] [int] NULL,
	[price] [bigint] NULL,
	[originprice] [bigint] NULL,
 CONSTRAINT [PK_Drink] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupTable]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupTable](
	[NAME] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_GroupTable] PRIMARY KEY CLUSTERED 
(
	[NAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[Name] [nvarchar](100) NOT NULL,
	[Salary] [bigint] NULL,
	[OverTimeSalary] [bigint] NULL,
	[MinusSalary] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] NOT NULL,
	[NAME] [nvarchar](100) NOT NULL,
	[IMAGE] [image] NULL,
	[BIRTHDATE] [date] NULL,
	[POSITION] [nvarchar](100) NULL,
	[USERNAME] [varchar](100) NULL,
	[OVERTIME] [int] NULL,
	[Fault] [int] NULL,
	[PhoneNumber] [varchar](10) NULL,
	[CMND] [varchar](9) NULL,
	[Address] [nvarchar](1000) NULL,
	[Sex] [bit] NULL,
	[SalaryReceived] [bigint] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[status] [bit] NULL,
	[NameGroup] [nvarchar](100) NULL,
 CONSTRAINT [PK_Table_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [STATUS]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [TOTAL]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT ('') FOR [NAME]
GO
ALTER TABLE [dbo].[Drink] ADD  DEFAULT ('') FOR [CATEGORY]
GO
ALTER TABLE [dbo].[Drink] ADD  DEFAULT ((1)) FOR [STATUS]
GO
ALTER TABLE [dbo].[Drink] ADD  DEFAULT ((0)) FOR [COUNT]
GO
ALTER TABLE [dbo].[Drink] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[Drink] ADD  DEFAULT ((0)) FOR [originprice]
GO
ALTER TABLE [dbo].[GroupTable] ADD  DEFAULT ('') FOR [NAME]
GO
ALTER TABLE [dbo].[Position] ADD  DEFAULT ((0)) FOR [Salary]
GO
ALTER TABLE [dbo].[Position] ADD  DEFAULT ((0)) FOR [OverTimeSalary]
GO
ALTER TABLE [dbo].[Position] ADD  DEFAULT ((0)) FOR [MinusSalary]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT ((0)) FOR [OVERTIME]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT ((0)) FOR [Fault]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT (('')) FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT (('')) FOR [CMND]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT (('')) FOR [Address]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT ((0)) FOR [SalaryReceived]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT ('') FOR [NameGroup]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_StaffID] FOREIGN KEY([STAFFID])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_StaffID]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_TableID] FOREIGN KEY([TABLEID])
REFERENCES [dbo].[TableFood] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_TableID]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_BillID] FOREIGN KEY([BILLID])
REFERENCES [dbo].[Bill] ([ID])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_BillID]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_DrinkID] FOREIGN KEY([DRINKID])
REFERENCES [dbo].[Drink] ([ID])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_DrinkID]
GO
ALTER TABLE [dbo].[Drink]  WITH CHECK ADD  CONSTRAINT [FK_Drink_Category] FOREIGN KEY([CATEGORY])
REFERENCES [dbo].[Category] ([NAME])
GO
ALTER TABLE [dbo].[Drink] CHECK CONSTRAINT [FK_Drink_Category]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Position] FOREIGN KEY([POSITION])
REFERENCES [dbo].[Position] ([Name])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Position]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_UserName] FOREIGN KEY([USERNAME])
REFERENCES [dbo].[Account] ([USERNAME])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_UserName]
GO
ALTER TABLE [dbo].[TableFood]  WITH CHECK ADD  CONSTRAINT [FK_TableFood_GroupTable] FOREIGN KEY([NameGroup])
REFERENCES [dbo].[GroupTable] ([NAME])
GO
ALTER TABLE [dbo].[TableFood] CHECK CONSTRAINT [FK_TableFood_GroupTable]
GO
/****** Object:  StoredProcedure [dbo].[USP_AddDrink]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_AddDrink]
@ID int, @Name nvarchar(100), @Price bigint, @Category nvarchar(100), @Image image, @Origin bigint
as
begin
	insert into Drink (ID, NAME, CATEGORY, PRICE, IMAGE, originprice) values (@ID, @Name, @Category, @Price, @Image, @Origin)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_AddStaff]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_AddStaff]
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @username varchar(100), @salaryreceived bigint , @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	insert into Staff  (ID, NAME, IMAGE,BIRTHDATE, POSITION, USERNAME, OVERTIME, SalaryReceived, Fault, PhoneNumber, CMND, Sex, Address)
	values(@ID, @Name, @image, @birthday, @pos, @username,0,@salaryreceived,0, @phonenumber, @cmnd, @sex, @address)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_AddStaffnoUsername]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_AddStaffnoUsername]
@ID int, @Name nvarchar(100), @image image, @birthday date, @pos nvarchar(100), @salaryreceived bigint , @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	insert into Staff (ID, NAME, IMAGE, BIRTHDATE, POSITION, SalaryReceived,PhoneNumber, CMND, Sex, Address) values(@ID, @Name, @image, @birthday, @pos, @salaryreceived,@phonenumber, @cmnd, @sex, @address)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DelAccount]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DelAccount]
@user varchar(100)
as
begin
	delete from Account where UserName = @user
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteBill]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_DeleteBill]
@ID int
as
begin
	delete from Bill
	where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteBillInfo]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_DeleteBillInfo]
@BillID int
as
begin
	delete from BillInfo
	where BillID = @BillID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteCategory]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DeleteCategory]
@Category nvarchar(100)
as 
begin
	delete from Drink
	where Category=@Category

	delete from Category
	where NAME=@Category
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DelStaff]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DelStaff]
@ID int
as
begin
	delete from Staff where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_EditDrink]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_EditDrink]
@ID int, @Name nvarchar(100), @Price bigint, @Category nvarchar(100), @Image image, @Origin bigint
as 
begin
	update Drink
	set Name=@Name, Price=@Price, category=@Category, Image=@Image, OriginPrice = @Origin
	where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_EditStaff]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_EditStaff]
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @username varchar(100),@salaryreceived bigint, @phonenumber varchar(10), @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, USERNAME = @username, SalaryReceived = @salaryreceived,PhoneNumber = @phonenumber, CMND = @cmnd, Sex = @sex, Address = @address
	where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_EditStaffnoUsername]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_EditStaffnoUsername]
@ID int, @Name nvarchar(100), @Image image,@birthday date, @pos nvarchar(100), @salaryreceived bigint, @phonenumber varchar(10),  @cmnd varchar(9), @sex bit, @address nvarchar(1000)
as
begin
	update Staff 
	set Name = @Name, IMAGE = @Image ,BirthDate = @birthday, Position = @pos, SalaryReceived = @salaryreceived, PhoneNumber = @phonenumber, CMND = @cmnd, Sex = @sex, Address = @address
	where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListInvoice]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListInvoice]
as
begin
	select d.Name as N'Tên món', d.Price as N'Đơn giá', bd.Count as N'Số lượng', d.PRICE * bd.COUNT as N'Thành tiền' from BillInfo as bd 
	inner join Drink as d
	on bd.DrinkID = d.ID 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListInvoicebyBillID]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListInvoicebyBillID]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListMenuByBillID]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListMenuByBillID]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBill]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBillInfo]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_SetnullDrinkIDinBillInfo]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_SetnullDrinkIDinBillInfo]
@drinkID int
as
begin
	update BillInfo
	set DrinkID=null
	where DrinkID=@drinkID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateBill]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_UpdateBill]
@ID int, @StaffID int, @CheckOut date, @Status bit, @Total bigint
as
begin
	update Bill
	set StaffID = @StaffID, CheckOut = @CheckOut, Status = @Status, Total = @Total 
	where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateFault]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_UpdateFault]
@ID int, @fault int
as
begin
	update Staff
	set Fault = @fault
	where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateOverTime]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create proc [dbo].[USP_UpdateOverTime]
	@ID int, @OverTime int
	as
	begin
		update Staff
		set OverTime = @OverTime
		where ID = @ID
	end
	GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateSalary]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_UpdateSalary]
@position nvarchar(100), @salary bigint,@overtimesalary bigint, @minussalary bigint
as
begin
	update Position
	set SALARY = @salary, OverTimeSalary = @overtimesalary, MinusSalary = @minussalary
	where Name = @position
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateSalaryReceived]    Script Date: 12/25/2020 9:04:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_UpdateSalaryReceived]
@id int, @salaryreceived bigint
as
begin
	update Staff
	set SalaryReceived = @salaryreceived
	where ID = @id
end
GO
USE [master]
GO
ALTER DATABASE [MILKTEA] SET  READ_WRITE 
GO
USE [MILKTEA]
GO
INSERT INTO ACCOUNT VALUES ('admin', '6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 0)
go
INSERT INTO POSITION ([NAME]) VALUES (N'Quản lý')
go
INSERT INTO POSITION ([NAME]) VALUES (N'Thu ngân')
go
INSERT INTO STAFF ([ID], [BIRTHDATE], [NAME], [POSITION], [USERNAME], [SEX]) VALUES (1, '2001-11-2', 'ADMIN', N'Quản lý', 'admin', 1)
go
