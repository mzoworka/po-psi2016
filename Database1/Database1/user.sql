CREATE TABLE [dbo].[user]
(
	[id_user] INT NOT NULL PRIMARY KEY, 
    [login] VARCHAR(20) NOT NULL, 
    [pass] VARCHAR(20) NULL, 
    [email] TEXT NULL
)
