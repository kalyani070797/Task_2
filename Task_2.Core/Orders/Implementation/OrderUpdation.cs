using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Orders.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;

namespace Task_2.Core.Orders.Implementation
{
    public class OrderUpdation : IOrderUpdation
    {
        public readonly UserDbContext _userDbContext;
        public OrderUpdation(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void UpdateOrder(int orderId, DateTime orderDate)
        {
            //var order = _userDbContext.Order
            //    .First(i => i.OrderId == orderId);
            //order.OrderId = orderId;
            //order.OrderedDate = orderDate;
            //_userDbContext.SaveChanges();
        }
    }
}
