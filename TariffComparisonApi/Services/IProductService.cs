using System.Collections.Generic;
using TariffComparisonApi.Dtos;

namespace TariffComparisonApi.Services
{
    public interface IProductService
    {   
        List<ProductDto> GetProductList(float consumption);
    }
}