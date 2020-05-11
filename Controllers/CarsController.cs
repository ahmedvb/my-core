using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using my_core.Data;
using my_core.Models;

namespace my_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarDB _car;
        public CarsController(ICarDB car)
        {
            _car = car;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            var r=_car.GetAllCars();
            return Ok(r);
        }
        [HttpGet("{id}")]
        public ActionResult<Car> GetCar(int id)
        {
            var r=_car.GetCarById(id);
            return Ok(r);
        }
    }
}