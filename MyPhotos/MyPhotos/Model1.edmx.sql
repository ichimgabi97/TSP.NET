
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 12:41:14
-- Generated from EDMX file: C:\Users\ichim\Desktop\TSP.NET\MyPhotos\MyPhotos\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Medias'
CREATE TABLE [dbo].[Medias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Add_date] datetime  NOT NULL
);
GO

-- Creating table 'Videos'
CREATE TABLE [dbo].[Videos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Last_updated] datetime  NULL,
    [Media_Id] int  NOT NULL
);
GO

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Last_updated] datetime  NULL,
    [Media_Id] int  NOT NULL
);
GO

-- Creating table 'Tags_video'
CREATE TABLE [dbo].[Tags_video] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Zone] nvarchar(max)  NULL,
    [Person] nvarchar(max)  NULL,
    [Event] nvarchar(max)  NULL,
    [Automobile] nvarchar(max)  NULL,
    [Other_tags] nvarchar(max)  NULL,
    [Video_Id] int  NOT NULL
);
GO

-- Creating table 'Tags_photo'
CREATE TABLE [dbo].[Tags_photo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Zone] nvarchar(max)  NULL,
    [Person] nvarchar(max)  NULL,
    [Event] nvarchar(max)  NULL,
    [Automobile] nvarchar(max)  NULL,
    [Other_tags] nvarchar(max)  NULL,
    [Photo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Medias'
ALTER TABLE [dbo].[Medias]
ADD CONSTRAINT [PK_Medias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Videos'
ALTER TABLE [dbo].[Videos]
ADD CONSTRAINT [PK_Videos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tags_video'
ALTER TABLE [dbo].[Tags_video]
ADD CONSTRAINT [PK_Tags_video]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tags_photo'
ALTER TABLE [dbo].[Tags_photo]
ADD CONSTRAINT [PK_Tags_photo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Media_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_MediasPhotos]
    FOREIGN KEY ([Media_Id])
    REFERENCES [dbo].[Medias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediasPhotos'
CREATE INDEX [IX_FK_MediasPhotos]
ON [dbo].[Photos]
    ([Media_Id]);
GO

-- Creating foreign key on [Media_Id] in table 'Videos'
ALTER TABLE [dbo].[Videos]
ADD CONSTRAINT [FK_MediasVideos]
    FOREIGN KEY ([Media_Id])
    REFERENCES [dbo].[Medias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediasVideos'
CREATE INDEX [IX_FK_MediasVideos]
ON [dbo].[Videos]
    ([Media_Id]);
GO

-- Creating foreign key on [Photo_Id] in table 'Tags_photo'
ALTER TABLE [dbo].[Tags_photo]
ADD CONSTRAINT [FK_PhotosTags_photo]
    FOREIGN KEY ([Photo_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosTags_photo'
CREATE INDEX [IX_FK_PhotosTags_photo]
ON [dbo].[Tags_photo]
    ([Photo_Id]);
GO

-- Creating foreign key on [Video_Id] in table 'Tags_video'
ALTER TABLE [dbo].[Tags_video]
ADD CONSTRAINT [FK_VideosTags_video]
    FOREIGN KEY ([Video_Id])
    REFERENCES [dbo].[Videos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VideosTags_video'
CREATE INDEX [IX_FK_VideosTags_video]
ON [dbo].[Tags_video]
    ([Video_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------