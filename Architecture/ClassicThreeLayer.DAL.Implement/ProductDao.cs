using ClassicThreeLayer.DAL.Interface;
using ClassicThreeLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicThreeLayer.DAL.Implement
{
    public class ProductDao : DaoBase<Product>, IProductDao
    {
        public ProductDao(string connection):base(connection)
        {

        }

        public Product GetProductByID(int productId)
        {
            Product product = null;
            //*******************************************************
            ///访问数据库，写sql 或者使用orm框架获取Product表中的数据
            /// product = DbHelper.Query("Select * from product where id = @id")
            //*******************************************************

            product = new Product
            {
                ProductID = productId,
                ProductName = $"prodcut{productId}",
                Price = 100.00m,
                Cost = 20.00m
            };

            return product;
        }
    }
}
