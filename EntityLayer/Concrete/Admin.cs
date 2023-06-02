using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key] 
        public int AdminId { get; set; }

        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
        public string AdminNameSurname { get; set; }
        public string AdminEmail { get; set; }
        public Int32 AdminContact { get; set; }
        public string AdminImageUrl { get; set; }
    }
}
