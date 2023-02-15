using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Productions
{
    [Table("production")]
    public class Production
    {
        [Key]
        public int Id { get; set; }
        //模治具代码
        public string? CodeOfDieFixture { get; set; }
        //模治具名称
        public string? NameOfTheFixture { get; set; }
        //类别
        public int ProductionsTypeId { get; set; }
        //分组
        public string? Packet { get; set; }
        //规格型号
        public string? Specifications { get; set; }
        //模具状态
        public int ProductionsStatusId { get; set; }
        //工装类型
        public string? ToolingType { get; set; }
        //组织
        public string? Organization { get; set; }
        //备注
        public string? Remarks { get; set; }
    }
}
