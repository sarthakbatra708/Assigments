using CaseStudy2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CaseStudy2.Services;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Http;

namespace CaseStudy2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        IProductService _productsService;

        public ProductApiController(IProductService productsService)
        {
            _productsService = productsService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var prodList = _productsService.GetProducts();
            return Ok(prodList);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Product obj)
        {
            Product p = _productsService.Create(obj);
            return Ok(new { result = p });
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Product obj)
        {
            _productsService.Edit(obj);
            return Ok(new { result = "Edited succesfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _productsService.Delete(id);
            return Ok(new { result = "Deleted successfully" });
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _productsService.GetProductById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet("GetProducts/{category}")]
        public IActionResult GetProductsByCategory(string category)
        {
            if (category == null)
            {
                return BadRequest(new { result = "You entered an empty string value for category name please enter correctly!" });
            }
            List<Product> procatlist = _productsService.GetProductsByCategory(category);
            if (procatlist == null)
            {
                return NotFound(new { result = "Products with that category are not available" });
            }
            else
            {
                return Ok(procatlist);
            }


        }
        [HttpGet("GetOutOfStockProducts")]
        public IActionResult GetOutOfStockProducts()
        {
            List<Product> outofstockproducts = _productsService.GetOutOfStockProducts();
            if (outofstockproducts.Count == 0)
            {
                return Ok(new { result = "There are no Out of Stock Products" });
            }
            else
            {
                return Ok(outofstockproducts);
            }
        }
        [HttpGet("ProductsInRange /{start}/{end}")]
        public IActionResult GetProductsInRange( double start, double end)
        {
            List<Product> productsinrange = _productsService.GetProductsInRangeOfPrice(start,end);
            if (productsinrange.Count == 0)
            {
                return Ok(new { result = "There are no Products whose price is in the given range" });
            }
            else
            {
                return Ok(productsinrange);
            }
        }
        [HttpGet("Categories")]
        public IActionResult GetCategories()
        {
            List<string> categories = _productsService.GetCategories();
            return Ok(categories);
        }


    }
}
