using System;
using MES.IRespository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MES.EFCors;
using Mes.Domain.Productions;

namespace MES.Respository
{
    public class ProductionRespository : IProductionRespository
    {
        public MyDbContext _mydbcontext;
        public ProductionRespository(MyDbContext mydbcontext)
        {
            _mydbcontext=mydbcontext;
        }
        public int Add(Production production)
        {
            _mydbcontext.Add(production);
            return _mydbcontext.SaveChanges();
        }

        public List<Production> GetAll()
        {
            return _mydbcontext.Productions.ToList();
        }

        public List<ProductionsType> GetAllTypes()
        {
            return _mydbcontext.ProductionsTypes.ToList();
        }

        public List<ProductionsStatus> GetStatuses()
        {
            return _mydbcontext.ProductionsStatuses.ToList();
        }
    }
}
