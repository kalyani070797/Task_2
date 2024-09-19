using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Customerss.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Model.Response;

namespace Task_2.Core.Customerss.Implementation
{
    public class CustomerCountByMonth(UserDbContext userDbContext) : ICustomerCountByMonth
    {
        public List<CustomerModel> CountCustomerByMonth(int year)
        {
            var monthCount = userDbContext.Customer
                .Where(i => i.CreatedDateTime.Year == year)
                .GroupBy(i => i.CreatedDateTime.Month)
                .Select(i => new CustomerModel
                {
                    Month = i.Key,
                    Count = i.Count()

                }).ToList();
            return monthCount;

        }
    }
}
