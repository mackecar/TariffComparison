using System;
using Domain.Exceptions;

namespace Domain.Entites
{
    public abstract class Product
    {
        /// <summary>
        /// Product Id
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Annual cost of prodcut
        /// </summary>
        public decimal AnnualCost { get; private set; }


        #region Setters

        /// <summary>
        /// Set name for the product
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ProductException("The product name is empty!");

            Name = name;
        }

        public void SetAnnualCost(decimal annualCost)
        {
            if(annualCost < 0 ) throw new ProductException("Annual cost can not be less than ZERO!");
            AnnualCost = annualCost;
        }

        #endregion

        #region Constructors
        public Product(string name, decimal annualCost)
        {
            Id = Guid.NewGuid().ToString();
            SetName(name);
            SetAnnualCost(annualCost);
        } 
        #endregion
    }
}
