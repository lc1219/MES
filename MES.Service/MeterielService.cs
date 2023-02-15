using Mes.Domain.Meteriel;
using MES.IRespository;
using MES.IService;
using MES.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Service
{
    public class MeterielService : IMeterielService
    {
        public IMeterielRespository _respository;
        public MeterielService(IMeterielRespository respository)
        {
            _respository = respository;
        }

        public int Add(Meteriel meteriel)
        {
           return _respository.Add(meteriel);
        }

        public int Del(int id)
        {
            return _respository.Del(id);
        }

        public Meteriel FindId(int id)
        {
            return _respository.FindId(id);
        }

        public List<Meteriel> GetAll()
        {
            return _respository.GetAll();
        }

        public List<CheckSystem> GetAllCheckSystem()
        {
            return _respository.GetAllCheckSystem();
        }

        public List<MaterielProperty> GetAllMaterielProperty()
        {
            return _respository.GetAllMaterielProperty();
        }

        public List<Packet> GetAllPackets()
        {
            return _respository.GetAllPackets();
        }

        public List<PurchaseUnit> GetAllPurchaseUnits()
        {
            return _respository.GetAllPurchaseUnits();
        }

        public List<BasicUnits> GetAllUnits()
        {
            return _respository.GetAllUnits();
        }

        public int Update(Meteriel meteriel)
        {
            return _respository.Update(meteriel);
        }
    }
}
