using diplom.src.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.entity
{
    [Table(name: "new_car_t")]
    public class NewCar : Car
    {

        public NewCar() {}

        public NewCar(String maker, String model, Decimal? price)
        {
            this.maker = maker;
            this.model = model;
            this.price = price;
        }

        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid id { get; set; }

        public Decimal? price { get; set; }
    }
}
