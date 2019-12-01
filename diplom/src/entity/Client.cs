using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using diplom.src.data.classes;

namespace diplom.src.entity
{
    [Table(name: "client_t")]
    public class Client {

        public Client() {}

        public Client(int inn, string kpp, Location location) {
            this.inn = inn;
        }

        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public String firstName { get; set; }

        public String middleName { get; set; }

        public String lastName { get; set; }

        public String phone { get; set; }

        public String address { get; set; }

        public int inn { get; set; }

        public int passportId { get; set; }

        public int passportSeries { get; set; }

        [ForeignKey(name: "customerId")] public virtual List<Order> orders { get; set; }

    }

}
