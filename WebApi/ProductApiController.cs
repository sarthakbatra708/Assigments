using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private ProductDbContext _dbConext;

        public ProductApiController(ProductDbContext dbcontext)
        {
            _dbConext = dbcontext;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_dbConext.Products.ToList());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product obj)
        {
            _dbConext.Products.Add(obj);
            _dbConext.SaveChanges();
            return Ok(new { result = "Product Details added to database" });
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Product obj)
        {
            _dbConext.Entry(obj).State = EntityState.Modified;
            _dbConext.SaveChanges();
            return Ok(new { result = "Product Details updated to database" });
        }


        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product obj = _dbConext.Products.Find(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Product obj = _dbConext.Products.Find(id);
            _dbConext.Products.Remove(obj);
            _dbConext.SaveChanges();
            return Ok(new { result = "Product Details deleted from database" });
        }
    }
    

}
