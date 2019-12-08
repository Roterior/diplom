using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.src.back.context;
using diplom.src.back.entity;

namespace diplom.src.back.service.impl
{
    class CarServiceImpl : INewCarService
    {
        private static readonly INewCarService service = new CarServiceImpl();
        private readonly ClientContext context;

        public CarServiceImpl()
        {
            context = new ClientContext();
        }

        public NewCar Create(NewCar entity)
        {
            context.NewCars.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public static INewCarService GetService()
        {
            return service;
        }

        public NewCar GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public NewCar Update(NewCar entity)
        {
            return entity;
        }

        public List<NewCar> GetAll()
        {
            return context.NewCars.ToList();
        }
    }
}
