
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/13/2016 12:15:18
-- Generated from EDMX file: C:\Users\Liu\Documents\Visual Studio 2015\Projects\My Portfolio Manager\My Portfolio Manager\aaa.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyManager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InstrumentTrade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TradeSet] DROP CONSTRAINT [FK_InstrumentTrade];
GO
IF OBJECT_ID(N'[dbo].[FK_InstrumentPrice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PriceSet] DROP CONSTRAINT [FK_InstrumentPrice];
GO
IF OBJECT_ID(N'[dbo].[FK_InstrumentInstType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InstrumentSet] DROP CONSTRAINT [FK_InstrumentInstType];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[InstrumentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstrumentSet];
GO
IF OBJECT_ID(N'[dbo].[TradeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TradeSet];
GO
IF OBJECT_ID(N'[dbo].[PriceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PriceSet];
GO
IF OBJECT_ID(N'[dbo].[InstTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstTypeSet];
GO
IF OBJECT_ID(N'[dbo].[InterstRateSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InterstRateSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InstrumentSet'
CREATE TABLE [dbo].[InstrumentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NULL,
    [Ticker] nvarchar(max)  NULL,
    [Exchange] nvarchar(max)  NULL,
    [Underlying] nvarchar(max)  NULL,
    [Strike] float  NULL,
    [Tenor] float  NOT NULL,
    [Iscall] bit  NOT NULL,
    [InstTypeId] int  NOT NULL,
    [BarrierType] nvarchar(max)  NULL,
    [Rebate] float  NOT NULL,
    [Barrier] float  NOT NULL,
    [InstType_Id] int  NOT NULL
);
GO

-- Creating table 'TradeSet'
CREATE TABLE [dbo].[TradeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Isbuy] bit  NOT NULL,
    [Quantity] int  NOT NULL,
    [Price] float  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [InstrumentId] int  NOT NULL
);
GO

-- Creating table 'PriceSet'
CREATE TABLE [dbo].[PriceSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [ClosingPrice] float  NOT NULL,
    [InstrumentId] int  NOT NULL
);
GO

-- Creating table 'InstTypeSet'
CREATE TABLE [dbo].[InstTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InterstRateSet'
CREATE TABLE [dbo].[InterstRateSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tenor] float  NOT NULL,
    [Rate] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'InstrumentSet'
ALTER TABLE [dbo].[InstrumentSet]
ADD CONSTRAINT [PK_InstrumentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TradeSet'
ALTER TABLE [dbo].[TradeSet]
ADD CONSTRAINT [PK_TradeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [PK_PriceSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InstTypeSet'
ALTER TABLE [dbo].[InstTypeSet]
ADD CONSTRAINT [PK_InstTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InterstRateSet'
ALTER TABLE [dbo].[InterstRateSet]
ADD CONSTRAINT [PK_InterstRateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [InstrumentId] in table 'TradeSet'
ALTER TABLE [dbo].[TradeSet]
ADD CONSTRAINT [FK_InstrumentTrade]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[InstrumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentTrade'
CREATE INDEX [IX_FK_InstrumentTrade]
ON [dbo].[TradeSet]
    ([InstrumentId]);
GO

-- Creating foreign key on [InstrumentId] in table 'PriceSet'
ALTER TABLE [dbo].[PriceSet]
ADD CONSTRAINT [FK_InstrumentPrice]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[InstrumentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentPrice'
CREATE INDEX [IX_FK_InstrumentPrice]
ON [dbo].[PriceSet]
    ([InstrumentId]);
GO

-- Creating foreign key on [InstType_Id] in table 'InstrumentSet'
ALTER TABLE [dbo].[InstrumentSet]
ADD CONSTRAINT [FK_InstrumentInstType]
    FOREIGN KEY ([InstType_Id])
    REFERENCES [dbo].[InstTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentInstType'
CREATE INDEX [IX_FK_InstrumentInstType]
ON [dbo].[InstrumentSet]
    ([InstType_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------