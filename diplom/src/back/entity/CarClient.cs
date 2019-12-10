using diplom.src.back.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.src.back.entity
{
    [Table("CarClient")]
    public class CarClient : Car
    {
        public CarClient() { }

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }

        public Guid ClientId { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }
    }
}
