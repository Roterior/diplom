using diplom.src.back.entity;
using diplom.src.back.interfaces;
using diplom.src.entity;
using System;
using System.Collections.Generic;

namespace diplom.src.service
{
    interface IClientService : ICrudService<Client, Guid>
    {
        Client GetByInn(int? inn);

        List<Client> GetByFilter(FilterClient filter);
    }
}
