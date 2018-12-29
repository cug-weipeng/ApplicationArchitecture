namespace ClassicThreeLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public decimal Price { get; set; }
    }
}
