using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.OrderItem.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.OrderItem.Implementation
{
    public class OrderItemsCreator(UserDbContext userDbContext) : IOrderItemsCreator
    {
        public void CreateOrderItemsByMultipleItems(OrderItemsRequestModel orderItemsRequestModel)
        {
            var orders=userDbContext.Order
                .Where(i=>orderItemsRequestModel.OrderIds.Contains(i.OrderId))
                .ToList();
            var createOrderItemsByMultipleItems = orders.Select(order=> new OrderItems
            {
                OrderId = order.OrderId,
                Quanity = orderItemsRequestModel.Quanity,
                Price = orderItemsRequestModel.Price,
                ProductId = orderItemsRequestModel.ProductId,
            }).ToList();
            userDbContext.OrderItems.AddRange(createOrderItemsByMultipleItems);
            userDbContext.SaveChanges();

        }
    }
}
