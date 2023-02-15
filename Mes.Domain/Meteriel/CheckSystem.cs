using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Meteriel
{
    //检测方式
    [Table("checkSystem")]
    public class CheckSystem
    {
        [Key]
        public int Id { get; set; }
        public string? CheckSystemName { get; set; }
    }
}
