using diplom.src.entity;
using System.Data.Entity;

namespace diplom.src.context {

    class OrderContext : DbContext {

        public OrderContext() : base("dbConnect") { }

        public DbSet<Order> Orders { get; set; }

    }

}
