CREATE TABLE [dbo].[Benevole]
(
	[BenevoleId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Prenom] VARCHAR(50) NOT NULL,
	[Nom] VARCHAR (80) NULL,
	[Tel] VARCHAR (20) NOT NULL,
	[Adresse] VARCHAR (200) NULL,
    [EstResponsable] BIT NOT NULL,
	[FormeFerme] BIT NOT NULL,
	[FormeReptile] BIT NOT NULL,
	[FormeContrat] BIT NOT NULL, 
    CONSTRAINT [FK_Benevole_ToSecteur] FOREIGN KEY ([BenevoleId]) REFERENCES [Secteur]([SecteurId]),
	CONSTRAINT [FK_Benevole_ToBenevole] FOREIGN KEY ([BenevoleId]) References [Fa] ([FaId])
)
