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
    public class OrderCreator : IOrderCreator
    {
        public readonly UserDbContext _userDbContext;
        public OrderCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;

        }
        public void UpdateQuantity(int customerId, int productId, int quantity)
        {
            var product = _userDbContext.Product.Find(productId);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            if (product.Quantity < quantity)
            {
                throw new Exception("Insufficient quantity");
            }
            var order = new Order
            {
                CustomerId = customerId,
                ProductId = productId,
                Quantity = quantity
            };
            _userDbContext.Order.Add(order);
            //Update Product quantity
            product.Quantity -= quantity;
            _userDbContext.SaveChanges();
        }
    }
}
