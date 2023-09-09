using ContactApi.Infrastructure;
using ContactApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
            return _contactService.GetContactById(id);
        }
    }
}
