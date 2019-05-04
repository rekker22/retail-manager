CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] NCHAR(10) NULL, 
    [Quantity] NCHAR(10) NULL, 
    [PurchasePrice] MONEY NULL, 
    [PurchaseDate] NCHAR(10) NULL
)
