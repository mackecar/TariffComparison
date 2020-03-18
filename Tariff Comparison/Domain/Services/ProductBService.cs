using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ProductBService : IProductBService
    {
        public ProductBService() { }

        public ProductB Create(string name, decimal basePrice, int unitLimit, decimal additionalUnitPrice)
        {
            return new ProductB(name,basePrice,unitLimit,additionalUnitPrice);
        }
    }
}
