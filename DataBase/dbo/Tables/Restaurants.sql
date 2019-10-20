CREATE TABLE [dbo].[Restaurants] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [IdAddress]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Restaurants_Addresses] FOREIGN KEY ([IdAddress]) REFERENCES [dbo].[Addresses] ([Id]) 
);

