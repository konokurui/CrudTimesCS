USE [C:\USERS\DIOGO.RGOMES1\SOURCE\REPOS\CRUDTIMESCS\CRUDTIMESCS\BDTIMECS.MDF]
GO

DECLARE	@return_value Int,
		@CodTimes int

EXEC	@return_value = [dbo].[pInserirTimes]
		@CodTimes = @CodTimes OUTPUT,
		@NomeTimes = N'aaa',
		@LogoTimes = N'aaaaaa',
		@FraseTimes = N'aaaaaaaaaaaaa'

SELECT	@CodTimes as N'@CodTimes'

SELECT	@return_value as 'Return Value'

GO
