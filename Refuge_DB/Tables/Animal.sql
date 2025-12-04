CREATE TABLE [dbo].[Animal]
(
	[AnimalId] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	[Nom] NVARCHAR (60),
	[Espece] NVARCHAR (30) NOT NULL,
	[Age] INT,
	[M/F] BIT,
	[Primo-vaccin] BIT,
	[Vaccin-complet] BIT,
	[Provenance] VARCHAR (50) NOT NULL,
	[Lieu_Provenance] VARCHAR (50),
	[Localisation] VARCHAR (50) NOT NULL,
	[Remarque] VARCHAR (200),
	CONSTRAINT [FK_Animal_ToTable] FOREIGN KEY ([AnimalId]) REFERENCES [F_A] ([FAId]),
	CONSTRAINT [FK_AnimalToTable] Foreign Key ([AnimalId]) REFERENCES [Secteur] ([SecteurId])

)
