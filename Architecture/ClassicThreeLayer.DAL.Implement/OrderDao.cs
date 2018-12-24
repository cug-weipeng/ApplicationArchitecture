using ClassicThreeLayer.DAL.Interface;
using ClassicThreeLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicThreeLayer.DAL.Implement
{
    public class OrderDao : DaoBase<Order>, IOrderDao
    {
        public OrderDao(string connection):base(connection)
        {

        }


        public long CreateOrder(Order order)
        {

            //*******************************************************
            ///访问数据库，写sql 或者使用orm框架获取Product表中的数据
            /// id = DbHelper.Insert("Insert Order Set ...")
            //*******************************************************

            return DateTime.Now.Ticks;
        }
    }
}
