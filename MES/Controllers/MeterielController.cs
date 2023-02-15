using Mes.Domain.Meteriel;
using MES.IService;
using MES.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //物料的新增与列表展示
    public class MeterielController : ControllerBase
    {
        public IMeterielService _service;
        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public MeterielController(IMeterielService service)
        {
            _service = service;
        }
        //新增
        [HttpPost]
        public int Add(Meteriel meteriel)
        {
            return _service.Add(meteriel);
        }
        //列表展示
        [HttpGet]
        public List<Meteriel> GetAll()
        {
            return _service.GetAll();
        }
        //修改数据
        [HttpPut]
        public int Update(Meteriel meteriel)
        {
            return _service.Update(meteriel);
        }
        //删除
        [HttpDelete]
        public int Del(int id)
        {
            return _service.Del(id);
        }
        //查询单个数据
        [HttpGet("FindId")]
        public Meteriel FindId(int id)
        {
            return _service.FindId(id);
        }
        //检验方式
        [HttpGet("CheckSystem")]
        public List<CheckSystem> GetAllCheckSystem()
        {
            return _service.GetAllCheckSystem();
        }
        //物料属性
        [HttpGet("MaterielProp")]
        public List<MaterielProperty> GetAllMaterielProperty()
        {
            return _service.GetAllMaterielProperty();
        }
        //物料分组
        [HttpGet("Packets")]
        public List<Packet> GetAllPackets()
        {
            return _service.GetAllPackets();
        }
        //采购单位
        [HttpGet("PurchaseUnits")]
        public List<PurchaseUnit> GetAllPurchaseUnits()
        {
            return _service.GetAllPurchaseUnits();
        }
        //基本单位
        [HttpGet("BasicUnits")]
        public List<BasicUnits> GetAllUnits()
        {
            return _service.GetAllUnits();
        }
    }
}
