using EntityLayer.Concrete;

namespace NetixProject1.Models
{
    public class ComputerPersonalViewModel
    {
        public Computer? Computer { get; set; }
        public Personal? Personal { get; set; }
        public Service? Service { get; set; }
        public int ComputerId { get; set; }
        public ICollection<Computer>? Computers { get; set; }
        public ICollection<Personal>? Personals { get; set; }
        public ICollection<Service>? Services { get; set; }
        public ICollection<ServiceHistory>? ServiceHistories { get; set; }
        public ICollection<ServiceHistory>? DeletedServices { get; set; } 
    }
}

