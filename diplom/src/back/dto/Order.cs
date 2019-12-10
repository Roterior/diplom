using System;

namespace diplom.src.back.dto
{
    public class Order
    {
        public string Description { get; set; }

        public DateTimeOffset? Timestamp { get; set; }

        public decimal? PaymentValue { get; set; }
    }
}
