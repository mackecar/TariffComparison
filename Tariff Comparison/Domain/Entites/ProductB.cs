using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class ProductB : Product
    {
        /// <summary>
        /// Base price for product
        /// </summary>
        public decimal BasePrice { get; private set; }

        /// <summary>
        /// Limit for annual calculation logic
        /// </summary>
        public int UnitLimit { get; private set; }

        /// <summary>
        /// Additional price per unit over limit
        /// </summary>
        public decimal AdditionalUnitPrice { get; private set; }

        #region Constructor
        public ProductB(string name, decimal basePrice, int unitLimit, decimal additionalUnitPrice) : base(name)
        {
            SetName(name);
            SetBasePrice(basePrice);
            SetUnitLimit(unitLimit);
            SetBAdditionalUnitPrice(additionalUnitPrice);
        }
        #endregion

        #region Setters

        /// <summary>
        /// Set base price
        /// </summary>
        /// <param name="basePrice">Base price</param>
        /// <exception cref="ProductException">The base price cannot be less than ZERO!</exception>
        private void SetBasePrice(decimal basePrice)
        {
            if (basePrice < 0) throw new ProductException("The base price cannot be less than ZERO!");
            BasePrice = basePrice;
        }

        /// <summary>
        /// Set unit limit
        /// </summary>
        /// <param name="unitLimit">Unit limit</param>
        /// <exception cref="ProductException">The unit limit cannot be less than ZERO!</exception>
        private void SetUnitLimit(int unitLimit)
        {
            if (unitLimit < 0) throw new ProductException("The unit limit cannot be less than ZERO!");
            UnitLimit = unitLimit;
        }

        /// <summary>
        /// Set additional unit price
        /// </summary>
        /// <param name="additionalUnitPrice">Additional unit price</param>
        /// <exception cref="ProductException">The additional unit price cannot be less than ZERO!</exception>
        private void SetBAdditionalUnitPrice(decimal additionalUnitPrice)
        {
            if (additionalUnitPrice < 0) throw new ProductException("The additional unit price cannot be less than ZERO!");
            AdditionalUnitPrice = additionalUnitPrice;
        }
        #endregion

        #region Methos
        /// <summary>
        /// Get annual cost calculation
        /// </summary>
        /// <param name="consumption">Value of consumption</param>
        /// <returns>Decimal value for annual cost</returns>
        public override decimal GetAnnualCost(decimal consumption)
        {
            if (consumption <= UnitLimit)
            {
                return BasePrice;
            }

            decimal additionalCost = (consumption - UnitLimit) * AdditionalUnitPrice;
            return BasePrice + additionalCost;
        } 
        #endregion
    }
}
