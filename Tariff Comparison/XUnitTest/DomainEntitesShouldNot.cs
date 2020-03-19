using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;
using Domain.Exceptions;
using Xunit;

namespace XUnitTest
{
    public class DomainEntitesShouldNot
    {
        [Fact]
        public void ProductAWrongName()
        {
            Assert.Throws<ProductException>(() => new ProductA("", -1, 0));
        }

        [Fact]
        public void ProductAWrongMonthPrice()
        {
            Assert.Throws<ProductException>(() => new ProductA("test", -1, 0));
        }

        [Fact]
        public void ProductAWrongMUnitPrice()
        {
            Assert.Throws<ProductException>(() => new ProductA("test", 0, -1));
        }

        [Fact]
        public void ProductBWrongName()
        {
            Assert.Throws<ProductException>(() => new ProductB("",0,0,0));
        }

        [Fact]
        public void ProductBBasePrice()
        {
            Assert.Throws<ProductException>(() => new ProductB("test", -1, 0, 0));
        }

        [Fact]
        public void ProductBUnitLimit()
        {
            Assert.Throws<ProductException>(() => new ProductB("test", 0, -1, 0));
        }

        [Fact]
        public void ProductBAdditionalUnitPrice()
        {
            Assert.Throws<ProductException>(() => new ProductB("test", 0, 0, -1));
        }

        [Fact]
        public void ProductUsageWrongTariffeName()
        {
            Assert.Throws<ProductUsageException>(() => new ProductUsage("", 0));
        }

        [Fact]
        public void ProductUsageWrongAnnualCost()
        {
            Assert.Throws<ProductUsageException>(() => new ProductUsage("test", -1));
        }
    }
}
