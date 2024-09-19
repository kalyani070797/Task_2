using Task_2.Model.Response;

namespace Task_2.Core.Products.Interface
{
    public interface IProductCreator
    {
        void CreateProduct(ProductRequestModel productResponse);
    }
}