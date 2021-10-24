using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getallcars")]
        public IActionResult GetAllCars()
        {
            var result = _carService.GetAllCars();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // api/cars/getcarsbycolorid/3
        [HttpGet("getcarsbycolorid/{id}")]
        public IActionResult GetAllCarsByColorId(int id)
        {
            var result = _carService.GetAllCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbycolor")]
        public IActionResult GetAllCarsByColor(string color)
        {
            var result = _carService.GetCarByColor(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarbyid")]
        public IActionResult GetCarById(int id)
        {
            var result = _carService.GetCarById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getcarsbymodel")]
        public IActionResult GetAllCarsByModel(int m1, int m2)
        {
            var result = _carService.GetAllCarsByModel(m1, m2);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getcarsdetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Car c)
        {
            var result = _carService.Add(c);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
