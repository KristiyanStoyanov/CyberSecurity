CREATE TABLE [dbo].[RegisteredUsers]
(
	[UserID] INT NOT NULL PRIMARY KEY,
	[UserName] nvarchar(50) not null,
	[UserPassword] varchar(30) not null,
	[UserEmail] nvarchar(200) not null,
)
