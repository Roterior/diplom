using System;
using System.Collections.Generic;
using System.Linq;
using diplom.src.back.utils.context;
using diplom.src.back.entity;

namespace diplom.src.back.service.impl
{
    class CarNewServiceImpl : ICarNewService
    {
        private static readonly ICarNewService service = new CarNewServiceImpl();
        private readonly Context context;

        public CarNewServiceImpl() => context = new Context();

        public static ICarNewService GetService() => service;

        public CarNew Create(CarNew entity)
        {
            context.CarNew.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public CarNew GetById(Guid id)
        {
            return context.CarNew.FirstOrDefault(c => c.Id.Equals(id));
        }

        public CarNew Update(CarNew entity)
        {
            context.SaveChanges();
            return entity;
        }

        public List<CarNew> GetAll() => context.CarNew.ToList();
    }
}
