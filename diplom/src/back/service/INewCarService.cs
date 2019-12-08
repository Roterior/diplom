using diplom.src.back.entity;
using diplom.src.back.interfaces;
using System;
using System.Collections.Generic;

namespace diplom.src.back.service
{
    interface INewCarService : ICrudService<NewCar, Guid>
    {
        List<NewCar> GetAll();
    }
}
