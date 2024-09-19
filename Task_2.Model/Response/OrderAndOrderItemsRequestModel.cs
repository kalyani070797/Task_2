using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model.Response
{
    public class OrderAndOrderItemsRequestModel
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public OrderItemsRequestModel OrderItemsRequestModel { get; set; }
    }
}
