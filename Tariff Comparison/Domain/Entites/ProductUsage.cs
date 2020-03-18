using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class ProductUsage
    {
        public string TariffeName { get; private set; }
        public decimal AnnualCost { get; private set; }

        public ProductUsage(string tariffeName, decimal annualCost)
        {
            SetTariffeName(tariffeName);
            SetAnnualCost(annualCost);
        }

        public void SetTariffeName(string tariffeName)
        {
            if(string.IsNullOrEmpty(tariffeName)) throw new ProductUsageException("The tariffe name cannot be empty!");
            TariffeName = tariffeName;
        }

        public void SetAnnualCost(decimal annualCost)
        {
            if(annualCost < 0) throw new ProductUsageException("Annual cost cannot be less than ZERO!");
            AnnualCost = annualCost;
        }

    }
}
