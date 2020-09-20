using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsalesCC.RequestDTOs;
using CarsalesCC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsalesCC.Controllers
{
    [ApiController]
    [Route("[controller]")]   
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<CarGetResponseDto> Get()
        {
            return _carService.GetAll();
        }


        [HttpPost]
        [Route("create")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public Task<CarCreateResponseDto> CreateCar(CarCreateRequestDto request )
        {
            return _carService.Create(request);
        }

        // PUT api/<CarsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CarsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
