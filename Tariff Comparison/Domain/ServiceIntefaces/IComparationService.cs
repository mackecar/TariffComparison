using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IComparationService
    {
        List<ProductUsage> GetComparation(decimal consumption);
    }
}
