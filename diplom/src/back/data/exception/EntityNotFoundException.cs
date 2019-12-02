using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.data.exception
{
    class EntityNotFoundException : SystemException
    {
        public EntityNotFoundException(string message) : base(message)
        {
        }
    }
}
