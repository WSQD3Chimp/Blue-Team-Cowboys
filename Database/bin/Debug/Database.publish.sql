﻿/*
Deployment script for Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Database"
:setvar DefaultFilePrefix "Database"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Rename refactoring operation with key 575afd25-5a31-42de-bb0b-6722b3755ca3 is skipped, element [dbo].[Table1].[Id] (SqlSimpleColumn) will not be renamed to accountid';


GO
PRINT N'Rename refactoring operation with key 90f5e19e-2bf5-4be4-9e44-39b2f1f07712 is skipped, element [dbo].[Item].[Id] (SqlSimpleColumn) will not be renamed to item_id';


GO
PRINT N'Rename refactoring operation with key 28ddda32-f6e5-42d2-9b13-ea9ea379dae4 is skipped, element [dbo].[Part_Association].[Id] (SqlSimpleColumn) will not be renamed to machine_id';


GO
PRINT N'Rename refactoring operation with key d0bb5c17-6128-4a60-a62e-9c96083c1f94 is skipped, element [dbo].[Table1].[name] (SqlSimpleColumn) will not be renamed to username';


GO
PRINT N'Creating Table [dbo].[Account]...';


GO
CREATE TABLE [dbo].[Account] (
    [accountid]      INT           IDENTITY (1, 1) NOT NULL,
    [password_hash]  VARCHAR (72)  NOT NULL,
    [security1_hash] VARCHAR (72)  NOT NULL,
    [security2_hash] VARCHAR (72)  NOT NULL,
    [security3_hash] VARCHAR (72)  NOT NULL,
    [username]       VARCHAR (100) NOT NULL,
    [isManager]      BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([accountid] ASC),
    UNIQUE NONCLUSTERED ([username] ASC)
);


GO
PRINT N'Creating Table [dbo].[Item]...';


GO
CREATE TABLE [dbo].[Item] (
    [item_id]      INT            IDENTITY (1, 1) NOT NULL,
    [item_minimum] DECIMAL (7, 2) NOT NULL,
    [item_units]   DECIMAL (7, 2) NOT NULL,
    [unit_price]   DECIMAL (7, 2) NOT NULL,
    [manufacturer] VARCHAR (50)   NOT NULL,
    [item_name]    VARCHAR (100)  NOT NULL,
    [description]  TEXT           NULL,
    [isMachine]    BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([item_id] ASC)
);


GO
PRINT N'Creating Table [dbo].[Part_Association]...';


GO
CREATE TABLE [dbo].[Part_Association] (
    [machine_id] INT NOT NULL,
    [part_id]    INT NOT NULL,
    CONSTRAINT [PK_Parts] PRIMARY KEY CLUSTERED ([machine_id] ASC, [part_id] ASC)
);


GO
PRINT N'Creating Table [dbo].[Transaction]...';


GO
CREATE TABLE [dbo].[Transaction] (
    [transaction_id] INT            IDENTITY (1, 1) NOT NULL,
    [account_id]     INT            NOT NULL,
    [item_id]        INT            NOT NULL,
    [operation_type] VARCHAR (13)   NOT NULL,
    [unit_change]    DECIMAL (7, 2) NULL,
    [datetime]       DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([transaction_id] ASC)
);


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[Account]...';


GO
ALTER TABLE [dbo].[Account]
    ADD DEFAULT 0 FOR [isManager];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[Item]...';


GO
ALTER TABLE [dbo].[Item]
    ADD DEFAULT 0 FOR [isMachine];


GO
PRINT N'Creating Foreign Key [dbo].[FK_Parts_Machine]...';


GO
ALTER TABLE [dbo].[Part_Association] WITH NOCHECK
    ADD CONSTRAINT [FK_Parts_Machine] FOREIGN KEY ([machine_id]) REFERENCES [dbo].[Item] ([item_id]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Parts_Part]...';


GO
ALTER TABLE [dbo].[Part_Association] WITH NOCHECK
    ADD CONSTRAINT [FK_Parts_Part] FOREIGN KEY ([part_id]) REFERENCES [dbo].[Item] ([item_id]);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '575afd25-5a31-42de-bb0b-6722b3755ca3')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('575afd25-5a31-42de-bb0b-6722b3755ca3')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '90f5e19e-2bf5-4be4-9e44-39b2f1f07712')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('90f5e19e-2bf5-4be4-9e44-39b2f1f07712')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '28ddda32-f6e5-42d2-9b13-ea9ea379dae4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('28ddda32-f6e5-42d2-9b13-ea9ea379dae4')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'd0bb5c17-6128-4a60-a62e-9c96083c1f94')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('d0bb5c17-6128-4a60-a62e-9c96083c1f94')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Part_Association] WITH CHECK CHECK CONSTRAINT [FK_Parts_Machine];

ALTER TABLE [dbo].[Part_Association] WITH CHECK CHECK CONSTRAINT [FK_Parts_Part];


GO
PRINT N'Update complete.';


GO