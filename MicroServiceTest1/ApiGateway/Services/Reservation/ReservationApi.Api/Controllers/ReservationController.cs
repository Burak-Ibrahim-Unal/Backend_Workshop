using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationApi.Infrastructure;
using ReservationApi.Models;

namespace ReservationApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{bkgNumber}")]
        public ReservationDTO Get(int bkgNumber)
        {
            return _reservationService.GetReservationByBkgNumber(bkgNumber);
        }
    }
}
