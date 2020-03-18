using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.ServiceIntefaces;
using Domain.Entites;

namespace ApplicationCore.Services
{
    public class ComparationService : IComparationService
    {
        private readonly IProductAService _productAService;
        private readonly IProductBService _productBService;
        private readonly IProductUsageService _productUsageService;

        public ComparationService(IProductAService productAService,
            IProductBService productBService,
            IProductUsageService productUsageService)
        {
            _productAService = productAService;
            _productBService = productBService;
            _productUsageService = productUsageService;
        }

        public List<ProductUsage> GetComparation(decimal consumption)
        {
            ProductA productA = _productAService.Create("basic electricity tariff", 5, (decimal) 0.22);
            ProductB productB = _productBService.Create("Packaged tariff", 800, 4000, (decimal) 0.3);

            ProductUsage productAUsage = _productUsageService.Create(productA.Name, productA.GetAnnualCost(consumption));
            ProductUsage productBUsage = _productUsageService.Create(productB.Name,productB.GetAnnualCost(consumption));

            return new List<ProductUsage>(){productAUsage,productBUsage};
        }
    }
}
