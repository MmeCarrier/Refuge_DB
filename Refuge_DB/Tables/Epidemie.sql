CREATE TABLE [dbo].[Epidemie]
(
	[EpidemieId] INT IDENTITY NOT NULL PRIMARY KEY,
	[Maladie] NVARCHAR(30),
	[DateDeclaration] DATETIME,	
	[EspeceConcernee] NVARCHAR(100),
	[EspecesVulnerables] NVARCHAR(MAX),
	[SecteurId] INT NOT NULL

	CONSTRAINT [FK_Epidemie_ToSecteur] FOREIGN KEY ([SecteurId]) REFERENCES [Secteur] ([SecteurId])
)
