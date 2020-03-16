using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Domain.Entites;
using Domain.Exceptions;

namespace Domain.Entites
{
    public class Consumption
    {
        /// <summary>
        /// Cosumption Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Product
        /// </summary>
        public Product Product { get; set; }

        //public string ProductId { get; set; }

        /// <summary>
        /// Total amount of consumed energy per month
        /// </summary>
        public int ConsumedEnergy { get; set; }

        /// <summary>
        /// Total price
        /// </summary>
        public decimal TotalAmount { get; set; }

        #region Setters

        public void SetConsumedEnergy(int consumedEnergy)
        {
            if (ConsumedEnergy < 0)
            {
                throw new ConstraintException("Consumed energy can not be less then ZERO!");
            }
            ConsumedEnergy = consumedEnergy;
        }

        public void SetProduct(Product product)
        {
            if (Product == null)
            {
                throw new ConsumptionException("Product can not be null!");
            }
            Product = product;
        }

        
        #endregion

        #region Constructors

        public Consumption(Product product, int consumedEnergy)
        {
            Id = Guid.NewGuid().ToString();
            SetProduct(Product);
            SetConsumedEnergy(consumedEnergy);
        }

        #endregion
    }
}
