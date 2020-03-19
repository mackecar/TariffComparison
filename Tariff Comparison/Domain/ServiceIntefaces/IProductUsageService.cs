using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IProductUsageService
    {
        /// <summary>
        /// Creat product usage for comparison
        /// </summary>
        /// <param name="tariffeName">Tariffe name</param>
        /// <param name="annualCost">Annual cost</param>
        /// <returns>Product usage</returns>
        /// <exception cref="ProductUsageServiceException">Creating Product Usage is not possible!</exception>
        ProductUsage Create(string tariffeName, decimal annualCost);
    }
}
