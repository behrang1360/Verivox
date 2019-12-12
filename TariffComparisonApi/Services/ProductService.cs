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

            BasicTarrif basicTarrif = new BasicTarrif();
            basicTarrif.Name = "Basic electricity tariff";
            var basicTarrif_annualCost = basicTarrif.Calculate(consumption);

            results.Add(new ProductDto { TarrifName = basicTarrif.Name, AnnualCost = basicTarrif_annualCost });

            PackageTarrif packageTarrif = new PackageTarrif();
            packageTarrif.Name = "Packaged tariff";
            var packageTarrif_annualCost = packageTarrif.Calculate(consumption);

            results.Add(new ProductDto { TarrifName = packageTarrif.Name, AnnualCost = packageTarrif_annualCost });

            return results.OrderBy(c => c.AnnualCost).ToList();
        }
    }
}
