using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TariffComparisonApi.Dtos;
using TariffComparisonApi.Services;

namespace TariffComparisonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductTariffComparisonController : ControllerBase
    { 

        private readonly ILogger<ProductTariffComparisonController> _logger;
        private readonly IProductService _productService;

        public ProductTariffComparisonController(
            ILogger<ProductTariffComparisonController> logger,
           IProductService productService

        )
        {
            _logger = logger;
            _productService = productService;
        }


        [HttpGet("{consumption}")]
        public IEnumerable<ProductDto> GetProductList(float consumption)
        {
            var list = _productService.GetProductList(consumption);
            return list;
        }
    }
}
