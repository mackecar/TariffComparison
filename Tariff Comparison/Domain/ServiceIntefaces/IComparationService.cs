using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using Domain.Entites;

namespace ApplicationCore.ServiceIntefaces
{
    public interface IComparationService
    {
        /// <summary>
        /// Get comparison products A and B
        /// </summary>
        /// <param name="consumption">Consumption</param>
        /// <returns>List of Product Usages</returns>
        /// <exception cref="ComparisonServiceException">Getting comparison is not possible!</exception>
        List<ProductUsage> GetComparison(decimal consumption);
    }
}
