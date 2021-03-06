﻿using ClassicThreeLayer.DAL.Interface;
using ClassicThreeLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicThreeLayer.DAL.Implement
{
    public class OrderDao : DaoBase<Order>, IOrderDao
    {
        private readonly static string _connectStringWrite = "Read from configFile";
        private readonly static string _connectStringReadOnly = "Read from configFile2";

        public OrderDao() : base(_connectStringReadOnly)
        { }

        public OrderDao(bool writeable)
            : base(writeable ? _connectStringWrite : _connectStringReadOnly)
        { }

        public long CreateOrder(Order order)
        {
            // _connection.Open();
            //*******************************************************
            ///访问数据库，写sql 或者使用orm框架获取Product表中的数据
            /// id = DbHelper.Insert("Insert Order Set ...")
            //*******************************************************

            return DateTime.Now.Ticks;
        }
    }
}
