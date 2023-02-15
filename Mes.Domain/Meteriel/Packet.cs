using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Meteriel
{
    //物料分组
    [Table("packet")]
    public class Packet
    {
        [Key]
        public int Id { get; set; }
        public string? PacketName { get; set; }
    }
}
