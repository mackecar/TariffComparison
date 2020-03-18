using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductAService
    {
        ProductA Create(string name, decimal monthPrice, decimal unitPrice);
    }
}
