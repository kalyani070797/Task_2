using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Ratingss.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.Ratingss.Implementation
{
    public class TopSellingProductByRatingCount(UserDbContext userDbContext) : ITopSellingProductByRatingCount
    {
        public List<RatingModel> ProductByRatingCount(int year)
        {
            var topSelling = userDbContext.Rating
                .Select(i => new
                {
                    i.ProductId,
                    i.Product.ProductName,
                    i.Ratings
                }).ToList();

            var topSellingProducts = topSelling.GroupBy(i => i.ProductId)
                .Select(x => new RatingModel()
                {
                    ProductId = x.Key,
                    ProductName = x.First().ProductName,
                    Ratings = x.Average(x => x.Ratings)
                }).ToList();

            return topSellingProducts;
        }
    }
}
