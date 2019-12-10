using diplom.src.back.context;
using diplom.src.back.entity;
using System;
using System.Linq;

namespace diplom.src.back.service.impl
{
    class OrderRepairServiceImpl : IOrderRepairService
    {
        private static readonly IOrderRepairService orderService = new OrderRepairServiceImpl();
        private readonly Context context;

        public OrderRepairServiceImpl() => context = new Context();

        public static IOrderRepairService GetService() => orderService;

        public OrderRepair Create(OrderRepair entity)
        {
            context.OrderRepair.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public OrderRepair GetById(Guid id)
        {
            return context.OrderRepair.FirstOrDefault(c => c.Id.Equals(id));
        }

        public OrderRepair Update(OrderRepair entity)
        {
            context.OrderRepair.Add(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
