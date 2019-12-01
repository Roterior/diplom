using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.src.entity
{
    [Table(name: "order_t")]
    public class Order
    {
        public Order()
        {
        }

        public Order(string description, DateTimeOffset? timestamp, decimal? paymentValue)
        {
            this.description = description;
            this.timestamp = timestamp;
            this.paymentValue = paymentValue;
        }

        public Order(Guid customerId, string description, DateTimeOffset? timestamp, decimal? paymentValue)
        {
            this.customerId = customerId;
            this.description = description;
            this.timestamp = timestamp;
            this.paymentValue = paymentValue;
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        [Column(name: "client_id")]
        public Guid customerId { get; set; }

        public String description { get; set; }

        public DateTimeOffset? timestamp { get; set; }

        [Column(name: "price")]
        public Decimal? paymentValue { get; set; }

        //[ForeignKey(name: "orderId")]
        //public List<Item> items { get; set; }

        public override string ToString()
        {
            return id.ToString() + " " + description;
        }
    }
}
