﻿USE [C:\USERS\DIOGO.RGOMES1\SOURCE\REPOS\CRUDTIMESCS\CRUDTIMESCS\BDTIMECS.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[pBuscarTudo]

SELECT	@return_value as 'Return Value'

GO
