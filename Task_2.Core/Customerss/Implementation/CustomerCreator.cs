using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Customerss.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.Customerss.Implementation
{
    public class CustomerCreator : ICustomerCreator
    {
        public readonly UserDbContext _userDbContext;
        public CustomerCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateCustomer(CustomerRequestModel customerResponse)
        {
            var customer = new Customer()
            {
                CustomerName = customerResponse.CustomerName,
                ContactNumber = customerResponse.ContactNumber,
                Age = customerResponse.Age,
            };
            _userDbContext.Customer.Add(customer);
            _userDbContext.SaveChanges();
        }
    }
}
