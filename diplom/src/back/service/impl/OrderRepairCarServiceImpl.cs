using diplom.src.back.context;
using diplom.src.back.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.src.back.service.impl
{
    class OrderRepairCarServiceImpl : IOrderRepairCar
    {
        private static readonly IOrderRepairCar orderService = new OrderRepairCarServiceImpl();
        private readonly ClientContext context;

        public OrderRepairCarServiceImpl()
        {
            context = new ClientContext();
        }

        public static IOrderRepairCar GetService()
        {
            return orderService;
        }

        public OrderRepairCar Create(OrderRepairCar entity)
        {
            context.OrderRepairCars.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public OrderRepairCar GetById(long id)
        {
            throw new NotImplementedException();
        }

        public OrderRepairCar Update(OrderRepairCar entity)
        {
            throw new NotImplementedException();
        }
    }
}
