namespace Task_2.Core.Orders.Interface
{
    public interface IOrderCreator
    {
        void UpdateQuantity(int customerId, int productId, int quantity);
    }
}