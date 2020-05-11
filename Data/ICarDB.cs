using System.Collections.Generic;
using my_core.Models;
namespace my_core.Data
{
    public interface ICarDB
    {
        //IEnumerable<Models.Car>GetAllCars();
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int Id);
        
    }
}