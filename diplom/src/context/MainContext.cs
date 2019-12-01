using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core;
using diplom.src.entity;
using System.ComponentModel.DataAnnotations.Schema;
using diplom.src.data.classes;

namespace diplom.src.context {

    class MainContext : DbContext {

        public MainContext(): base("mainConnection") {}

        public virtual DbSet<Client> Customers { get; set; }

    }

}
