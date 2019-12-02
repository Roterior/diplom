using diplom.src.entity;
using System.Data.Entity;

namespace diplom.src.context {

    class ClientContext : DbContext {

        public ClientContext() : base("dbConnect") {}

        public DbSet<Client> Clients { get; set; }

    }

}
