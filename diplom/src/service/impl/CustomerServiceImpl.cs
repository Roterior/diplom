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
    class CustomerServiceImpl : CustomerService
    {

        private static CustomerService customerService = new CustomerServiceImpl();

        private MainContext mainContext;

        public CustomerServiceImpl()
        {
            mainContext = new MainContext();
        }

        public Client create(Client entity)
        {
            entity = setFullAddress(entity);
            mainContext.Customers.Add(entity);
            mainContext.SaveChanges();
            return entity;
        }

        public Client findById(Guid id)
        {
            mainContext = new MainContext();
            Client customer = mainContext.Customers
                //.Include(c => c.address)
                //.Include(c => c.orders)
                .FirstOrDefault(c => c.id.Equals(id));
            if (customer == null)
            {
                throw new EntityNotFoundException("Entity with required id not found: " + id);
            }
            return customer;
        }

        public static CustomerService GetService()
        {
            return customerService;
        }

        public Client update(Guid id, Client entity)
        {
            entity.id = id;
            mainContext.SaveChanges();
            return entity;
        }

        private Client setFullAddress(Client customer)
        {
            //Location location = customer.address;
            //customer.fullAddress = String.Format("{0}, г. {1}, р-н {2}, ул. {3}", location.country, location.city,
                //location.district, location.street);
            return customer;
        }

        public Client findByInn(int inn)
        {
            Client customer = mainContext.Customers
                //.Include(c => c.address)
                //.Include(c => c.orders)
                .Where(c => c.inn.Equals(inn))
                .FirstOrDefault();
            if (customer == null)
            {
                throw new EntityNotFoundException(String.Format("Customer with required INN not found, {0}", inn));
            }
            return customer;
        }
    }
}
