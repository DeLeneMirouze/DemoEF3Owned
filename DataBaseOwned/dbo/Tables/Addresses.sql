CREATE TABLE [dbo].[Addresses] (
    [Number] NVARCHAR (8)   NULL,
    [Street] NVARCHAR (150) NOT NULL,
    [Zip]    NVARCHAR (10)  NOT NULL,
    [Town]   NVARCHAR (50)  NOT NULL,
    [RestaurantId] INT NOT NULL, 
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([RestaurantId]),
CONSTRAINT [FK_Address_Restaurants_RestaurantId] FOREIGN KEY ([RestaurantId]) REFERENCES [Restaurants] ([Id]) ON DELETE CASCADE

	
);

