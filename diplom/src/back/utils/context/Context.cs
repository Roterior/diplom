using diplom.src.back.entity;
using System.Data.Entity;

namespace diplom.src.back.utils.context
{
    class Context : DbContext
    {
        public Context() : base("dbConnect") { }

        public DbSet<Client> Client { get; set; }

        public DbSet<CarClient> CarClient { get; set; }

        public DbSet<CarNew> CarNew { get; set; }

        public DbSet<OrderBuy> OrderBuy { get; set; }

        public DbSet<OrderRepair> OrderRepair { get; set; }
    }
}
