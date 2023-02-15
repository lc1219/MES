﻿using Mes.Domain.Productions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.IService
{
    public interface IProductionService
    {
        int Add(Production production);
        List<Production> GetAll();
        List<ProductionsType> GetAllTypes();
        List<ProductionsStatus> GetStatuses();
    }
}
