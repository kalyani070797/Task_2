using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model.Response
{
    public class OrderItemsRequestModel
    {      
        public List<int> OrderIds { get; set; }
        public int Quanity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
    }

}
