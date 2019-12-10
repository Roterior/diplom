using System;

namespace diplom.src.back.exception
{
    internal class EntityNotFoundException : SystemException
    {
        public EntityNotFoundException(string message) : base(message)
        {
        }
    }
}
