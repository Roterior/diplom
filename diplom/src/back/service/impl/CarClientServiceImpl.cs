using System;
using System.Collections.Generic;
using System.Linq;
using diplom.src.back.utils.context;
using diplom.src.back.entity;

namespace diplom.src.back.service.impl
{
    class CarClientServiceImpl : ICarClientService
    {
        private static readonly ICarClientService service = new CarClientServiceImpl();
        private readonly Context context;

        public CarClientServiceImpl() => context = new Context();

        public static ICarClientService GetService() => service;

        public CarClient Create(CarClient entity)
        {
            context.CarClient.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public List<CarClient> GetAll() => context.CarClient.ToList();

        public CarClient GetById(Guid id)
        {
            return context.CarClient.FirstOrDefault(c => c.Id.Equals(id));
        }

        public CarClient Update(CarClient entity)
        {
            context.SaveChanges();
            return entity;
        }
    }
}
