using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Infrastructure.Tables
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        [Precision(18,2)]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
