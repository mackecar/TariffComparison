using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductBService
    {
        ProductB Create(string name, decimal basePrice, int unitLimit, decimal additionalUnitPrice);
    }
}
