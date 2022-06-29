USE [master]
GO
DROP DATABASE IF EXISTS MemberDB;
CREATE DATABASE MemberDB;
GO

USE MemberDB;
GO
DROP TABLE IF EXISTS members;
CREATE TABLE members(
	id INT PRIMARY KEY ,
      full_name NVARCHAR(100),
	password NVARCHAR(200),
	email VARCHAR(200) UNIQUE,
	city NVARCHAR(50),
	country NVARCHAR(50),
);

INSERT INTO MemberDB.dbo.members (id, full_name, password, email, city, country)
VALUES (1, N'Bùi Nhật Tân', N'tannbnse150170', N'tannbnse150170@fpt.edu.vn', N'Hồ Chí Minh', N'Việt Nam');

INSERT INTO MemberDB.dbo.members (id, full_name, password, email, city, country)
VALUES (2, N'Nguyễn Minh Trung', N'trungnmse150182', N'trungnmse150182@fpt.edu.vn', N'Buôn Ma Thuột', N'Việt Nam');

INSERT INTO MemberDB.dbo.members (id, full_name, password, email, city, country)
VALUES (3, N'Nguyễn Bảo Toàn', N'toannbse150270', N'toannbse150270@fpt.edu.vn', N'Biến Tre', N'Việt Nam');

INSERT INTO MemberDB.dbo.members (id, full_name, password, email, city, country)
VALUES (4, N'Huỳnh Ngô Gia Bảo', N'baohngse150260', N'baohngse150260@fpt.edu.vn', N'Biến Tre', N'Việt Nam');

INSERT INTO MemberDB.dbo.members (id, full_name, password, email, city, country)
VALUES (5, N'Lê Hà Duy', N'duylhse150233', N'duylhse150233@fpt.edu.vn', N'Biến Tre', N'Việt Nam');

SELECT * FROM  members;