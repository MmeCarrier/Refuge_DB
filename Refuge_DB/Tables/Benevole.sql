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
    [SecteurId] INT NULL, 
    [FaId] INT NULL, 
    CONSTRAINT [FK_Benevole_ToSecteur] FOREIGN KEY ([SecteurId]) REFERENCES [Secteur]([SecteurId]),
	CONSTRAINT [FK_Benevole_ToFa] FOREIGN KEY ([FaId]) References [Fa] ([FaId])
)
