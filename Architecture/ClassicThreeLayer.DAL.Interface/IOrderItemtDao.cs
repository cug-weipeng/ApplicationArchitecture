using ClassicThreeLayer.Entities;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IOrderItemtDao
    {
        OrderItem GetOrderItemsByOrderID(long orderId);

        long CreateOrderItem(OrderItem orderItem);
    }
}
