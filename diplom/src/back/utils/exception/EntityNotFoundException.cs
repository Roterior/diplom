using System;

namespace diplom.src.back.utils.exception
{
    internal class EntityNotFoundException : SystemException
    {
        public EntityNotFoundException(string message) : base(message)
        {
        }
    }
}
