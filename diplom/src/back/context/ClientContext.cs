using diplom.src.back.entity;
using diplom.src.entity;
using System.Data.Entity;

namespace diplom.src.back.context
{

    class ClientContext : DbContext
    {

        public ClientContext() : base("dbConnect") { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<OrderBuyCar> OrderBuyCars { get; set; }

        public DbSet<NewCar> NewCars { get; set; }

        public DbSet<ClientCar> ClientCars { get; set; }
    }
}
