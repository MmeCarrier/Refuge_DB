CREATE PROCEDURE [dbo].[SupprimerAnimal]
	@Nom NVARCHAR(60)
	
AS
	BEGIN
	DELETE
	FROM [dbo].[Animal]
	WHERE [Nom] = @Nom

	END