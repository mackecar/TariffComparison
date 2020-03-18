using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ProductUsageService : IProductUsageService
    { 
        public ProductUsageService() { }

        public ProductUsage Create(string tariffeName, decimal annualCost)
        {
            return new ProductUsage(tariffeName,annualCost);
        }
    }
}
