CREATE PROCEDURE [dbo].[UpdateAnimal]
	@AnimalId INT,
	@Nom NVARCHAR(60),
	@Espece NVARCHAR (30),
	@Age INT,
	@MF BIT,
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
	UPDATE  [dbo].[Animal] 
	SET [Nom] = @Nom,
	[Espece] = @Espece,
	[Age] = @Age,
	[MF] = @MF,
	[PrimoVaccin] = @PrimoVaccin,
	[VaccinComplet] = @VaccinComplet,
	[Provenance]= @Provenance,
	[LieuProvenance] = @LieuProvenance,
	[Localisation] = @Localisation,
	[Remarque]= @Remarque,
	[SecteurId]= @SecteurId,
	[FaId]= @FaId

	WHERE @AnimalId = AnimalId;
	
END TRY
	BEGIN CATCH
	THROW
END CATCH

END
