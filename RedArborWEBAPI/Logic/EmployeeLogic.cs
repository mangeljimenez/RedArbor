using RedArborDataAccessLayer.Repository;
using RedArborDataAccessLayer.Utilities;
using RedArborWEBAPI.Models;
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
        public static string CreateEmployee(string connectionStrin, Employee employee)
        {
            RedArborDataAccessLayer.Models.EmployeeModel employeeDB = new RedArborDataAccessLayer.Models.EmployeeModel();

            employeeDB.CompanyId = employee.CompanyId;
            employeeDB.CreatedOn = Convert.ToDateTime(employee.CreatedOn);
            employeeDB.DeletedOn = Convert.ToDateTime(employee.DeletedOn);
            employeeDB.Email = employee.Email;
            employeeDB.Fax = employee.Fax;
            employeeDB.Name = employee.Name;
            employeeDB.Lastlogin = Convert.ToDateTime(employee.Lastlogin);
            employeeDB.Password = employee.Password;
            employeeDB.PortalId = employee.PortalId;
            employeeDB.RoleId = employee.RoleId;
            employeeDB.StatusId = employee.StatusId;
            employeeDB.Telephone = employee.Telephone;
            employeeDB.UpdatedOn = Convert.ToDateTime(employee.UpdatedOn);
            employeeDB.Username = employee.Username;

            string data = DbClientFactory<EmployeeDBClient>.Instance.CreateEmployee(connectionStrin, employeeDB);

            return data;
        }

        public static Employee GetSingleEmployee(string connectionStrin, int id)
        {
            Employee employee = new Employee();

            RedArborDataAccessLayer.Models.EmployeeModel employeeDB = DbClientFactory<EmployeeDBClient>.Instance.GetSingleEmployee(connectionStrin, id);

            if (employeeDB != null)
            {
                employee.CompanyId = employeeDB.CompanyId;
                employee.CreatedOn = employeeDB.CreatedOn.ToString("yyyy-MM-dd hh:mm:ss");
                employee.DeletedOn = employeeDB.DeletedOn.HasValue ? employeeDB.DeletedOn.Value.ToString("yyyy-MM-dd hh:mm:ss") : "";
                employee.Email = employeeDB.Email;
                employee.Fax = employeeDB.Fax;
                employee.Name = employeeDB.Name;
                employee.Lastlogin = employeeDB.Lastlogin.ToString("yyyy-MM-dd hh:mm:ss");
                employee.Password = employeeDB.Password;
                employee.PortalId = employeeDB.PortalId;
                employee.RoleId = employeeDB.RoleId;
                employee.StatusId = employeeDB.StatusId;
                employee.Telephone = employeeDB.Telephone;
                employee.UpdatedOn = employeeDB.UpdatedOn.HasValue ? employeeDB.UpdatedOn.Value.ToString("yyyy-MM-dd hh:mm:ss") : "";
                employee.Username = employeeDB.Username;
                return employee;
            }
            else
                return null;

           
            
        }

        public static List<Employee> GetAllEmployees(string connectionStrin)
        {
            List<Employee> employeeList = new List<Employee>();
            List<RedArborDataAccessLayer.Models.EmployeeModel> employeeDBList = DbClientFactory<EmployeeDBClient>.Instance.GetAllEmployees(connectionStrin);

            foreach(var employeeDB in employeeDBList)
            {
                Employee employee = new Employee();
                employee.CompanyId = employeeDB.CompanyId;
                employee.CreatedOn = employeeDB.CreatedOn.ToString("yyyy-MM-dd hh:mm:ss");
                employee.DeletedOn = employeeDB.DeletedOn.HasValue ? employeeDB.DeletedOn.Value.ToString("yyyy-MM-dd hh:mm:ss") : "";
                employee.Email = employeeDB.Email;
                employee.Fax = employeeDB.Fax;
                employee.Name = employeeDB.Name;
                employee.Lastlogin = employeeDB.Lastlogin.ToString("yyyy-MM-dd hh:mm:ss");
                employee.Password = employeeDB.Password;
                employee.PortalId = employeeDB.PortalId;
                employee.RoleId = employeeDB.RoleId;
                employee.StatusId = employeeDB.StatusId;
                employee.Telephone = employeeDB.Telephone;
                employee.UpdatedOn = employeeDB.UpdatedOn.HasValue ? employeeDB.UpdatedOn.Value.ToString("yyyy-MM-dd hh:mm:ss") : "";
                employee.Username = employeeDB.Username;

                employeeList.Add(employee);
            }

            return employeeList;
        }

        public static string UpdateEmployee(string connectionStrin, int id, EmployeeUpdate employee)
        {
            RedArborDataAccessLayer.Models.EmployeeModel employeeDB = new RedArborDataAccessLayer.Models.EmployeeModel();
            employeeDB.CompanyId = id;
            employeeDB.Email = employee.Email;
            employeeDB.Fax = employee.Fax;
            employeeDB.Name = employee.Name;
            employeeDB.Password = employee.Password;
            employeeDB.Telephone = employee.Telephone;
            employeeDB.Username = employee.Username;
            string data = DbClientFactory<EmployeeDBClient>.Instance.UpdateEmployee(connectionStrin, employeeDB);
            return data;
        }

        public static string DeleteEmployee(string connectionStrin, int id)
        {
            string data = DbClientFactory<EmployeeDBClient>.Instance.DeleteEmployee(connectionStrin, id);
            return data;
        }

    }
}
