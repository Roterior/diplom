using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.data.classes
{
    interface CrudService<T, K>
    {
        T create(T entity);

        T update(K id, T entity);

        T findById(K id);
    }
}
