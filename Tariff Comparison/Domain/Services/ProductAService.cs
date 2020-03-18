using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ProductAService: IProductAService
    {
        public ProductAService() { }
        
        public ProductA Create(string name, decimal monthPrice, decimal unitPrice)
        {
            return new ProductA(name,monthPrice,unitPrice);
        }
    }
}
