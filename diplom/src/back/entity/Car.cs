using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.entity
{
    public class Car
    {

        public Car() {}

        public int? horsePower { get; set; }

        public int? fuelConsuption { get; set; }

        public int? maxSpeed { get; set; }

        public String color { get; set; }

        public String model { get; set; }

        public String maker { get; set; }

        public int? releaseYear { get; set; }

    }

}
