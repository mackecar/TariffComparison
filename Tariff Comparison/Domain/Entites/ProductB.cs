using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class ProductB : Product
    {
        public decimal BasePrice { get; private set; }
        public int UnitLimit { get; private set; }
        public decimal AdditionalUnitPrice { get; private set; }

        public ProductB(string name, decimal basePrice,int unitLimit, decimal additionalUnitPrice) : base(name)
        {
            SetName(name);
            SetBasePrice(basePrice);
            SetUnitLimit(unitLimit);
            SetBAdditionalUnitPrice(additionalUnitPrice);
        }

        public void SetBasePrice(decimal basePrice)
        {
            if(basePrice < 0) throw new ProductException("The base price cannot be less than ZERO!");
            BasePrice = basePrice;
        }

        public void SetUnitLimit(int unitLimit)
        {
            if (unitLimit < 0) throw new ProductException("The unit limit cannot be less than ZERO!");
            UnitLimit = unitLimit;
        }

        public void SetBAdditionalUnitPrice(decimal additionalUnitPrice)
        {
            if (additionalUnitPrice < 0) throw new ProductException("The additional unit price cannot be less than ZERO!");
            AdditionalUnitPrice = additionalUnitPrice;
        }

        public override decimal GetAnnualCost(decimal consumption)
        {
            if (consumption <= UnitLimit)
            {
                return BasePrice;
            }

            decimal additionalCost = (consumption - UnitLimit) * AdditionalUnitPrice;
            return BasePrice + additionalCost;
        }
    }
}
