﻿USE [C:\USERS\DIOGO.RGOMES1\SOURCE\REPOS\CRUDTIMESCS\CRUDTIMESCS\BDTIMECS.MDF]
GO

DECLARE	@return_value Int,
		@CodJogadores int

EXEC	@return_value = [dbo].[pInserirJogadores]
		@CodJogadores = @CodJogadores OUTPUT,
		@NomeJogadores = N'cladudio',
		@EmailJogadores = N'adaaa@gmail.com',
		@FoneJogadores = N'2552352'

SELECT	@CodJogadores as N'@CodJogadores'

SELECT	@return_value as 'Return Value'

GO
