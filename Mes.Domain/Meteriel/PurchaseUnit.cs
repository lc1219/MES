using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Meteriel
{
    //采购单位
    [Table("purchaseUnit")]
    public class PurchaseUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
