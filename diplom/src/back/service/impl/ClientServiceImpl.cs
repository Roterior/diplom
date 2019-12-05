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
using diplom.src.back.entity;

namespace diplom.src.service.impl {

    class ClientServiceImpl : IClientService {

        private static IClientService service = new ClientServiceImpl();
        private ClientContext context;

        public ClientServiceImpl() {
            context = new ClientContext();
        }

        public Client create(Client entity) {
            context.Clients.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Client findById(Guid id) {
            context = new ClientContext();
            Client customer = context.Clients
                .Include(c => c.orders)
                .FirstOrDefault(c => c.id.Equals(id));
            if (customer == null) {
                throw new EntityNotFoundException("Entity with required id not found: " + id);
            }
            return customer;
        }

        public static IClientService GetService() {
            return service;
        }

        public Client update(Guid id, Client entity) {
            entity.id = id;
            context.SaveChanges();
            return entity;
        }

        public List<Client> findBy(FilterClient filter) {
            IQueryable<Client> query = context.Clients.Include(c => c.orders);
            if (filter.fname != "")
            {
                query = query.Where(c => c.firstName == filter.fname);
            }
            if (filter.mname != "")
            {
                query = query.Where(c => c.middleName == filter.mname);
            }
            if (filter.lname != "")
            {
                query = query.Where(c => c.lastName == filter.lname);
            }
            if (filter.inn != null && filter.inn != 0)
            {
                query = query.Where(c => c.inn == filter.inn);
            }
            return query.ToList();
        }

        public Client findByInn(int? inn) {
            Client client = context.Clients
                .Include(c => c.orders)
                .Where(c => c.inn == inn)
                .FirstOrDefault();
            if (client == null) {
                throw new EntityNotFoundException(String.Format("Customer with required INN not found, {0}", inn));
            }
            return client;
        }

    }

}
