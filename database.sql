CREATE DATABASE MedicineStore;
GO
USE MedicineStore;
GO

--Mã Nhân Viên --
CREATE FUNCTION [dbo].[Auto_IDEmp]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(E_ID) FROM Employee
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(E_ID, 8))
        FROM Employee;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'NV00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'NV0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;
GO
--Table Nhân viên--
CREATE TABLE Employee
(
    E_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_Employee
            DEFAULT dbo.Auto_IDEmp(),
    Fullname NVARCHAR(100) NOT NULL,
    Birthday DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    Addres NVARCHAR(500) NOT NULL,
);
GO
--Table tài khoản--
CREATE TABLE Account
(
    Username NVARCHAR(50) NOT NULL,
    Pass NVARCHAR(50) NOT NULL,
    E_ID NVARCHAR(10) NOT NULL,
    Permission INT NOT NULL,
    Suppended BIT NOT NULL,
    CONSTRAINT PK_Accout
        PRIMARY KEY CLUSTERED (
                                  Username,
                                  E_ID
                              ),
    CONSTRAINT FK_Emp_Account
        FOREIGN KEY (E_ID)
        REFERENCES dbo.Employee (E_ID)
);
GO
--Mã khách hàng--
CREATE FUNCTION [dbo].[Auto_IDCust]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(C_ID) FROM dbo.Customer
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(C_ID, 8))
        FROM dbo.Customer;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'KH000000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'KH00000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99 THEN
                         'KH0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999 THEN
                         'KH000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9999 THEN
                         'KH00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99999 THEN
                         'KH0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999999 THEN
                         'KH' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;
GO
--Table Khách hàng--
CREATE TABLE Customer
(
    C_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_Customer
            DEFAULT dbo.Auto_IDCust(),
    C_Fullname NVARCHAR(100) NOT NULL,
    C_Age INT NOT NULL,
    C_Gender NVARCHAR(10) NOT NULL,
    C_Phonenumber VARCHAR(15) NOT NULL,
    C_Address NVARCHAR(500) NOT NULL
);
GO
--Mã Nhà cung cấp--
CREATE FUNCTION [dbo].[Auto_Supplier]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(S_ID) FROM dbo.Supplier
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(S_ID, 7))
        FROM dbo.Supplier;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'NCC00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'NCC0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;
GO
--Table Nhà cung cấp--
CREATE TABLE Supplier
(
    S_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_Supplier
            DEFAULT dbo.Auto_Supplier(),
    S_Name NVARCHAR(500) NOT NULL,
    S_Phonenumber VARCHAR(15) NOT NULL,
    S_Address NVARCHAR(500) NOT NULL
);
GO
--Table đơn vị tính--
CREATE TABLE Donvitinh
(
    U_ID INT NOT NULL IDENTITY(1, 1)
        CONSTRAINT PK_Donvitinh PRIMARY KEY,
    U_Name NVARCHAR(20) NOT NULL
);
GO
--Table nhóm thuốc--
CREATE TABLE MedicineGroup
(
    MG_ID INT NOT NULL IDENTITY(1, 1)
        CONSTRAINT PK_MedicineGroup PRIMARY KEY,
    MG_Name NVARCHAR(500) NOT NULL,
);
GO
--Mã Thuốc--
CREATE FUNCTION [dbo].[Auto_IDMedicine]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(M_ID) FROM dbo.Medicine
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(M_ID, 7))
        FROM dbo.Medicine;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'MED00000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'MED0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99 THEN
                         'MED000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999 THEN
                         'MED00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9999 THEN
                         'MED0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99999 THEN
                         'MED' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;

