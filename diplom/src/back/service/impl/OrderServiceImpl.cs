using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.src.back.context;
using diplom.src.entity;

namespace diplom.src.service.impl
{
    class OrderServiceImpl : IOrderService
    {
        private static readonly IOrderService orderService = new OrderServiceImpl();
        //private readonly OrderContext orderContext;

        public OrderServiceImpl()
        {
            //orderContext = new OrderContext();
        }

        public static IOrderService GetService()
        {
            return orderService;
        }

        public Order Create(Order entity)
        {
            //orderContext.Orders.Add(entity);
            //orderContext.SaveChanges();
            return entity;
        }

        public Order GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
