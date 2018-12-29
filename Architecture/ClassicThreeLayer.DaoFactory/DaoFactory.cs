using ClassicThreeLayer.DAL.Interface;
using ClassicThreeLayer.DAL.Implement;
using System;

namespace ClassicThreeLayer.DAL.Factory
{
    public class DaoFactory
    {
        public T Create<T>()
        {
            if (typeof(T) is IOrderDao)
            {
                return  (T)(object)(new OrderDao());
            }
            else
            {
                throw new Exception($"不支持的类型{typeof(T).Name}");
            }
        }
    }
}
