using Mes.Domain.Meteriel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.IService
{
    public interface IMeterielService
    {
        int Add(Meteriel meteriel);
        List<Meteriel> GetAll();
        List<BasicUnits> GetAllUnits();
        List<CheckSystem> GetAllCheckSystem();
        List<MaterielProperty> GetAllMaterielProperty();
        List<Packet> GetAllPackets();
        List<PurchaseUnit> GetAllPurchaseUnits();
        Meteriel FindId(int id);
        int Update(Meteriel meteriel);
        int Del(int id);
    }
}
