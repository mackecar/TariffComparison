using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Services;
using Domain.Entites;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Xunit;

namespace XUnitTest
{
    public class ServicesShould
    {
        [Fact]
        public void CreatProductA()
        {
            ProductAService sut = new ProductAService();

            ProductA productA = sut.Create("Basic electricity tariff", 5, (decimal) 0.22);
            Assert.IsType((typeof(ProductA)), productA);
            Assert.Equal("Basic electricity tariff", productA.Name);
            Assert.Equal(5, productA.MonthPrice);
            Assert.Equal((decimal)0.22, productA.UnitPrice);
        }

        [Fact]
        public void CreateProductB()
        {
            ProductBService sut = new ProductBService();
            ProductB productB = sut.Create("Packaged tariff", 800, 4000, (decimal)0.3);

            Assert.IsType((typeof(ProductB)), productB);
            Assert.Equal("Packaged tariff", productB.Name);
            Assert.Equal(800, productB.BasePrice);
            Assert.Equal(4000, productB.UnitLimit);
            Assert.Equal((decimal)0.3, productB.AdditionalUnitPrice);
        }

        [Fact]
        public void CreateProductProductUsage()
        {
            ProductUsageService sut = new ProductUsageService();
            ProductUsage productUsage = sut.Create("test", 100);

            Assert.IsType((typeof(ProductUsage)), productUsage);
            Assert.Equal("test", productUsage.TariffeName);
            Assert.Equal(100, productUsage.AnnualCost);
        }

        [Fact]
        public void GetComparison()
        {
            ProductAService productAService = new ProductAService();
            ProductBService productBervice = new ProductBService();
            ProductUsageService productUsage = new ProductUsageService();

            ComparisonService sut = new ComparisonService(productAService,productBervice,productUsage);

            List<ProductUsage> comparison = sut.GetComparison(4500);
            Assert.IsType((typeof(List<ProductUsage>)), comparison);
            Assert.Equal("Basic electricity tariff", comparison[0].TariffeName);
            Assert.Equal("Packaged tariff", comparison[1].TariffeName);
            Assert.Equal(1050, comparison[0].AnnualCost);
            Assert.Equal(950, comparison[1].AnnualCost);
        }
    }
}
