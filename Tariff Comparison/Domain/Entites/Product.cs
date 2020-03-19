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

        #region Constructors

        protected Product(string name)
        {
            Id = Guid.NewGuid().ToString();
            SetName(name);
        }

        #endregion

        #region Setters

        /// <summary>
        /// Set name for the product
        /// </summary>
        /// <param name="name"></param>
        protected void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ProductException("The product name is empty!");

            Name = name;
        }

        #endregion

        #region Methods

        public abstract decimal GetAnnualCost(decimal consumption);

        #endregion
    }
}
