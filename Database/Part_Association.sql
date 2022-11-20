CREATE TABLE [dbo].[Part_Association]
(
	[machine_id] INT NOT NULL PRIMARY KEY, 
    [part_id] INT NOT NULL PRIMARY KEY, 
    CONSTRAINT [FK_Parts_Machine] FOREIGN KEY ([machine_id]) REFERENCES [Item]([item_id]),
    CONSTRAINT [FK_Parts_Part] FOREIGN KEY ([part_id]) REFERENCES [Item]([item_id])
)
