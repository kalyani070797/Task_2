using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Model.Response;

namespace Task_2.Core.Customerss.Implementation
{
    public class GetCustomerDetailByFromAndToDate
    {
        public readonly UserDbContext _userDbContext;
        public GetCustomerDetailByFromAndToDate(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void GetDetails(DateTime fromDate, DateTime toDate, int customerId)
        {
            //var Get = _userDbContext.Order
            //    .Include(o => o.Customer)
            //    .Where(i => i.CustomerId == customerId && i.OrderedDate >= fromDate && i.OrderedDate <= toDate)
            //    .Select(o => new GetDetailsResponseModel
            //    {
            //        CustomerName = 
            //    });





        }

    }
}


