using diplom.src.back.entity;
using diplom.src.data.classes;
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

        List<Client> findBy(FilterClient filter);

    }

}
