using Mes.Domain.Productions;
using MES.IRespository;
using MES.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Service
{
    public class ProductionService : IProductionService
    {
        public IProductionRespository _respository;
        public ProductionService(IProductionRespository respository)
        {
            _respository = respository;
        }

        public int Add(Production production)
        {
            return _respository.Add(production);
        }

        public List<Production> GetAll()
        {
            return _respository.GetAll();
        }

        public List<ProductionsType> GetAllTypes()
        {
            return _respository.GetAllTypes();
        }

        public List<ProductionsStatus> GetStatuses()
        {
            return _respository.GetStatuses();
        }
    }
}
