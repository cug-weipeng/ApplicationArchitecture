using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicThreeLayer.Entities
{
    public class OrderItem
    {
        public long OrderItemId { get; set; }

        public long OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal Quantity { get; set; }
    }
}
