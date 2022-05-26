USE [C:\USERS\DIOGO.RGOMES1\SOURCE\REPOS\CRUDTIMESCS\CRUDTIMESCS\BDTIMECS.MDF]
GO

<<<<<<< HEAD
DECLARE	@return_value Int,
		@CodJogadores int

EXEC	@return_value = [dbo].[pInserirJogadores]
		@CodJogadores = @CodJogadores OUTPUT,
		@NomeJogadores = N'aaaa',
		@EmailJogadores = N'aaaa',
		@FoneJogadores = N'552452'

SELECT	@CodJogadores as N'@CodJogadores'
=======
DECLARE	@return_value Int

EXEC	@return_value = [dbo].[pBuscaCodigoJogadores]
		@CodJogadores = 1
>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2

SELECT	@return_value as 'Return Value'

GO
