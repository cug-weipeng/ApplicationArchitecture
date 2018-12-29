using ClassicThreeLayer.Entities;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IOrderItemDao
    {
        OrderItem GetOrderItemsByOrderID(long orderId);

        long CreateOrderItem(OrderItem orderItem);
    }
}
