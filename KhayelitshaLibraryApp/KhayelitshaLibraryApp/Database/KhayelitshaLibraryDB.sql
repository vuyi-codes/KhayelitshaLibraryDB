-- Khayelitsha Community Library
-- Database creation script for MDB622 FA2
-- Run this script in SQL Server Management Studio or against LocalDB

IF DB_ID(N'KhayelitshaLibraryDB') IS NOT NULL
BEGIN
    ALTER DATABASE KhayelitshaLibraryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE KhayelitshaLibraryDB;
END
GO

CREATE DATABASE KhayelitshaLibraryDB;
GO

USE KhayelitshaLibraryDB;
GO

-- Member table
CREATE TABLE Member
(
    MemberID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    JoinDate DATE NOT NULL
);
GO

-- Book title table
CREATE TABLE BookTitle
(
    TitleID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Title NVARCHAR(150) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    ISBN NVARCHAR(20) NULL,
    Category NVARCHAR(50) NOT NULL,
    YearPublished INT NOT NULL,
    CONSTRAINT CK_BookTitle_YearPublished CHECK (YearPublished >= 1900 AND YearPublished <= 2100)
);
GO

-- Physical book copy table
CREATE TABLE BookCopy
(
    CopyID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TitleID INT NOT NULL,
    Status NVARCHAR(20) NOT NULL,
    ShelfLocation NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_BookCopy_BookTitle FOREIGN KEY (TitleID) REFERENCES BookTitle(TitleID),
    CONSTRAINT CK_BookCopy_Status CHECK (Status IN (N'Available', N'On Loan', N'Lost', N'Damaged'))
);
GO

-- Staff table
CREATE TABLE Staff
(
    StaffID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20) NOT NULL
);
GO

-- Loan table
CREATE TABLE Loan
(
    LoanID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MemberID INT NOT NULL,
    CopyID INT NOT NULL,
    StaffID INT NOT NULL,
    LoanDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL,
    CONSTRAINT FK_Loan_Member FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    CONSTRAINT FK_Loan_BookCopy FOREIGN KEY (CopyID) REFERENCES BookCopy(CopyID),
    CONSTRAINT FK_Loan_Staff FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
    CONSTRAINT CK_Loan_DueDate CHECK (DueDate >= LoanDate)
);
GO

-- Sample members (5)
INSERT INTO Member (FullName, Address, Phone, JoinDate) VALUES
(N'Nomsa Dlamini', N'12 Spine Road, Khayelitsha', N'0821112233', '2024-01-15'),
(N'Thando Mokoena', N'45 Mandela Park, Khayelitsha', N'0832223344', '2024-02-10'),
(N'Anele Nkosi', N'7 Site B Road, Khayelitsha', N'0843334455', '2024-03-05'),
(N'Sipho Cele', N'22 Harare Street, Khayelitsha', N'0714445566', '2024-04-20'),
(N'Zanele Peyi', N'9 Ilitha Park, Khayelitsha', N'0725556677', '2024-05-12');
GO

-- Sample book titles (5)
INSERT INTO BookTitle (Title, Author, ISBN, Category, YearPublished) VALUES
(N'Long Walk to Freedom', N'Nelson Mandela', N'9780316548182', N'Biography', 1994),
(N'Cry, the Beloved Country', N'Alan Paton', N'9780743262170', N'Fiction', 1948),
(N'Born a Crime', N'Trevor Noah', N'9780399588174', N'Biography', 2016),
(N'Things Fall Apart', N'Chinua Achebe', N'9780385474542', N'Fiction', 1958),
(N'Introduction to Databases', N'Thomas Connolly', N'9780321601100', N'Education', 2014);
GO

-- Sample book copies (8)
INSERT INTO BookCopy (TitleID, Status, ShelfLocation) VALUES
(1, N'On Loan', N'A1'),
(1, N'Available', N'A1'),
(2, N'On Loan', N'B2'),
(2, N'Available', N'B2'),
(3, N'On Loan', N'C3'),
(3, N'Available', N'C3'),
(4, N'Damaged', N'D4'),
(5, N'Available', N'E5');
GO

-- Sample staff (3)
INSERT INTO Staff (FullName, Role, Phone) VALUES
(N'Lindiwe Jacobs', N'Librarian', N'0215551001'),
(N'Johan Botha', N'Assistant', N'0215551002'),
(N'Fatima Adams', N'Librarian', N'0215551003');
GO

-- Sample loans (5)
-- Three active loans and two returned loans
INSERT INTO Loan (MemberID, CopyID, StaffID, LoanDate, DueDate, ReturnDate) VALUES
(1, 1, 1, '2026-07-01', '2026-07-15', NULL),
(2, 3, 2, '2026-07-05', '2026-07-19', NULL),
(3, 5, 1, '2026-06-20', '2026-07-04', NULL),
(4, 2, 3, '2026-05-10', '2026-05-24', '2026-05-22'),
(5, 4, 2, '2026-06-01', '2026-06-15', '2026-06-14');
GO
