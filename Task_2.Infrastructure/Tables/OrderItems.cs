using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Infrastructure.Tables
{
    public class OrderItems
    {
        public int OrderItemsId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quanity { get; set; }
        [Precision(18,2)]
        public decimal Price { get; set; }
        public Order Order { get; set; }
        //public Product Product { get; set; }
    }
}
