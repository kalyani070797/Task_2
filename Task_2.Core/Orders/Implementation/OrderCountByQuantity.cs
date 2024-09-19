using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Orders.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.Orders.Implementation
{
    public class OrderCountByQuantity(UserDbContext userDbContext) : IOrderCountByQuantity
    {
        public List<TopSellingModel> CountOrderByQuantity(int year)
        {   //With OrderByDescending
            //var getCount = userDbContext.Order
            //      .Include(i => i.Product)
            //      .Where(i => i.OrderedDate.Year == year)
            //      .GroupBy(i => i.Product)
            //      .OrderByDescending(i => i.Sum(i => i.Quantity))
            //      .Take(5)
            //      .Select(i => new TopSellingModel
            //      {
            //          ProductId = i.Key.ProductId,
            //          ProductName = i.Key.ProductName,
            //          ProductPrice = i.Key.Price,
            //          TotalQuantity = i.Count()
            //      })
            //      .ToList();
            var topSelling = userDbContext.Order
                .Include(i => i.Product)
                .Select(x => new
                {
                    x.ProductId,
                    x.Product.ProductName,
                    ProductPrice = x.Product.Price,
                    TotalQuantity = x.Quantity,
                });
            var topSellingProductsByQuantity = topSelling.GroupBy(i => i.ProductId)
                .Select(i => new TopSellingModel()
                {
                    ProductId = i.Key,
                    ProductName = i.First().ProductName,
                    ProductPrice = i.First().ProductPrice,
                    TotalQuantity = i.Count()
                }).ToList();
            return topSellingProductsByQuantity;

        }


    }
}
