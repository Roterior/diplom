using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.src.back.entity
{
    [Table("OrderBuy")]
    public class OrderBuy
    {
        public OrderBuy() { }

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public Guid NewCarId { get; set; }

        public string Description { get; set; }

        public DateTimeOffset? Timestamp { get; set; }

        public decimal? Price { get; set; }
    }
}
