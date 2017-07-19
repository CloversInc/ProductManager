
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/17/2017 14:45:34
-- Generated from EDMX file: C:\Work\RestaurantManager\RestaurantManager.DataBase\RestaurantManagerDbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RestaurantManager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[RestaurantManagerModelStoreContainer].[FK_MenuItemsMenuTypes_MenuItems]', 'F') IS NOT NULL
    ALTER TABLE [RestaurantManagerModelStoreContainer].[MenuItemsMenuTypes] DROP CONSTRAINT [FK_MenuItemsMenuTypes_MenuItems];
GO
IF OBJECT_ID(N'[RestaurantManagerModelStoreContainer].[FK_MenuItemsMenuTypes_MenuTypes]', 'F') IS NOT NULL
    ALTER TABLE [RestaurantManagerModelStoreContainer].[MenuItemsMenuTypes] DROP CONSTRAINT [FK_MenuItemsMenuTypes_MenuTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_ProductTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_ProductTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_UnitType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_UnitType];
GO
IF OBJECT_ID(N'[dbo].[FK_Recipes_UnitTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_Recipes_UnitTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Sets_SetTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_Sets_SetTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_SetsProducts_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItemsProducts] DROP CONSTRAINT [FK_SetsProducts_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_SetsProducts_Sets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItemsProducts] DROP CONSTRAINT [FK_SetsProducts_Sets];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MenuItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItems];
GO
IF OBJECT_ID(N'[dbo].[MenuItemsProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItemsProducts];
GO
IF OBJECT_ID(N'[dbo].[MenuItemTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItemTypes];
GO
IF OBJECT_ID(N'[dbo].[MenuTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuTypes];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductTypes];
GO
IF OBJECT_ID(N'[dbo].[UnitTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UnitTypes];
GO
IF OBJECT_ID(N'[RestaurantManagerModelStoreContainer].[MenuItemsMenuTypes]', 'U') IS NOT NULL
    DROP TABLE [RestaurantManagerModelStoreContainer].[MenuItemsMenuTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MenuItems'
CREATE TABLE [dbo].[MenuItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Price] decimal(19,4)  NOT NULL,
    [CreatedOn] datetime  NOT NULL,
    [UnitTypeId] int  NOT NULL,
    [UnitTypeAmount] int  NOT NULL,
    [MenuItemTypeId] int  NOT NULL
);
GO

-- Creating table 'MenuItemTypes'
CREATE TABLE [dbo].[MenuItemTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [OrderId] int  NOT NULL
);
GO

-- Creating table 'MenuTypes'
CREATE TABLE [dbo].[MenuTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Price] decimal(19,4)  NOT NULL,
    [Description] nvarchar(500)  NULL,
    [CreatedOn] datetime  NOT NULL,
    [ProductTypeId] int  NOT NULL,
    [UnitTypeAmount] int  NOT NULL,
    [UnitTypeId] int  NOT NULL
);
GO

-- Creating table 'ProductTypes'
CREATE TABLE [dbo].[ProductTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'UnitTypes'
CREATE TABLE [dbo].[UnitTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'MenuItemsProducts'
CREATE TABLE [dbo].[MenuItemsProducts] (
    [Products_Id] int  NOT NULL,
    [MenuItems_Id] int  NOT NULL
);
GO

-- Creating table 'MenuItemsMenuTypes'
CREATE TABLE [dbo].[MenuItemsMenuTypes] (
    [MenuItems_Id] int  NOT NULL,
    [MenuTypes_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems]
ADD CONSTRAINT [PK_MenuItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MenuItemTypes'
ALTER TABLE [dbo].[MenuItemTypes]
ADD CONSTRAINT [PK_MenuItemTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MenuTypes'
ALTER TABLE [dbo].[MenuTypes]
ADD CONSTRAINT [PK_MenuTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductTypes'
ALTER TABLE [dbo].[ProductTypes]
ADD CONSTRAINT [PK_ProductTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UnitTypes'
ALTER TABLE [dbo].[UnitTypes]
ADD CONSTRAINT [PK_UnitTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Products_Id], [MenuItems_Id] in table 'MenuItemsProducts'
ALTER TABLE [dbo].[MenuItemsProducts]
ADD CONSTRAINT [PK_MenuItemsProducts]
    PRIMARY KEY CLUSTERED ([Products_Id], [MenuItems_Id] ASC);
GO

-- Creating primary key on [MenuItems_Id], [MenuTypes_Id] in table 'MenuItemsMenuTypes'
ALTER TABLE [dbo].[MenuItemsMenuTypes]
ADD CONSTRAINT [PK_MenuItemsMenuTypes]
    PRIMARY KEY CLUSTERED ([MenuItems_Id], [MenuTypes_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UnitTypeId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems]
ADD CONSTRAINT [FK_Recipes_UnitTypes]
    FOREIGN KEY ([UnitTypeId])
    REFERENCES [dbo].[UnitTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Recipes_UnitTypes'
CREATE INDEX [IX_FK_Recipes_UnitTypes]
ON [dbo].[MenuItems]
    ([UnitTypeId]);
GO

-- Creating foreign key on [MenuItemTypeId] in table 'MenuItems'
ALTER TABLE [dbo].[MenuItems]
ADD CONSTRAINT [FK_Sets_SetTypes]
    FOREIGN KEY ([MenuItemTypeId])
    REFERENCES [dbo].[MenuItemTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sets_SetTypes'
CREATE INDEX [IX_FK_Sets_SetTypes]
ON [dbo].[MenuItems]
    ([MenuItemTypeId]);
GO

-- Creating foreign key on [ProductTypeId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_ProductTypes]
    FOREIGN KEY ([ProductTypeId])
    REFERENCES [dbo].[ProductTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_ProductTypes'
CREATE INDEX [IX_FK_Products_ProductTypes]
ON [dbo].[Products]
    ([ProductTypeId]);
GO

-- Creating foreign key on [UnitTypeId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_UnitType]
    FOREIGN KEY ([UnitTypeId])
    REFERENCES [dbo].[UnitTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_UnitType'
CREATE INDEX [IX_FK_Products_UnitType]
ON [dbo].[Products]
    ([UnitTypeId]);
GO

-- Creating foreign key on [Products_Id] in table 'MenuItemsProducts'
ALTER TABLE [dbo].[MenuItemsProducts]
ADD CONSTRAINT [FK_MenuItemsProducts_Product]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MenuItems_Id] in table 'MenuItemsProducts'
ALTER TABLE [dbo].[MenuItemsProducts]
ADD CONSTRAINT [FK_MenuItemsProducts_MenuItem]
    FOREIGN KEY ([MenuItems_Id])
    REFERENCES [dbo].[MenuItems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuItemsProducts_MenuItem'
CREATE INDEX [IX_FK_MenuItemsProducts_MenuItem]
ON [dbo].[MenuItemsProducts]
    ([MenuItems_Id]);
GO

-- Creating foreign key on [MenuItems_Id] in table 'MenuItemsMenuTypes'
ALTER TABLE [dbo].[MenuItemsMenuTypes]
ADD CONSTRAINT [FK_MenuItemsMenuTypes_MenuItem]
    FOREIGN KEY ([MenuItems_Id])
    REFERENCES [dbo].[MenuItems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MenuTypes_Id] in table 'MenuItemsMenuTypes'
ALTER TABLE [dbo].[MenuItemsMenuTypes]
ADD CONSTRAINT [FK_MenuItemsMenuTypes_MenuType]
    FOREIGN KEY ([MenuTypes_Id])
    REFERENCES [dbo].[MenuTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuItemsMenuTypes_MenuType'
CREATE INDEX [IX_FK_MenuItemsMenuTypes_MenuType]
ON [dbo].[MenuItemsMenuTypes]
    ([MenuTypes_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------