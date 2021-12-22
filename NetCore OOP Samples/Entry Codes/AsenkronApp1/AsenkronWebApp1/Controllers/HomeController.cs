using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsenkronWebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetHomeContent()
        {
            var task = new HttpClient().GetStringAsync("https://www.google.com");
            var data = await task;
            return Ok(data);


        }



    }
}
