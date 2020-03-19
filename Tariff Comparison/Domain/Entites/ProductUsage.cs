using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class ProductUsage
    {
        /// <summary>
        /// Tariffe name
        /// </summary>
        public string TariffeName { get; private set; }

        /// <summary>
        /// Annual cost
        /// </summary>
        public decimal AnnualCost { get; private set; }

        #region Constructor

        public ProductUsage(string tariffeName, decimal annualCost)
        {
            SetTariffeName(tariffeName);
            SetAnnualCost(annualCost);
        }
        #endregion

        #region Setters

        /// <summary>
        /// Set tarrife name
        /// </summary>
        /// <param name="tariffeName">Tariffe name</param>
        /// <exception cref="ProductUsageException">The tariffe name cannot be empty!</exception>
        private void SetTariffeName(string tariffeName)
        {
            if (string.IsNullOrEmpty(tariffeName)) throw new ProductUsageException("The tariffe name cannot be empty!");
            TariffeName = tariffeName;
        }

        /// <summary>
        /// Set annual cost
        /// </summary>
        /// <param name="annualCost">Annual cost</param>
        /// <exception cref="ProductUsageException">Annual cost cannot be less than ZERO!</exception>
        private void SetAnnualCost(decimal annualCost)
        {
            if (annualCost < 0) throw new ProductUsageException("Annual cost cannot be less than ZERO!");
            AnnualCost = annualCost;
        } 
        #endregion

    }
}
