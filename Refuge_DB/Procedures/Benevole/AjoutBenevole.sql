CREATE PROCEDURE [dbo].[AjoutBenevole]
	@Prenom VARCHAR(50),
	@Nom VARCHAR(80),
	@Tel VARCHAR (20),
	@Adresse VARCHAR (200),
    @EstResponsable BIT,
	@FormeFerme BIT,
	@FormeReptile BIT,
	@FormeContrat BIT,
	@SecteurId INT,
	@FaId INT
AS
BEGIN
	BEGIN TRY
		IF LEN(TRIM(@Prenom)) = 0
			RAISERROR('Veuillez entrer un prénom', 16,1);

		IF LEN(TRIM(@Tel)) = 0
			RAISERROR('Veuillez entrer un numéro de téléphone', 16,1);

		IF @EstResponsable NOT IN (0,1)
			RAISERROR('Veuillez indiquer le rôle adéquat', 16,1);

		IF NOT EXISTS (SELECT 1 FROM Secteur WHERE SecteurId = @SecteurId)
			RAISERROR('SecteurId invalide', 16, 1);

		IF NOT EXISTS (SELECT 1 FROM Fa WHERE FaId = @FaId)
			RAISERROR('FaId invalide', 16, 1);

	
		INSERT INTO [dbo].[Benevole] ([Prenom], [Nom], [Tel], [Adresse], [EstResponsable], [FormeFerme], [FormeReptile], [FormeContrat], [SecteurId], [FaId])
		VALUES (@Prenom, @Nom, @Tel, @Adresse, @EstResponsable, @FormeFerme, @FormeReptile, @FormeContrat, @SecteurId, @FaId)
	
	
	END TRY
	BEGIN CATCH
		THROW;
	END CATCH
END
