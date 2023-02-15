using Mes.Domain.Meteriel;
using MES.EFCors;
using MES.IRespository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Respository
{
    public class MeterielRespository : IMeterielRespository
    {
        public MyDbContext _dbcontext;
        public MeterielRespository(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public int Add(Meteriel meteriel)
        {
            _dbcontext.Add(meteriel);
            return _dbcontext.SaveChanges();
        }

        public int Del(int id)
        {
            _dbcontext.Meteriels.Remove(FindId(id));

            return _dbcontext.SaveChanges();
        }

        public Meteriel FindId(int id)
        {
            return _dbcontext.Meteriels.Find(id);
        }

        public List<Meteriel> GetAll()
        {
            return _dbcontext.Meteriels.ToList();
        }

        public List<CheckSystem> GetAllCheckSystem()
        {
            return _dbcontext.CheckSystems.ToList();
        }

        public List<MaterielProperty> GetAllMaterielProperty()
        {
            return _dbcontext.MaterielProperties.ToList();
        }

        public List<Packet> GetAllPackets()
        {
            return _dbcontext.Packets.ToList();
        }

        public List<PurchaseUnit> GetAllPurchaseUnits()
        {
            return _dbcontext.PurchaseUnits.ToList();
        }

        public List<BasicUnits> GetAllUnits()
        {
            return _dbcontext.BasicUnits.ToList();
        }

        public int Update(Meteriel meteriel)
        {
            _dbcontext.Entry(meteriel).State = EntityState.Modified;
            return _dbcontext.SaveChanges();
        }
    }
}
