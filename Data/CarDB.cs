using System.Collections.Generic;
using my_core.Models;
namespace my_core.Data
{
    public class CarDB : ICarDB
    {
        public IEnumerable<Car> GetAllCars()
        {
            List<Car> r = null;
            Car car=null;
            r=new List<Car>();
            car=new Car();
            car.Brand="Hundai";
            car.Id=2;
            car.ModelYear=2018;
            car.Price=89000f;
            r.Add(car);
            car=new Car();
            car.Brand="Mazda";
            car.Id=3;
            car.ModelYear=2020;
            car.Price=68000f;
            r.Add(car);
            return r;
        }
        public Car GetCarById(int Id)
        {
            Car r = null;
            r=new Car();
            r.Brand="Toyota";
            r.Id=1;
            r.ModelYear=2020;
            r.Price=490000.1f;
            return r;
        }
    }
}