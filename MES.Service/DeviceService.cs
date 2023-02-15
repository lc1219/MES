using Mes.Domain.Devices;
using MES.IRespository;
using MES.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Service
{
    public class DeviceService : IDeviceService
    {
        public IDeviceRespository _respository;
        public DeviceService(IDeviceRespository respository)
        {
            _respository = respository;
        }

        public int Add(Device devie)
        {
            return _respository.Add(devie);
        }

        public List<Device> GetAll()
        {
            return _respository.GetAll();
        }
    }
}
