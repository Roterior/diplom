using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using diplom.src.back.entity;
using diplom.src.back.context;
using diplom.src.back.dto;

namespace diplom.src.back.service.impl
{
    class ClientServiceImpl : IClientService
    {
        private static readonly IClientService service = new ClientServiceImpl();
        private readonly Context context;

        public ClientServiceImpl() => context = new Context();

        public static IClientService GetService() => service;

        public Client Create(Client entity)
        {
            context.Client.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Client GetById(Guid id)
        {
            return context.Client
                .Include(c => c.OrderBuyList)
                .Include(c => c.CarClientList)
                .Include(c => c.OrderRepairList)
                .FirstOrDefault(c => c.Id.Equals(id));
        }

        public Client Update(Client entity)
        {
            context.SaveChanges();
            return entity;
        }

        public List<Client> GetByFilter(FilterClient filter)
        {
            IQueryable<Client> query = context.Client
                .Include(c => c.OrderBuyList)
                .Include(c => c.CarClientList)
                .Include(c => c.OrderRepairList);
            if (filter.FirstName != "")
            {
                query = query.Where(c => c.FirstName.Contains(filter.FirstName));
            }
            if (filter.MiddleName != "")
            {
                query = query.Where(c => c.MiddleName.Contains(filter.MiddleName));
            }
            if (filter.LastName != "")
            {
                query = query.Where(c => c.LastName.Contains(filter.LastName));
            }
            if (filter.Inn != null && filter.Inn != 0)
            {
                query = query.Where(c => c.Inn.ToString().Contains(filter.Inn.ToString()));
            }
            return query.ToList();
            /*return context.Client
                .Include(c => c.OrderBuyList)
                .Include(c => c.CarClientList)
                .Include(c => c.OrderRepairList)
                .Where(c => c.FirstName.Contains(filter.FirstName))
                .Where(c => c.MiddleName.Contains(filter.MiddleName))
                .Where(c => c.LastName.Contains(filter.LastName))
                .Where(c => c.Inn.ToString().Contains(filter.Inn.ToString()))
                .ToList();*/
        }
    }
}
