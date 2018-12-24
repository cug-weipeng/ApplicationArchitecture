using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicThreeLayer.Entities
{
    public class Order
    {
        public string OrderId { get; set; }

        public string Customer { get; set; }

        public Address ShippingAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public string DiscountStratege { get; set; }
    }
}
