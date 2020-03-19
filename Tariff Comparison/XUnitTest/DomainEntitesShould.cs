using System;
using Domain.Entites;
using Xunit;

namespace XUnitTest
{
    public class DomainEntitesShould
    {
        [Fact]
        public void CreateProductA()
        {
            ProductA sut = new ProductA("Basic electricity tariff", 5, (decimal)0.22);
            
            Assert.IsType((typeof(ProductA)),sut);
            Assert.Equal("Basic electricity tariff", sut.Name);
            Assert.Equal(5,sut.MonthPrice);
            Assert.Equal((decimal)0.22, sut.UnitPrice);
        }

        [Fact]
        public void CreateProductB()
        {
            ProductB sut = new ProductB("Packaged tariff", 800, 4000, (decimal)0.3);

            Assert.IsType((typeof(ProductB)), sut);
            Assert.Equal("Packaged tariff", sut.Name);
            Assert.Equal(800, sut.BasePrice);
            Assert.Equal(4000, sut.UnitLimit);
            Assert.Equal((decimal)0.3, sut.AdditionalUnitPrice);
        }

        [Fact]
        public void CreateProductProductUsage()
        {
            ProductUsage sut = new ProductUsage("test",100);

            Assert.IsType((typeof(ProductUsage)), sut);
            Assert.Equal("test", sut.TariffeName);
            Assert.Equal(100, sut.AnnualCost);
        }
    }
}
