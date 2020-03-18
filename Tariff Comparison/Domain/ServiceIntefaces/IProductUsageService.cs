using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductUsageService
    {
        ProductUsage Create(decimal consumption, string tariffeName, decimal annualCost);
    }
}
