using System;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class Product
    {
        /// <summary>
        /// Product Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Base price per month
        /// </summary>
        public decimal BasePrice { get; private set; }

        /// <summary>
        /// Consumption costs per month in cents per kWh
        /// </summary>
        public decimal ConsumptionPrice { get; private set; }

        #region Setters

        /// <summary>
        /// Set name for the product
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ProductException("The product name is empty!");
            }

            Name = name;
        }

        /// <summary>
        /// Set base price for the product
        /// </summary>
        /// <param name="basePrice"></param>
        public void SetBasePrice(decimal basePrice)
        {
            if (basePrice < 0)
            {
                throw new ProductException("Base price can not be less then ZERO!");
            }

            BasePrice = basePrice;
        }

        public void SetConsumptionPrice(decimal consumptionPrice)
        {
            if (consumptionPrice < 0)
            {
                throw new ProductException("Consumption price can not be less then ZERO!");
            }

            ConsumptionPrice = consumptionPrice;
        }

        #endregion

        #region Constructors
        public Product(string name, decimal basePrice, decimal consumptionPrice)
        {
            Id = Guid.NewGuid().ToString();
            SetName(name);
            SetBasePrice(basePrice);
            SetConsumptionPrice(consumptionPrice);
        } 
        #endregion
    }
}
