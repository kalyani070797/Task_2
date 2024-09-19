using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model.Response
{
    public class DashboardResponseModel
    {
        public List<CustomerModel> CustomerModel {  get; set; }
        public List<OrderModel> OrderModel { get; set; }
        public List<RatingModel> RatingModel { get; set; }
        public List<TopSellingModel> TopSellingModel { get; set; }
    }
         public class CustomerModel
    {
        public int Month { get; set; }
        public int Count { get; set; }
    }
    public class OrderModel 
    {
        public int Month { get; set; }
        public int Count { get; set; }

    }
    public class TopSellingModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int TotalQuantity { get; set; }
    }
    public class RatingModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Ratings { get; set; }
    }

}
