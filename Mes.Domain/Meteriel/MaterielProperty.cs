using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Meteriel
{
    //物料属性
    [Table("materielProperty")]
    public class MaterielProperty
    {
        [Key]
        public int Id { get; set; }
        public string? MaterielPropertyName { get; set; }
    }
}
