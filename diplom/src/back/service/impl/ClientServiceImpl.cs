using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using diplom.src.entity;
using System.Data.Entity.Infrastructure;
using diplom.src.back.entity;
using diplom.src.back.context;
using diplom.src.back.exception;

namespace diplom.src.service.impl {

    class ClientServiceImpl : IClientService {

        private static IClientService service = new ClientServiceImpl();
        private ClientContext context;

        public ClientServiceImpl() {
            context = new ClientContext();
        }

        public Client Create(Client entity) {
            context.Clients.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Client GetById(Guid id) {
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

        public Client Update(Client entity) {
            context.SaveChanges();
            return entity;
        }

        public List<Client> GetByFilter(FilterClient filter) {
            IQueryable<Client> query = context.Clients.Include(c => c.orders);
            if (filter.fname != "")
            {
                query = query.Where(c => c.firstName.Contains(filter.fname));
            }
            if (filter.mname != "")
            {
                query = query.Where(c => c.middleName.Contains(filter.mname));
            }
            if (filter.lname != "")
            {
                query = query.Where(c => c.lastName.Contains(filter.lname));
            }
            if (filter.inn != null && filter.inn != 0)
            {
                query = query.Where(c => c.inn.ToString().Contains(filter.inn.ToString()));
            }
            return query.ToList();
        }

        public Client GetByInn(int? inn) {
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
