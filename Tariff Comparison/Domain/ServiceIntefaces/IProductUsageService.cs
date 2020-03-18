using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductUsageService
    {
        ProductUsage Create(string tariffeName, decimal annualCost);
    }
}
