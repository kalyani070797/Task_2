using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Products.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;
using Task_2.Model.Response;

namespace Task_2.Core.Products.Implementation
{
    public class ProductCreator : IProductCreator
    {
        public readonly UserDbContext _userDbContext;
        public ProductCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateProduct(ProductRequestModel productResponse)
        {
            var product = new Product()
            {
                ProductName = productResponse.ProductName,
                Price = productResponse.Price,
            };
            _userDbContext.Product.Add(product);
            _userDbContext.SaveChanges();
        }
    }
}
