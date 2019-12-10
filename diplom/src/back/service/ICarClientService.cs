using diplom.src.back.entity;
using diplom.src.back.interfaces;
using System;
using System.Collections.Generic;

namespace diplom.src.back.service
{
    internal interface ICarClientService : ICrudService<CarClient, Guid>
    {
        List<CarClient> GetAll();
    }
}
