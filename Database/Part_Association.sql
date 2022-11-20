CREATE TABLE [dbo].[Part_Association]
(
	[machine_id] INT NOT NULL, 
    [part_id] INT NOT NULL, 
    CONSTRAINT [FK_Parts_Machine] FOREIGN KEY ([machine_id]) REFERENCES [Item]([item_id]),
    CONSTRAINT [FK_Parts_Part] FOREIGN KEY ([part_id]) REFERENCES [Item]([item_id]),
    CONSTRAINT [PK_Parts] PRIMARY KEY ([machine_id],[part_id])
)
