using Task_2.Model.Response;

namespace Task_2.Core.OrderItem.Interface
{
    public interface IOrderItemsCreator
    {
        void CreateOrderItemsByMultipleItems(OrderItemsRequestModel orderItemsRequestModel);
    }
}