
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/28/2017 15:35:15
-- Generated from EDMX file: C:\Projects\RestaurantManager\RestaurantManager.DataBase\RestaurantManagerDbContext.edmx
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

IF OBJECT_ID(N'[dbo].[FK_Products_ProductTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_ProductTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_UnitType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_UnitType];
GO
IF OBJECT_ID(N'[dbo].[FK_Recipes_UnitTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItem] DROP CONSTRAINT [FK_Recipes_UnitTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Sets_SetTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MenuItem] DROP CONSTRAINT [FK_Sets_SetTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_SetsProducts_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecipesProducts] DROP CONSTRAINT [FK_SetsProducts_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_SetsProducts_Sets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RecipesProducts] DROP CONSTRAINT [FK_SetsProducts_Sets];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MenuItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItem];
GO
IF OBJECT_ID(N'[dbo].[MenuItemTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MenuItemTypes];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductTypes];
GO
IF OBJECT_ID(N'[dbo].[RecipesProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RecipesProducts];
GO
IF OBJECT_ID(N'[dbo].[UnitTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UnitTypes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MenuItems'
CREATE TABLE [dbo].[MenuItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(40)  NOT NULL,
    [CreatedOn] datetime  NOT NULL,
    [UnitTypeId] int  NULL,
    [UnitTypeAmount] nchar(10)  NULL,
    [MenuItemTypeId] int  NOT NULL
);
GO

-- Creating table 'MenuItemTypes'
CREATE TABLE [dbo].[MenuItemTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(40)  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(40)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Description] nvarchar(500)  NULL,
    [CreatedOn] datetime  NOT NULL,
    [ProductTypeId] int  NOT NULL,
    [UnitTypeAmount] float  NOT NULL,
    [UnitTypeId] int  NOT NULL
);
GO

-- Creating table 'ProductTypes'
CREATE TABLE [dbo].[ProductTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nchar(20)  NOT NULL
);
GO

-- Creating table 'UnitTypes'
CREATE TABLE [dbo].[UnitTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'RecipesProducts'
CREATE TABLE [dbo].[RecipesProducts] (
    [Products_Id] int  NOT NULL,
    [MenuItems_Id] int  NOT NULL
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

-- Creating primary key on [Products_Id], [MenuItems_Id] in table 'RecipesProducts'
ALTER TABLE [dbo].[RecipesProducts]
ADD CONSTRAINT [PK_RecipesProducts]
    PRIMARY KEY CLUSTERED ([Products_Id], [MenuItems_Id] ASC);
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

-- Creating foreign key on [Products_Id] in table 'RecipesProducts'
ALTER TABLE [dbo].[RecipesProducts]
ADD CONSTRAINT [FK_RecipesProducts_Products]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MenuItems_Id] in table 'RecipesProducts'
ALTER TABLE [dbo].[RecipesProducts]
ADD CONSTRAINT [FK_RecipesProducts_MenuItem]
    FOREIGN KEY ([MenuItems_Id])
    REFERENCES [dbo].[MenuItems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecipesProducts_MenuItem'
CREATE INDEX [IX_FK_RecipesProducts_MenuItem]
ON [dbo].[RecipesProducts]
    ([MenuItems_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------