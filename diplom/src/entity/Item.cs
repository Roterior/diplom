﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.entity
{
    //[Table(name: "item_t")]
    public class Item
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        //[Column(name: "order_id")]
        public Guid orderId { get; set; }

        public String name { get; set; }

        public int? index { get; set; }

        public int? count { get; set; }

        //[Column(name: "total_cost")]
        public Decimal? totalCost { get; set; }


    }
}