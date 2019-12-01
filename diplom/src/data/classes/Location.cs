using diplom.src.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.data.classes
{
    //[Table(name: "cust_location_t")]
    public class Location
    {
        public Location()
        {
        }

        public Location(string country, string city, string street, string district)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.district = district;
        }

        //[Key]
        //[ForeignKey(name: "customer")]
        public Guid id { get; set; }

        public String country { get; set; }

        public String city { get; set; }

        public String street { get; set; }

        public String district { get; set; }

        public Client customer { get; set; }
    }
}
