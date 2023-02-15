using Mes.Domain.Productions;
using MES.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //辅助工具的新增与列表展示
    public class ProductionController : ControllerBase
    {
        public IProductionService _service;
        public ProductionController(IProductionService service)
        {
            _service = service;
        }
        //新增
        [HttpPost]
        public int Add(Production production)
        {
            return _service.Add(production);
        }
        //列表展示
        [HttpGet]
        public List<Production> GetAll()
        {
            return _service.GetAll();
        }
        [HttpGet("Types")]
        public List<ProductionsType> GetAllTypes()
        {
            return _service.GetAllTypes();
        }
        [HttpGet("Status")]

        public List<ProductionsStatus> GetStatuses()
        {
            return _service.GetStatuses();
        }
    }
}
