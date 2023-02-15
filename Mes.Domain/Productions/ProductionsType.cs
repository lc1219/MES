using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Productions
{
    [Table("productionsType")]
    public class ProductionsType
    {
        public int Id { get; set; } 
        public string ProductionsTypeName { get; set; }
    }
}
