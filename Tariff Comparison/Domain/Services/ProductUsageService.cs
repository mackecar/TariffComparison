using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ProductUsageService : IProductUsageService
    { 
        public ProductUsageService() { }

        public ProductUsage Create(string tariffeName, decimal annualCost)
        {
            try
            {
                return new ProductUsage(tariffeName, annualCost);
            }
            catch (Exception ex)
            {
                throw new ProductUsageServiceException($"Creating Product Usage is not possible! {ex.Message}");
            }
        }
    }
}
