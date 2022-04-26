-- =============================================
-- Author:		<Author,,Minguel Angel Jimenez Muñoz>
-- Create date: <Create Date,,2022/04/25>
-- Description:	<Description,,Procedimiento almacenado que se encarga de consultar todos los empleados>
-- =============================================
CREATE OR ALTER PROCEDURE pGetAllEmployees
AS
BEGIN
	SELECT 
		CompanyId,
		CreatedOn,
		DeletedOn,
		Email,
		Fax,
		Name,
		Lastlogin,
		Password,
		PortalId,
		RoleId,
		StatusId,
		Telephone,
		UpdatedOn,
		Username
	FROM Employees
END
GO
