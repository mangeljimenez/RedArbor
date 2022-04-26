using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RedArborWEBAPI.Models
{
    [DataContract]
    public class Employee
    {
        [DataMember(Name = "CompanyId")]
        public int CompanyId { get; set; }

        [DataMember(Name = "CreatedOn")]
        public string CreatedOn { get; set; }

        [DataMember(Name = "DeletedOn")]
        public string DeletedOn { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "Fax")]
        public string Fax { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Lastlogin")]
        public string Lastlogin { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "PortalId")]
        public int PortalId { get; set; }

        [DataMember(Name = "RoleId")]
        public int RoleId { get; set; }

        [DataMember(Name = "StatusId")]
        public int StatusId { get; set; }

        [DataMember(Name = "Telephone")]
        public string Telephone { get; set; }

        [DataMember(Name = "UpdatedOn")]
        public string UpdatedOn { get; set; }

        [DataMember(Name = "Username")]
        public string Username { get; set; }
    }
}
