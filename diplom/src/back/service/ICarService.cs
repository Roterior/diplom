using diplom.src.back.entity;
using diplom.src.data.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.service
{
    interface ICarService : CrudService<NewCar, Guid>
    {
        List<NewCar> findAll();
    }
}
