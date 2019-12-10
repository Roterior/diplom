using diplom.src.back.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.src.back.entity
{
    [Table("CarNew")]
    public class CarNew : Car
    {
        public CarNew() { }

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }

        [ForeignKey("NewCarId")] public List<OrderBuy> Orders { get; set; }

        public decimal? Price { get; set; }
    }
}
