using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Productions
{
    [Table("productionsStatus")]
    public class ProductionsStatus
    {
        public int Id { get; set; }
        public string ProductionsStatusName { get; set; }
    }
}
