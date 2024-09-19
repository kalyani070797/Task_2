using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Orders.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Model.Response;

namespace Task_2.Core.Orders.Implementation
{
    public class OrderCountByMonth(UserDbContext userDbContext) : IOrderCountByMonth
    {
        public List<OrderModel> CountOrderByMonth(int year)
        {
            var countMonth = userDbContext.Order
                .Where(i => i.CreatedDateTime.Year == year)
                .GroupBy(i => i.CreatedDateTime.Month)
                .Select(i => new OrderModel
                {
                    Month = i.Key,
                    Count = i.Count()
                });
            return countMonth.ToList();
        }
    }
}
