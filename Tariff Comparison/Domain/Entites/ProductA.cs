using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class ProductA : Product
    {
        /// <summary>
        /// Month price for Product A
        /// </summary>
        public decimal MonthPrice { get; private set; }

        /// <summary>
        /// Price for kWh
        /// </summary>
        public decimal UnitPrice { get; private set; }

        #region Constructors
        public ProductA(string name, decimal monthPrice, decimal unitPrice) : base(name)
        {
            SetName(name);
            SetMonthPrice(monthPrice);
            SetUnitPrice(unitPrice);
        }
        #endregion

        #region Setters

        /// <summary>
        /// Set month price
        /// </summary>
        /// <param name="monthPrice">Month price</param>
        /// <exception cref="ProductException">The month price cannot be less than ZERO!</exception>
        private void SetMonthPrice(decimal monthPrice)
        {
            if (monthPrice < 0) throw new ProductException("The month price cannot be less than ZERO!");
            MonthPrice = monthPrice;
        }

        /// <summary>
        /// Set unit price
        /// </summary>
        /// <param name="unitPrice">Unit price</param>
        /// <exception cref="ProductException">The unit price cannot be less than ZERO!</exception>
        private void SetUnitPrice(decimal unitPrice)
        {
            if (unitPrice < 0) throw new ProductException("The unit price cannot be less than ZERO!");
            UnitPrice = unitPrice;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Get annual cost calculation
        /// </summary>
        /// <param name="consumption">Value of consumption</param>
        /// <returns>Decimal value for annual cost</returns>
        /// <exception cref="ProductException">The consumption cannot be less than ZERO!</exception>
        public override decimal GetAnnualCost(decimal consumption)
        {
            if(consumption < 0) throw new ProductException("The consumption cannot be less than ZERO!");

            decimal basePrice = MonthPrice * 12;//annual price 5 euro
            decimal consumptionPrice = consumption * (decimal)UnitPrice; //consumption costs 0.22 euro
            return basePrice + consumptionPrice;
        } 
        #endregion
    }
}
