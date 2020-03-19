using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ProductBService : IProductBService
    {
        public ProductBService() { }

        
        public ProductB Create(string name, decimal basePrice, int unitLimit, decimal additionalUnitPrice)
        {
            try
            {
                return new ProductB(name, basePrice, unitLimit, additionalUnitPrice);
            }
            catch (Exception ex)
            {
                throw new ProductBServiceException($"Creating Product B is not possible! {ex.Message}");
            }
        }
    }
}
