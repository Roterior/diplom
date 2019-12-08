using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.src.back.context;
using diplom.src.back.entity;
using diplom.src.entity;

namespace diplom.src.service.impl
{
    class OrderServiceImpl : IOrderService
    {
        private static readonly IOrderService orderService = new OrderServiceImpl();
        private readonly ClientContext context;

        public OrderServiceImpl()
        {
            context = new ClientContext();
        }

        public static IOrderService GetService()
        {
            return orderService;
        }

        public OrderBuyCar Create(OrderBuyCar entity)
        {
            context.OrderBuyCars.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public OrderBuyCar GetById(long id)
        {
            throw new NotImplementedException();
        }

        public OrderBuyCar Update(OrderBuyCar entity)
        {
            context.OrderBuyCars.Add(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
