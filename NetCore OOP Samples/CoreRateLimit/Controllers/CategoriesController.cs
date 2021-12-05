using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreRateLimit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(new { Id = 1, Name = "Computers" });
        }

    }
}
