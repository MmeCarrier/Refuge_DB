CREATE PROCEDURE [dbo].[SupprimerBenevole]
	@Prenom VARCHAR(50)
	
AS
	BEGIN
		DELETE 
		FROM [dbo].[Benevole]
		WHERE [Prenom] = @Prenom
	END



