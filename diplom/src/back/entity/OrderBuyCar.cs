using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.entity
{
    [Table(name: "order_t")]
    class OrderBuyCar
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public Guid clientId { get; set; }

        public String description { get; set; }

        public DateTimeOffset? timestamp { get; set; }

        public Decimal? price { get; set; }

        public NewCar newCar { get; set; }
    }
}
