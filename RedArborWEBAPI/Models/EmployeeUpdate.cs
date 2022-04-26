using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RedArborWEBAPI.Models
{
    [DataContract]
    public class EmployeeUpdate
    {
        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "Fax")]
        public string Fax { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "Telephone")]
        public string Telephone { get; set; }

        [DataMember(Name = "Username")]
        public string Username { get; set; }    
    }
}
