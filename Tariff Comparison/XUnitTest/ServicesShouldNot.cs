using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Exceptions;
using ApplicationCore.Services;
using Domain.Entites;
using Xunit;

namespace XUnitTest
{
    public class ServicesShouldNot
    {
        [Fact]
        public void CannotCreatProductA()
        {
            ProductAService sut = new ProductAService();

            Assert.Throws<ProductAServiceException>(() => sut.Create("test", -1, 0));
        }

        [Fact]
        public void CannotCreatProductB()
        {
            ProductBService sut = new ProductBService();

            Assert.Throws<ProductBServiceException>(() => sut.Create("", 800, 4000, (decimal)0.3));
        }

        [Fact]
        public void CannotCreatProductUsage()
        {
            ProductUsageService sut = new ProductUsageService();

            Assert.Throws<ProductUsageServiceException>(() => sut.Create("", 100));
        }

        [Fact]
        public void CannotGetComparison()
        {
            ProductAService productAService = new ProductAService();
            ProductBService productBervice = new ProductBService();
            ProductUsageService productUsage = new ProductUsageService();

            ComparisonService sut = new ComparisonService(productAService, productBervice, productUsage);

            Assert.Throws<ComparisonServiceException>(() => sut.GetComparison(-1));
        }
    }
}