GO
--Table Thuốc--
CREATE TABLE Medicine
(
    M_IDG INT NOT NULL
        CONSTRAINT FK_MG_Medicine
        FOREIGN KEY REFERENCES dbo.MedicineGroup (MG_ID),
    M_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_Medicine
            DEFAULT dbo.Auto_IDMedicine(),
    M_Name NVARCHAR(100) NOT NULL,
    M_SDK VARCHAR(20) NOT NULL,
    M_TPC NVARCHAR(100) NOT NULL,
    M_HL VARCHAR(20) NOT NULL,
    M_Package NVARCHAR(100) NOT NULL,
    M_NuocSX NVARCHAR(100) NOT NULL,
    M_BasicUnit NVARCHAR(20) NOT NULL,
    M_Batch NVARCHAR(20) NOT NULL,
    M_Dat DATE NOT NULL,
    M_Quantity INT NOT NULL,
    M_ImUnit NVARCHAR(20) NOT NULL,
    M_GTQD INT NOT NULL,
    M_Price FLOAT NOT NULL,
    M_ImPrice FLOAT NOT NULL,
    M_DMT INT NOT NULL
);
GO
--Mã Phiếu nhập từ nhà ung cấp--
CREATE FUNCTION [dbo].[Auto_IDImpFromSupp]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(IFS_ID) FROM dbo.ImpFromSupp
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(IFS_ID, 8))
        FROM dbo.ImpFromSupp;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'PN00000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'PN0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99 THEN
                         'PN000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999 THEN
                         'PN00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9999 THEN
                         'PN0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99999 THEN
                         'PN' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;
GO
--Table Nhập từ NCC--
CREATE TABLE ImpFromSupp
(
    IFS_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_ImpFromSupp
            DEFAULT dbo.Auto_IDImpFromSupp(),
    IFS_Time DATETIME NOT NULL,
    E_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Emp_ImpFromSupp
        FOREIGN KEY REFERENCES dbo.Employee (E_ID),
    S_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Cust_ImpFromSupp
        FOREIGN KEY REFERENCES dbo.Supplier (S_ID),
    IFS_Note NVARCHAR(500) NULL,
    IFS_Total FLOAT NOT NULL
);
GO
--Table CT nhập từ NCC--
CREATE TABLE DetailImpFromSupp
(
    IFS_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_ImpFromSupp_DIFS
        FOREIGN KEY REFERENCES dbo.ImpFromSupp (IFS_ID),
    M_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Medicine_DIFS
        FOREIGN KEY REFERENCES dbo.Medicine (M_ID),
    M_Name NVARCHAR(100) NOT NULL,
    M_Batch NVARCHAR(20) NOT NULL,
    M_Dat DATE NOT NULL,
    M_Quantity INT NOT NULL,
    M_ImUnit NVARCHAR(20) NOT NULL,
    M_GTQD INT NOT NULL,
    M_Price FLOAT NOT NULL,
    M_ImPrice FLOAT NOT NULL,
    DIFS_Total FLOAT NOT NULL
        CONSTRAINT PK_DIFS
        PRIMARY KEY CLUSTERED (
                                  IFS_ID,
                                  M_ID
                              )
);
GO
--Mã Phiếu trả nhà Cung cấp--
CREATE FUNCTION [dbo].[Auto_IDReturnSupp]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(RS_ID) FROM dbo.ReturnSupplier
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(RS_ID, 5))
        FROM dbo.ReturnSupplier;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'PTNCC000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'PTNCC00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99 THEN
                         'PTNCC0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999 THEN
                         'PTNCC' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;
GO
--Table Trả NCC--
CREATE TABLE ReturnSupplier
(
    RS_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_ReturnSupplier
            DEFAULT dbo.Auto_IDReturnSupp(),
    S_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_S_RS
        FOREIGN KEY REFERENCES dbo.Supplier (S_ID),
	RS_Time DATETIME NOT NULL,
    E_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Emp_RS
        FOREIGN KEY REFERENCES dbo.Employee (E_ID),
    RS_Total FLOAT NOT NULL
);
GO
--Table CT trả NCC--
CREATE TABLE DetailReturnSupplier
(
    RS_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_RS_DRS
        FOREIGN KEY REFERENCES dbo.ReturnSupplier (RS_ID),
    M_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Medicine_DRS
        FOREIGN KEY REFERENCES dbo.Medicine (M_ID),
    M_Name NVARCHAR(100) NOT NULL,
    M_Unit NVARCHAR(20) NOT NULL,
    M_QuantityReturn INT NOT NULL,
    M_ImPrice FLOAT NOT NULL,
    DRS_Total FLOAT NOT NULL,
    CONSTRAINT PK_DRS
        PRIMARY KEY CLUSTERED (
                                  RS_ID,
                                  M_ID
                              )
);
GO
--Mã Hoá đơn bán--
CREATE FUNCTION [dbo].[Auto_IDSale]
()
RETURNS NVARCHAR(10)
AS
BEGIN
    DECLARE @id NVARCHAR(10);
    IF
    (
        SELECT COUNT(SAL_ID) FROM dbo.Sale
    ) = 0
        SET @id = N'0';
    ELSE
        SELECT @id = MAX(RIGHT(SAL_ID, 7))
        FROM dbo.Sale;
    SELECT @id = CASE
                     WHEN @id >= 0
                          AND @id < 9 THEN
                         'HDB000000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9 THEN
                         'HDB00000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99 THEN
                         'HDB0000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999 THEN
                         'HDB000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 9999 THEN
                         'HDB00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 99999 THEN
                         'HDB0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                     WHEN @id >= 999999 THEN
                         'HDB' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
                 END;
    RETURN @id;
