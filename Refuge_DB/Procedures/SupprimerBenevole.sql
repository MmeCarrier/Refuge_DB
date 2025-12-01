CREATE PROCEDURE [dbo].[SupprimerBenevole]
	@Id INT
	
AS
	BEGIN
		DELETE 
		FROM [dbo].[Benevole]
		WHERE [Id] = @Id
	END



