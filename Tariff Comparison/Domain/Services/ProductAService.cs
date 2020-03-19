using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ProductAService: IProductAService
    {
        public ProductAService() { }

        public ProductA Create(string name, decimal monthPrice, decimal unitPrice)
        {
            try
            {
                return new ProductA(name, monthPrice, unitPrice);
            }
            catch (Exception ex)
            {
                throw new ProductAServiceException($"Creating Product A is not possible! {ex.Message}");
            }
        }
    }
}
