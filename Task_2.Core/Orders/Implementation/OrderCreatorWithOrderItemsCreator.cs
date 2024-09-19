using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.OrderItem.Interface;
using Task_2.Core.Orders.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.Orders.Implementation
{
    public class OrderCreatorWithOrderItemsCreator(UserDbContext userDbContext,
                                                    IOrderItemsCreator _orderItemsCreator) : IOrderCreatorWithOrderItemsCreator
    {
        public void CreateOrderWithOrderItem(OrderAndOrderItemsRequestModel orderAndOrderItemsRequestModel)
                                            
        {
            var order = new Order()
            {
                CustomerId = orderAndOrderItemsRequestModel.CustomerId,
                ProductId = orderAndOrderItemsRequestModel.ProductId,
                Quantity = orderAndOrderItemsRequestModel.Quantity,
                OrderedDate = orderAndOrderItemsRequestModel.OrderedDate,
                CreatedDateTime = orderAndOrderItemsRequestModel.CreatedDateTime,

            };
            userDbContext.Order.Add(order);
            userDbContext.SaveChanges();
           
          _orderItemsCreator.CreateOrderItemsByMultipleItems(orderAndOrderItemsRequestModel.OrderItemsRequestModel);
            //var orderItem = orderAndOrderItemsRequestModel.OrderItemsRequestModel;
            //foreach (var items in orderItem)
            //{
            //    items.orderId = orderItem.OrderId;
            //    _orderItemsCreator.CreateOrderItemsByMultipleItems(items);
            //}
            //CreateOrderItemsByMultipleItems(orderAndOrderItemsRequestModel.OrderItemsModel);
            //var orderItems = new OrderItems()
            //{
            //    OrderId = order.OrderId,
            //    ProductId = order.ProductId,
            //    Quanity = order.Quantity,
            //    Price = orderAndOrderItemsRequestModel.Quantity,
            //};           

        }
    }
}
