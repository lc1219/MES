using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Meteriel
{
    //基本单位
    [Table("basicunits")]
    public class BasicUnits
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
