using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using diplom.src.context;
using diplom.src.data.classes;
using diplom.src.data.exception;
using diplom.src.entity;
using System.Data.Entity.Infrastructure;

namespace diplom.src.service.impl
{
    class CustomerServiceImpl : IClientService
    {

        private static IClientService customerService = new CustomerServiceImpl();

        private ClientContext context;

        public CustomerServiceImpl()
        {
            context = new ClientContext();
        }

        public Client create(Client entity)
        {
            //entity = setFullAddress(entity);
            
            context.Clients.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Client findById(Guid id)
        {
            context = new ClientContext();
            Client customer = context.Clients
                //.Include(c => c.address)
                //.Include(c => c.orders)
                .FirstOrDefault(c => c.id.Equals(id));
            if (customer == null)
            {
                throw new EntityNotFoundException("Entity with required id not found: " + id);
            }
            return customer;
        }

        public static IClientService GetService()
        {
            return customerService;
        }

        public Client update(Guid id, Client entity)
        {
            entity.id = id;
            context.SaveChanges();
            return entity;
        }

        private Client setFullAddress(Client customer)
        {
            //Location location = customer.address;
            //customer.fullAddress = String.Format("{0}, г. {1}, р-н {2}, ул. {3}", location.country, location.city,
            //    location.district, location.street);
            return customer;
        }

        public Client findByInn(int inn) {
            Client client = context.Clients
                .Include(c => c.orders)
                .Where(c => c.inn.Equals(inn))
                .FirstOrDefault();
            if (client == null) {
                throw new EntityNotFoundException(String.Format("Customer with required INN not found, {0}", inn));
            }
            return client;
        }

    }

}
