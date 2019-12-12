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
    public class ProductTarrifComparisonController : ControllerBase
    { 

        private readonly ILogger<ProductTarrifComparisonController> _logger;
        private readonly IProductService _productService;

        public ProductTarrifComparisonController(
            ILogger<ProductTarrifComparisonController> logger,
           IProductService productService

        )
        {
            _logger = logger;
            _productService = productService;
        }


        [HttpGet("{id}")]
        public IEnumerable<ProductDto> GetProductList(float id)
        {
            var list = _productService.GetProductList(id);
            return list;
        }
    }
}
