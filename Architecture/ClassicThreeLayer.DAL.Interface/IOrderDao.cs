using ClassicThreeLayer.Entities;
using System;

namespace ClassicThreeLayer.DAL.Interface
{
    public interface IOrderDao : IDisposable
    {
        long CreateOrder(Order order);
    }
}
