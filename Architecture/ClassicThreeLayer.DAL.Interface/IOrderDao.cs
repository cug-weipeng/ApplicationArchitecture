using ClassicThreeLayer.Entities;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IOrderDao
    {
        long CreateOrder(Order order);
    }
}
