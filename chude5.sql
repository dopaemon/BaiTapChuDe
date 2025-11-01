create database ChuDe5
GO

use ChuDe5
GO

create table Category
(ID int primary key not null identity(1,1),
[Name]nvarchar(100) not null)
GO

insert into Category values(N'Khai vi')
insert into Category values(N'Hải sản')
insert into Category values(N'Gà')
insert into Category values(N'Cơm')
insert into Category values(N'Thịt')
insert into Category values(N'Rau')
insert into Category values(N'Canh')
insert into Category values(N'Lẩu')
insert into Category values(N'Bia')
insert into Category values(N'Nước ngọt')
insert into Category values(N'Cà phê')
insert into Category values(N'Trà đá')
insert into Category values(N'Nướng')
GO

CREATE TABLE Food (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Unit NVARCHAR(20),
    FoodCategoryID INT,
    Price INT,
    Notes NVARCHAR(200),
    FOREIGN KEY (FoodCategoryID) REFERENCES Category(ID)
)
GO

INSERT INTO Food (Name, Unit, FoodCategoryID, Price, Notes)
VALUES
(N'Ếch thui rơm', N'Đĩa', 3, 70000, N''),
(N'Sò lông nướng mỡ hành', N'Đĩa', 3, 80000, N''),
(N'Càng cua hấp', N'Đĩa', 3, 100000, N''),
(N'Cơm chiên Dương Châu', N'Đĩa', 1, 35000, N''),
(N'Coca-Cola', N'Chai', 2, 15000, N''),
(N'Ba chỉ nướng mật ong', N'Đĩa', 4, 90000, N'');
GO

CREATE TABLE BillDetails (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    BillID INT,
    FoodID INT,
    Quantity INT,
    FOREIGN KEY (FoodID) REFERENCES Food(ID)
)
GO

INSERT INTO Food (Name, Unit, FoodCategoryID, Price)
VALUES 
(N'Cơm chiên', N'đĩa', 1, 45000),
(N'Phở bò', N'tô', 1, 40000),
(N'Cà phê sữa', N'ly', 2, 25000),
(N'Nước cam', N'ly', 2, 30000);
GO

INSERT INTO BillDetails (BillID, FoodID, Quantity)
VALUES 
(1, 7, 5),  
(2, 7, 3),  
(3, 8, 2);  
GO

CREATE PROCEDURE [InsertFood]
    @ID int OUTPUT,
    @Name nvarchar(1000),
    @Unit nvarchar(100),
    @FoodCategoryID int,
    @Price int,
    @Notes nvarchar(3000)
AS
BEGIN
    INSERT INTO [Food] ([Name], [Unit], [FoodCategoryID], [Price], [Notes])
    VALUES (@Name, @Unit, @FoodCategoryID, @Price, @Notes);

    SELECT @ID = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE [UpdateFood]
    @ID int,
    @Name nvarchar(1000),
    @Unit nvarchar(100),
    @FoodCategoryID int,
    @Price int,
    @Notes nvarchar(3000)
AS
BEGIN
    UPDATE [Food]
    SET [Name] = @Name,
        [Unit] = @Unit,
        [FoodCategoryID] = @FoodCategoryID,
        [Price] = @Price,
        [Notes] = @Notes
    WHERE ID = @ID;

    IF @@ERROR <> 0
        RETURN 0;
    ELSE
        RETURN 1;
END
GO

CREATE TABLE Bill
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    DateCreated DATETIME,
    Discount FLOAT
)
GO

CREATE TABLE BillDetails
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    BillID INT,
    FoodID INT,
    Quantity INT,
    FOREIGN KEY (FoodID) REFERENCES Food(ID),
    FOREIGN KEY (BillID) REFERENCES Bill(ID)
)
GO


CREATE TABLE Role (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Account (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    DisplayName NVARCHAR(100),
    PasswordHash NVARCHAR(200) NOT NULL,
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Role(ID)
);
GO

CREATE TABLE AccountActivity (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT,
    BillID INT,
    DateCreated DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (AccountID) REFERENCES Account(ID),
    FOREIGN KEY (BillID) REFERENCES Bill(ID)
);
GO

-- Tạo hash SHA256 và chuyển sang chuỗi HEX
DECLARE @pass NVARCHAR(100) = '123456';
DECLARE @hash VARBINARY(32) = HASHBYTES('SHA2_256', @pass);

-- Chèn vào cột NVARCHAR dưới dạng HEX
UPDATE Account
SET PasswordHash = CONVERT(NVARCHAR(64), @hash, 2)
WHERE Username = 'admin';
GO

-- Giả lập AccountActivity
INSERT INTO AccountActivity (AccountID, BillID, DateCreated) VALUES
(2, 1, '2025-10-01'),
(2, 2, '2025-10-02'),
(3, 3, '2025-10-03'),
(5, 4, '2025-10-04'),
(4, 5, '2025-10-05');
GO

INSERT INTO Role (RoleName) VALUES
(N'Admin'),
(N'Cashier'),
(N'Staff'),
(N'Chef'),
(N'Waiter');
GO

-- Lưu ý: PasswordHash = HASHBYTES('SHA2_256','123456')
INSERT INTO Account (Username, DisplayName, PasswordHash, RoleID) VALUES
(N'admin', N'Administrator', HASHBYTES('SHA2_256','123456'), 1),
(N'cashier01', N'Nguyen Van A', HASHBYTES('SHA2_256','123456'), 2),
(N'chef01', N'Tran Thi B', HASHBYTES('SHA2_256','123456'), 4),
(N'waiter01', N'Le Van C', HASHBYTES('SHA2_256','123456'), 5),
(N'staff01', N'Pham Thi D', HASHBYTES('SHA2_256','123456'), 3);
GO
