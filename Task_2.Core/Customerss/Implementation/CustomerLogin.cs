using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Infrastructure.PracticeDbContext;

namespace Task_2.Core.Customerss.Implementation
{
    public class CustomerLogin(UserDbContext userDbContext) : ICustomerLogin
    {
        public bool LoginCustomer(string email, string password)
        {
            var loginCustomer = userDbContext.Customer
                .Where(i => i.Email == email && i.Password == password);
            if (loginCustomer != null)
            {

                return true;
            }
            return false;
        }
    }
}
