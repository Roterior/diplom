using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.src.context;
using diplom.src.entity;

namespace diplom.src.service.impl
{
    class OrderServiceImpl : IOrderService
    {

        private static IOrderService orderService = new OrderServiceImpl();

        private OrderContext orderContext;

        public OrderServiceImpl()
        {
            orderContext = new OrderContext();
        }

        public static IOrderService GetService()
        {
            return orderService;
        }

        public Order create(Order entity)
        {
            orderContext.Orders.Add(entity);
            orderContext.SaveChanges();
            return entity;
        }

        public Order findById(long id)
        {
            throw new NotImplementedException();
        }

        public Order update(long id, Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
