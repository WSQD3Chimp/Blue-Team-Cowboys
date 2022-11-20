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
