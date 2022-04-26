using RedArborDataAccessLayer.Models;
using RedArborDataAccessLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedArborDataAccessLayer.Mapping
{
    public static class EmployeeMapping
    {
        public static EmployeeModel TranslateAsEmployee(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new EmployeeModel();
            if (reader.IsColumnExists("CompanyId"))
                item.CompanyId = SqlHelper.GetNullableInt32(reader, "CompanyId");

            if (reader.IsColumnExists("CreatedOn"))
                item.CreatedOn = SqlHelper.GetNullableDateTime(reader, "CreatedOn");

            if (reader.IsColumnExists("DeletedOn"))
                item.DeletedOn = SqlHelper.GetNullableDateTime(reader, "DeletedOn");

            if (reader.IsColumnExists("Email"))
                item.Email = SqlHelper.GetNullableString(reader, "Email");

            if (reader.IsColumnExists("Fax"))
                item.Fax = SqlHelper.GetNullableString(reader, "Fax");

            if (reader.IsColumnExists("Name"))
                item.Name = SqlHelper.GetNullableString(reader, "Name");

            if (reader.IsColumnExists("Lastlogin"))
                item.Lastlogin = SqlHelper.GetNullableDateTime(reader, "Lastlogin");

            if (reader.IsColumnExists("Password"))
                item.Password = SqlHelper.GetNullableString(reader, "Password");

            if (reader.IsColumnExists("PortalId"))
                item.PortalId = SqlHelper.GetNullableInt32(reader, "PortalId");

            if (reader.IsColumnExists("RoleId"))
                item.RoleId = SqlHelper.GetNullableInt32(reader, "RoleId");

            if (reader.IsColumnExists("StatusId"))
                item.StatusId = SqlHelper.GetNullableInt32(reader, "StatusId");

            if (reader.IsColumnExists("Telephone"))
                item.Telephone = SqlHelper.GetNullableString(reader, "Telephone");

            if (reader.IsColumnExists("UpdatedOn"))
                item.UpdatedOn = SqlHelper.GetNullableDateTime(reader, "UpdatedOn");

            if (reader.IsColumnExists("Username"))
                item.Username = SqlHelper.GetNullableString(reader, "Username");

            return item;
        }

        public static List<EmployeeModel> TranslateAsEmployeesList(this SqlDataReader reader)
        {
            var list = new List<EmployeeModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsEmployee(reader, true));
            }
            return list;
        }

    }
}
