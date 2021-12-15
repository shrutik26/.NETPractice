using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeApplication2.Models;
using PracticeApplication2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApplication2.Controller
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductController : ControllerBase
    {
        private IProduct productRepository;
        public ProductController(IProduct _productRepository)
        {
            productRepository = _productRepository;
        }
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetProducts();
        }
        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = productRepository.GetProduct(id);
            if (product == null)
            {
                return NotFound("No Record Found...");
            }
            return Ok(product);
        }
        // POST: api/Products
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            productRepository.AddProduct(product);
            return StatusCode(StatusCodes.Status201Created);
        }
        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != product.Id)
            {
                return BadRequest();
            }
            try
            {
                productRepository.UpdateProduct(product);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return NotFound("No Record Found against this Id...");
            }
            return Ok("Product Updated...");
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productRepository.DeleteProduct(id);
            return Ok("Product Deleted...");
        }
    }
}
