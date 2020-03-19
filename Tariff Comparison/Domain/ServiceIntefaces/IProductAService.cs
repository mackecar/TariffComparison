using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductAService
    {
        /// <summary>
        /// Create Product A
        /// </summary>
        /// <param name="name">Product name</param>
        /// <param name="monthPrice">Month price</param>
        /// <param name="unitPrice">Unit price</param>
        /// <returns>Product A</returns>
        /// <exception cref="ProductAServiceException">Creating Product A is not possible!</exception>
        ProductA Create(string name, decimal monthPrice, decimal unitPrice);
    }
}
