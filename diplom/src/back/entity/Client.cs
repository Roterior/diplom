using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using diplom.src.back.entity;

namespace diplom.src.entity
{

    [Table(name: "client_t")]
    public class Client
    {
        public Client() { }

        public Client(String fname, String mname, String lname, String phone, String address, int? inn, int? pId, int? pSer) {
            this.firstName = fname;
            this.middleName = mname;
            this.lastName = lname;
            this.phone = phone;
            this.address = address;
            this.inn = inn;
            this.passportId = pId;
            this.passportSeries = pSer;
        }

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public String firstName { get; set; }

        public String middleName { get; set; }

        public String lastName { get; set; }

        public String phone { get; set; }

        public String address { get; set; }

        public int? inn { get; set; }

        public int? passportId { get; set; }

        public int? passportSeries { get; set; }

        [ForeignKey(name: "ClientId")] public List<ClientCar> ClientsCars { get; set; }

        [ForeignKey(name: "clientId")] public List<OrderBuyCar> OrderBuyCars { get; set; }

        [ForeignKey(name: "ClientId")] public List<OrderRepairCar> OrderRepairCars { get; set; }
    }
}
