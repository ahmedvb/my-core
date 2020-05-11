using my_core.Models;
using System.Collections.Generic;
namespace my_core.Data
{
    public class CarDB2:ICarDB
    {
        public IEnumerable<Car> GetAllCars()
        {
            List<Car>r=new List<Car>();
            Car c=new Car();
            c.Id=7;
            r.Add(c);
            return r;
        }
        public Car GetCarById(int Id)
        {
            Car r=new Car();
            r.Brand="Mercedes";
            r.Price=980000f;
            return r;
        }
    }
}