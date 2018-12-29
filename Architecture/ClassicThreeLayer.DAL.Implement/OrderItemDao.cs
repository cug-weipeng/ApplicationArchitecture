using ClassicThreeLayer.DAL.Interface;
using ClassicThreeLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicThreeLayer.DAL.Implement
{
    public class OrderItemDao : DaoBase<OrderItem>, IOrderItemDao
    {
        public OrderItemDao(string connection):base(connection)
        {

        }

        public long CreateOrderItem(OrderItem orderItem)
        {
            //*******************************************************
            ///访问数据库，写sql 或者使用orm框架获取Product表中的数据
            /// id = DbHelper.Insert("Insert Order Set ...")
            //*******************************************************

            return DateTime.Now.Ticks;
        }

        public OrderItem GetOrderItemsByOrderID(long orderId)
        {
            return new OrderItem()
            {
                OrderId = orderId,
                ProductId = 1,
                Quantity = 2,
                OrderItemId = DateTime.Now.Ticks
            };
        }
    }
}
