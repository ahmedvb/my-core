using System.Collections.Generic;
using my_core.Models;
namespace my_core.Data
{
    public class CarDB : ICarDB
    {
        IEnumerable<Car> ICarDB.GetAllCars()
        {
            //throw new System.NotImplementedException();
            List<Car> r = null;
            Car car=null;
            r=new List<Car>();
            car=new Car();
            car.Brand="Hundai";
            car.Id=2;
            car.ModelYear=2018;
            car.Price=89000f;
            r.Add(car);
            return r;
        }
        Car ICarDB.GetCarById(int Id)
        {
            //throw new System.NotImplementedException();
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