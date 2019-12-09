using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.entity
{
    [Table(name: "order_repair_car_t")]
    public class OrderRepairCar
    {
        public OrderRepairCar() {}

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTimeOffset? Timestamp { get; set; }

        public decimal? Price { get; set; }
    }
}
