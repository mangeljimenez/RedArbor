using RedArborDataAccessLayer.Mapping;
using RedArborDataAccessLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedArborDataAccessLayer.Repository
{
    public class EmployeeDBClient
    {
        public string CreateEmployee(string connectionStrin, Models.EmployeeModel employee)
        {
            SqlParameter[] parameters =  {
                new SqlParameter("@CompanyId",employee.CompanyId),
                new SqlParameter("@CreatedOn",employee.CreatedOn),
                new SqlParameter("@DeletedOn",employee.DeletedOn), 
                new SqlParameter("@Email",employee.Email),
                new SqlParameter("@Fax",employee.Fax),
                new SqlParameter("@Name",employee.Name),
                new SqlParameter("@Lastlogin",employee.Lastlogin),
                new SqlParameter("@Password",employee.Password),
                new SqlParameter("@PortalId",employee.PortalId),
                new SqlParameter("@RoleId",employee.RoleId),
                new SqlParameter("@StatusId",employee.StatusId),
                new SqlParameter("@Telephone",employee.Telephone),
                new SqlParameter("@UpdatedOn",employee.UpdatedOn),
                new SqlParameter("@Username",employee.Username)
            };
            return SqlHelper.ExecuteProcedureReturnString(connectionStrin, "pCreateEmployee", parameters);
        }   

        public List<Models.EmployeeModel> GetAllEmployees(string connectionStrin)
        {
            return SqlHelper.ExecuteProcedureReturnData<List<Models.EmployeeModel>>(connectionStrin, "pGetAllEmployees", r => r.TranslateAsEmployeesList());
        }

        public Models.EmployeeModel GetSingleEmployee(string connectionStrin, int id)
        {
            SqlParameter[] parameters =  {
                new SqlParameter("@id",id)
            };
            return SqlHelper.ExecuteProcedureReturnData<Models.EmployeeModel>(connectionStrin, "pGetSingleEmployee", r => r.TranslateAsEmployee(),parameters);
        }

        public string UpdateEmployee(string connectionStrin, Models.EmployeeModel employee)
        {
            SqlParameter[] parameters =  {
                new SqlParameter("@CompanyId",employee.CompanyId),
                new SqlParameter("@Email",employee.Email),
                new SqlParameter("@Fax",employee.Fax),
                new SqlParameter("@Name",employee.Name),
                new SqlParameter("@Password",employee.Password),
                new SqlParameter("@Telephone",employee.Telephone),
                new SqlParameter("@Username",employee.Username)
            };
            return SqlHelper.ExecuteProcedureReturnString(connectionStrin, "pUpdateEmployee", parameters);
        }

        public string DeleteEmployee(string connectionStrin, int id)
        {
            SqlParameter[] parameters =  {
                new SqlParameter("@id",id)
            };
            return SqlHelper.ExecuteProcedureReturnString(connectionStrin, "pDeleteEmployee", parameters);
        }
    }
}
