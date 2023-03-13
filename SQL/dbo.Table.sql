CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Driver Name] VARCHAR(50) NOT NULL, 
    [Lot No.] VARCHAR(50) NOT NULL, 
    [Plate No.] VARCHAR(50) NOT NULL, 
    [Purpose of Visitor] VARCHAR(50) NOT NULL, 
    [Time In] DATETIME NOT NULL, 
    [Time Out] DATETIME NULL
)
