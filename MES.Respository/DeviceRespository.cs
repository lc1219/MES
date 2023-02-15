using Mes.Domain.Devices;
using MES.EFCors;
using MES.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Respository
{
    public class DeviceRespository : IDeviceRespository
    {
        public MyDbContext _dbcontext;
        public DeviceRespository(MyDbContext dbcontext)
        {
            _dbcontext= dbcontext;
        }
        public int Add(Device device)
        {
            _dbcontext.Add(device);
            return _dbcontext.SaveChanges();
        }

        public List<Device> GetAll()
        {
            return _dbcontext.Devices.ToList();
        }

    }
}
