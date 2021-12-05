using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreRateLimit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new { Id = 1, Name = "Pencil", Price = 10 });
        }


        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok(new { Id = 2, Name = "Test", Price = 8 });
        }

        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }


        [HttpGet("{productName}")]
        public IActionResult GetProduct(string productName)
        {
            return Ok(productName);
        }


    }



}
