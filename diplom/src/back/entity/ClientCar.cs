using diplom.src.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.entity {

    [Table(name:"client_car")]
    public class ClientCar : Car {

        public ClientCar() {}

        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public string status { get; set; }

        public string description { get; set; }

        [ForeignKey(name:"id")] public Client clientId { get; set; }

    }

}
