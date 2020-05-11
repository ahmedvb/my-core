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
        public ActionResult<IEnumerable<Car>>GetAllCars()
        {
            IEnumerable<Car>r=null;
            CarDB c=new CarDB();
            r=c.GetAllCars();
            return Ok(r);
        }
        public ActionResult<Car>GetCar(int id)
        {
            Car r=null;
            CarDB c=new CarDB();
            r=c.GetCarById(id);
            return Ok(r);
        }
    }
}