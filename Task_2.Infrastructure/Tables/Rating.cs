using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Infrastructure.Tables
{
    public class Rating
    {
        public int RatingId {  get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Comments { get; set; }
        public int Ratings {  get; set; }
        public Product Product {  get; set; }
        public Customer Customer { get; set; }
    }
}