END;

GO
--Table Bán--
CREATE TABLE Sale
(
    SAL_ID NVARCHAR(10) NOT NULL PRIMARY KEY
        CONSTRAINT PK_Sale
            DEFAULT dbo.Auto_IDSale(),
	SAL_Time DATETIME NOT NULL,
    E_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Emp_Sale
        FOREIGN KEY REFERENCES dbo.Employee (E_ID),
    C_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Cust_Sale
        FOREIGN KEY REFERENCES dbo.Customer (C_ID),
    SAL_Total FLOAT NOT NULL
);
GO
--Table CT bán--
CREATE TABLE DetailSale
(
    SAL_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Sale_DS
        FOREIGN KEY REFERENCES dbo.Sale (SAL_ID),
    M_ID NVARCHAR(10) NOT NULL
        CONSTRAINT FK_Medicine_DS
        FOREIGN KEY REFERENCES dbo.Medicine (M_ID),
    M_Name NVARCHAR(100) NOT NULL,
    M_Unit NVARCHAR(20) NOT NULL,
    M_QuantitySale INT NOT NULL,
    M_Price FLOAT NOT NULL,
    DS_Total FLOAT NOT NULL,
    CONSTRAINT PK_DetailSale
        PRIMARY KEY CLUSTERED (
                                  SAL_ID,
                                  M_ID
                              )
);
GO

-- tao DB ban dau--
INSERT INTO dbo.Employee
(
    E_ID,
    Fullname,
    Birthday,
    Gender,
    PhoneNumber,
    Addres
)
VALUES
(   DEFAULT,                           -- E_ID - nvarchar(10)
    N'Trần Văn Toàn',                  -- Fullname - nvarchar(100)
    '1992-09-15',                      -- Birthday - date
    N'Nam',                            -- Gender - nvarchar(10)
    '0344191220',                      -- PhoneNumber - varchar(15)
    N'Minh Hoà - Kinh Môn - Hải Dương' -- Addres - nvarchar(500)
    );
GO
INSERT INTO dbo.Employee
(
    E_ID,
    Fullname,
    Birthday,
    Gender,
    PhoneNumber,
    Addres
)
VALUES
(   DEFAULT,                           -- E_ID - nvarchar(10)
    N'Trần Thị Oanh',                  -- Fullname - nvarchar(100)
    '1994-06-12',                      -- Birthday - date
    N'Nam',                            -- Gender - nvarchar(10)
    '0789239372',                      -- PhoneNumber - varchar(15)
    N'Minh Hoà - Kinh Môn - Hải Dương' -- Addres - nvarchar(500)
    );
GO
INSERT INTO dbo.Account
(
    Username,
    Pass,
    E_ID,
    Permission,
    Suppended
)
VALUES
(   N'admin', -- Username - nvarchar(50)
    N'admin', -- Pass - nvarchar(50)
    N'NV001', -- E_ID - nvarchar(10)
    1,        -- Permission - int
    'FALSE'   -- Suppended - bit
    );
GO
INSERT INTO dbo.Account
(
    Username,
    Pass,
    E_ID,
    Permission,
    Suppended
)
VALUES
(   N'oanhtran',   -- Username - nvarchar(50)
    N'tranoanh94', -- Pass - nvarchar(50)
    N'NV002',      -- E_ID - nvarchar(10)
    2,             -- Permission - int
    'FALSE'        -- Suppended - bit
    );
SELECT a.E_ID,
       a.Fullname
FROM Employee a;
SELECT E_ID,
       Fullname
FROM Employee
WHERE NOT EXISTS
(
    SELECT E_ID FROM Account WHERE Employee.E_ID = Account.E_ID
);