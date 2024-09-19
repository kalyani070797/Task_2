using Task_2.Model.Response;

namespace Task_2.Core.Customerss.Interface
{
    public interface ICustomerCreator
    {
        void CreateCustomer(CustomerRequestModel customerResponse);
    }
}