namespace diplom.src.back.utils.interfaces
{
    interface ICrudService<T, K>
    {
        T Create(T entity);

        T Update(T entity);

        T GetById(K id);
    }
}
