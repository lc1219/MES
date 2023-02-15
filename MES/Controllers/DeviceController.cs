using Mes.Domain.Devices;
using MES.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //设备的新增与列表展示
    public class DeviceController : ControllerBase
    {
        public IDeviceService _service;
        public DeviceController(IDeviceService service)
        {
            _service = service;
        }
        //新增
        [HttpPost]
        public int Add(Device device)
        {
            return _service.Add(device);
        }
        //列表展示
        [HttpGet]
        public List<Device> GetAll()
        {
            return _service.GetAll();
        }
    }
}
