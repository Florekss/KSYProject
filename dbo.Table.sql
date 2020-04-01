CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login] NCHAR(50) NULL, 
    [Password] NCHAR(50) NULL, 
    [FIO] NCHAR(80) NULL, 
    [Prev] INT NULL, 
    [Question] NCHAR(250) NULL, 
    [Req] NCHAR(50) NULL, 
    [Reg] DATETIME NULL
)
