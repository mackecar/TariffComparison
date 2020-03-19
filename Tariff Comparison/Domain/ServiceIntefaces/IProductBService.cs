using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductBService
    {
        /// <summary>
        /// Creat Product B
        /// </summary>
        /// <param name="name">Product name</param>
        /// <param name="basePrice">Base month price</param>
        /// <param name="unitLimit">Limit for calculation</param>
        /// <param name="additionalUnitPrice">Additional unit price if consumation is over limit</param>
        /// <returns>ProductB</returns>
        /// <exception cref="ProductBServiceException">Creating Product B is not possible!</exception>
        ProductB Create(string name, decimal basePrice, int unitLimit, decimal additionalUnitPrice);
    }
}
