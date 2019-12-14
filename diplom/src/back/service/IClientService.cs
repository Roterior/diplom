using diplom.src.back.dto;
using diplom.src.back.entity;
using diplom.src.back.utils.interfaces;
using System;
using System.Collections.Generic;

namespace diplom.src.back.service
{
    internal interface IClientService : ICrudService<Client, Guid>
    {
        List<Client> GetByFilter(FilterClient filter);
    }
}
