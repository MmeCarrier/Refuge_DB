CREATE PROCEDURE [dbo].[UpdateBenevole]
	@Id INT,
	@Prenom VARCHAR(50),
	@Nom VARCHAR(80),
	@Tel VARCHAR (20),
	@Adresse VARCHAR (200),
    @EstResponsable BIT,
	@FormeFerme BIT,
	@FormeReptile BIT,
	@FormeContrat BIT
AS
	BEGIN
	UPDATE [dbo].[Benevole]
	SET  [Prenom] = @Prenom, 
		 [Nom] = @Nom, 
		 [Tel] = @Tel, 
		 [EstResponsable] = @EstResponsable, 
		 [FormeFerme] = @FormeFerme, 
		 [FormeReptile] = @FormeReptile, 
		 [FormeContrat] = @FormeContrat
	WHERE [Prenom] = @Prenom
END
