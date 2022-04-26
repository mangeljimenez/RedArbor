-- =============================================
-- Author:		<Author,,Miguel Angel Jimenez Muñoz>
-- Create date: <Create Date,,2022/04/25>
-- Description:	<Description,,Procedimiento almacenado que se encarga de crear empleados>
-- =============================================
CREATE OR ALTER PROCEDURE pCreateEmployee 
	@CompanyId int,
	@CreatedOn datetime,
	@DeletedOn datetime,
	@Email varchar(256),
	@Fax varchar(30),
	@Name varchar(256),
	@Lastlogin datetime,
	@Password varchar(32),
	@PortalId int,
	@RoleId int,
	@StatusId int,
	@Telephone varchar(30),
	@UpdatedOn datetime,
	@Username varchar(32)
AS
BEGIN
	
	DECLARE @msg VARCHAR(128) = '',
	@hasError BIT = 0

	IF(SELECT COUNT(*) FROM Employees WHERE CompanyId = @CompanyId) = 0
	BEGIN		
		INSERT INTO Employees (CompanyId,CreatedOn,DeletedOn,Email,Fax,Name,Lastlogin,	Password,PortalId,RoleId,StatusId,Telephone,UpdatedOn,Username)
		VALUES(@CompanyId,@CreatedOn,@DeletedOn,@Email,@Fax,@Name,@Lastlogin,@Password,@PortalId,@RoleId,@StatusId,@Telephone,@UpdatedOn,@Username)
	END
	ELSE
	BEGIN
		SET @msg = 'El ID con el cual trata de crear este empleado ya existe en la base de datos'
		SET @hasError = 1
	END
	
	SELECT @msg AS msg

END
GO
