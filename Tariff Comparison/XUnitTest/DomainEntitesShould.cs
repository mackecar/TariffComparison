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
            ProductA sut = new ProductA("test",100,(decimal)0.2);
            
            Assert.IsType((typeof(ProductA)),sut);
            Assert.Equal("test",sut.Name);
            Assert.Equal(100,sut.MonthPrice);
            Assert.Equal((decimal)0.2, sut.UnitPrice);
        }

        [Fact]
        public void CreateProductB()
        {
            ProductB sut = new ProductB("test",200,50,(decimal)0.2);

            Assert.IsType((typeof(ProductB)), sut);
            Assert.Equal("test", sut.Name);
            Assert.Equal(200, sut.BasePrice);
            Assert.Equal(50, sut.UnitLimit);
            Assert.Equal((decimal)0.2, sut.AdditionalUnitPrice);
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
