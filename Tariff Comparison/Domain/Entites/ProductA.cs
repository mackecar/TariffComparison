using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class ProductA : Product
    {
        public decimal MonthPrice { get; private set; }
        public decimal UnitPrice { get; private set; }

        public ProductA(string name,decimal monthPrice, decimal unitPrice) : base(name)
        {
            SetName(name);
            SetMonthPrice(monthPrice);
            SetUnitPrice(unitPrice);
        }

        public void SetMonthPrice(decimal monthPrice)
        {
            if(monthPrice < 0) throw new ProductException("The month price cannot be less than ZERO!");
            MonthPrice = monthPrice;
        }

        public void SetUnitPrice(decimal unitPrice)
        {
            if (unitPrice < 0) throw new ProductException("The unit price cannot be less than ZERO!");
            UnitPrice = unitPrice;
        }

        public override decimal GetAnnualCost(int consumption)
        {
            decimal basePrice = MonthPrice * 12;//annual price 5 euro
            decimal consumptionPrice = consumption * (decimal) UnitPrice; //consumption costs 0.22 euro
            return basePrice+consumptionPrice;
        }
    }
}
