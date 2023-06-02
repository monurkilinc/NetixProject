using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Personal
    {
        [Key]
        public int PersonalId { get; set; }

        public string PersonalNameSurname { get; set; }
        public string PersonalDepartment { get; set; }
        public string PersonalGender { get; set; }
        public int PersonalAge { get; set; }
        public string PersonalMail { get; set; }
        public Int64 PersonalCellPhoneNumber { get; set; }

        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        
    }
}
