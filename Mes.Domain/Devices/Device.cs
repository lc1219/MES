using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Devices
{
    [Table("device")]
    public class Device
    {
        public int Id { get; set; }
        public string? DeviceCode { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceGrouping { get; set; }
        public string? DeviceClasses { get; set; }
        public int DeviceStatus { get; set; }
        public DateTime StartDate { get; set; }
        public string? Organization { get; set; }
        public string? Remarks { get; set; }
    }
}
