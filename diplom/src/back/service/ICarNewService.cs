using diplom.src.back.entity;
using diplom.src.back.interfaces;
using System;
using System.Collections.Generic;

namespace diplom.src.back.service
{
    internal interface ICarNewService : ICrudService<CarNew, Guid>
    {
        List<CarNew> GetAll();
    }
}
