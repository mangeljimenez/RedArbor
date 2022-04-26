-- =============================================
-- Author:		<Author,,Miguel Angel Jimenez Muñoz>
-- Create date: <Create Date,,2022/04/25>
-- Description:	<Description,,Procedimiento almacenado que se encarga de actualizar datos de los empleados>
-- =============================================
CREATE OR ALTER PROCEDURE pUpdateEmployee 
	@CompanyId int,
	@Email varchar(256) = NULL,
	@Fax varchar(30) = NULL,
	@Name varchar(256) = NULL,	
	@Password varchar(32) = NULL,	
	@Telephone varchar(30) = NULL,	
	@Username varchar(32) = NULL
AS
BEGIN

	--declare @CompanyId int = 2,
	--@Email varchar(256) = 'aaaaaaaa@gmail.com',
	--@Fax varchar(30) = NULL,
	--@Name varchar(256) = NULL,	
	--@Password varchar(32) = NULL,	
	--@Telephone varchar(30) = '456465456',	
	--@Username varchar(32) = NULL

	DECLARE @msg VARCHAR(128) = '',
	@hasError BIT = 0

	IF(SELECT COUNT(*) FROM Employees WHERE CompanyId = @CompanyId) = 0
	BEGIN		
		SET @msg = 'El ID ingresado no existe en la base de datos'
		SET @hasError = 1	
	END
	ELSE
	BEGIN
		
		DECLARE @sqlQuery NVARCHAR(MAX) = 'UPDATE Employees SET ',
		@exeUpdate BIT = 0,
		@fItem BIT = 1

		IF(@Email IS NOT NULL)
		BEGIN
			SET @sqlQuery = @sqlQuery + ' Email = '''+ @Email +''' ,'
			SET @exeUpdate = 1
		END

		IF(@Fax IS NOT NULL)
		BEGIN			
			SET @sqlQuery = @sqlQuery + ' Fax = ''' + @Fax + ''' ,'
			SET @exeUpdate = 1
		END

		IF(@Name IS NOT NULL)
		BEGIN			
			SET @sqlQuery = @sqlQuery + ' Name = ''' + @Name + ''' ,'
			SET @exeUpdate = 1
		END

		IF(@Password IS NOT NULL)
		BEGIN			
			SET @sqlQuery = @sqlQuery + ' Password = ''' + @Password + ''' ,'
			SET @exeUpdate = 1
		END

		IF(@Telephone IS NOT NULL)
		BEGIN			
			SET @sqlQuery = @sqlQuery + ' Telephone = ''' + @Telephone + ''' ,'
			SET @exeUpdate = 1
		END

		IF(@Username IS NOT NULL)
		BEGIN			
			SET @sqlQuery = @sqlQuery + ' Username = ''' + @Username + ''' ,'
			SET @exeUpdate = 1
		END

		SET @sqlQuery = substring(@sqlQuery, 1, (len(@sqlQuery) - 1))

		SET @sqlQuery = @sqlQuery + ' WHERE CompanyId = ' + CAST(@CompanyId AS VARCHAR)

		IF(@exeUpdate = 1)			
			EXECUTE(@sqlQuery)
		ELSE
		BEGIN
			SET @msg = 'No se actualizó ningun registro'
			SET @hasError = 1
		END

	END
	
	SELECT @msg AS msg

END
GO
