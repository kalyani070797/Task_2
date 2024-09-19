using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Infrastructure.Tables
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public int Age { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
   

}
