using System;
using System.Linq;
using diplom.src.back.context;
using diplom.src.back.entity;

namespace diplom.src.back.service.impl
{
    class OrderBuyServiceImpl : IOrderBuyService
    {
        private static readonly IOrderBuyService orderService = new OrderBuyServiceImpl();
        private readonly Context context;

        public OrderBuyServiceImpl() => context = new Context();

        public static IOrderBuyService GetService() => orderService;

        public OrderBuy Create(OrderBuy entity)
        {
            context.OrderBuy.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public OrderBuy GetById(Guid id)
        {
            return context.OrderBuy.FirstOrDefault(c => c.Id.Equals(id));
        }

        public OrderBuy Update(OrderBuy entity)
        {
            context.OrderBuy.Add(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
