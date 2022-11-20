CREATE TABLE [dbo].[Transaction]
(
	[transaction_id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[account_id] INT NOT NULL,
	[item_id] INT NOT NULL,
	[operation_type] VARCHAR(13) NOT NULL,
	[unit_change] DECIMAL(7,2) NULL,
	[datetime] DATETIME NOT NULL
)
