CREATE TABLE [dbo].[Animal]
(
	[AnimalId] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	[Nom] NVARCHAR (60),
	[Espece] NVARCHAR (30) NOT NULL,
	[Age] INT,
	[MF] BIT,
	[Sterilise] BIT,
	[PrimoVaccin] BIT,
	[VaccinComplet] BIT,
	[Provenance] VARCHAR (50) NOT NULL,
	[LieuProvenance] VARCHAR (50),
	[Localisation] VARCHAR (50) NOT NULL,
	[Remarque] VARCHAR (200),
	[FaId] INT NULL, 
    [SecteurId] INT NOT NULL, 
    CONSTRAINT [FK_Animal_ToFa] FOREIGN KEY ([FaId]) REFERENCES [Fa] ([FaId]),
	CONSTRAINT [FK_AnimalToBenevole] Foreign Key ([SecteurId]) REFERENCES [Secteur] ([SecteurId])

)
