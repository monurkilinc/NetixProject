using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServiceHistory
    {
        [Key]
        public int ServiceHisId { get; set; }
        
        public string DeviceStatus { get; set; }
        public string ServiceWorker { get; set; }
        public DateTime DeviceDateEntry { get; set; }
        public DateTime DeviceDeliverEntry { get; set; }
        public bool ServiceDelayStatus { get; set; }
        public string DeviceServiceReason { get; set; }
        public string DeviceChangingParts { get; set; }
        public int? DeviceProcessingTime { get; set; }

        public string PersonalNameSurname; 
        public Personal Personal { get; set; }

        public int ServiceId;
        public Service Service { get; set; }
    }
}
