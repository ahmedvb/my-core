using Microsoft.EntityFrameworkCore;
using my_core.Models;

namespace my_core.Data
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext>opt):base(opt)
        {
            
        }
        public DbSet<Car> cars { get; set; }
    }
}