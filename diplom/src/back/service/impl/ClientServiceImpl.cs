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

        public Client findBy(String fname, String mname) {
            IQueryable<Client> query = context.Clients.Include(c => c.orders);
            FilterClient filter = new FilterClient();
            filter.fname = fname;
            filter.mname = mname;
            if (filter.fname != "")
            {
                query = query.Where(c => c.firstName == fname);
            }
            if (filter.mname != "")
            {
                query = query.Where(c => c.middleName == mname);
            }
            Client client = query.FirstOrDefault();
            //List<Client> clients = 
                //context.Clients

                //.Include(c => c.orders)
                //.Where(c => filter(fname, mname))
                //.ToList();

            return client;
        }

        private bool filter(String fname, String mname)
        {
            if (fname != "")
            {

            }

            return true;
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
