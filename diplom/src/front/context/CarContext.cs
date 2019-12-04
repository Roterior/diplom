using diplom.src.back.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.front.context
{
    class CarContext : DbContext
    {
        public CarContext() : base("dbConnect") { }

        public DbSet<NewCar> NewCars { get; set; }
    }
}
