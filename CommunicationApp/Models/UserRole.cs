using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunicationApp.Models
{
    public class UserRole
    {
        public List<Person> Admins { get; set; }
        public List<Person> Users { get; set; }

        [Display(Name = "Roll")]
        public string RoleName { get; set; }
        public string Person { get; set; }
    }
}