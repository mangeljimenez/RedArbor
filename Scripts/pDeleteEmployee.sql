-- =============================================
-- Author:		<Author,,Minguel Angel Jimenez Muñoz>
-- Create date: <Create Date,,2022/04/25>
-- Description:	<Description,,Procedimiento almacenado que se encarga de eliminar empleados>
-- =============================================
CREATE OR ALTER PROCEDURE pDeleteEmployee
	@id INT
AS
BEGIN
	
	DECLARE @msg VARCHAR(128) = '',
	@hasError BIT = 0

	IF(SELECT COUNT(*) FROM Employees WHERE CompanyId = @id) > 0
	BEGIN
		DELETE Employees
		WHERE CompanyId = @id
	END
	ELSE
	BEGIN
		SET @msg = 'No se ha encontrado registros para eliminar'
		SET @hasError = 1
	END

	SELECT @msg AS msg
END
GO
