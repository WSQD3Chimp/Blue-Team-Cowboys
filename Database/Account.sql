CREATE TABLE [dbo].[Table1]
(
	[accountid] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [password_hash] VARCHAR(72) NOT NULL,
	[security1_hash] VARCHAR(72) NOT NULL,
	[security2_hash] VARCHAR(72) NOT NULL,
	[security3_hash] VARCHAR(72) NOT NULL,
	[name] VARCHAR(100) NOT NULL, 
    [isManager] BIT NOT NULL DEFAULT 0
);