CREATE PROCEDURE [dbo].[AjoutAnimal]
	@Nom NVARCHAR(60),
	@Espece NVARCHAR (30),
	@Age INT,
	@MF BIT,
	@Sterilise BIT,
	@PrimoVaccin BIT,
	@VaccinComplet BIT,
	@Provenance VARCHAR (50),
	@LieuProvenance VARCHAR (50),
	@Localisation VARCHAR (50),
	@Remarque VARCHAR (200),
	@SecteurId INT,
	@FaId INT

AS
BEGIN
	BEGIN TRY
		IF LEN (TRIM(@Nom)) = 0
		RAISERROR ('Le nom ne peut pas être vide', 16, 1);
				
		IF LEN (TRIM(@Espece)) = 0
		RAISERROR ('Le prenom ne peut pas être vide', 16, 1);

		If LEN (TRIM(@Provenance)) = 0
		RAISERROR ('La provenance ne peut pas être vide', 16, 1);

		IF LEN (TRIM(@LieuProvenance)) = 0
		RAISERROR ('Le lieu de provenance ne peut pas être vide', 16, 1);

		IF LEN(TRIM(@Remarque)) = 0
		RAISERROR('La remarque ne peut pas être vide' ,16, 1);
INSERT INTO [dbo].[Animal] ([Nom],[Espece],[Age],[MF],[Sterilise],[PrimoVaccin],[VaccinComplet],[Provenance],[LieuProvenance], [Localisation],[Remarque],[SecteurId],[FaId])
	VALUES (@Nom,@Espece,@Age,@MF,@Sterilise,@PrimoVaccin,@VaccinComplet,@Provenance,@LieuProvenance,@Localisation,@Remarque,@SecteurId,@FaId)

END TRY
	BEGIN CATCH
	THROW;
	END CATCH
END