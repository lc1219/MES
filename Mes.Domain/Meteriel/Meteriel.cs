using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Domain.Meteriel
{
    [Table("meteriel")]
    public class Meteriel
    {
        [Column("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        public int MaterialId { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string? MaterielName { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string? Specifications { get; set; }
        /// <summary>
        /// 默认仓库
        /// </summary>
        public string? DefaultDepot { get; set; }
        /// <summary>
        /// 默认仓位
        /// </summary>
        public string? DefaultPositions { get; set; }
        /// <summary>
        /// 物料类别
        /// </summary>
        public string? MaterielType { get; set; }
        /// <summary>
        /// 单位组
        /// </summary>
        public string? UnitGroup { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 物料分组
        /// </summary>
        public int PacketId { get; set; }
        /// <summary>
        /// 使用组织
        /// </summary>
        public string? Useorganization { get; set; }
        /// <summary>
        /// 物料属性
        /// </summary>
        public int MaterielPropertyId { get; set; }
        /// <summary>
        /// 检验方式
        /// </summary>
        public int CheckSystemId { get; set; }
        /// <summary>
        /// 基本单位
        /// </summary>
        public int BasicUnitsId { get; set; }
        /// <summary>
        /// 采购单位
        /// </summary>
        public string? PurchaseUnitId { get; set; }
        /// <summary>
        /// 销售单位
        /// </summary>
        public string? MarketingUnit { get; set; }
        /// <summary>
        /// 库存单位
        /// </summary>
        public string? StockKeepingUnit { get; set; }
        /// <summary>
        /// 最小包装量
        /// </summary>
        public int MinPackage { get; set; }
        /// <summary>
        /// 图号
        /// </summary>
        public int DrawingNumber { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string? UnitPrice { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public string? Taxrate { get; set; }
        /// <summary>
        /// 最大库存量
        /// </summary>
        public string? MaximumInventory { get; set; }
        /// <summary>
        /// 安全库存量
        /// </summary>
        public string? SafetyStock { get; set; }
        /// <summary>
        /// 最低库存量
        /// </summary>
        public string? MinimumQuantity { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public string? GrossWeight { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public int Net { get; set; }
        /// <summary>
        /// 启用序列号
        /// </summary>
        public string? EnableSequenceNumber { get; set; }
        /// <summary>
        /// 第三方序列号
        /// </summary>
        public string? ThirdPartySerialNumber { get; set; }
        /// <summary>
        /// 终检
        /// </summary>
        public string? FinalInspection { get; set; }
        /// <summary>
        /// 不投料
        /// </summary>
        public string? NoFeeding { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string? Image { get; set; }
        /// <summary>
        /// 物料维度
        /// </summary>
        public string? Nimikedimensio { get; set; }
    }
}
