using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Services;
using WebApplication2.Data.ViewModel;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] ProductVm productVm)
        {
            _productService.AddProduct(productVm);
            return Ok();
        }


        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProductWithEmployees(int id)
        {
            var product = _productService.GetProductWithEmployeeVm(id);
            return Ok(product);
        }
    }
}
