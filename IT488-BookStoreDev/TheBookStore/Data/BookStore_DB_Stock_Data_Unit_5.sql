USE [master]
GO
/** Object:  Database [Bookstoredb]    Script Date: 11/30/2023 10:22:57 PM **/
CREATE DATABASE [Bookstoredb]

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bookstoredb].[dbo].[sp_fulltext_database] @action = 'enable'
end


USE [Bookstoredb]
GO
/** Object:  Table [dbo].[Book Information]    Script Date: 11/30/2023 10:22:59 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book Information](
	[Book ID] [nvarchar](50) NOT NULL,
	[Book Title] [nvarchar](max) NULL,
	[Book Author] [nvarchar](max) NULL,
	[ISBN] [nchar](10) NULL,
	[Publisher] [nvarchar](50) NULL,
	[Genre] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Publication Date] [datetime] NULL,
	[Number of Pages] [int] NULL,
	[Language] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/** Object:  Table [dbo].[Book Location]    Script Date: 11/30/2023 10:23:00 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book Location](
	[Shelf Number] [varchar](50) NULL,
	[Section] [varchar](50) NULL
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Book Pricing]    Script Date: 11/30/2023 10:23:00 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book Pricing](
	[Retail Price] [decimal](18, 2) NULL,
	[Discount Percentage] [decimal](18, 2) NULL,
	[Promotional Price] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Stock Available]    Script Date: 11/30/2023 10:23:00 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock Available](
	[Stock Quantity] [int] NOT NULL,
	[Stock Status] [nvarchar](50) NULL,
	[Reorder Threshold] [int] NULL
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Supplier]    Script Date: 11/30/2023 10:23:00 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Supplier ID] [varchar](50) NOT NULL,
	[Supplier Name] [char](100) NULL,
	[Contact Information] [varchar](50) NULL,
	[Lead Time] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Bookstoredb] SET  READ_WRITE 
GO


USE master;
GO
CREATE LOGIN Chenna WITH PASSWORD = 'Admin';
GO
CREATE LOGIN Alex WITH PASSWORD = 'Developer';
GO
CREATE LOGIN Jason  WITH PASSWORD = 'DevAdmin';
GO
CREATE LOGIN Christopher WITH PASSWORD = 'Pmanager';
GO


USE Bookstoredb;
GO

CREATE USER Chenna FOR LOGIN Chenna;
GO

CREATE USER Alex FOR LOGIN Alex;
GO

CREATE USER Jason FOR LOGIN Jason;
GO

CREATE USER Christopher FOR LOGIN Christopher;
GO


USE Bookstoredb;
GO

ALTER ROLE db_owner ADD MEMBER Chenna;
GO

ALTER ROLE db_owner ADD MEMBER Alex;
GO

ALTER ROLE db_owner ADD MEMBER Jason;
GO

ALTER ROLE db_owner ADD MEMBER Christopher;
GO


Use Bookstoredb;
GO

ALTER TABLE [dbo].[Book Information]
ALTER [ISBN] nvarchar(20);
GO


ALTER TABLE [dbo].[Book Information]
DROP COLUMN [ISBN];
GO

ALTER TABLE [dbo].[Book Information]
ADD [ISBN] nvarchar(20);
GO

INSERT INTO [dbo].[Book Information] ([Book ID], [Book Title], [Book Author], [ISBN], [Publisher], [Genre], [Description], [Publication Date], [Number of Pages], [Language])
VALUES
	('BK-12345678', 'The Lord of the Rings: The Fellowship of the Ring', 'J. R. R. Tolkien', '978-0-00-757453-2', 'HarperCollins', 'Fantasy', 'An epic fantasy trilogy set in Middle-earth', '1954-07-29', 472, 'English'),
	('BK-98765432', 'The Hitchhikers Guide to the Galaxy', 'Douglas Adams', '978-0-330-25854-2', 'Pan Books', 'Science Fiction', 'A comedic sci-fi adventure across the galaxy', '1979-10-12', 224, 'English'),
	('BK-24681357', 'To Kill a Mockingbird', 'Harper Lee', '978-0-446-31079-6', 'HarperCollins', 'Historical Fiction', 'A Pulitzer Prize-winning coming-of-age story', '1960-07-11', 328, 'English'),
	('BK-57392810', 'The Catcher in the Rye', 'J. D. Salinger', '978-0-312-57017-4', 'Little, Brown and Company', 'Bildungsroman', 'A coming-of-age story about a teenagers rebellion', '1951-07-16', 224, 'English'),
	('BK-89012345', '1984', 'George Orwell', '978-0-14-008233-6', 'Penguin Classics', 'Dystopian Fiction', 'A chilling portrayal of a totalitarian future', '1949-06-08', 272, 'English'),
	('BK-35791246', 'Animal Farm', 'George Orwell', '978-0-451-52634-3', 'Penguin Classics', 'Political Satire', 'A fable criticizing totalitarianism', '1945-08-17', 112, 'English'),
	('BK-78945612', 'The Great Gatsby', 'F. Scott Fitzgerald', '978-0-7432-7356-5', 'Charles Scribners Sons', 'American Literature', 'A classic tale of love, loss, and the American Dream', '1925-04-10', 189, 'English'),
	('BK-01234567', 'The Adventures of Huckleberry Finn', 'Mark Twain', '978-0-14-039173-0', 'Penguin Classics', 'Satire, Adventure', 'A satirical tale of a boys journey down the Mississippi River', '1885-02-18', 368, 'English');
GO

INSERT INTO [dbo].[Book Location] ([Shelf Number], [Section])
VALUES
	('A-123', 'Fiction'),
	('B-456', 'Science Fiction'),
	('C-789', 'Non-Fiction'),
	('D-012', 'Biography'),
	('E-345', 'History'),
	('F-678', 'Art & Photography'),
	('G-901', 'Children Books'),
	('H-234', 'Young Adult Fiction');
GO

INSERT INTO [dbo].[Book Pricing] ([Retail Price], [Discount Percentage], [Promotional Price])
VALUES
	(14.99, 10.00, 13.49),
	(22.50, 15.00, 19.13),
	(35.99, 5.00, 34.19),
	(18.75, 20.00, 15.00),
	(29.99, 7.50, 27.74),
	(44.50, 25.00, 33.38),
	(12.99, 30.00, 9.09),
	(39.95, 12.00, 35.16);
GO

INSERT INTO [dbo].[Stock Available] ([Stock Quantity], [Stock Status], [Reorder Threshold])
VALUES
	(100, 'In Stock', 50),
	(50, 'Low Stock', 20),
	(25, 'Out of Stock', 0),
	(75, 'In Stock', 30),
	(150, 'High Stock', 100),
	(60, 'In Stock', 40),
	(90, 'In Stock', 70),
	(30, 'Low Stock', 15);
GO

ALTER TABLE [dbo].[Supplier]
ALTER COLUMN [Lead Time] nvarchar(50);
GO

INSERT INTO [dbo].[Supplier] ([Supplier ID], [Supplier Name], [Contact Information], [Lead Time])
VALUES
	('SUP-123456', 'Ingram Content Group', 'https://www.ingramcontent.com/', '1-2 business days'),
	('SUP-789012', 'Baker & Taylor', 'https://www.baker-taylor.com/', '2-3 business days'),
	('SUP-345678', 'Gardners Books', 'https://www.gardners.com/', '3-5 business days'),
	('SUP-901234', 'Bertrams Book Services', 'https://www.bertrams.co.uk/', '3-5 business days'),
	('SUP-567890', 'Book Depository', 'https://bookdepositoryus.com/', '4-7 business days'),
	('SUP-123450', 'Blackwells', 'https://blackwells.co.uk/bookshop/shops', '5-7 business days'),
	('SUP-78901234', 'The Book People', 'https://twitter.com/thebookpeople?lang=en', '3-5 business days'),
	('SUP-34567890', 'Barnes & Noble', 'https://www.barnesandnoble.com/', '2-4 business days');
GO