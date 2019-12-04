using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.src.back.entity;
using diplom.src.front.context;

namespace diplom.src.back.service.impl
{
    class CarServiceImpl : ICarService
    {
        private static ICarService service = new CarServiceImpl();
        private CarContext context;

        public CarServiceImpl()
        {
            context = new CarContext();
        }

        public NewCar create(NewCar entity)
        {
            context.NewCars.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public static ICarService GetService()
        {
            return service;
        }

        public NewCar findById(Guid id)
        {
            throw new NotImplementedException();
        }

        public NewCar update(Guid id, NewCar entity)
        {
            throw new NotImplementedException();
        }
        public List<NewCar> findAll()
        {
            return context.NewCars.ToList();
        }
    }
}
