using Mes.Domain.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.IService
{
    public interface IDeviceService
    {
        int Add(Device devie);
        List<Device> GetAll();
    }
}
