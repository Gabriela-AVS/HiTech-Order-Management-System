-- HiTech Order Management System - database setup
-- Portfolio-safe version: machine-specific SQL Server file paths and credentials removed.

IF DB_ID(N'HiTechDb') IS NULL
BEGIN
    CREATE DATABASE [HiTechDb];
END
GO

USE [HiTechDb];
GO

/****** Object:  Table [dbo].[Authors]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorsBooks]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorsBooks](
	[BookId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
	[YearPublished] [int] NOT NULL,
 CONSTRAINT [PK_AuthorsBooks] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC,
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[Booktitle] [varchar](200) NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
	[YearPublished] [int] NOT NULL,
	[QOH] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[PublisherId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1000,1) NOT NULL,
	[NameOfInstitution] [varchar](60) NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[City] [varchar](40) NOT NULL,
	[PostalCode] [varchar](10) NOT NULL,
	[Telephone] [varchar](20) NOT NULL,
	[Fax] [varchar](20) NOT NULL,
	[CreditLimit] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1111,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobId] [int] NOT NULL,
	[JobTitle] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(100,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[OrderStatus] [varchar](50) NOT NULL,
	[OrderSource] [varchar](20) NULL,
	[PaymentMethod] [varchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentId] [int] IDENTITY(111,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherId] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [varchar](100) NOT NULL,
	[WebAddress] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2025-12-08 11:21:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (1, N'Robert', N'Martin', N'robert.martin@example.com')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (2, N'Andrew', N'Hunt', N'andrew.hunt@example.com')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (3, N'David', N'Thomas', N'david.thomas@example.com')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (4, N'Brian', N'Kernighan', N'brian.kernighan@example.com')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName], [Email]) VALUES (5, N'Jon', N'Skeet', N'jon.skeet@example.com')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (1, 1, 2008)
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (2, 2, 1999)
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (2, 3, 1999)
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (3, 4, 1988)
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (4, 5, 2019)
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (1009, 4, 1988)
INSERT [dbo].[AuthorsBooks] ([BookId], [AuthorId], [YearPublished]) VALUES (1010, 2, 2010)
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (1, N'9781234567890', N'Test LINQ Book', CAST(59.99 AS Decimal(10, 2)), 2024, 4, 1, 1)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (3, N'9780596006372', N'Learning SQL', CAST(44.99 AS Decimal(10, 2)), 2005, 8, 3, 5)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (4, N'9781593271442', N'Hacking: The Art of Exploitation', CAST(100.00 AS Decimal(10, 2)), 2008, 0, 4, 5)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (5, N'9780134668250', N'Computer Networking: A Top-Down Approach', CAST(89.99 AS Decimal(10, 2)), 2017, 7, 2, 4)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (6, N'9780132350884', N'Clean Code', CAST(59.99 AS Decimal(10, 2)), 2008, 9, 1, 2)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (1003, N'9780201616224', N'The Pragmatic Programmer', CAST(100.00 AS Decimal(10, 2)), 1999, 7, 1, 2)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (1004, N'9780134494166', N'Clean Architecture', CAST(59.99 AS Decimal(10, 2)), 2017, 4, 1, 2)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (1009, N'9780131101630', N'The C Programming Language', CAST(69.99 AS Decimal(10, 2)), 1988, 4, 1, 3)
INSERT [dbo].[Books] ([BookId], [ISBN], [Booktitle], [UnitPrice], [YearPublished], [QOH], [CategoryId], [PublisherId]) VALUES (1010, N'9780596809485', N'97 Things Every Programmer Should Know', CAST(54.99 AS Decimal(10, 2)), 2010, 9, 1, 3)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Programming')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Networking')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Database')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Cybersecurity')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Programming')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (6, N'Networking')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (7, N'Database')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (8, N'Cybersecurity')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1000, N'McGill University', N'845 Sherbrooke St W', N'Montreal', N'H3A 0G4', N'514-555-1001', N'514-555-9001', CAST(49855.01 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1001, N'Concordia University', N'1455 De Maisonneuve Blvd W', N'Montreal', N'H3G 1M8', N'514-555-2002', N'514-555-9002', CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1002, N'Université de Montréal', N'2900 Edouard-Montpetit Blvd', N'Montreal', N'H3T 1J4', N'514-555-3003', N'514-555-9003', CAST(59930.01 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1003, N'Université Laval', N'2325 Rue de l Université', N'Quebec City', N'G1V 0A6', N'418-555-4004', N'418-555-9004', CAST(54840.01 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1004, N'UQAM – Université du Québec à Montréal', N'405 Rue Sainte-Catherine E', N'Montreal', N'H2L 2C4', N'514-555-5005', N'514-555-9005', CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1005, N'UQTR – Université du Québec à Trois-Rivières', N'3351 Boulevard des Forges', N'Trois-Rivières', N'G8Z 4M3', N'819-555-6006', N'819-555-9006', CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1006, N'Université de Sherbrooke', N'2500 Boulevard de l Université', N'Sherbrooke', N'J1K 2R1', N'819-555-7007', N'819-555-9007', CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1007, N'Collège LaSalle', N'2000 Saint-Catherine St W', N'Montreal', N'H3H 2T2', N'514-555-8008', N'514-555-9008', CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (1008, N'Dawson College', N'3040 Sherbrooke St W', N'Montreal', N'H3Z 1A4', N'514-555-9009', N'514-555-9019', CAST(12000.00 AS Decimal(10, 2)))
INSERT [dbo].[Customers] ([CustomerId], [NameOfInstitution], [Street], [City], [PostalCode], [Telephone], [Fax], [CreditLimit]) VALUES (2003, N'McGill University', N'122 st Montreal', N'Montreal', N'H3L2H7', N'514-333-5555', N'514-333-4444', CAST(500.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobId]) VALUES (1111, N'Henryss', N'Brown', 1)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobId]) VALUES (1112, N'Thomas', N'Moore', 2)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobId]) VALUES (1113, N'Peter', N'Wang', 3)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobId]) VALUES (1114, N'Mary', N'Brown', 4)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobId]) VALUES (1115, N'Jennifer', N'Green', 4)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobId]) VALUES (1123, N'Danna', N'Scully', 4)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (1, N'MIS Manager')
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (2, N'Sales Manager')
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (3, N'Inventory Controller')
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (4, N'Clerk')
GO
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (107, 1, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (108, 1, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (109, 1, 3, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (109, 3, 1, CAST(44.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (109, 4, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1101, 1, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1102, 1, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1102, 3, 1, CAST(44.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1102, 4, 1, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1103, 1, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1103, 3, 1, CAST(44.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1103, 4, 1, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1104, 1009, 1, CAST(69.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1104, 1010, 1, CAST(54.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1105, 4, 1, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1106, 1003, 1, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1106, 1004, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1107, 1009, 1, CAST(69.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1108, 1009, 1, CAST(69.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1109, 4, 1, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1109, 6, 1, CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1110, 3, 1, CAST(44.99 AS Decimal(10, 2)))
INSERT [dbo].[OrderDetails] ([OrderId], [BookId], [Quantity], [UnitPrice]) VALUES (1110, 4, 1, CAST(100.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (107, CAST(N'2025-11-29' AS Date), 1000, 1111, N'Canceled', N'Phone', N'Direct Withdrawal – RBC')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (108, CAST(N'2025-11-29' AS Date), 1000, 1114, N'New', N'Fax', N'Direct Withdrawal – TD')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (109, CAST(N'2025-11-29' AS Date), 1007, 1114, N'New', N'Email', N'Direct Withdrawal – Scotiabank')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1101, CAST(N'2025-12-03' AS Date), 1000, 1114, N'Canceled', NULL, N'Direct Withdrawal – CIBC')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1102, CAST(N'2025-12-08' AS Date), 1000, 1114, N'New', N'Fax', N'Direct Withdrawal – RBC')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1103, CAST(N'2025-12-08' AS Date), 1002, 1114, N'New', N'Fax', N'Direct Withdrawal – RBC')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1104, CAST(N'2025-12-08' AS Date), 1008, 1114, N'New', N'Fax', N'Direct Withdrawal – CIBC')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1105, CAST(N'2025-12-08' AS Date), 1000, 1114, N'Canceled', N'Phone', N'')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1106, CAST(N'2025-12-08' AS Date), 1008, 1114, N'New', N'Fax', N'Direct Withdrawal – TD')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1107, CAST(N'2025-12-08' AS Date), 1008, 1114, N'New', N'Phone', N'Direct Withdrawal – BMO')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1108, CAST(N'2025-12-08' AS Date), 1002, 1114, N'New', N'Email', N'Direct Withdrawal – Desjardins')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1109, CAST(N'2025-12-08' AS Date), 1003, 1114, N'New', N'Fax', N'Direct Withdrawal – CIBC')
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId], [OrderStatus], [OrderSource], [PaymentMethod]) VALUES (1110, CAST(N'2025-12-08' AS Date), 1000, 1114, N'New', N'Email', N'Direct Withdrawal – RBC')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([PaymentId], [OrderId], [PaymentDate], [Amount]) VALUES (111, 107, CAST(N'2025-11-29' AS Date), CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[Payments] ([PaymentId], [OrderId], [PaymentDate], [Amount]) VALUES (112, 108, CAST(N'2025-11-29' AS Date), CAST(59.99 AS Decimal(10, 2)))
INSERT [dbo].[Payments] ([PaymentId], [OrderId], [PaymentDate], [Amount]) VALUES (113, 109, CAST(N'2025-11-30' AS Date), CAST(284.95 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[Publishers] ON 

INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (1, N'Wrox', N'https://www.wrox.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (2, N'Pearson', N'https://www.pearson.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (3, N'O''Reilly', N'https://www.oreilly.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (4, N'Pearson', N'https://www.pearson.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (5, N'O''Reilly', N'https://www.oreilly.com')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName], [WebAddress]) VALUES (6, N'Wrox', N'https://www.wrox.com')
SET IDENTITY_INSERT [dbo].[Publishers] OFF
GO
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (1, N'Active')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (2, N'Inactive')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (3, N'Suspended')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (4, N'Pending')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (5, N'Locked')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (6, N'Terminated')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (7, N'Retired')
INSERT [dbo].[Status] ([StatusId], [Description]) VALUES (8, N'Vacation')
GO
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeId], [StatusId]) VALUES (N'mis.demo', N'Demo123!', 1111, 1)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeId], [StatusId]) VALUES (N'clerk2.demo', N'Demo123!', 1115, 1)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeId], [StatusId]) VALUES (N'clerk.demo', N'Demo123!', 1114, 1)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeId], [StatusId]) VALUES (N'inventory.demo', N'Demo123!', 1113, 1)
INSERT [dbo].[Users] ([UserName], [Password], [EmployeeId], [StatusId]) VALUES (N'sales.demo', N'Demo123!', 1112, 1)
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Authors]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Job]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Books]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Orders]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Status]
GO
USE [master]
GO
ALTER DATABASE [HiTechDb] SET  READ_WRITE 
GO
