CREATE PROCEDURE [dbo].[CreerEpidemie]
	@Maladie NVARCHAR(30),
	@DateDeclaration DATE,
	@SecteurConcerne NVARCHAR(30),
	@EspeceConcernee NVARCHAR(100),
	@EspecesVulnerables NVARCHAR(MAX),
	@SecteurId INT
AS
	BEGIN 
		BEGIN TRY
		IF LEN (TRIM(@Maladie)) = 0
		RAISERROR ('La maladie ne peut pas être vide', 16, 1);
		IF LEN (TRIM(@SecteurConcerne)) = 0
		RAISERROR ('Le nom du secteur concerné ne peut pas être vide', 16, 1);
		IF LEN (TRIM(@EspeceConcernee)) = 0
		RAISERROR ('Le nom de l_espèce atteinte peut pas être vide', 16, 1);
		IF LEN (TRIM(@EspecesVulnerables)) = 0
		RAISERROR ('Le nom ne peut pas être vide', 16, 1);

	INSERT INTO [dbo].[Epidemie] ([Maladie],[DateDeclaration],[SecteurConcerne],[EspeceConcernee],[EspecesVulnerables],[SecteurId])
	VALUES (@Maladie,@DateDeclaration,@SecteurConcerne,@EspeceConcernee,@EspecesVulnerables,@SecteurId)
END TRY
	BEGIN CATCH
	THROW;
	END CATCH
END