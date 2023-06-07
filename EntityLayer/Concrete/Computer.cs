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
    public class Computer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComputerId { get; set; }

        public string ComputerBrand { get; set; }
        public string ComputerSerialNo { get; set; }
        public int ComputerYearOfProduction { get; set; }
        public string OperatingSystem { get; set; }
        public int Ram { get; set; }
        public string CPU { get; set; }
        public string GraphicCard { get; set; }

        public Personal Personal { get; set; }
        public List<Service> Services { get; set; }
    }
}
