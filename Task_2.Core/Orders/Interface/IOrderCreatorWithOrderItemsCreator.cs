using Task_2.Model.Response;

namespace Task_2.Core.Orders.Interface
{
    public interface IOrderCreatorWithOrderItemsCreator
    {
        void CreateOrderWithOrderItem(OrderAndOrderItemsRequestModel orderAndOrderItemsRequestModel);
    }
}