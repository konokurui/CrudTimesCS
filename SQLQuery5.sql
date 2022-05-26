USE [C:\USERS\DIOGO.RGOMES1\SOURCE\REPOS\CRUDTIMESCS\CRUDTIMESCS\BDTIMECS.MDF]
GO

DECLARE	@return_value Int,
		@CodJogadores int

EXEC	@return_value = [dbo].[pInserirJogadores]
		@CodJogadores = @CodJogadores OUTPUT,
		@NomeJogadores = N'aaaaa',
		@EmailJogadores = N'@dff',
		@FoneJogadores = N'323242'

SELECT	@CodJogadores as N'@CodJogadores'

SELECT	@return_value as 'Return Value'

GO
