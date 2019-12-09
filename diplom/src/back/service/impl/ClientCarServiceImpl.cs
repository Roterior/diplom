using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.src.back.context;
using diplom.src.back.entity;

namespace diplom.src.back.service.impl
{
    class ClientCarServiceImpl : IClientCarService
    {
        private static IClientCarService service = new ClientCarServiceImpl();
        private ClientContext context;

        public ClientCarServiceImpl()
        {
            context = new ClientContext();
        }

        public static IClientCarService GetService()
        {
            return service;
        }

        public ClientCar Create(ClientCar entity)
        {
            context.ClientCars.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public List<ClientCar> GetAll()
        {
            return context.ClientCars.ToList();
        }

        public ClientCar GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ClientCar Update(ClientCar entity)
        {
            throw new NotImplementedException();
        }
    }
}
