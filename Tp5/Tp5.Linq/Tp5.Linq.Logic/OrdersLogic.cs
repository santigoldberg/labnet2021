using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Entities;

namespace Tp5.Linq.Logic
{
    public class OrdersLogic :BaseLogic , IABMLogic<Orders>
    {
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public void Add(Orders newOrder)
        {
            context.Orders.Add(newOrder);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderAEliminar = context.Orders.First(o => o.OrderID == id);
        }

        public void Update(Orders order)
        {
            var orderUpdate = context.Orders.First(o => o.OrderID == order.OrderID);

            orderUpdate.Order_Details = order.Order_Details;

            context.SaveChanges();
        }
    }
}
