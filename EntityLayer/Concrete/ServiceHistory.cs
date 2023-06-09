using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServiceHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool ServisStatus { get; set; } = true;
        public string ServicePriority { get; set; }
        public string DeviceStatus { get; set; }
        public string ServiceWorker { get; set; }
        public DateTime DeviceDateEntry { get; set; }
        public DateTime DeviceDeliverEntry { get; set; }
        public bool ServiceDelayStatus { get; set; }
        public string DeviceServiceReason { get; set; }
        public string DeviceChangingParts { get; set; }
        public int? DeviceProcessingTime { get; set; }


        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        public int ComputerId { get; set; }
        
    }
}
