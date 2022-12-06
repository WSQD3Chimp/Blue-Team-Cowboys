CREATE TABLE [dbo].[Table1]
(
	[accountid] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [password_hash] VARCHAR(72) NOT NULL,
	[security1_hash] VARCHAR(72) NOT NULL,
	[security2_hash] VARCHAR(72) NOT NULL,
	[security3_hash] VARCHAR(72) NOT NULL,
	[name] VARCHAR(100) NOT NULL, 
    [isManager] BIT NOT NULL DEFAULT 0
)


CREATE TABLE [dbo].[Item]
(
	[item_id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[item_minimum] DECIMAL(7,2) NOT NULL,
	[item_units] DECIMAL(7,2) NOT NULL,
	[unit_price] DECIMAL(7,2) NOT NULL,
	[manufacturer] VARCHAR(50) NOT NULL,
	[item_name] VARCHAR(100) NOT NULL,
	[description] TEXT NULL,
	[isMachine] BIT NOT NULL DEFAULT 0 
)


CREATE TABLE [dbo].[Part_Association]
(
	[machine_id] INT NOT NULL, 
    [part_id] INT NOT NULL, 
    CONSTRAINT [FK_Parts_Machine] FOREIGN KEY ([machine_id]) REFERENCES [Item]([item_id]),
    CONSTRAINT [FK_Parts_Part] FOREIGN KEY ([part_id]) REFERENCES [Item]([item_id]),
    CONSTRAINT [PK_Parts] PRIMARY KEY ([machine_id],[part_id])
)


CREATE TABLE [dbo].[Transaction]
(
	[transaction_id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[account_id] INT NOT NULL,
	[item_id] INT NOT NULL,
	[operation_type] VARCHAR(13) NOT NULL,
	[unit_change] DECIMAL(7,2) NULL,
	[datetime] DATETIME NOT NULL
);