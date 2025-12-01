CREATE TABLE [dbo].[Benevole]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Prenom] VARCHAR(50) NOT NULL,
	[Nom] VARCHAR (80) NULL,
	[Tel] VARCHAR (20) NOT NULL,
	[Adresse] VARCHAR (200) NULL,
    [EstResponsable] BIT NOT NULL,
	[FormeFerme] BIT NOT NULL,
	[FormeReptile] BIT NOT NULL,
	[FormeContrat] BIT NOT NULL	
)
