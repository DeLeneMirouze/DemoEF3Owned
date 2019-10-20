CREATE TABLE [dbo].[Addresses] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Number] NVARCHAR (8)   NULL,
    [Street] NVARCHAR (150) NOT NULL,
    [Zip]    NVARCHAR (10)  NOT NULL,
    [Town]   NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

