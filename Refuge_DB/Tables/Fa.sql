CREATE TABLE [dbo].[Fa]
(
	[FaId] INT IDENTITY NOT NULL PRIMARY KEY,
	[BenevoleId] INT NULL, 
    [AnimalId] INT NULL, 
    CONSTRAINT [FK_FA_ToBenevole] FOREIGN KEY ([BenevoleId]) REFERENCES [Benevole] ([BenevoleId]),
	CONSTRAINT [FK_FA_ToAnimal] FOREIGN KEY ([AnimalId]) REFERENCES [Animal] ([AnimalId])
)
