using RedArborDataAccessLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedArborLogic.EmployeeLogic
{
    public class EmployeeLogic
    {
        public bool CreateEmployee(string connectionStrin)
        {
            SqlParameter[] paramters;
            string result = SqlHelper.ExecuteProcedureReturnString(connectionStrin, "");

            return false;
        }
    }
}
