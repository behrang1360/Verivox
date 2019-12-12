using System;
using System.Collections.Generic;
using TariffComparisonApi.Dtos;
using System.Linq;

namespace TariffComparisonApi.Services
{
    public class ProductService : IProductService
    {
        public List<ProductDto> GetProductList(float consumption)
        {

            List<ProductDto> results = new List<ProductDto>();

            BasicTariff basicTariff = new BasicTariff();
            basicTariff.Name = "Basic electricity tariff";
            var basicTariff_annualCost = basicTariff.Calculate(consumption);

            results.Add(new ProductDto { TariffName = basicTariff.Name, AnnualCost = basicTariff_annualCost });

            PackageTariff packageTariff = new PackageTariff();
            packageTariff.Name = "Packaged tariff";
            var packageTariff_annualCost = packageTariff.Calculate(consumption);

            results.Add(new ProductDto { TariffName = packageTariff.Name, AnnualCost = packageTariff_annualCost });

            return results.OrderBy(c => c.AnnualCost).ToList();
        }
    }
}
