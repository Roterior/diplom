using diplom.src.back.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diplom.src.back.entity
{
    [Table("Client")]
    public class Client : FilterClient
    {
        public Client() { }

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }

        [ForeignKey("ClientId")] public List<CarClient> CarClientList { get; set; }

        [ForeignKey("ClientId")] public List<OrderBuy> OrderBuyList { get; set; }

        [ForeignKey("ClientId")] public List<OrderRepair> OrderRepairList { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public int? PassportNumber { get; set; }

        public int? PassportSeries { get; set; }
    }
}
