using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Customerss.Interface;
using Task_2.Core.Dashboards.Interface;
using Task_2.Core.Orders.Interface;
using Task_2.Core.Ratingss.Interface;
using Task_2.Model.Response;

namespace Task_2.Core.Dashboards.Implementation
{
    public class DashboardCommon(
                                   ICustomerCountByMonth customerCountByMonth,
                                   IOrderCountByMonth orderCountByMonth,
                                   ITopSellingProductByRatingCount topSellingProductByRatingCount,
                                   IOrderCountByQuantity orderCountByQuantity) : IDashboardCommon
    {
        public DashboardResponseModel GetDashboard(int year)
        {

            var customer = customerCountByMonth.CountCustomerByMonth(year);
            var order = orderCountByMonth.CountOrderByMonth(year);
            var topRating = topSellingProductByRatingCount.ProductByRatingCount(year);
            var topSelling = orderCountByQuantity.CountOrderByQuantity(year);
            return new DashboardResponseModel
            {
                CustomerModel = customer,
                OrderModel = order,
                TopSellingModel = topSelling,
                RatingModel = topRating,
            };

        }
    }
}
