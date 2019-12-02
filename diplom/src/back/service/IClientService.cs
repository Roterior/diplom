﻿using diplom.src.data.classes;
using diplom.src.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.service
{
    interface IClientService : CrudService<Client, Guid>
    {
        Client findByInn(int? inn);

        Client findBy(String fname, String mname);

    }

}