using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.src.entity
{

    [Table(name: "payment_t")]
    public class Payment
    {

        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public Guid orderId { get; set; }

        public Decimal price { get; set; }

    }

}
