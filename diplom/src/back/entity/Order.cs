using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using diplom.src.back.entity;

namespace diplom.src.entity
{

    [Table(name: "order_t")]
    public class Order
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public Guid clientId { get; set; }

        public String description { get; set; }

        public DateTimeOffset? timestamp { get; set; }

        public Decimal? paymentValue { get; set; }

        [ForeignKey(name: "orderId")] public List<NewCar> newCars { get; set; }
    }
}
